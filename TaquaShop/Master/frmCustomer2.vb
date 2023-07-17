Imports System.Data.SqlClient

Public Class frmCustomer2

    Private CustomerID As Integer = 0
    Private Edit As Boolean = False

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        If MsgBox("Do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Close()

    End Sub

    Private Sub frmCustomer2_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then

                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)

                End If

            Case Keys.Escape

                If MsgBox("Do you want to exit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Close()

        End Select

    End Sub

    Private Sub frmCustomer2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ApplyControlTheme()

        SQL = "select distinct state from customers where len(state)>0 order by state"
        ESSA.LoadCombo(cmbState, SQL, "state")

        SQL = "select distinct country from customers where len(country)>0 order by country"
        ESSA.LoadCombo(cmbCountry, SQL, "country")

        GenerateCustomerID()

        txtName.Select()

    End Sub

    Private Sub ApplyControlTheme()

        For Each ctl As Control In Me.Controls

            If TypeOf ctl Is TextBox Or TypeOf ctl Is ComboBox Then

                AddHandler ctl.Enter, AddressOf Ctl_Enter
                AddHandler ctl.Leave, AddressOf Ctl_Leave

            End If

        Next

    End Sub

    Private Sub Ctl_Enter(sender As Object, e As EventArgs)

        CType(sender, Control).BackColor = Color.LightCyan

    End Sub

    Private Sub Ctl_Leave(sender As Object, e As EventArgs)

        CType(sender, Control).BackColor = SystemColors.Window

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If txtName.Text.Trim = "" Then
            MsgBox("Customer name should be empty..!", MsgBoxStyle.Information)
            txtName.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select customerid from customers where customercode='" & txtCode.Text.Trim & "'" & IIf(Edit = True, " and customerid<>" & CustomerID, "")) = True Then
            MsgBox("Customer code already exists..!", MsgBoxStyle.Information)
            txtCode.SelectAll()
            Exit Sub
        ElseIf ESSA.ISFound("select customerid from customers where customername='" & txtName.Text.Trim & "'" & IIf(Edit = True, " and customerid<>" & CustomerID, "")) = True Then
            MsgBox("Customer name already exists..!", MsgBoxStyle.Information)
            txtName.SelectAll()
            Exit Sub
        End If

        If MsgBox("Do you want to save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from customers where customerid=" & CustomerID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateCustomerID()
            End If

            SQL = "insert into customers values (" _
                & CustomerID & ",'" _
                & txtCode.Text.Trim & "','" _
                & txtName.Text.Trim & "','" _
                & txtAdd1.Text.Trim & "','" _
                & txtAdd2.Text.Trim & "','" _
                & txtCity.Text.Trim & "','" _
                & cmbState.Text.Trim & "','" _
                & cmbCountry.Text.Trim & "','" _
                & txtPhone.Text.Trim & "','" _
                & txtGST.Text.Trim & "','" _
                & txtMailID.Text.Trim & "',0,0,'" _
                & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & ShopID & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        MsgBox("New customer has been saved successfully..!", vbExclamation)
        RefreshForms()

    End Sub

    Private Sub RefreshForms()

        Edit = False
        ESSA.ClearTextBox(Me)
        txtName.Focus()
        GenerateCustomerID()

    End Sub

    Private Sub GenerateCustomerID()

        SQL = "select max(customerid) from customers"
        CustomerID = ESSA.GenerateID(SQL)
        txtCode.Text = "C" & CustomerID

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click

    End Sub
End Class