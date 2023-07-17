Imports System.Data.SqlClient

Public Class CodeReaderView

    Private EntryNo As Integer = 0

    Private Sub CodeReaderView_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.AlignCenter(pnlList, Me)
        ESSA.AlignCenter(pnlLoad, Me)

    End Sub

    Private Sub btnAlter_Click(sender As Object, e As EventArgs) Handles btnAlter.Click

        SQL = "SELECT M.*, U.UserName FROM CRMaster M, Users U " _
            & "WHERE M.UserID = U.UserID ORDER BY M.ENo"

        TG.Rows.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(4, TG.Rows.Count - 1).Value = .GetString(6).Trim
                TG.Item(5, TG.Rows.Count - 1).Value = If(.Item(5), "Completed", "Pending")
            End While
            .Close()
        End With

        pnlList.Show()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        pnlList.Hide()

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 6 Then

            SQL = "SELECT Z.PluId, Z.Plucode, D.Department, C.Category, S.Style, P.Pattern,
                    M.Material, O.Color, V.Sleeve, B.Brand, G.Catalog, 
                    CASE WHEN Z.IsStitched = 0 THEN 'Yes' ELSE 'No' END [IsStitched],
                    Z.IsStitched, Z.Sno, Z.NewCode, Z.Rate
                    FROM CRDetail Z, TSDepartment D, TSCategory C,
                    TSStyle S, TSPattern P, TSMaterial M, TSColor O, TSSleeve V, TSBrand B,
                    TSCatalog G
                    WHERE D.DeptId = Z.DeptId AND Z.CatId = C.CatId
                    AND Z.StyleId = S.StyleId AND Z.PatternId = P.PatternId
                    AND Z.MaterialId = M.MaterialId AND Z.ColorId = O.ColorId
                    AND Z.SleeveId = V.SleeveId AND Z.BrandId = B.BrandId
                    AND Z.CatalogId = G.CatalogId AND Z.ENo = {0} ORDER BY Z.Sno"

            EntryNo = Val(TG.Item(0, e.RowIndex).Value)
            SQL = String.Format(SQL, EntryNo)
            ESSA.LoadDataGrid(DataGrid, SQL)
            lblTotal.Text = "Total Items: " & DataGrid.Rows.Count
            pnlList.Hide()
            btnUpdateCategory.Enabled = IIf(TG.Item(5, e.RowIndex).Value = "Completed", False, True)

        ElseIf e.ColumnIndex = 7 Then

            If TG.Item(5, e.RowIndex).Value <> "Completed" Then
                MsgBox("Label printing only available for completed products.", MsgBoxStyle.Information)
                Exit Sub
            End If

            SQL = "Select m.pluid,m.plucode,m.pluname,1 qty,m.retailprice,m.id,d.plucode from productmaster m,CRDetail d where m.plucode=d.newcode " _
                & "And d.eno= " & Val(TG.Item(0, e.RowIndex).Value) & " order by d.sno"

            LablePrinting.LoadProducts(SQL)
            LablePrinting.Visible = False
            LablePrinting.Show(Me)

        End If

    End Sub

    Private Sub btnUpdateCategory_Click(sender As Object, e As EventArgs) Handles btnUpdateCategory.Click

        If MsgBox("Update category ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        pnlLoad.Show() : pnlLoad.Refresh()

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand


        Try

            For i As Integer = 0 To DataGrid.Rows.Count - 1
                Cmd.CommandText = "UpdateProduct"
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.Parameters.Clear()
                Cmd.Parameters.AddWithValue("@PluId", Val(DataGrid.Item(0, i).Value))
                Cmd.Parameters.AddWithValue("@UTax", Val(DataGrid.Item(12, i).Value))
                Cmd.Parameters.AddWithValue("@Sno", Val(DataGrid.Item(13, i).Value))
                Cmd.Parameters.AddWithValue("@ENo", EntryNo)
                Cmd.Parameters.AddWithValue("@Rate", Val(DataGrid.Item(15, i).Value))
                Cmd.ExecuteNonQuery()
            Next

            Cmd.CommandType = CommandType.Text
            SQL = "UPDATE CRMaster SET Status=1 WHERE ENo=" & EntryNo
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            'Trn.Commit()
            Con.Close()

            MsgBox("Updated", MsgBoxStyle.Information)
            btnUpdateCategory.Enabled = False

        Catch ex As SqlException
            'Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        pnlLoad.Hide()

    End Sub

    Private Sub TG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellContentClick

    End Sub

    Private Sub CodeReaderView_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class