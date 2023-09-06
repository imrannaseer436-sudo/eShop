Imports System.Data.SqlClient
Imports OfficeOpenXml
Imports Zuby.ADGV

Public Class frmDueReport

    Dim bind As New BindingSource
    Dim LSERVER As String = "ESERVER"
    Dim DBASE As String = "eWarehouse1213"

    Private Sub frmDueReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT DeptId,Department FROM TSDepartment ORDER BY Department "
        ESSA.LoadCombo(cmbDept, SQL, "Department", "DeptId", "All Departments")

        SQL = "SELECT CatId,Category FROM TSCategory ORDER BY Category "
        ESSA.LoadCombo(cmbCat, SQL, "Category", "CatId", "All Categories")

    End Sub

    Private Sub LoadDueReport()

        SQL = "SELECT S.PluId," _
            & "M.PluCode [CODE]," _
            & "M.PluName [DESCRIPTION]," _
            & "A.Department [DEPARTMENT]," _
            & "A.Category [CATEGORY]," _
            & "PM.CostPrice [COST PRICE]," _
            & "PM.RetailPrice [RETAIL PRICE]," _
            & "DATEDIFF(DAY,G.GRNDt,CURRENT_TIMESTAMP) [DAYS], " _
            & "SUM(S.stock) [STOCK] " _
            & "FROM V_StockPOS S, ProductMaster M,GRNDetails G,GRNMaster GM, ProductAttributes A,PriceMaster PM " _
            & "WHERE S.pluid = M.PluID And M.Size = G.PluID And S.pluid = A.PluId And G.GrnNo = GM.GrnNo AND " _
            & "PM.PLUID = S.PLUID AND PM.SHOPID = " & ShopID & " AND S.LOCATION_ID = " & ShopID & ""

        '= "SELECT S.PluId," _
        '    & "M.PluCode [CODE]," _
        '    & "M.PluName [DESCRIPTION]," _
        '    & "A.Department [DEPARTMENT]," _
        '    & "A.Category [CATEGORY]," _
        '    & "M.CostPrice [COST PRICE]," _
        '    & "M.RetailPrice [RETAIL PRICE]," _
        '    & "DATEDIFF(DAY,G.GRNDt,CURRENT_TIMESTAMP) [DAYS], " _
        '    & "SUM(S.stock) [STOCK] " _
        '    & "FROM V_StockPOS S, ProductMaster M," & LSTBL("GRNDetails", "G") & ", " & LSTBL("GRNMaster", "GM") & ", ProductAttributes A " _
        '    & "WHERE S.pluid = M.PluID And M.Size = G.PluID And S.pluid = A.PluId And G.GrnNo = GM.GrnNo And S.stock > 0 "

        If cmbDept.SelectedIndex > 0 Then
            SQL &= " And A.DeptId =" & cmbDept.SelectedValue
        End If

        If cmbCat.SelectedIndex > 0 Then
            SQL &= " And A.CatId =" & cmbCat.SelectedValue
        End If

        SQL &= " And GM.GrnDt BETWEEN '" & Format(dtpBegin.Value, "yyyy-MM-dd") & "' AND '" & Format(dtpEnd.Value, "yyyy-MM-dd") & "'"

        SQL &= " GROUP BY S.pluid, M.Plucode, M.Pluname, A.Department,A.Category, PM.CostPrice,PM.RetailPrice, DATEDIFF(DAY,G.GRNDt,CURRENT_TIMESTAMP) " _
             & "ORDER BY DAYS DESC"

        Try

            LoadData(SQL)
            LoadSummary()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Con.Close()

        End Try

        dgvList.Columns(0).Visible = False
        dgvList.Columns(1).Width = 80
        dgvList.Columns(2).Width = 250
        dgvList.Columns(3).Width = 120
        dgvList.Columns(4).Width = 120
        dgvList.Columns(5).Width = 100
        dgvList.Columns(6).Width = 100
        dgvList.Columns(7).Width = 80
        dgvList.Columns(8).Width = 80

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If dgvList.Rows.Count = 0 Then Exit Sub

        Dim sfd1 As New SaveFileDialog
        sfd1.Title = "Please select export location"
        sfd1.FileName = "DueDays Report"
        sfd1.Filter = "Excel Files (*.xlsx)|*.xlsx"
        If sfd1.ShowDialog = DialogResult.Cancel Then Exit Sub

        Dim fileName = sfd1.FileName & ".xlsx"
        Dim tableData As New DataTable
        tableData = CType(dgvList.DataSource, DataTable)

        Using package As New ExcelPackage(New IO.FileInfo(fileName))
            Dim ws As ExcelWorksheet = package.Workbook.Worksheets.Add("Sheet1")
            ws.Cells("A1").LoadFromDataTable(tableData, True)
            package.Save()
        End Using

        MsgBox("File exported successfully..!", MsgBoxStyle.Exclamation)

    End Sub

    Private Sub LoadData(iSql As String)

        ESSA.OpenConnection()
        Using adp As New SqlDataAdapter(iSql, Con)
            adp.SelectCommand.CommandTimeout = 0
            Using data2 As New DataTable
                adp.Fill(data2)
                bind.DataSource = Nothing
                bind.DataSource = data2
                dgvList.CleanFilterAndSort()
                dgvList.DataSource = Nothing
                dgvList.DataSource = bind.DataSource
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Function LSTBL(tbl As String, als As String) As String

        LSTBL = LSERVER & "." & DBASE & ".DBO." & tbl & " " & als

    End Function

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        pnlLoad.Show() : pnlLoad.Refresh()
        LoadDueReport()
        pnlLoad.Hide()

    End Sub

    Private Sub LoadSummary()

        Dim Qty As Double = 0
        Dim Amount As Double = 0

        For i As Integer = 0 To dgvList.Rows.Count - 1
            Qty += Val(dgvList.Item(8, i).Value)
            Amount += Val(dgvList.Item(6, i).Value)
        Next

        lblQty.Text = Qty
        lblAmount.Text = Format(Amount, "0.00")

    End Sub

    Private Sub frmDueReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.AlignCenter(pnlLoad, Me)

    End Sub

    Private Sub dgvList_SortStringChanged(sender As Object, e As AdvancedDataGridView.SortEventArgs) Handles dgvList.SortStringChanged

        bind.Sort = dgvList.SortString

    End Sub

    Private Sub dgvList_FilterStringChanged(sender As Object, e As AdvancedDataGridView.FilterEventArgs) Handles dgvList.FilterStringChanged

        bind.Filter = dgvList.FilterString
        LoadSummary()

    End Sub

End Class