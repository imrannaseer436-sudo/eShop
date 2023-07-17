Public Class SalesReportCatWise

    Private Sub CmbFloor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbFloor.SelectedIndexChanged

        Dim Floor As String = ""
        If CmbFloor.SelectedIndex = 0 Then
            Floor = "U"
        ElseIf CmbFloor.SelectedIndex = 1 Then
            Floor = "0"
        ElseIf CmbFloor.SelectedIndex = 2 Then
            Floor = "1"
        ElseIf CmbFloor.SelectedIndex = 3 Then
            Floor = "2"
        ElseIf CmbFloor.SelectedIndex = 4 Then
            Floor = "3"
        End If
        Try
            ESSA.LoadCombo(CmbSP, "SELECT SPID, Name FROM SalesPersons WHERE Floor = '" & Floor & "' ORDER BY Name", "Name", "SPID")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub SalesReportCatWise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        mebFrom.Value = Format(DateTime.Now, "01-MM-yyyy")
        Try
            ESSA.LoadCombo(CmbDept, "SELECT DeptId,Department FROM TSDepartment ORDER BY Department", "Department", "DeptId")
            ESSA.LoadCombo(CmbCat, "SELECT CatId,Category FROM TSCategory ORDER BY Category", "Category", "CatId")
            ESSA.LoadCombo(CmbMat, "SELECT MaterialId,Material FROM TSMaterial ORDER BY Material", "Material", "MaterialId")
            ESSA.LoadCombo(CmbBrand, "SELECT BrandId,Brand FROM TSBrand ORDER BY Brand", "Brand", "BrandId")
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub BtnSPFilter_Click(sender As Object, e As EventArgs) Handles BtnSPFilter.Click

        If PnlCategory.Visible = True Then
            PnlCategory.Visible = False
        ElseIf PnlSP.Visible = True Then
            PnlSP.Visible = False
        ElseIf PnlSP.Visible = False Then
            PnlSP.Visible = True
            CmbFloor.SelectedIndex = 0
        End If

    End Sub

    Private Sub BtnCatFilter_Click(sender As Object, e As EventArgs) Handles BtnCatFilter.Click

        If PnlCategory.Visible = True Then
            PnlCategory.Visible = False
        ElseIf PnlSP.Visible = True Then
            PnlSP.Visible = False
        ElseIf PnlCategory.Visible = False Then
            PnlCategory.Visible = True
            CmbDept.SelectedValue = 1
            CmbCat.SelectedValue = 1
            CmbMat.SelectedValue = 1
            CmbBrand.SelectedValue = 1
        End If

    End Sub

    Private Sub BtnHide2_Click(sender As Object, e As EventArgs) Handles BtnHide2.Click

        PnlSP.Visible = False

    End Sub

    Private Sub BtnHide_Click(sender As Object, e As EventArgs) Handles BtnHide.Click

        PnlCategory.Visible = False

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub BtnFilter2_Click(sender As Object, e As EventArgs) Handles BtnFilter2.Click

        If CmbSP.FindStringExact(CmbSP.Text.Trim) = -1 Then
            MsgBox(CmbSP.Text.Trim + " is not a valid option..!", MsgBoxStyle.Exclamation)
            CmbSP.Focus()
            Exit Sub
        End If

        SQL = "SELECT A.Category,CONVERT(DECIMAL(10,2),SUM(A.Qty)) Qty,CONVERT(DECIMAL(10,2),SUM(A.Amount)) Amount " _
        & "FROM " _
        & "(SELECT BD.BillId,BD.PLuId,PA.Category,SUM(BD.Qty) Qty,SUM(BD.Amount) Amount " _
        & "FROM BillDetails BD " _
        & "INNER JOIN ProductAttributes PA ON PA.PluId = BD.PluID AND BD.ShopId = " & ShopID & " BD.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' " _
        & "GROUP BY BD.BillId,BD.PluId,PA.Category) A " _
        & "LEFT JOIN " _
        & "(SELECT BSP.BillId,BSP.PluId,SP.Name FROM BillSalePersons BSP " _
        & "INNER JOIN SalesPersons SP ON SP.SPID = BSP.SPID)B ON A.BillId = B.BillId AND A.PluId = B.PluId " _
        & "WHERE B.Name ='" & CmbSP.Text.Trim & "' GROUP BY A.Category"

        Try
            ESSA.LoadDataGrid(TG, SQL)
            ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleRight)
            ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleRight)
            TG.Columns(0).Width = 200
            CalculateSummary(1, LblQty)
            CalculateSummary(2, LblAmt)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub CalculateSummary(colIndex As Short, lbl As Label)

        Dim total As Double = 0
        For i As Integer = 0 To TG.Rows.Count - 1

            total += Val(TG.Item(colIndex, i).Value)

        Next

        lbl.Text = Format(total, "0.00")

    End Sub

    Private Sub BtnFilter_Click(sender As Object, e As EventArgs) Handles BtnFilter.Click

        If CmbDept.FindStringExact(CmbDept.Text.Trim) = -1 Then
            MsgBox(CmbDept.Text.Trim + " is not a valid option..!", MsgBoxStyle.Exclamation)
            CmbDept.Focus()
            Exit Sub
        ElseIf CmbCat.FindStringExact(CmbCat.Text.Trim) = -1 Then
            MsgBox(CmbCat.Text.Trim + " is not a valid option..!", MsgBoxStyle.Exclamation)
            CmbCat.Focus()
            Exit Sub
        ElseIf CmbMat.FindStringExact(CmbMat.Text.Trim) = -1 Then
            MsgBox(CmbMat.Text.Trim + " is not a valid option..!", MsgBoxStyle.Exclamation)
            CmbMat.Focus()
            Exit Sub
        ElseIf CmbBrand.FindStringExact(CmbBrand.Text.Trim) = -1 Then
            MsgBox(CmbBrand.Text.Trim + " is not a valid option..!", MsgBoxStyle.Exclamation)
            CmbBrand.Focus()
            Exit Sub
        ElseIf CmbCat.SelectedValue = 1 Then
            MsgBox("Category must be selected..!", MsgBoxStyle.Exclamation)
            CmbCat.Focus()
            Exit Sub
        End If

        SQL = "SELECT B.Name,SUM(A.Qty) Qty,SUM(A.Amount) Amount " _
        & "FROM " _
        & "(SELECT BD.BillId, BD.PLuId, PA.Department, PA.Category, PA.Material, PA.Brand, SUM(BD.Qty) Qty, SUM(BD.Amount) Amount  " _
        & "FROM BillDetails BD " _
        & "INNER JOIN ProductAttributes PA ON PA.PluId = BD.PluID And BD.ShopId = " & ShopID & " AND BD.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' "

        If CmbCat.SelectedValue > 1 Then
            SQL &= " AND PA.Category ='" & CmbCat.Text.Trim & "' "
        ElseIf CmbDept.SelectedValue > 1 Then
            SQL &= " AND PA.Department = '" & CmbDept.Text.Trim & ""
        ElseIf CmbMat.SelectedValue > 1 Then
            SQL &= " AND PA.Material = '" & CmbMat.Text.Trim & ""
        ElseIf CmbBrand.SelectedValue > 1 Then
            SQL &= " AND PA.Brand = '" & CmbBrand.Text.Trim & ""
        End If

        SQL &= "GROUP BY BD.BillId,BD.PluId,PA.Department, PA.Category, PA.Material, PA.Brand) A " _
        & "LEFT JOIN " _
        & "(SELECT BSP.BillId,BSP.PluId,SP.Name FROM BillSalePersons BSP  " _
        & "INNER JOIN SalesPersons SP ON SP.SPID = BSP.SPID)B ON A.BillId = B.BillId And A.PluId = B.PluId " _
        & "GROUP BY B.Name ORDER BY B.Name"

        Try
            ESSA.LoadDataGrid(TG, SQL)
            ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleRight)
            ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleRight)
            CalculateSummary(1, LblQty)
            CalculateSummary(2, LblAmt)
            TG.Columns(0).Width = 200
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

End Class