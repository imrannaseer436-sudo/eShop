Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Imports System.Threading.Tasks
Imports Syncfusion.Windows.Forms.Tools
Imports OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup

Public Class FrmStockAuditNew

    Dim barcodesList As New List(Of String)
    Dim excelFilePath As String = ""
    Dim unknownList As New List(Of String)
    Dim otherProductList As New List(Of String)
    Dim stockQty = 0
    Dim stockCP As Double = 0
    Dim isFiltered As Boolean = False
    Private Async Sub FrmStockAuditNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SQL = "SELECT DeptId,Department FROM TSDepartment ORDER BY Department"
        Await ESSA.LoadComboAsync(CmbDept, SQL, "Department", "DeptId", "All Departments")

        SQL = "SELECT CatId,Category FROM TSCategory ORDER BY Category"
        Await ESSA.LoadComboAsync(CmbCat, SQL, "Category", "CatId", "All Categories")

        SQL = "SELECT DeptId,'''' + Department + '''' [Department] FROM TSDepartment ORDER BY Department"
        Await LoadMultiSelectComboBox(CmbDept2, SQL, "Department", "DeptId")

        SQL = "SELECT CatId, '''' + Category + '''' [Category] FROM TSCategory ORDER BY Category"
        Await LoadMultiSelectComboBox(CmbCat2, SQL, "Category", "CatId")

        SQL = $"SELECT P.Plucode
                FROM ProductMaster P"

        'SQL = $"SELECT P.Plucode
        '        FROM ProductMaster P
        '        INNER JOIN V_StockPos S ON P.Pluid = S.Pluid AND S.Location_Id = {ShopID}
        '        INNER JOIN ProductAttributes A ON A.PluId = P.PluId"

        barcodesList.Clear()
        With Await ESSA.OpenReaderAsync(SQL)
            While Await .ReadAsync
                barcodesList.Add(.Item(0).ToString.Trim)
            End While
        End With

    End Sub

    Private Async Sub BtnDisplay_Click(sender As Object, e As EventArgs) Handles BtnDisplay.Click

        stockQty = 0
        stockCP = 0
        LblStock.Text = "0"
        LblStockCP.Text = "0.00"
        PBLoading.Minimum = 0
        PBLoading.Maximum = 100
        Dim totalRows = 0
        Dim processedRows = 0

        PBLoading.Visible = True

        SQL = $"SELECT Count(P.Pluid)
                FROM ProductMaster P
                INNER JOIN V_StockPos S ON P.Pluid = S.Pluid AND S.Location_Id = {ShopID}
                INNER JOIN ProductAttributes A ON A.PluId = P.PluId"

        If CmbDept2.Text <> String.Empty Then
            SQL &= $" AND A.Department IN ({CmbDept2.Text.Trim.Substring(0, CmbDept2.Text.Trim.Length - 1)})"
        End If

        If CmbCat2.Text > String.Empty Then
            SQL &= $" AND A.Category IN ({CmbCat2.Text.Trim.Substring(0, CmbCat2.Text.Trim.Length - 1)})"
        End If

        'If CmbDept.SelectedIndex > 0 Then
        '    SQL &= $" AND A.Department = '{CmbDept.Text}'"
        'End If

        'If CmbCat.SelectedIndex > 0 Then
        '    SQL &= $" AND A.Category = '{CmbCat.Text}'"
        'End If

        With Await ESSA.OpenReaderAsync(SQL)

            If Await .ReadAsync Then

                totalRows = .Item(0)

            End If

        End With

        SQL = $"SELECT Distinct P.PluId,P.Plucode,A.Department + '->' + A.Category,P.Pluname, P.Id,
            M.CostPrice, S.Stock
            FROM ProductMaster P
            INNER JOIN V_StockPos S ON P.Pluid = S.Pluid AND S.Location_Id = {ShopID}            
            INNER JOIN PriceMaster M ON M.PluId = S.PluId AND M.ShopId = {ShopID} 
            INNER JOIN ProductAttributes A ON A.PluId = P.PluId"

        If CmbDept2.Text <> String.Empty Then
            SQL &= $" AND A.Department IN ({CmbDept2.Text.Trim.Substring(0, CmbDept2.Text.Trim.Length - 1)})"
        End If

        If CmbCat2.Text > String.Empty Then
            SQL &= $" AND A.Category IN ({CmbCat2.Text.Trim.Substring(0, CmbCat2.Text.Trim.Length - 1)})"
        End If

        'If CmbDept.SelectedIndex > 0 Then
        '    SQL &= $" AND A.Department = '{CmbDept.Text}'"
        'End If

        'If CmbCat.SelectedIndex > 0 Then
        '    SQL &= $" AND A.Category = '{CmbCat.Text}'"
        'End If

        With Await ESSA.OpenReaderAsync(SQL)

            TG.DataSource = Nothing
            TG.Rows.Clear()

            While Await .ReadAsync

                processedRows += 1
                Dim progressPercentage As Integer = CInt(Math.Max(0, Math.Min((processedRows / totalRows) * 100, 100)))
                UpdateProgressBar(progressPercentage)
                Dim row = TG.Rows.Add
                TG.Item(0, row).Value = .Item(0)
                TG.Item(1, row).Value = .Item(1)
                TG.Item(2, row).Value = .Item(2).ToString.Trim
                TG.Item(3, row).Value = .Item(3).ToString.Trim
                TG.Item(4, row).Value = .Item(4)
                TG.Item(5, row).Value = .Item(5)
                TG.Item(6, row).Value = .Item(6)
                stockQty += .Item(6)
                TG.Item(9, row).Value = Val(TG.Item(5, row).Value) * Val(TG.Item(6, row).Value)
                stockCP += Val(TG.Item(9, row).Value)
                LblStock.Text = Format(stockQty, "0")
                LblStockCP.Text = Format(stockCP, "0.00")

            End While

            PBLoading.Value = PBLoading.Maximum
            PBLoading.Visible = False
            .Close()
        End With

    End Sub

    Private Sub UpdateProgressBar(perc As Integer)

        PBLoading.Value = perc

    End Sub

    Private Async Sub BtnUpload_Click(sender As Object, e As EventArgs) Handles BtnUpload.Click

        If TG.Rows.Count = 0 Then Exit Sub
        If OFD.ShowDialog() <> DialogResult.OK Then Exit Sub
        excelFilePath = OFD.FileName.Trim
        If excelFilePath = String.Empty Then Exit Sub
        Try
            Await UploadDataFromExcel()
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        Dim missedBarcodes As String = ""

        For Each barcode As String In unknownList
            missedBarcodes &= barcode & vbCrLf
        Next

        If missedBarcodes.Trim = String.Empty Then
            MsgBox("File uploaded..!", MsgBoxStyle.Information)
        Else
            'MsgBox("File uploaded with some changes, Fix these Barcodes :" & vbCrLf & missedBarcodes, MsgBoxStyle.Information)
            MessageBox.Show("File uploaded with some changes, Fix these Barcodes :" & vbCrLf & missedBarcodes, "eShop", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Clipboard.Clear()
            Clipboard.SetText(missedBarcodes)
        End If

        Await Verify()
        BtnSave.Enabled = True

    End Sub

    Private Async Function UploadDataFromExcel() As Task

        PBLoading.Minimum = 0
        PBLoading.Maximum = 100
        PBLoading.Value = 0
        PBLoading.Visible = True

        Dim excelApp As New Application()
        Dim workbook As Workbook = excelApp.Workbooks.Open(excelFilePath)
        Dim worksheet As Worksheet = workbook.Sheets(1)

        ' Get the total number of rows in the worksheet
        Dim totalRows As Integer = worksheet.UsedRange.Rows.Count

        Dim conn As New SqlConnection(ConStr)
        Await conn.OpenAsync()

        Dim transaction As SqlTransaction = Nothing
        Dim cmd As New SqlCommand()
        cmd.Connection = conn

        Try
            transaction = conn.BeginTransaction()
            cmd.Transaction = transaction

            Dim row As Integer = 1
            unknownList.Clear()
            cmd.CommandText = $"DELETE FROM Stock_Excel WHERE Location_id = {ShopID}"
            Await cmd.ExecuteNonQueryAsync()

            Do While Not String.IsNullOrEmpty(worksheet.Cells(row, 1).Value)
                'Dim progressPercentage As Integer = CInt((row / TG.Rows.Count) * 100)
                Dim progressPercentage As Integer = CInt(Math.Max(0, Math.Min((row / totalRows) * 100, 100)))

                UpdateProgressBar(progressPercentage)

                Dim col1Value As String = worksheet.Cells(row, 1).Value
                Dim col2Value As String = IIf(String.IsNullOrEmpty(worksheet.Cells(row, 2).Value), 1, worksheet.Cells(row, 2).value)

                If Not barcodesList.Contains(col1Value) Then
                    unknownList.Add(col1Value)
                Else
                    ' Insert the data into SQL Server table
                    Dim SQL As String = $"INSERT INTO Stock_Excel VALUES ('{col1Value}', {col2Value}, {ShopID})"
                    cmd.CommandText = SQL
                    Await cmd.ExecuteNonQueryAsync()
                End If

                row += 1
            Loop

            transaction.Commit()
            PBLoading.Value = PBLoading.Maximum
            PBLoading.Visible = False

        Catch ex As Exception
            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If

            ' Handle the exception or display an error message
            MessageBox.Show("An error occurred during data upload: " & ex.Message)

        Finally
            If transaction IsNot Nothing Then
                transaction.Dispose()
            End If

            conn.Close()

            ' Clean up Excel objects
            workbook.Close()
            excelApp.Quit()
            System.Runtime.InteropServices.Marshal.ReleaseComObject(worksheet)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)
        End Try

    End Function

    Private Async Function Verify() As Task

        If TG.Rows.Count = 0 Then Exit Function
        PBLoading.Minimum = 0
        PBLoading.Maximum = 100
        PBLoading.Value = 0
        PBLoading.Visible = True
        Dim progressRows = 0
        otherProductList.Clear()


        SQL = $"SELECT barcode, SUM(qty) Qty
            FROM Stock_Excel 
            WHERE location_id = {ShopID}
            GROUP BY barcode"

        With Await ESSA.OpenReaderAsync(SQL)

            While Await .ReadAsync

                Dim progressPercentage As Integer = CInt(Math.Max(0, Math.Min((progressRows / TG.Rows.Count) * 100, 100)))
                UpdateProgressBar(progressPercentage)

                Dim NRI = ESSA.FindGridIndex(TG, 1, .Item(0))
                If NRI = -1 Then
                    otherProductList.Add(.Item(0))
                Else
                    TG.Item(7, NRI).Value = .Item(1)
                End If
                progressRows += 1

            End While

            .Close()

            For Each barcode As String In otherProductList

                'Using product master

                SQL = $"SELECT Distinct P.PluId,P.Plucode,A.Department + '->' + A.Category,P.Pluname, P.Id,
                P.CostPrice, 0 Stock,SUM(E.Qty)
                FROM ProductMaster P                
                INNER JOIN ProductAttributes A ON A.PluId = P.PluId AND P.Plucode = '{barcode}'
                INNER JOIN Stock_Excel E ON E.Barcode = P.Plucode AND E.Location_Id = {ShopID}
                GROUP BY P.Pluid,P.Plucode,A.Department,A.Category,P.Pluname,P.Id,P.CostPrice"

                'Using PriceMaster

                'SQL = $"SELECT Distinct P.PluId,P.Plucode,A.Department + '->' + A.Category,P.Pluname, P.Id,
                'M.CostPrice, S.Stock,SUM(E.Qty)
                'FROM ProductMaster P
                'INNER JOIN V_StockPos S ON P.Pluid = S.Pluid AND S.Location_Id = {ShopID} AND P.Plucode = '{barcode}'           
                'INNER JOIN PriceMaster M ON M.PluId = S.PluId AND M.ShopId = {ShopID} 
                'INNER JOIN ProductAttributes A ON A.PluId = P.PluId 
                'INNER JOIN Stock_Excel E ON E.Barcode = P.Plucode AND E.Location_Id = {ShopID}
                'GROUP BY P.Pluid,P.Plucode,A.Department,A.Category,P.Pluname,P.Id,M.CostPrice,S.Stock"

                With Await ESSA.OpenReaderAsync(SQL)
                    While Await .ReadAsync
                        Dim row = TG.Rows.Add()
                        TG.Item(0, row).Value = .Item(0)
                        TG.Item(1, row).Value = .Item(1)
                        TG.Item(2, row).Value = .Item(2).ToString.Trim
                        TG.Item(3, row).Value = .Item(3).ToString.Trim
                        TG.Item(4, row).Value = .Item(4)
                        TG.Item(5, row).Value = .Item(5)
                        TG.Item(6, row).Value = .Item(6)
                        TG.Item(7, row).Value = .Item(7)
                        stockQty += .Item(6)
                        TG.Item(9, row).Value = Val(TG.Item(5, row).Value) * Val(TG.Item(6, row).Value)
                        stockCP += Val(TG.Item(9, row).Value)
                        LblStock.Text = Format(stockQty, "0")
                        LblStockCP.Text = Format(stockCP, "0.00")
                        TG.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(85, 145, 213)
                    End While
                    .Close()
                End With

            Next

            For Each barcode As String In unknownList
                Dim row = TG.Rows.Add
                TG.Item(0, row).Value = 0
                TG.Item(1, row).Value = barcode
                TG.Rows(row).DefaultCellStyle.BackColor = Color.FromArgb(85, 145, 213)
            Next

            UpdateGrid()
            PBLoading.Value = PBLoading.Maximum
            PBLoading.Visible = False

        End With

    End Function

    Private Sub UpdateGrid()

        Dim uploadQty = 0
        Dim uploadCP As Double = 0

        For i As Integer = 0 To TG.Rows.Count - 1

            If Val(TG.Item(7, i).Value) = 0 Then
                TG.Item(7, i).Value = 0
            End If
            uploadQty += TG.Item(7, i).Value
            TG.Item(8, i).Value = Val(TG.Item(7, i).Value) - Val(TG.Item(6, i).Value)
            If Val(TG.Item(8, i).Value) <> 0 Then
                TG.Item(8, i).Style.ForeColor = Color.Crimson
            End If

            TG.Item(10, i).Value = Val(TG.Item(5, i).Value) * Val(TG.Item(7, i).Value)
            uploadCP += Val(TG.Item(10, i).Value)

        Next

        Dim variation = uploadQty - Val(LblStock.Text)
        LblStock.Text = Format(stockQty, "0")
        LblStockCP.Text = Format(stockCP, "0.00")
        LblUpload.Text = Format(uploadQty, "0")
        LblVariation.Text = Format(variation, "0")
        LblUploadCP.Text = Format(uploadCP, "0.00")
        LblVariationCP.Text = Format(uploadCP - Val(LblStockCP.Text), "0.00")

    End Sub

    Private Async Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click

        If (MsgBox("Are you sure to update stock ..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No) Then Exit Sub

        If TG.Rows.Count = 0 Then Exit Sub
        Await UpdateStock()
        CmbDept.SelectedIndex = 0
        CmbCat.SelectedIndex = 0
        TxtRemarks.Clear()
        TG.Rows.Clear()
        LblStock.Text = "0"
        LblUpload.Text = "0"
        LblVariation.Text = "0"
        LblStockCP.Text = "0.00"
        LblUploadCP.Text = "0.00"
        LblVariationCP.Text = "0.00"
        BtnSave.Enabled = False
        stockQty = 0
        stockCP = 0
        unknownList.Clear()
        otherProductList.Clear()

    End Sub

    Private Async Function UpdateStock() As Task

        Dim EntryNo = Await GetEntryNo()
        PBLoading.Minimum = 0
        PBLoading.Maximum = 100
        PBLoading.Value = 0
        PBLoading.Visible = True
        Dim progressRows = 0

        Dim conn As New SqlConnection(ConStr)
        Await conn.OpenAsync()

        Dim transaction As SqlTransaction = Nothing
        Dim cmd As New SqlCommand()
        cmd.Connection = conn

        Try

            transaction = conn.BeginTransaction()
            cmd.Transaction = transaction

            SQL = $"INSERT INTO 
            StockAuditMaster 
            VALUES (
            {EntryNo},
            '{Format(Date.Now, "yyyy-MM-dd")}',
            '{CmbDept.Text}',
            '{CmbCat.Text}',
            '{TxtRemarks.Text.Trim}',
            {Val(LblStock.Text)},
            {Val(LblUpload.Text)},
            {Val(LblVariation.Text)},
            {ShopID},
            {UserID},1)"

            cmd.CommandText = SQL
            Await cmd.ExecuteNonQueryAsync()

            For i As Integer = 0 To TG.Rows.Count - 1

                Dim progressPercentage As Integer = CInt(Math.Max(0, Math.Min((progressRows / TG.Rows.Count) * 100, 100)))
                UpdateProgressBar(progressPercentage)

                If Val(TG.Item(8, i).Value) <> 0 And Val(TG.Item(0, i).Value) <> 0 Then

                    SQL = $"INSERT INTO 
                    StockAuditDetails VALUES (
                    {EntryNo},
                    {Val(TG.Item(0, i).Value)},
                    {Val(TG.Item(5, i).Value)},
                    {Val(TG.Item(6, i).Value)},
                    {Val(TG.Item(7, i).Value)},
                    {Val(TG.Item(8, i).Value)},
                    {i + 1})"

                    cmd.CommandText = SQL
                    Await cmd.ExecuteNonQueryAsync()

                End If

                progressRows += 1

            Next

            transaction.Commit()
            MsgBox("Stock Updated..!", MsgBoxStyle.Information)
            PBLoading.Value = 100
            PBLoading.Visible = False

        Catch ex As Exception

            If transaction IsNot Nothing Then
                transaction.Rollback()
            End If
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            conn.Close()

        Finally

            If transaction IsNot Nothing Then
                transaction.Dispose()
            End If

            cmd.Dispose()
            conn.Close()

        End Try


    End Function

    Private Async Function GetEntryNo() As Task(Of Integer)

        Dim EntryNo As Integer = 0
        SQL = "SELECT ISNULL(Max(Id),0) FROM StockAuditMaster"
        With Await ESSA.OpenReaderAsync(SQL)
            If Await .ReadAsync Then
                EntryNo = .Item(0)
            End If
        End With

        Return EntryNo + 1

    End Function

    Private Sub BtnClose_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmStockAuditNew_Resize(sender As Object, e As EventArgs) Handles Me.Resize


        ESSA.AlignCenter(TitlePanel2, TitlePanel)


    End Sub

    Private Sub FrmStockAuditNew_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            Me.ProcessTabKey(True)
        End If

    End Sub

    Private Sub IconPictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBoxClose.Click
        If MessageBox.Show("Do you want to close ?", "eShop", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Close()
        End If
    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.ColumnIndex = 11 Then
            stockQty -= TG.Item(6, e.RowIndex).Value
            stockCP -= TG.Item(9, e.RowIndex).Value
            TG.Rows.RemoveAt(e.RowIndex)
            UpdateGrid()
        End If

    End Sub

    Private Sub TG_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellEndEdit

        UpdateGrid()

    End Sub

    Private Sub ApplyFilter(isFiltered As Boolean)
        Dim filterColumnIndex As Integer = 8 ' The column index you want to filter (zero-based index)
        For Each row As DataGridViewRow In TG.Rows
            If isFiltered Then
                Dim cell As DataGridViewCell = row.Cells(filterColumnIndex)
                If Not Val(cell.Value).Equals(0) Then
                    row.Visible = True ' Show the row
                Else
                    row.Visible = False ' Hide the row
                End If
            Else
                row.Visible = True
            End If
        Next
    End Sub

    Private Sub TG_KeyDown(sender As Object, e As KeyEventArgs) Handles TG.KeyDown

        If e.Control AndAlso e.KeyCode = Keys.F Then
            isFiltered = Not isFiltered
            ApplyFilter(isFiltered)
        End If

    End Sub

    Private Async Function LoadMultiSelectComboBox(ByVal Cmb As MultiSelectionComboBox, ByVal Qry As String, ByVal Name As String, Optional ByVal ID As String = "", Optional ByVal Header As String = "") As Task

        Using nCon As New SqlConnection(ConStr)
            nCon.Open()
            Using Adp As New SqlDataAdapter(Qry, nCon)
                Using Tbl As New DataSet
                    Await Task.Run(Sub() Adp.Fill(Tbl))

                    If Header <> "" Then
                        Dim Tr As DataRow
                        Tr = Tbl.Tables(0).NewRow
                        Tr(Name) = Header
                        Tbl.Tables(0).Rows.InsertAt(Tr, 0)
                    End If

                    Cmb.DataSource = Tbl.Tables(0)
                    Cmb.DisplayMember = Name
                    Cmb.ValueMember = ID
                End Using
            End Using
            nCon.Close()
        End Using

    End Function

End Class