Imports System.Data.SqlClient
Public Class SalesPerson

    Private Edit As Boolean = False

    Private Sub SalesPerson_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F2

                btnAddSalesPerson.PerformClick()

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then

                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)

                End If

            Case Keys.Escape

                If pnlRegister.Visible Then btnHide.PerformClick() : Exit Sub
                If MsgBox("Do you want to exit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Close()

        End Select

    End Sub

    Private Sub SalesPerson_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Align Header

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)

        ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleCenter)

        '// Load Sales Person List

        LoadSalesPersonList()

    End Sub

    Private Sub btnAddSalesPerson_Click(sender As Object, e As EventArgs) Handles btnAddSalesPerson.Click

        'GenerateSPID()
        RefreshForms()
        Edit = False
        setLable()
        pnlRegister.Visible = True
        txtSPID.Focus()

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        LoadSalesPersonList()
        pnlRegister.Visible = False
        Edit = False

    End Sub

    Private Sub GenerateSPID()

        txtSPID.Text = ESSA.GenerateID("select max(spid) from salespersons")

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If txtSPID.Text = "" Then
            MsgBox("SP Code should not be empty..!", MsgBoxStyle.Critical)
            txtSPID.Focus()
            Exit Sub
        ElseIf txtName.Text.Trim = "" Then
            MsgBox("Sales person name should not be empty..!", MsgBoxStyle.Critical)
            txtName.Focus()
            Exit Sub
        ElseIf txtFloor.Text.Trim.Length = 0 Then
            MsgBox("Floor Value Should Not Be Empty..!", MsgBoxStyle.Critical)
            txtFloor.Focus()
            Exit Sub
        ElseIf cmbSupervisor.FindStringExact(cmbSupervisor.Text) = -1 Then
            MsgBox("Only yes or no available..!", MsgBoxStyle.Critical)
            cmbSupervisor.Focus()
            Exit Sub
        End If

        cmbSupervisor.SelectedIndex = cmbSupervisor.FindStringExact(cmbSupervisor.Text)

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit Then
                SQL = "delete from salespersons where shopid = " & ShopID & " and spcode=" & Val(txtSPID.Text)
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                If ifExists(txtSPID.Text) Then
                    MsgBox("code exists already..!", MsgBoxStyle.Critical)
                    txtSPID.Focus()
                    Exit Sub
                End If
                '    GenerateSPID()
            End If

            SQL = "insert into salespersons (spcode,name,floor,perc,supervisor,status,updateddate,userid,shopid) values (" _
                 & Val(txtSPID.Text) & ",'" _
                 & txtName.Text.Trim & "','" _
                 & txtFloor.Text.Trim & "'," _
                 & Val(txtPerc.Text) & "," _
                 & cmbSupervisor.SelectedIndex & "," _
                 & IIf(rdoWorking.Checked, "0", "1") & ",'" _
                 & Format(Now, "yyyy-MM-dd HH:mm:ss") & "'," _
                 & UserID & "," _
                 & ShopID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

            RefreshForms()

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub LoadSalesPersonList()

        SQL = $"select * from salespersons where shopid = {ShopID} order by spid"

        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3).Trim
                TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                TG.Item(5, TG.Rows.Count - 1).Value = IIf(.Item(5) = 0, "No", "Yes")
                TG.Item(6, TG.Rows.Count - 1).Value = "2"
                TG.Item(8, TG.Rows.Count - 1).Value = .Item(6)
                If .Item(6) = 1 Then
                    TG.Rows(TG.Rows.Count - 1).DefaultCellStyle.BackColor = Color.MistyRose
                End If
            End While
            .Close()
        End With

    End Sub

    Private Sub RefreshForms()

        txtFloor.Clear()
        txtName.Clear()
        txtPerc.Clear()
        txtSPID.Clear()
        'GenerateSPID()
        rdoWorking.Checked = True
        txtSPID.Focus()

        If Edit = True Then
            Edit = False
            LoadSalesPersonList()
            pnlRegister.Visible = False
        End If

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 6 Then
            ViewSalesPerson(Val(TG.Item(0, e.RowIndex).Value))
            setLable()
        End If

    End Sub

    Private Sub ViewSalesPerson(iSPID As Short)

        SQL = "select * from salespersons where spid=" & iSPID
        With ESSA.OpenReader(SQL)
            If .Read Then
                Edit = True
                txtSPID.Text = .Item(1)
                txtName.Text = .GetString(2).Trim
                txtFloor.Text = .GetString(3).Trim
                txtPerc.Text = Format(.Item(4), "0.00")
                cmbSupervisor.SelectedIndex = .Item(5)
                If .Item(6) = 0 Then
                    rdoWorking.Checked = True
                Else
                    rdoDiscontinued.Checked = True
                End If
                pnlRegister.Visible = True
                txtName.Focus()
            End If
        End With

    End Sub

    Private Sub setLable()

        If Edit = True Then
            lblRegister.Text = "Sales Person Register - Edit Mode"
            lblRegister.BackColor = Color.Red
        Else
            lblRegister.Text = "Sales Person Register"
            lblRegister.BackColor = Color.FromArgb(0, 0, 192)
        End If

    End Sub

    Private Sub TG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellContentClick

    End Sub

    Private Function ifExists(SPCode As String) As Boolean

        ifExists = False
        SQL = "SELECT * FROM SalesPersons WHERE ShopId = " & ShopID & " AND  SpCode ='" & SPCode & "'"

        With ESSA.OpenReader(SQL)
            If .HasRows Then
                ifExists = True
            End If
        End With

        Return ifExists

    End Function

End Class