Imports System.Data.SqlClient
Imports OfficeOpenXml

Public Class StockReportSW

    Private Sub StockReportSW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT DISTINCT DeptId, Department FROM TSDepartment ORDER BY Department"
        ESSA.LoadCombo(cmbDept, SQL, "Department", "Deptid", "All Departments")

        SQL = "SELECT DISTINCT CatId, Category FROM TSCategory ORDER BY Category"
        ESSA.LoadCombo(cmbCat, SQL, "Category", "CatId", "All Categories")

        SQL = "SELECT DISTINCT MaterialId, Material FROM TSMaterial ORDER BY Material"
        ESSA.LoadCombo(cmbMat, SQL, "Material", "MaterialId", "All Materials")

        SQL = "SELECT DISTINCT BrandId, Brand FROM TSBrand ORDER BY Brand"
        ESSA.LoadCombo(cmbBrand, SQL, "Brand", "BrandId", "All Brands")

        SQL = "SELECT DISTINCT VendorId, VendorName FROM Vendors ORDER BY VendorName"
        ESSA.LoadCombo(cmbVendors, SQL, "VendorName", "VendorId", "All Vendors")

        cmbDept.Select()

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        ESSA.AlignCenter(pnlLoad, Me)
        pnlLoad.Show() : pnlLoad.Refresh()

        SQL = "SELECT Id [SIZE], "

        If rbStock.Checked Then
            SQL &= " SUM(Stock) [STOCK] FROM V_StockSizeWiseShop WHERE LocationId = " & ShopID & " "
        Else
            SQL &= " SUM(Sales) [SALES] FROM V_SalesSizeWise WHERE LocationId = " & ShopID & " "
        End If

        If cmbCat.SelectedIndex > 0 Then
            SQL &= "  AND CatId = " & cmbCat.SelectedValue
        End If

        If cmbDept.SelectedIndex > 0 Then
            SQL &= "AND DeptId = " & cmbDept.SelectedValue
        End If

        If cmbMat.SelectedIndex > 0 Then
            SQL &= " And StyleId = " & cmbMat.SelectedValue
        End If

        If cmbBrand.SelectedIndex > 0 Then
            SQL &= " And BrandId = " & cmbBrand.SelectedValue
        End If

        If cmbVendors.SelectedIndex > 0 Then
            SQL &= " And VendorId = " & cmbVendors.SelectedValue
        End If

        SQL &= " GROUP BY ID " _
            & "ORDER BY " _
            & "Case " _
            & "WHEN ISNUMERIC(ID) = 1 THEN CONVERT(INT, ID) " _
            & "ELSE 9999999 " _
            & "END, " _
            & "ID "

        'If TG.Columns.Count > 0 Then
        '    TG.Columns.Clear()
        'End If

        'ESSA.LoadDataGrid(TG, SQL)

        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                Dim row = TG.Rows.Add
                TG.Item(0, row).Value = .GetString(0)
                TG.Item(1, row).Value = .Item(1)
            End While
            .Close()
        End With

        Dim TotalQty As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            TotalQty += Val(TG.Item(1, i).Value)

        Next

        TG.Rows.Add()
        TG.Rows(TG.Rows.Count - 1).DefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        TG.Item(0, TG.Rows.Count - 1).Value = "TOTAL QTY"
        TG.Item(1, TG.Rows.Count - 1).Value = Format(TotalQty, "0.00")

        pnlLoad.Hide()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub
End Class