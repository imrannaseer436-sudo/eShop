'******************************************* Bismillah ************************************
Imports System.Data.SqlClient
Public Class ProductReport

    Private Enum DisplayType As Byte

        NoFilter = 0
        Filter = 1

    End Enum

    Private Sub LoadData(ByVal SearchType As DisplayType, Optional ByVal KeyWordWise As Boolean = False)

        If KeyWordWise = True Then

            If SearchType = DisplayType.NoFilter Then

                SQL = "SELECT DISTINCT PLUCODE 'CODE',PLUNAME 'PRODUCT DESCRIPTION',UNITS 'UOM',V.STOCK,CONVERT(DECIMAL(10,2),M.COSTPRICE) 'C.PRICE',L.DEPARTMENT CATDESC,L.CATEGORY SCATDESC1,L.MATERIAL SCATDESC2,L.STYLE SCATDESC3, L.BRAND SCATDESC4,L.PATTERN SCATDESC5 FROM " _
                    & "PRODUCTMASTER P,PRODUCTATTRIBUTES L,V_STOCKPOS V,PRICEMASTER M WHERE P.PLUID=V.PLUID AND P.PLUID=L.PLUID AND M.PLUID = V.PLUID AND M.SHOPID = " & ShopID & " AND V.LOCATION_ID = " & ShopID & " AND " & IIf(lblCode.Text = "CODE", "P.PLUCODE", "P.PLUNAME") & " LIKE '%" & txtCode.Text.Trim & "%'"

                If chkEZQ.Checked = True Then
                    SQL &= " AND V.STOCK>0"
                End If

                SQL &= " ORDER BY PLUCODE"

            Else

                SQL = "SELECT DISTINCT PLUCODE 'CODE',PLUNAME 'PRODUCT DESCRIPTION',UNITS 'UOM',V.STOCK,CONVERT(DECIMAL(10,2),M.COSTPRICE) 'C.PRICE',L.DEPARTMENT CATDESC,L.CATEGORY SCATDESC1,L.MATERIAL SCATDESC2,L.STYLE SCATDESC3, L.BRAND SCATDESC4,L.PATTERN SCATDESC5 FROM " _
                    & "PRODUCTMASTER P,PRODUCTATTRIBUTES L,V_STOCKPOS V,PRICEMASTER M WHERE P.PLUID=V.PLUID P.PLUID=L.PLUID AND M.ShopId = " & ShopID & " AND M.Pluid = P.Pluid AND V.LOCATION_ID = " & ShopID & " AND " & IIf(lblCode.Text = "CODE", "P.PLUCODE", "P.PLUNAME") & " LIKE '%" & txtCode.Text.Trim & "%' "

                If chkEZQ.Checked = True Then
                    SQL &= " AND V.STOCK>0"
                End If

                If cmbCat.SelectedIndex > 0 Then
                    SQL &= "and L.DeptID=" & cmbCat.SelectedValue
                End If

                If cmbSCat1.SelectedIndex > 0 Then
                    SQL &= "and L.CatId=" & cmbSCat1.SelectedValue
                End If

                If cmbSCat2.SelectedIndex > 0 Then
                    SQL &= "and L.MaterialID=" & cmbSCat2.SelectedValue
                End If

                If cmbSCat3.SelectedIndex > 0 Then
                    SQL &= "and L.StyleId=" & cmbSCat3.SelectedValue
                End If

                If cmbSCat4.SelectedIndex > 0 Then
                    SQL &= "and L.BrandId=" & cmbSCat4.SelectedValue
                End If

                If cmbSCat5.SelectedIndex > 0 Then
                    SQL &= "and L.PatternId=" & cmbSCat5.SelectedValue
                End If

                SQL &= " order by plucode"

            End If

        Else

            If SearchType = DisplayType.NoFilter Then

                SQL = "SELECT DISTINCT PLUCODE 'CODE',PLUNAME 'PRODUCT DESCRIPTION',UNITS 'UOM',V.STOCK,CONVERT(DECIMAL(10,2),M.MRP) 'MRP',L.DEPARTMENT CATDESC,L.CATEGORY SCATDESC1,L.MATERIAL SCATDESC2,L.STYLE SCATDESC3, L.BRAND SCATDESC4,L.PATTERN SCATDESC5 FROM " _
                    & "PRODUCTMASTER P,PRODUCTATTRIBUTES L,V_STOCKPOS V,PRICEMASTER M WHERE P.PLUID=V.PLUID AND V.LOCATION_ID = " & ShopID & " AND P.PLUID=L.PLUID AND M.SHOPID = " & ShopID & " AND M.PluId = P.PluId "

                If chkEZQ.Checked = True Then
                    SQL &= " AND V.STOCK>0"
                End If

                SQL &= " ORDER BY PLUCODE"

            Else

                SQL = "SELECT DISTINCT PLUCODE 'CODE',PLUNAME 'PRODUCT DESCRIPTION',UNITS 'UOM',V.STOCK,CONVERT(DECIMAL(10,2),M.MRP) 'MRP',L.DEPARTMENT CATDESC,L.CATEGORY SCATDESC1,L.MATERIAL SCATDESC2,L.STYLE SCATDESC3, L.BRAND SCATDESC4,L.PATTERN SCATDESC5 FROM " _
                    & "PRODUCTMASTER P,PRODUCTATTRIBUTES L,V_STOCKPOS V,PRICEMASTER M WHERE P.PLUID=V.PLUID AND V.LOCATION_ID = " & ShopID & " AND P.PLUID=L.PLUID AND M.ShopID = " & ShopID & " AND M.PluID = P.PluId "

                If chkEZQ.Checked = True Then
                    SQL &= " AND V.STOCK>0"
                End If

                If cmbCat.SelectedIndex > 0 Then
                    SQL &= "and L.DeptID=" & cmbCat.SelectedValue
                End If

                If cmbSCat1.SelectedIndex > 0 Then
                    SQL &= "and L.CatId=" & cmbSCat1.SelectedValue
                End If

                If cmbSCat2.SelectedIndex > 0 Then
                    SQL &= "and L.MaterialID=" & cmbSCat2.SelectedValue
                End If

                If cmbSCat3.SelectedIndex > 0 Then
                    SQL &= "and L.StyleId=" & cmbSCat3.SelectedValue
                End If

                If cmbSCat4.SelectedIndex > 0 Then
                    SQL &= "and L.BrandId=" & cmbSCat4.SelectedValue
                End If

                If cmbSCat5.SelectedIndex > 0 Then
                    SQL &= "and L.PatternId=" & cmbSCat5.SelectedValue
                End If

                SQL &= " order by plucode"

            End If

        End If

        ESSA.LoadDataGrid(TG, SQL)

        Dim tot As Double = 0
        For i As Integer = 0 To TG.Rows.Count - 1
            tot += Val(TG.Item(3, i).Value)
        Next
        lblStock.Text = tot

        'TG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill)

    End Sub

    Private Sub lblSearchMode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblSearchMode.Click

        If lblCode.Text = "CODE" Then
            lblCode.Text = "PRODUCT"
            lblSearchMode.Text = "< CODE"
        Else
            lblCode.Text = "CODE"
            lblSearchMode.Text = "< PRODUCT"
        End If

    End Sub

    Private Sub ProductReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'SQL = "select catid,catdesc from category order by catdesc"
        'ESSA.LoadCombo(cmbCat, SQL, "catdesc", "catid", "All Cateogry(s)")

        SQL = "SELECT BrandId,Brand FROM TSBrand  ORDER BY Brand"
        ESSA.LoadCombo(cmbSCat4, SQL, "Brand", "BrandId", "All Brands")

        SQL = "SELECT CatId,Category FROM TSCategory  ORDER BY Category"
        ESSA.LoadCombo(cmbSCat1, SQL, "Category", "CatId", "All Categories")

        SQL = "SELECT  DeptId,Department FROM   TSDepartment  ORDER BY Department"
        ESSA.LoadCombo(cmbCat, SQL, "Department", "DeptId", "All Departments")

        SQL = "SELECT  MaterialId,Material FROM   TSMaterial  ORDER BY Material"
        ESSA.LoadCombo(cmbSCat2, SQL, "Material", "MaterialId", "All Materials")

        SQL = "SELECT  PatternId,Pattern FROM   TSPattern  ORDER BY Pattern"
        ESSA.LoadCombo(cmbSCat5, SQL, "Pattern", "PatternId", "All Pattern")

        SQL = "SELECT  StyleId,Style  FROM   TSStyle  ORDER BY Style "
        ESSA.LoadCombo(cmbSCat3, SQL, "Style", "StyleId", "All Styles")

        LoadData(DisplayType.NoFilter)

        'Dim DGVMgr As New DgvFilterManager
        'DGVMgr.DataGridView = TG

        'For i As SByte = 0 To TG.Columns.Count - 1
        '    DGVMgr(i) = New DgvComboBoxColumnFilter
        'Next

    End Sub

    'Private Sub cmbCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCat.SelectedIndexChanged

    '    If cmbCat.SelectedIndex = -1 Then Exit Sub

    '    SQL = "select scatid,scatdesc from subcategory1 "
    '    If cmbCat.SelectedIndex > 0 Then
    '        SQL &= " where pvscatid=" & cmbCat.SelectedValue
    '    End If
    '    SQL &= "order by scatdesc"

    '    ESSA.LoadCombo(cmbSCat1, SQL, "scatdesc", "scatid", "All Cateogry(s)")

    'End Sub

    'Private Sub cmbSCat1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSCat1.SelectedIndexChanged

    '    If cmbSCat1.SelectedIndex = -1 Then Exit Sub

    '    SQL = "select scatid,scatdesc from subcategory1 "
    '    If cmbSCat1.SelectedIndex > 0 Then
    '        SQL &= " where pvscatid=" & cmbSCat1.SelectedValue
    '    End If
    '    SQL &= "order by scatdesc"

    '    ESSA.LoadCombo(cmbSCat2, SQL, "scatdesc", "scatid", "All Cateogry(s)")

    'End Sub

    'Private Sub cmbSCat2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSCat2.SelectedIndexChanged

    '    If cmbSCat2.SelectedIndex = -1 Then Exit Sub

    '    SQL = "select scatid,scatdesc from subcategory1 "
    '    If cmbSCat2.SelectedIndex > 0 Then
    '        SQL &= " where pvscatid=" & cmbSCat2.SelectedValue
    '    End If
    '    SQL &= "order by scatdesc"

    '    ESSA.LoadCombo(cmbSCat3, SQL, "scatdesc", "scatid", "All Cateogry(s)")

    'End Sub

    'Private Sub cmbSCat3_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSCat3.SelectedIndexChanged

    '    If cmbSCat3.SelectedIndex = -1 Then Exit Sub

    '    SQL = "select scatid,scatdesc from subcategory1 "
    '    If cmbSCat3.SelectedIndex > 0 Then
    '        SQL &= " where pvscatid=" & cmbSCat3.SelectedValue
    '    End If
    '    SQL &= "order by scatdesc"

    '    ESSA.LoadCombo(cmbSCat4, SQL, "scatdesc", "scatid", "All Cateogry(s)")

    'End Sub

    'Private Sub cmbSCat4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSCat4.SelectedIndexChanged

    '    If cmbSCat4.SelectedIndex = -1 Then Exit Sub

    '    SQL = "select scatid,scatdesc from subcategory1 "
    '    If cmbSCat4.SelectedIndex > 0 Then
    '        SQL &= " where pvscatid=" & cmbSCat4.SelectedValue
    '    End If
    '    SQL &= "order by scatdesc"

    '    ESSA.LoadCombo(cmbSCat5, SQL, "scatdesc", "scatid", "All Cateogry(s)")

    'End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlSearchOpn.Visible = False

    End Sub

    Private Sub btnAdvanceSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvanceSearch.Click

        pnlSearchOpn.Visible = True
        cmbCat.Focus()

    End Sub

    Private Sub btnShow_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShow.Click

        LoadData(DisplayType.Filter)
        pnlSearchOpn.Visible = False
        txtCode.Focus()

    End Sub

    Private Sub txtCode_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyUp

        If chkSBK.Checked = True Then
            LoadData(DisplayType.NoFilter, True)
        Else
            ESSA.FindAndSelect(TG, If(lblCode.Text = "CODE", 0, 1), txtCode.Text)
        End If

    End Sub

    Private Sub btnShowAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowAll.Click

        LoadData(DisplayType.NoFilter)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub


    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub
End Class