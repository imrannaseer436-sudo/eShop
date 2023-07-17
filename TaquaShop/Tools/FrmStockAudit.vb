Imports System.Threading.Tasks

Public Class FrmStockAudit
    Private Async Sub FrmStockAudit_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT DeptId,Department FROM TSDepartment ORDER BY Department"
        Await ESSA.LoadComboAsync(CmbDept, SQL, "Department", "DeptId", "All Departments")

        SQL = "SELECT CatId,Category FROM TSCategory ORDER BY Category"
        Await ESSA.LoadComboAsync(CmbCat, SQL, "Category", "CatId", "All Categories")

    End Sub

    Private Async Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click

        PBLoading.Minimum = 0
        PBLoading.Maximum = 300

        SQL = $"SELECT P.PluId,P.Plucode,A.Department + '->' + A.Category,P.Pluname, P.Id,
            P.CostPrice, S.Stock
            FROM ProductMaster P
            INNER JOIN V_StockPos S ON P.Pluid = S.Pluid AND S.Location_Id = {ShopID}
            INNER JOIN ProductAttributes A ON A.PluId = P.PluId"

        If CmbDept.SelectedIndex > 0 Then
            SQL &= $" AND A.Department = '{CmbDept.Text}'"
        End If

        If CmbCat.SelectedIndex > 0 Then
            SQL &= $" AND A.Category = '{CmbCat.Text}'"
        End If

        With Await ESSA.OpenReaderAsync(SQL)

            TG.DataSource = Nothing
            TG.Rows.Clear()

            While Await .ReadAsync

                Dim row = TG.Rows.Add
                TG.Item(0, row).Value = .Item(0)
                TG.Item(1, row).Value = .Item(1)
                TG.Item(2, row).Value = .Item(2).ToString.Trim
                TG.Item(3, row).Value = .Item(3).ToString.Trim
                TG.Item(4, row).Value = .Item(4)
                TG.Item(5, row).Value = .Item(5)
                TG.Item(6, row).Value = .Item(6)

            End While

        End With

    End Sub
End Class