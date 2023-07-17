Imports System.Net.NetworkInformation

'**** In the name of Allah, Most Merciful, Most Compassionate ****
Public Class frmVerifier

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then

            '// Check product code field is empty

            If txtCode.Text.Trim = "" Then
                MsgBox("Product code cannot be empty..!", MsgBoxStyle.Information)
                txtCode.Focus()
                Exit Sub
            End If

            '// Check product code has single quoate

            If txtCode.Text.Trim.Contains("'") Then
                MsgBox("Please remove single quote ['] from product code.", MsgBoxStyle.Information)
                txtCode.Focus()
                Exit Sub
            End If


            '// Check product code found in database

            Dim objID = ESSA.GenerateData(String.Format("select pluid from productmaster where plucode='{0}'", txtCode.Text.Trim))

            If objID Is Nothing Then
                MsgBox("Product code not found..!", MsgBoxStyle.Information)
                txtCode.Focus()
                Exit Sub
            End If

            SQL = String.Format("insert into pv_codelist (pluid,refid) values ({0},'{1}')", CInt(objID), lblRefID.Text)
            ESSA.Execute(SQL)

            Dim nri = dgvCode.Rows.Add()
            dgvCode.Item(0, nri).Value = CInt(objID)
            dgvCode.Item(1, nri).Value = txtCode.Text.Trim
            dgvCode.Item(2, nri).Value = "r"
            txtCode.Clear()

        End If

    End Sub

    Private Sub dgvCode_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCode.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 2 Then

            If MsgBox("Do you want to remove an item..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            SQL = "delete from pv_codelist where sno={1} and pluid={0}"
            SQL = String.Format(SQL, Val(dgvCode.Item(0, e.RowIndex).Value), Val(dgvCode.Item(4, e.RowIndex).Value))
            ESSA.Execute(SQL)

            dgvCode.Rows.RemoveAt(e.RowIndex)

        End If

    End Sub

    Private Sub frmVerifier_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F8

                txtCode.Focus()

        End Select

    End Sub

    Private Sub dgvCode_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles dgvCode.RowsAdded

        lblCount.Text = "[ " & dgvCode.Rows.Count & " ]"

    End Sub

    Private Sub dgvCode_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dgvCode.RowsRemoved

        lblCount.Text = "[ " & dgvCode.Rows.Count & " ]"

    End Sub

    Private Sub frmVerifier_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lblRefID.Text = My.Computer.Name
        ESSA.AlignHeader(dgvList, 1, DataGridViewContentAlignment.MiddleCenter)

        ESSA.AlignHeader(dgvRst, 1, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(dgvRst, 2, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(dgvRst, 3, DataGridViewContentAlignment.MiddleCenter)

        '// Load list of shops
        SQL = "select shopid,(shopname + '-' + shopcode) shop from shops where shoptype='WAREHOUSE' order by shopid"
        ESSA.LoadCombo(cmbDCode, SQL, "shop", "shopid")

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlList.Visible = False

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

        SQL = "select refid,count(*) from pv_codelist group by refid order by refid"
        With ESSA.OpenReader(SQL)
            dgvList.Rows.Clear()
            While .Read
                Dim nri = dgvList.Rows.Add
                dgvList.Item(0, nri).Value = .GetString(0).Trim
                dgvList.Item(1, nri).Value = .Item(1)
            End While
            .Close()
        End With

        If dgvList.Rows.Count > 0 Then
            pnlList.Visible = True
            dgvList.Focus()
        Else
            MsgBox("Sorry, No data found..!", MsgBoxStyle.Information)
            txtCode.Focus()
        End If

    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click

        '// check whether item is selected

        Dim validateSelected As Boolean = False

        For i As Short = 0 To dgvList.Rows.Count - 1

            If Val(dgvList.Item(2, i).Value) = 1 Then

                validateSelected = True
                Exit For

            End If

        Next

        If Not validateSelected Then
            MsgBox("Select atleast one item..!", MsgBoxStyle.Information)
            dgvList.Focus()
            Exit Sub
        End If

        '// Load list of product code from database

        SQL = "select p.pluid,p.plucode,l.sno from productmaster p,pv_codelist l " _
            & "where p.pluid=l.pluid and l.refid in ("

        For i As Short = 0 To dgvList.Rows.Count - 1

            If Val(dgvList.Item(2, i).Value) = 1 Then

                SQL &= "'" & dgvList.Item(0, i).Value & "',"

            End If

        Next

        SQL = Mid(SQL, 1, SQL.Length - 1) & ") order by l.sno"

        With ESSA.OpenReader(SQL)
            dgvCode.Rows.Clear()
            While .Read
                Dim nri = dgvCode.Rows.Add
                dgvCode.Item(0, nri).Value = .Item(0)
                dgvCode.Item(1, nri).Value = .GetString(1).Trim
                dgvCode.Item(4, nri).Value = .Item(2)
            End While
            .Close()
        End With

        pnlList.Visible = False
        txtCode.Focus()

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        If MsgBox("Do you want to remove all items..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        SQL = "delete from pv_codelist where refid='" & lblRefID.Text.Trim & "'"
        ESSA.Execute(SQL)
        dgvCode.Rows.Clear()
        MsgBox("Data removed successfully..!", MsgBoxStyle.Exclamation)
        txtCode.Focus()

    End Sub

    Private Sub btnLoad2_Click(sender As Object, e As EventArgs) Handles btnLoad2.Click

        SQL = "select deliverycode from deliverymaster where deliveryfrom={0} order by id"
        SQL = String.Format(SQL, cmbDCode.SelectedValue)

        With ESSA.OpenReader(SQL)
            While .Read
                Dim nri = dgvDCode.Rows.Add
                dgvDCode.Item(1, nri).Value = .GetString(0).Trim
            End While
            .Close()
        End With

    End Sub

    Private Sub btnRun_Click(sender As Object, e As EventArgs) Handles btnRun.Click

        '// check whether item is selected

        Dim validateSelected As Boolean = False

        For i As Short = 0 To dgvDCode.Rows.Count - 1

            If Val(dgvDCode.Item(2, i).Value) = 1 Then

                validateSelected = True
                Exit For

            End If

        Next

        If Not validateSelected Then
            MsgBox("Please select atleast one delivery code..!", MsgBoxStyle.Information)
            dgvDCode.Focus()
            Exit Sub
        End If



        Dim deliveryCode As String = ""
        Dim resultVal As Double = 0

        Dim delivered As Double = 0
        Dim received As Double = 0
        Dim variation As Double = 0

        For i As Short = 0 To dgvDCode.Rows.Count - 1

            If Val(dgvDCode.Item(2, i).Value) = 1 Then

                deliveryCode &= "'" & dgvDCode.Item(1, i).Value & "',"

            End If

        Next

        deliveryCode = Mid(deliveryCode, 1, deliveryCode.Length - 1)

        SQL = "select p.plucode,sum(rqty) rq,sum(dqty) dq,p.pluid from productmaster p," _
            & "(select pluid,quantity rqty,0 dqty from receiveddetailstemp " _
            & "where deliverycode in ({0}) union all " _
            & "select pluid,0,1 from pv_codelist) v " _
            & "where p.pluid=v.pluid group by p.plucode,p.pluid order by p.plucode"

        SQL = String.Format(SQL, deliveryCode)

        With ESSA.OpenReader(SQL)
            dgvRst.Rows.Clear()
            While .Read
                Dim nri = dgvRst.Rows.Add
                dgvRst.Item(0, nri).Value = .GetString(0).Trim
                dgvRst.Item(1, nri).Value = .Item(1)
                dgvRst.Item(2, nri).Value = .Item(2)

                resultVal = .Item(1) - .Item(2)

                dgvRst.Item(3, nri).Value = resultVal
                dgvRst.Item(5, nri).Value = .Item(3)


                If resultVal < 0 Then
                    dgvRst.Rows(nri).DefaultCellStyle.BackColor = Color.LightSalmon
                ElseIf resultVal > 0 Then
                    dgvRst.Rows(nri).DefaultCellStyle.BackColor = Color.LightGreen
                End If

                delivered += .Item(1)
                received += .Item(2)
                variation += resultVal

            End While
            .Close()
        End With


        lblDelivered.Text = delivered
        lblReceived.Text = received
        lblVariation.Text = variation

    End Sub

    Private Sub dgvRst_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRst.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub

        SQL = "select distinct deliverycode from receiveddetailstemp where pluid={0}"
        SQL = String.Format(SQL, Val(dgvRst.Item(5, e.RowIndex).Value))

        With ESSA.OpenReader(SQL)
            dgvErr.Rows.Clear()
            While .Read
                Dim nri = dgvErr.Rows.Add()
                dgvErr.Item(0, nri).Value = .GetString(0).Trim
            End While
            .Close()
        End With

        If dgvErr.Rows.Count > 0 Then
            pnlErr.Visible = True
        End If

    End Sub

    Private Sub btnHide2_Click(sender As Object, e As EventArgs) Handles btnHide2.Click

        pnlErr.Visible = False

    End Sub

    Private Sub dgvRst_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvRst.CellContentClick

    End Sub
End Class