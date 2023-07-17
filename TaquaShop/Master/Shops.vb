'*************************************** Bismillah **************************************
Imports System.Data.SqlClient
Public Class Shops

    Private SopID As Short
    Private Edit As Boolean = False

    Private Sub vendors_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2
                btnSave.PerformClick()
            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        LoadShopList()
        GenerateShopID()
        txtLName.Select()
        cmbLType.SelectedIndex = 0

    End Sub

    Private Sub GenerateShopID()

        SQL = "select max(Shopid) from Shops"
        SopID = ESSA.GenerateID(SQL)

        SQL = "select max(Shopid) from Shops where Shoptype='" & cmbLType.Text & "'"
        txtLCode.Text = IIf(cmbLType.SelectedIndex = 0, "EW", "ER") & Format(ESSA.GenerateID(SQL), "00")
        'txtLCode.Text = IIf(cmbLType.SelectedIndex = 0, "WH", "TS") & Format(ESSA.GenerateID(SQL), "00")

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtLName.Text.Trim = "" Then
            TTip.Show("Shop name should be empty..!", txtLName, 0, 25, 2000)
            txtLName.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select shopid from shops where shopname='" & txtLName.Text.Trim & "'" & IIf(Edit = True, " and shopid<>" & SopID, "")) = True Then
            TTip.Show("Shop name already exists..!", txtLName, 0, 25, 2000)
            txtLName.SelectAll()
            txtLName.Focus()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from Shops where Shopid=" & SopID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateShopID()
            End If

            SQL = "insert into Shops values (" _
                & SopID & ",'" _
                & txtLCode.Text & "','" _
                & txtLName.Text & "','" _
                & txtAlias.Text & "','" _
                & cmbLType.Text & "','" _
                & txtAddress1.Text & "','" _
                & txtAddress2.Text & "','" _
                & txtCity.Text & "','" _
                & txtState.Text & "','" _
                & txtPhone.Text & "','" _
                & txtMobile.Text & "','" _
                & txtFax.Text & "','" _
                & txtEmail.Text & "','" _
                & txtVAT.Text & "','" _
                & txtCST.Text & "',0,0,'" _
                & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()
            RefreshForms()
            'xMessageBox.ShowMessage("New Shop has been created successfully..!", "Congratualtions..!", xMessageBox.MessageBoxStyle.OKOnly)

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub RefreshForms()

        Edit = False
        ESSA.ClearTextBox(Panel2)
        GenerateShopID()
        txtLName.Focus()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        RefreshForms()

    End Sub

    Private Sub cmbLType_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbLType.Leave

        If Edit = False Then
            GenerateShopID()
        End If

    End Sub

    Private Sub LoadShopList()

        TG.Rows.Clear()

        SQL = "select shopid,shopcode,shopname from shops order by shopid"
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
            End While
            .Close()
        End With

    End Sub

    Private Sub txtFindCust_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindCust.KeyDown

        TG_KeyDown(sender, e)

    End Sub

    Private Sub txtFindCust_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFindCust.KeyUp

        If e.KeyCode = Keys.Down Then
            TG.Focus()
        ElseIf e.KeyCode <> Keys.Enter Then
            ESSA.FindAndSelect(TG, 2, txtFindCust.Text)
        End If

    End Sub

    Private Sub TG_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            SQL = "select * from shops where shopid=" & Val(TG.Item(0, TG.CurrentRow.Index).Value)
            With ESSA.OpenReader(SQL)
                If .Read Then
                    Edit = True
                    SopID = .Item("ShopId")
                    txtLCode.Text = .Item("ShopCode").Trim
                    txtLName.Text = .Item("ShopName").Trim
                    cmbLType.Text = .Item("ShopType").Trim
                    txtAddress1.Text = .Item("Address1").Trim
                    txtAddress2.Text = .Item("Address2").Trim
                    txtCity.Text = .Item("City").Trim
                    txtState.Text = .Item("State").Trim
                    txtPhone.Text = .Item("Phone").Trim
                    txtMobile.Text = .Item("Mobile").Trim
                    txtFax.Text = .Item("Fax").Trim
                    txtEmail.Text = .Item("Email").Trim
                    txtVAT.Text = .Item("VAT").Trim
                    txtCST.Text = .Item("CST").Trim
                    txtAlias.Text = .Item("Alias").Trim
                    txtLName.Focus()
                End If
                .Close()
            End With

        End If

    End Sub

End Class