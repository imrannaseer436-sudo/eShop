Public Class frmSalesReportSPWise

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        If CmbRptStyle.SelectedIndex = 0 Then

            'SQL = "SELECT SP.Name [Sales Person],CONVERT(DECIMAL(10,2),SUM(D.Qty)) Quantity,CONVERT(DECIMAL(10,2),SUM(D.Amount)) Amount FROM SalesPersons SP " _
            '   & "INNER JOIN BillSalePersons BSP ON BSP.SPID = SP.SPID " _
            '   & "INNER JOIN BillDetails D ON D.BillID = BSP.BillId AND D.PluID = BSP.PluId " _
            '   & "AND D.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'" _
            '   & "GROUP BY SP.Name"

            SQL = "SELECT ISNULL(B.Name,'NOT GIVEN') [Sales Person], CONVERT(DECIMAL(10,2),SUM(A.Quantity)) Quantity,CONVERT(DECIMAL(10,2),SUM(A.Amount)) Amount FROM " _
            & "(SELECT BD.BillID, BD.PluId, SUM(BD.Qty) Quantity, SUM(BD.Amount) Amount " _
            & "FROM BillDetails BD WHERE BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' " _
            & "GROUP BY BD.BillID,BD.PluId) A " _
            & "LEFT JOIN " _
            & "(SELECT BSP.BillId,BSP.PluId,SP.Name FROM SalesPersons SP " _
            & "INNER JOIN BillSalePersons BSP ON BSP.SPID = SP.SPID " _
            & ") B On A.BillId = B.BillId And A.PluID = B.PluId " _
            & " GROUP BY B.Name"

        ElseIf CmbRptStyle.SelectedIndex = 1 Then

            SQL = "Select A.[Term ID],A.[Bill No],A.[Bill Date],A.Code,A.Qty,A.Amount,B.SPID,B.[Sales Person],B.Floor FROM " _
            & "(Select DISTINCT BD.BIllId,BD.PluID, BM.TermID [Term ID],BM.BillNo [Bill No],BM.BillDt [Bill Date],PM.Plucode [Code],CONVERT(Decimal(10,2),BD.Qty) [Qty],CONVERT(Decimal(10,2),BD.Amount) Amount " _
            & "FROM BillMaster BM " _
            & "INNER JOIN BillDetails BD On BD.BillID = BM.BillID And BM.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' " _
            & "INNER JOIN ProductMaster PM ON PM.PluID = BD.PluID ) A " _
            & "LEFT JOIN " _
            & "(SELECT BSP.BillId,BSP.PluId,SP.SPID ,ISNULL(SP.Name,'NOT GIVEN') [Sales Person], CASE SP.Floor When '0' THEN 'GROUND' WHEN '1' THEN 'FIRST' WHEN '2' THEN 'SECOND' WHEN '3' THEN 'THIRD' WHEN 'U' THEN 'UNSPECIFIED' END AS [Floor] FROM BillSalePersons BSP " _
            & "INNER JOIN SalesPersons SP ON SP.SPID = BSP.SPID) B ON A.BillId = B.BillId AND A.PluId = B.PluId"

        ElseIf CmbRptStyle.SelectedIndex = 2 Then

            If CmbUnknown.FindStringExact(CmbUnknown.Text.Trim) = -1 Then
                MsgBox(CmbUnknown.Text.Trim + " is not availbale..!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            SQL = "SELECT A.[Term ID],A.[Bill No],A.[Bill Date],A.Code,A.Qty,A.Amount,B.SPID,B.[Sales Person],B.Floor FROM " _
            & "(SELECT DISTINCT BD.BIllId,BD.PluID, BM.TermID [Term ID],BM.BillNo [Bill No],BM.BillDt [Bill Date],PM.Plucode [Code],CONVERT(DECIMAL(10,2),BD.Qty) [Qty],CONVERT(DECIMAL(10,2),BD.Amount) Amount " _
            & "FROM BillMaster BM " _
            & "INNER JOIN BillDetails BD ON BD.BillID = BM.BillID AND BM.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' " _
            & "INNER JOIN ProductMaster PM ON PM.PluID = BD.PluID ) A " _
            & "LEFT JOIN " _
            & "(SELECT BSP.BillId,BSP.PluId,SP.SPID ,ISNULL(SP.Name,'NOT GIVEN') [Sales Person], CASE SP.Floor When '0' THEN 'GROUND' WHEN '1' THEN 'FIRST' WHEN '2' THEN 'SECOND' WHEN '3' THEN 'THIRD' WHEN 'U' THEN 'UNSPECIFIED' END AS [Floor] FROM BillSalePersons BSP " _
            & "INNER JOIN SalesPersons SP ON SP.SPID = BSP.SPID) B ON A.BillId = B.BillId AND A.PluId = B.PluId WHERE B.Floor ='" & CmbUnknown.Text.Trim & "'"

        ElseIf CmbRptStyle.SelectedIndex = 3 Then

            If CmbUnknown.FindStringExact(CmbUnknown.Text.Trim) = -1 Then
                MsgBox(CmbUnknown.Text.Trim + " is not available..!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            SQL = "SELECT A.[Term ID],A.[Bill No],A.[Bill Date],A.Code,A.Qty,A.Amount,B.SPID,B.[Sales Person],B.Floor FROM " _
            & "(SELECT DISTINCT BD.BIllId,BD.PluID, BM.TermID [Term ID],BM.BillNo [Bill No],BM.BillDt [Bill Date],PM.Plucode [Code],CONVERT(DECIMAL(10,2),BD.Qty) [Qty],CONVERT(DECIMAL(10,2),BD.Amount) Amount " _
            & "FROM BillMaster BM " _
            & "INNER JOIN BillDetails BD ON BD.BillID = BM.BillID AND BM.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "' " _
            & "INNER JOIN ProductMaster PM ON PM.PluID = BD.PluID ) A " _
            & "LEFT JOIN " _
            & "(SELECT BSP.BillId,BSP.PluId,SP.SPID ,ISNULL(SP.Name,'NOT GIVEN') [Sales Person], CASE SP.Floor When '0' THEN 'GROUND' WHEN '1' THEN 'FIRST' WHEN '2' THEN 'SECOND' WHEN '3' THEN 'THIRD' WHEN 'U' THEN 'UNSPECIFIED' END AS [Floor] FROM BillSalePersons BSP " _
            & "INNER JOIN SalesPersons SP ON SP.SPID = BSP.SPID) B ON A.BillId = B.BillId AND A.PluId = B.PluId WHERE B.[Sales Person] ='" & CmbUnknown.Text.Trim & "'"

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
            CalculateSummary(1, LblQty)
            CalculateSummary(2, LblAmt)
        ElseIf CmbRptStyle.SelectedIndex = 1 Or CmbRptStyle.SelectedIndex = 2 Or CmbRptStyle.SelectedIndex = 3 Then
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
            ESSA.LoadCombo(CmbUnknown, "SELECT SPID, Name FROM SalesPersons ORDER BY Name", "Name", "SPID")
            LblUnknown.Enabled = True
            CmbUnknown.Enabled = True
        Else
            LblUnknown.Enabled = False
            CmbUnknown.Enabled = False
        End If

    End Sub
End Class