'******************************************* Bismillah *********************************************
Imports System.Data.SqlClient
Public Class Customer

    Private CustID As Short = 0
    Private Edit As Boolean = False

    Private Sub GenerateCustID()

        SQL = "select max(customerid) from customers"
        CustID = ESSA.GenerateID(SQL)
        txtCustCode.Text = "C" & CustID

    End Sub

    Private Sub RefreshForms()

        Edit = False
        ESSA.ClearTextBox(Panel2)
        txtCustCode.Focus()
        GenerateCustID()

    End Sub

    Private Sub LoadCustomers()

        TG.Rows.Clear()

        SQL = "select customerid,customercode,customername from customers order by customerid"
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

    Private Sub Customer_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadCustomers()
        GenerateCustID()
        txtCustCode.Select()

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        If txtCustName.Text.Trim = "" Then
            TTip.Show("Customer name should be empty..!", txtCustName, 0, 25, 2000)
            txtCustName.Focus()
            Exit Sub
        ElseIf ESSA.ISFound("select customerid from customers where customercode='" & txtCustCode.Text.Trim & "'" & IIf(Edit = True, " and customerid<>" & CustID, "")) = True Then
            TTip.Show("Customer code already exists..!", txtCustCode, 0, 25, 2000)
            txtCustCode.SelectAll()
            Exit Sub
        ElseIf ESSA.ISFound("select customerid from customers where customername='" & txtCustName.Text.Trim & "'" & IIf(Edit = True, " and customerid<>" & CustID, "")) = True Then
            TTip.Show("Customer name already exists..!", txtCustName, 0, 25, 2000)
            txtCustName.SelectAll()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then
                SQL = "delete from customers where customerid=" & CustID
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                GenerateCustID()
            End If

            SQL = "insert into customers values (" _
                & CustID & ",'" _
                & txtCustCode.Text.Trim & "','" _
                & txtCustName.Text.Trim & "','" _
                & txtAddress1.Text.Trim & "','" _
                & txtAddress2.Text.Trim & "','" _
                & txtCity.Text.Trim & "','" _
                & txtState.Text.Trim & "','" _
                & txtCountry.Text.Trim & "','" _
                & txtPhone.Text.Trim & "','" _
                & txtMobile.Text.Trim & "','" _
                & txtEmail.Text.Trim & "',0," _
                & Val(txtDis.Text) & ",'" _
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

        MsgBox("New customer has been save successfully..!", vbExclamation)
        RefreshForms()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        LoadCustomers()
        RefreshForms()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

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

            SQL = "select * from customers where customerid=" & Val(TG.Item(0, TG.CurrentRow.Index).Value)
            With ESSA.OpenReader(SQL)
                If .Read Then
                    Edit = True
                    CustID = .Item(0)
                    If IsDBNull(.Item(1)) = False Then txtCustCode.Text = .GetString(1)
                    If IsDBNull(.Item(2)) = False Then txtCustName.Text = .GetString(2)
                    If IsDBNull(.Item(3)) = False Then txtAddress1.Text = .GetString(3)
                    If IsDBNull(.Item(4)) = False Then txtAddress2.Text = .GetString(4)
                    If IsDBNull(.Item(5)) = False Then txtCity.Text = .GetString(5)
                    If IsDBNull(.Item(6)) = False Then txtState.Text = .GetString(6)
                    If IsDBNull(.Item(7)) = False Then txtCountry.Text = .GetString(7)
                    If IsDBNull(.Item(8)) = False Then txtPhone.Text = .GetString(8)
                    If IsDBNull(.Item(9)) = False Then txtMobile.Text = .GetString(9)
                    If IsDBNull(.Item(10)) = False Then txtEmail.Text = .GetString(10)
                    If IsDBNull(.Item(11)) = False Then txtDis.Text = .Item(11)
                End If
                .Close()
            End With

            txtFindCust.Clear()
            txtCustCode.Focus()

        End If

    End Sub

End Class