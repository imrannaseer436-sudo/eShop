Imports System.Data.SqlClient
Imports System.Runtime.ConstrainedExecution
Imports System.Runtime.InteropServices.ComTypes
Imports System.Web.UI.WebControls.WebParts
Imports System.Windows.Media
Imports OfficeOpenXml.FormulaParsing.Excel.Functions.RefAndLookup
Imports Syncfusion.Windows.Forms.Tools.Win32API

Public Class frmSalesReportSPWise
    Dim IsEditMode As Boolean = False
    Dim CommId As Integer = 0

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click
        'IMRAN
        If chkCommission.Checked = True Then

            If CmbRptStyle.SelectedIndex = 0 Then

                'IMRAN
                SQL = $"SELECT ISNULL(D.[SALES PERSON],'NOT GIVEN') [SALES PERSON],SUM(D.Qty)[QUANTITY],SUM(D.Amount)[AMOUNT],FORMAT(SUM(D.[Commission Amount]),'0.00')[COMMISSION AMOUNT]
                        FROM
                        (Select A.[Term ID],A.[Bill No],A.[Bill Date],A.Code,A.Qty,A.Amount,B.SPCode,B.[Sales Person],B.Floor,A.[Commission %],A.[Commission Amount]                           
                        FROM (Select DISTINCT BD.BIllId,BD.PluID, BM.TermID [Term ID],BM.BillNo [Bill No],BM.BillDt [Bill Date],PM.Plucode [Code],
                        CONVERT(Decimal(10,2),BD.Qty) [Qty],CONVERT(Decimal(10,2),BD.Amount) Amount,
                        ISNULL(SPC.CommissionPerc, 0) As [Commission %],ROUND(BD.Rate * ISNULL(SPC.CommissionPerc, 0) * BD.Qty / 100, 2) As [Commission Amount] 
                        FROM BillMaster BM
                        JOIN BillDetails BD On BD.BillID = BM.BillID And BM.BillDt BETWEEN '{Format(mebFrom.Value, "yyyy-MM-dd")}' AND '{Format(mebTo.Value, "yyyy-MM-dd")}' 
                        AND BM.ShopId = {ShopID} AND BD.ShopId = {ShopID}
                        JOIN ProductMaster PM ON PM.PluID = BD.PluID
                        JOIN SalesPersonCommission SPC ON SPC.ShopId = BM.ShopID AND BD.Rate BETWEEN SPC.FromAmount AND SPC.ToAmount ) A 
                        LEFT JOIN 
                        (SELECT BSP.BillId,BSP.PluId,SP.SPCode ,ISNULL(SP.Name,'NOT GIVEN') [Sales Person], 
                        CASE SP.Floor When '0' THEN 'GROUND' WHEN '1' THEN 'FIRST' WHEN '2' THEN 'SECOND' WHEN '3' THEN 'THIRD' 
                        WHEN 'U' THEN 'UNSPECIFIED' END AS [Floor] FROM BillSalePersons BSP 
                        JOIN SalesPersons SP ON SP.SPCode = BSP.SPID AND BSP.ShopId = {ShopID} AND SP.ShopId = {ShopID}) B ON A.BillId = B.BillId AND A.PluId = B.PluId )D
                        GROUP BY D.[Sales Person]"

            ElseIf CmbRptStyle.SelectedIndex = 1 Then

                'IMRAN
                SQL = $"Select A.[TERM ID],A.[BILL NO],A.[BILL DATE],A.CODE,A.QTY,A.AMOUNT,B.SPCODE,B.[SALES PERSON],B.FLOOR,
                        A.[COMMISSION %],A.[COMMISSION AMOUNT] 
                        FROM (Select DISTINCT BD.BIllId,BD.PluID, BM.TermID [Term ID],BM.BillNo [Bill No],BM.BillDt [Bill Date],PM.Plucode [Code],Convert(Decimal(10, 2), BD.Qty) [Qty],
                        CONVERT(Decimal(10,2),BD.Amount) Amount,
                        ISNULL(SPC.CommissionPerc, 0) As [Commission %],FORMAT(ROUND(BD.Rate * ISNULL(SPC.CommissionPerc, 0) * BD.Qty / 100, 2),'0.00') As [Commission Amount] 
                        From BillMaster BM
                        JOIN BillDetails BD On BD.BillID = BM.BillID And BM.BillDt BETWEEN '{Format(mebFrom.Value, "yyyy-MM-dd")}' AND '{Format(mebTo.Value, "yyyy-MM-dd")}' 
                        And BM.ShopId = {ShopID} And BD.ShopId = {ShopID}
                        JOIN ProductMaster PM ON PM.PluID = BD.PluID
                        JOIN SalesPersonCommission SPC ON SPC.ShopId = BM.ShopID And BD.Rate BETWEEN SPC.FromAmount And SPC.ToAmount
                        ) A 
                        LEFT JOIN
                        (SELECT BSP.BillId,BSP.PluId,SP.SPCode ,ISNULL(SP.Name,'NOT GIVEN') [Sales Person], 
                        Case SP.Floor When '0' THEN 'GROUND' WHEN '1' THEN 'FIRST' WHEN '2' THEN 'SECOND' WHEN '3' THEN 'THIRD' 
                        WHEN 'U' THEN 'UNSPECIFIED' END AS [Floor] FROM BillSalePersons BSP 
                        JOIN SalesPersons SP ON SP.SPCode = BSP.SPID And BSP.ShopId = {ShopID} And SP.ShopId = {ShopID}) B ON A.BillId = B.BillId And A.PluId = B.PluId"

            ElseIf CmbRptStyle.SelectedIndex = 2 = Visible = False Then
                Exit Sub
            ElseIf CmbRptStyle.SelectedIndex = 3 = Visible = False Then
                Exit Sub
            End If

        Else

            If CmbRptStyle.SelectedIndex = 0 Then

                'SQL = "SELECT SP.Name [Sales Person],CONVERT(DECIMAL(10,2),SUM(D.Qty)) Quantity,CONVERT(DECIMAL(10,2),SUM(D.Amount)) Amount FROM SalesPersons SP " _
                '       & "INNER JOIN BillSalePersons BSP ON BSP.SPID = SP.SPID " _
                '       & "INNER JOIN BillDetails D ON D.BillID = BSP.BillId AND D.PluID = BSP.PluId " _
                '       & "AND D.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'" _
                '       & "GROUP BY SP.Name"

                SQL = "SELECT ISNULL(B.Name,'NOT GIVEN') [SALES PERSON], CONVERT(DECIMAL(10,2),SUM(A.Quantity)) QUANTITY,CONVERT(DECIMAL(10,2),SUM(A.Amount)) AMOUNT FROM " _
                    & "(SELECT BD.BillID, BD.PluId, SUM(BD.Qty) Quantity, SUM(BD.Amount) Amount " _
                    & "FROM BillDetails BD WHERE ShopId = " & ShopID & " AND BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' " _
                    & "GROUP BY BD.BillID,BD.PluId) A " _
                    & "LEFT JOIN " _
                    & "(SELECT BSP.BillId,BSP.PluId,SP.Name FROM SalesPersons SP " _
                    & "INNER JOIN BillSalePersons BSP ON BSP.SPID = SP.SPCode AND SP.ShopId = " & ShopID & " AND BSP.ShopId = " & ShopID & " " _
                    & ") B On A.BillId = B.BillId And A.PluID = B.PluId " _
                    & " GROUP BY B.Name"

            ElseIf CmbRptStyle.SelectedIndex = 1 Then

                SQL = "Select A.[TERM ID],A.[BILL NO],A.[BILL DATE],A.CODE,A.QTY,A.AMOUNT,B.SPCODE,B.[SALES PERSON],B.FLOOR FROM " _
                & "(Select DISTINCT BD.BIllId,BD.PluID, BM.TermID [Term ID],BM.BillNo [Bill No],BM.BillDt [Bill Date],PM.Plucode [Code],CONVERT(Decimal(10,2),BD.Qty) [Qty],CONVERT(Decimal(10,2),BD.Amount) Amount " _
                & "FROM BillMaster BM " _
                & "INNER JOIN BillDetails BD On BD.BillID = BM.BillID And BM.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' AND BM.ShopId = " & ShopID & " AND BD.ShopId = " & ShopID & " " _
                & "INNER JOIN ProductMaster PM ON PM.PluID = BD.PluID ) A " _
                & "LEFT JOIN " _
                & "(SELECT BSP.BillId,BSP.PluId,SP.SPCode ,ISNULL(SP.Name,'NOT GIVEN') [Sales Person], CASE SP.Floor When '0' THEN 'GROUND' WHEN '1' THEN 'FIRST' WHEN '2' THEN 'SECOND' WHEN '3' THEN 'THIRD' WHEN 'U' THEN 'UNSPECIFIED' END AS [Floor] FROM BillSalePersons BSP " _
                & "INNER JOIN SalesPersons SP ON SP.SPCode = BSP.SPID AND BSP.ShopId = " & ShopID & " AND SP.ShopId = " & ShopID & ") B ON A.BillId = B.BillId AND A.PluId = B.PluId"

            ElseIf CmbRptStyle.SelectedIndex = 2 Then

                If CmbUnknown.FindStringExact(CmbUnknown.Text.Trim) = -1 Then
                    MsgBox(CmbUnknown.Text.Trim + " is not available..!", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                SQL = "SELECT A.[TERM ID],A.[BILL NO],A.[BILL DATE],A.CODE,A.QTY,A.AMOUNT,B.SPCODE,B.[SALES PERSON],B.FLOOR FROM " _
            & "(SELECT DISTINCT BD.BIllId,BD.PluID, BM.TermID [Term ID],BM.BillNo [Bill No],BM.BillDt [Bill Date],PM.Plucode [Code],CONVERT(DECIMAL(10,2),BD.Qty) [Qty],CONVERT(DECIMAL(10,2),BD.Amount) Amount " _
            & "FROM BillMaster BM " _
            & "INNER JOIN BillDetails BD ON BD.BillID = BM.BillID AND BM.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' AND BM.ShopId = " & ShopID & " AND BD.ShopId = " & ShopID & " " _
            & "INNER JOIN ProductMaster PM ON PM.PluID = BD.PluID ) A " _
            & "LEFT JOIN " _
            & "(SELECT BSP.BillId,BSP.PluId,SP.SPCode ,ISNULL(SP.Name,'NOT GIVEN') [Sales Person], CASE SP.Floor When '0' THEN 'GROUND' WHEN '1' THEN 'FIRST' WHEN '2' THEN 'SECOND' WHEN '3' THEN 'THIRD' WHEN 'U' THEN 'UNSPECIFIED' END AS [Floor] FROM BillSalePersons BSP " _
            & "INNER JOIN SalesPersons SP ON SP.SPCode = BSP.SPID AND BSP.ShopId = " & ShopID & " AND SP.ShopId = " & ShopID & ") B ON A.BillId = B.BillId AND A.PluId = B.PluId WHERE B.Floor ='" & CmbUnknown.Text.Trim & "'"

            ElseIf CmbRptStyle.SelectedIndex = 3 Then

                If CmbUnknown.FindStringExact(CmbUnknown.Text.Trim) = -1 Then
                    MsgBox(CmbUnknown.Text.Trim + " is not available..!", MsgBoxStyle.Critical)
                    Exit Sub
                End If

                SQL = "SELECT A.[TERM ID],A.[BILL NO],A.[BILL DATE],A.CODE,A.QTY,A.AMOUNT,B.SPCODE,B.[SALES PERSON],B.FLOOR FROM " _
            & "(SELECT DISTINCT BD.BIllId,BD.PluID, BM.TermID [Term ID],BM.BillNo [Bill No],BM.BillDt [Bill Date],PM.Plucode [Code],CONVERT(DECIMAL(10,2),BD.Qty) [Qty],CONVERT(DECIMAL(10,2),BD.Amount) Amount " _
            & "FROM BillMaster BM " _
            & "INNER JOIN BillDetails BD ON BD.BillID = BM.BillID AND BM.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' AND BM.ShopId = " & ShopID & " AND BD.ShopId = " & ShopID & " " _
            & "INNER JOIN ProductMaster PM ON PM.PluID = BD.PluID ) A " _
            & "LEFT JOIN " _
            & "(SELECT BSP.BillId,BSP.PluId,SP.SPCode ,ISNULL(SP.Name,'NOT GIVEN') [Sales Person], CASE SP.Floor When '0' THEN 'GROUND' WHEN '1' THEN 'FIRST' WHEN '2' THEN 'SECOND' WHEN '3' THEN 'THIRD' WHEN 'U' THEN 'UNSPECIFIED' END AS [Floor] FROM BillSalePersons BSP " _
            & "INNER JOIN SalesPersons SP ON SP.SPCode = BSP.SPID AND BSP.ShopId = " & ShopID & " AND SP.ShopId = " & ShopID & ") B ON A.BillId = B.BillId AND A.PluId = B.PluId WHERE B.[Sales Person] ='" & CmbUnknown.Text.Trim & "'"

            End If

        End If
        TG.Columns.Clear()
        Try
            ESSA.LoadDataGrid(TG, SQL)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
        If CmbRptStyle.SelectedIndex = 0 Then
            TG.Columns(0).Width = 200
            ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleRight)
            ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleRight)
            If chkCommission.Checked = True Then
                ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight) 'IMRAN
                TG.Columns(3).Width = 150
            End If
            CalculateSummary(1, LblQty)
            CalculateSummary(2, LblAmt)
            'IMRAN
        ElseIf CmbRptStyle.SelectedIndex = 1 Then
            TG.Columns(0).Width = 80
            TG.Columns(1).Width = 80
            TG.Columns(4).Width = 80
            TG.Columns(6).Width = 80
            TG.Columns(7).Width = 200
            ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
            ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)
            ESSA.AlignHeader(TG, 6, DataGridViewContentAlignment.MiddleCenter)
            If chkCommission.Checked = True Then                                    'IMRAN
                ESSA.AlignHeader(TG, 9, DataGridViewContentAlignment.MiddleRight)
                ESSA.AlignHeader(TG, 10, DataGridViewContentAlignment.MiddleRight)
                TG.Columns(10).Width = 150
            End If                                                                  'IMRAN
            CalculateSummary(4, LblQty)
            CalculateSummary(5, LblAmt)
            'IMRAN
        ElseIf CmbRptStyle.SelectedIndex = 2 Or CmbRptStyle.SelectedIndex = 3 Then
            TG.Columns(0).Width = 80
            TG.Columns(1).Width = 80
            TG.Columns(4).Width = 80
            TG.Columns(6).Width = 80
            TG.Columns(7).Width = 200
            ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
            ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)
            ESSA.AlignHeader(TG, 6, DataGridViewContentAlignment.MiddleCenter)
            CalculateSummary(4, LblQty)
            CalculateSummary(5, LblAmt)
        End If

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub frmSalesReportSPWise_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pnlCommission.Visible = False
        mebFrom.Value = Format(DateTime.Now, "01-MM-yyyy")
        CmbRptStyle.SelectedIndex = 0

    End Sub

    Private Sub CalculateSummary(colIndex As Short, lbl As Label)

        Dim total As Double = 0
        For i As Integer = 0 To TG.Rows.Count - 1

            total += Val(TG.Item(colIndex, i).Value)

        Next

        lbl.Text = Format(total, "0.00")

    End Sub

    Private Sub CmbRptStyle_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbRptStyle.SelectedIndexChanged

        If CmbRptStyle.SelectedIndex = 2 Then
            LblUnknown.Text = "Floors"
            CmbUnknown.DataSource = Nothing
            CmbUnknown.Items.Clear()
            CmbUnknown.Items.Add("Ground")
            CmbUnknown.Items.Add("First")
            CmbUnknown.Items.Add("Second")
            CmbUnknown.Items.Add("Third")
            CmbUnknown.Items.Add("Unspecified")
            CmbUnknown.SelectedIndex = 0
            LblUnknown.Enabled = True
            CmbUnknown.Enabled = True
        ElseIf CmbRptStyle.SelectedIndex = 3 Then
            LblUnknown.Text = "Sales Person"
            CmbUnknown.Items.Clear()
            ESSA.LoadCombo(CmbUnknown, $"SELECT SPID, Name FROM SalesPersons WHERE ShopId = { ShopID } ORDER BY Name", "Name", "SPID")
            LblUnknown.Enabled = True
            CmbUnknown.Enabled = True
        Else
            LblUnknown.Enabled = False
            CmbUnknown.Enabled = False
        End If

    End Sub
    'IMRAN
    Private Sub btnCommission_Click(sender As Object, e As EventArgs) Handles btnCommission.Click

        LoadCommissionGrid()
        pnlCommission.Visible = True
        If IsAdmin = False Then
            txtFromAmount.Enabled = False
            txtToAmount.Enabled = False
            txtCommissionPerc.Enabled = False
            btnSave.Enabled = False
            btnClear.Enabled = False
        End If
        txtFromAmount.Focus()
    End Sub

    Private Sub frmSalesReportSPWise_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.AlignCenter(pnlCommission, Me)

    End Sub

    Private Sub btnCommissionClose_Click(sender As Object, e As EventArgs) Handles btnCommissionClose.Click

        pnlCommission.Visible = False

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtFromAmount.Clear()
        txtToAmount.Clear()
        txtCommissionPerc.Clear()

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If Val(txtFromAmount.Text) <= 0 Or Val(txtToAmount.Text) <= 0 Then
            MsgBox("Please Enter Valid From/To Amount", MsgBoxStyle.Critical)
            txtFromAmount.Focus()
            Exit Sub
        ElseIf Val(txtFromAmount.Text) > Val(txtToAmount.Text) Then
            MsgBox("From Amount Should Not be Greater Than To Amount", MsgBoxStyle.Critical)
            txtToAmount.Focus()
            txtToAmount.SelectAll()
            Exit Sub
        ElseIf Val(txtCommissionPerc.Text) <= 0 Then
            MsgBox("Please Enter Valid %", MsgBoxStyle.Critical)
            txtCommissionPerc.Focus()
            txtCommissionPerc.SelectAll()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim trn = Con.BeginTransaction
        Try

            If IsEditMode = False Then

                SQL = $"SELECT COUNT(*) FROM SalesPersonCommission WHERE ShopId = {ShopID} 
                        AND FromAmount <= {txtToAmount.Text}
                        AND ToAmount >= {txtFromAmount.Text}"

            Else

                SQL = $"SELECT COUNT(*) FROM SalesPersonCommission WHERE ShopId = {ShopID}  
                        AND FromAmount <= {txtToAmount.Text}                   
                        AND ToAmount >= {txtFromAmount.Text} 
                        AND CommId <> {CommId}"

            End If
            Dim chkCmd As New SqlCommand(SQL, Con, trn)
            Dim cnt As Integer = chkCmd.ExecuteScalar()

            If cnt > 0 Then
                MsgBox("This Range Already Exists. Please Edit Directly..!", MsgBoxStyle.Information)
                trn.Rollback()
                Con.Close()
                Exit Sub
            End If

            If IsEditMode = False Then

                Dim maxId As String = "select isNull(max(CommId),0) + 1 from SalesPersonCommission"
                Using cmd As New SqlCommand(maxId, Con, trn)
                    maxId = cmd.ExecuteScalar()
                End Using

                SQL = $"insert into SalesPersonCommission values (
                 {maxId},
                '{txtFromAmount.Text}',
                '{txtToAmount.Text}',
                '{txtCommissionPerc.Text}',
                 {ShopID},
                 '{Now.ToString("yyyy-MM-dd HH:mm:ss")}'                 
                 )"

            Else

                SQL = $"UPDATE SalesPersonCommission SET 
                        FromAmount = '{Val(txtFromAmount.Text)}', 
                        ToAmount = '{Val(txtToAmount.Text)}',
                        CommissionPerc = {Val(txtCommissionPerc.Text)}
                        WHERE CommId = {CommId}"
            End If

            Using command As New SqlCommand(SQL, Con, trn)
                command.ExecuteNonQuery()
            End Using

            trn.Commit()
            Con.Close()
            MsgBox("Commission Saved Successfully", MsgBoxStyle.Information)
            txtFromAmount.Clear()
            txtToAmount.Clear()
            txtCommissionPerc.Clear()
            txtFromAmount.Focus()
            IsEditMode = False
            CommId = 0
            LoadCommissionGrid()

        Catch ex As Exception
            trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub dgvCommission_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCommission.CellClick
        Try
            If IsAdmin = True Then
                If e.ColumnIndex = 7 Then
                    If e.RowIndex < 0 Then Exit Sub

                    If MsgBox("Do you want to delete this entry..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

                    SQL = $"DELETE FROM SalesPersonCommission WHERE CommId = '{dgvCommission.Item(0, e.RowIndex).Value}'"

                    ESSA.OpenConnection()
                    Using command As New SqlCommand(SQL, Con)
                        command.ExecuteNonQuery()
                    End Using
                    MsgBox("Commission Deleted Successfully", MsgBoxStyle.Information)
                    dgvCommission.Rows.RemoveAt(e.RowIndex)
                    Con.Close()
                End If

                If e.ColumnIndex = 6 Then
                    If e.RowIndex < 0 Then Exit Sub
                    IsEditMode = True
                    CommId = dgvCommission.Item(0, e.RowIndex).Value
                    txtFromAmount.Text = dgvCommission.Item(3, e.RowIndex).Value
                    txtToAmount.Text = dgvCommission.Item(4, e.RowIndex).Value
                    txtCommissionPerc.Text = dgvCommission.Item(5, e.RowIndex).Value
                    txtFromAmount.Focus()
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Con.Close()
        End Try
    End Sub
    Private Sub LoadCommissionGrid()

        Try
            dgvCommission.Rows.Clear()

            ESSA.OpenConnection()

            SQL = $"SELECT CommId,FromAmount,ToAmount,CommissionPerc,CreatedDate FROM SalesPersonCommission 
                    WHERE ShopId = {ShopID} 
                    ORDER BY FromAmount"

            Using cmd As New SqlCommand(SQL, Con)
                Using Reader = cmd.ExecuteReader()
                    While Reader.Read()

                        Dim rows As Integer = dgvCommission.Rows.Add()
                        dgvCommission.Item(0, rows).Value = Reader(0)
                        dgvCommission.Item(1, rows).Value = rows + 1
                        dgvCommission.Item(2, rows).Value = Format(Reader(4), "dd-MM-yyyy")
                        dgvCommission.Item(3, rows).Value = Format(Reader(1), "0.00")
                        dgvCommission.Item(4, rows).Value = Format(Reader(2), "0.00")
                        dgvCommission.Item(5, rows).Value = Format(Reader(3), "0.00")

                    End While
                    Reader.Close()
                    Con.Close()
                End Using
            End Using
        Catch ex As Exception
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub
    Private Sub txtFromAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtFromAmount.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtToAmount.Focus()
        End If
    End Sub

    Private Sub txtToAmount_KeyDown(sender As Object, e As KeyEventArgs) Handles txtToAmount.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCommissionPerc.Focus()
        End If
    End Sub

    Private Sub txtCommissionPerc_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCommissionPerc.KeyDown
        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            btnSave.Focus()
        End If
    End Sub
End Class