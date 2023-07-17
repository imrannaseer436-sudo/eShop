'************************************************ Bismillah ********************************************
Imports System.Data.SqlClient
Public Class OpeningStockEntry

    Private PluID As Integer

    Private Sub OpeningStockEntry_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            SQL = "select pluid,plucode,pluname,units,retailprice from productmaster where plucode='" & txtCode.Text.Trim & "'"
            With ESSA.OpenReader(SQL)
                If .Read Then
                    PluID = .Item(0)
                    txtCode.Text = .GetString(1)
                    txtName.Text = .GetString(2)
                    txtUOM.Text = .GetString(3)
                    txtRate.Text = Format(.Item(4), "0.00")
                    txtOpn.Focus()
                Else
                    TTIP.Show("Sorry, Product code not found..!", txtCode, 0, 25, 2000)
                End If
                .Close()
            End With

        End If

    End Sub

    Private Sub txtOpn_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtOpn.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            Dim NRI = ESSA.FindGridIndex(TG, 0, PluID)
            If NRI = -1 Then NRI = TG.Rows.Add

            TG.Item(0, NRI).Value = PluID
            TG.Item(1, NRI).Value = txtCode.Text
            TG.Item(2, NRI).Value = txtName.Text
            TG.Item(3, NRI).Value = txtUOM.Text
            TG.Item(4, NRI).Value = Format(Val(txtRate.Text), "0.00")
            TG.Item(5, NRI).Value = Val(txtOpn.Text)

            txtCode.Clear()
            txtName.Clear()
            txtRate.Clear()
            txtOpn.Clear()
            txtUOM.Clear()
            txtCode.Focus()

        End If

    End Sub

    Private Sub btnApproved_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnApproved.Click

        If MsgBox("Are you sure, do you want to update..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            SQL = "delete from openingstock"
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Integer = 0 To TG.Rows.Count - 1

                If Val(TG.Item(5, i).Value) > 0 Then

                    SQL = "insert into openingstock values (" _
                        & Val(TG.Item(0, i).Value) & "," _
                        & Val(TG.Item(5, i).Value) & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Trn.Commit()
            Con.Close()
            MsgBox("Opening stock entry saved successfully..!", MsgBoxStyle.Information)

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub OpeningStockEntry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        TG.Rows.Clear()
        SQL = "select p.pluid,p.plucode,p.pluname,p.units,p.retailprice,o.qty from productmaster p,openingstock o where p.pluid=o.pluid order by p.plucode"
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3)
                TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                TG.Item(5, TG.Rows.Count - 1).Value = .Item(5)
            End While
            .Close()
        End With
        txtCode.Select()

    End Sub

End Class