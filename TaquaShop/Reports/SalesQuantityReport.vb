'************************************************ Bismillah *****************************************************
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop

Public Class SalesQuantityReport

    Private Sub SalesQuantityReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'SQL = "select catid,catdesc from category order by catdesc"
        'ESSA.LoadComboSimple(CmbCat, SQL, "catdesc", "catid", "All Category(s)")

        SQL = "select convert(varchar,termid) term from terminal where shopid = " & ShopID & " order by termid" ' where shopid=" & ShopID
        ESSA.LoadCombo(cmbTerm, SQL, "term", "", "All")

        SQL = "select deptid,department from tsdepartment order by department"
        ESSA.LoadCombo(CmbDept, SQL, "department", "deptid", "All Department(s)")

        SQL = "select catid,category from tscategory order by category"
        ESSA.LoadCombo(CmbCat, SQL, "category", "catid", "All Category(s)")

        SQL = "select styleid,style from tsstyle order by style"
        ESSA.LoadCombo(cmbStyle, SQL, "style", "styleid", "All Style(s)")

        SQL = "select catalogid,catalog from tscatalog order by catalog"
        ESSA.LoadCombo(CmbCatalog, SQL, "catalog", "catalogid", "All Catalog(s)")

    End Sub

    'Private Sub CmbCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCat.SelectedIndexChanged

    '    If CmbCat.SelectedIndex = -1 Then Exit Sub
    '    SQL = "select scatid,scatdesc from subcategory1 " & IIf(CmbCat.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(CmbCat), "") & " order by scatdesc"
    '    ESSA.LoadComboSimple(CmbSCat1, SQL, "scatdesc", "scatid", "All Category(s)")

    'End Sub

    'Private Sub CmbSCat1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSCat1.SelectedIndexChanged

    '    If CmbSCat1.SelectedIndex = -1 Then Exit Sub
    '    SQL = "select scatid,scatdesc from subcategory2 " & IIf(CmbSCat1.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(CmbSCat1), "") & " order by scatdesc"
    '    ESSA.LoadComboSimple(cmbSCat2, SQL, "scatdesc", "scatid", "All Category(s)")

    'End Sub

    'Private Sub cmbSCat2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSCat2.SelectedIndexChanged

    '    If cmbSCat2.SelectedIndex = -1 Then Exit Sub
    '    SQL = "select scatid,scatdesc from subcategory3 " & IIf(cmbSCat2.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(cmbSCat2), "") & " order by scatdesc"
    '    ESSA.LoadComboSimple(cmbSCat3, SQL, "scatdesc", "scatid", "All Category(s)")

    'End Sub

    Private Sub btnCatFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatFilter.Click

        pnlCatFilter.Visible = True
        CmbDept.Focus()

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlCatFilter.Visible = False

    End Sub

    Private Sub LoadData()

        SQL = "select p.plucode 'CODE',p.pluname 'PRODUCT DESCRIPTION',p.units 'UOM',sum(d.qty) 'QUANTITY',sum(d.amount) 'AMOUNT',a.department 'DEPARTMENT',a.category 'CATEGORY',a.style 'STYLE',a.catalog 'CATALOG' from productmaster p,billdetails d," _
            & "productattributes a where p.pluid=a.pluid and p.pluid=d.pluid and d.shopid = " & ShopID & " and d.billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        If cmbTerm.SelectedIndex > 0 Then
            SQL &= " and d.termid=" & cmbTerm.Text
        End If

        If CmbDept.SelectedIndex > 0 Then
            SQL &= " and a.deptid=" & ESSA.GetItemValue(CmbDept)
        End If

        If CmbCat.SelectedIndex > 0 Then
            SQL &= " and a.catid=" & ESSA.GetItemValue(CmbCat)
        End If

        If cmbStyle.SelectedIndex > 0 Then
            SQL &= " and a.styleid=" & ESSA.GetItemValue(cmbStyle)
        End If

        If CmbCatalog.SelectedIndex > 0 Then
            SQL &= " and a.catalogid=" & ESSA.GetItemValue(CmbCatalog)
        End If

        If txtPlucode.Text.Trim.Length > 0 Then
            SQL &= " and p.plucode like '%" & txtPlucode.Text & "%'"
        End If

        SQL &= " and d.qty>0 group by p.plucode,p.pluname,p.units,a.department,a.category,a.style,a.catalog order by p.plucode"

        ESSA.LoadDataGrid(TG, SQL)
        TG.Columns(0).Width = 100
        TG.Columns(1).Width = 250
        TG.Columns(2).Width = 100
        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        TG.Columns(3).Width = 80
        TG.Columns(4).Width = 80
        TG.Columns(5).Width = 120
        TG.Columns(6).Width = 120
        TG.Columns(7).Width = 120
        TG.Columns(8).Width = 250

        Dim TQty As Double = 0
        For i As Integer = 0 To TG.Rows.Count - 1
            TQty += Val(TG.Item(3, i).Value)
        Next
        lblQty.Text = TQty

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        LoadData()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        LoadData()
        pnlCatFilter.Visible = False

    End Sub

    Public Shared Sub ExportToExcel(ByVal dgv As DataGridView)
        Try
            ' Create a new Excel application
            Dim excelApp As New Excel.Application()

            ' Create a new workbook
            Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()

            ' Create a new worksheet
            Dim worksheet As Excel.Worksheet = DirectCast(workbook.Sheets(1), Excel.Worksheet)

            ' Export headers to Excel
            For i As Integer = 1 To dgv.Columns.Count
                worksheet.Cells(1, i) = dgv.Columns(i - 1).HeaderText
            Next

            ' Export data to Excel
            For i As Integer = 0 To dgv.Rows.Count - 1
                For j As Integer = 0 To dgv.Columns.Count - 1
                    worksheet.Cells(i + 2, j + 1) = dgv.Rows(i).Cells(j).Value
                Next
            Next

            ' Auto-fit columns
            worksheet.UsedRange.Columns.AutoFit()

            ' Get the desktop path
            Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

            ' Set the base file name
            Dim baseFileName As String = "Sales Qty Report.xlsx"

            ' Check if the file already exists, if yes, append a number
            Dim filePath As String = System.IO.Path.Combine(desktopPath, baseFileName)
            Dim counter As Integer = 1

            While System.IO.File.Exists(filePath)
                baseFileName = $"Sales Qty Report({counter}).xlsx"
                filePath = System.IO.Path.Combine(desktopPath, baseFileName)
                counter += 1
            End While

            workbook.SaveAs(filePath)

            ' Close the workbook and release resources
            workbook.Close()
            excelApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)

            MsgBox("Data exported to Excel successfully!" & vbCrLf & "File saved on the desktop.", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox("Error exporting data to Excel: " & ex.Message, MsgBoxStyle.Exclamation)
        End Try
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        ExportToExcel(TG)

    End Sub
End Class