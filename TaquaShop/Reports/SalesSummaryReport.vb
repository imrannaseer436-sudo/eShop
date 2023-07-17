'************************************* Bismillah **********************************
Imports System.Data.SqlClient
Public Class SalesSummaryReport

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If rdoSmry.Checked = True Then

            'SQL = "SELECT 'COUNTER SALES' 'SALES TYPE',CONVERT(DECIMAL(10,2),SUM(SALES)) 'GROSS',CONVERT(DECIMAL(10,2),SUM(RFUND)) 'REFUND',CONVERT(DECIMAL(10,2),SUM(SALES-RFUND)) 'NET TOTAL' FROM V_PAYMENTSUMMARY WHERE BILLDT BETWEEN '" _
            '    & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

            SQL = "SELECT 'COUNTER SALES' 'SALES TYPE',CONVERT(DECIMAL(10,2),SUM(SALES)) 'GROSS',CONVERT(DECIMAL(10,2),SUM(RFUND)) 'REFUND',CONVERT(DECIMAL(10,2),SUM(SALES-RFUND)) 'NET TOTAL' FROM V_PAYMENTSUMMARY WHERE BILLDT BETWEEN '" _
                & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

            If cmbTerm.SelectedIndex > 0 Then
                SQL &= " AND TERMID=" & Val(cmbTerm.Text)
            End If

            TG.Columns.Clear()
            ESSA.LoadDataGrid(TG, SQL)
            TG.Columns(0).Width = 100
            TG.Columns(1).Width = 100
            ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleRight)
            TG.Columns(2).Width = 100
            ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleRight)
            TG.Columns(3).Width = 100
            ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)

        ElseIf rdoDts.Checked = True Then

            Dim TableSummary = IIf(chkAddUpi.Checked, "V_PAYMENTSUMMARY2", "V_PAYMENTSUMMARY")

            SQL = "SELECT PAYMENTTYPE 'PAYMENT MODE',CONVERT(DECIMAL(10,2),SUM(SALES)) GROSS,CONVERT(DECIMAL(10,2),SUM(RFUND)) REFUND,CONVERT(DECIMAL(10,2),SUM(SALES-RFUND)) 'NET TOTAL' FROM " & TableSummary & " WHERE ShopId =  " & ShopID & " AND BILLDT BETWEEN '" _
                & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

            If cmbTerm.SelectedIndex > 0 Then
                SQL &= " AND TERMID=" & Val(cmbTerm.Text)
            End If

            SQL &= " GROUP BY PAYMENTTYPE,BTYPE ORDER BY BTYPE"

            TG.Columns.Clear()
            ESSA.LoadDataGrid(TG, SQL)
            TG.Columns(0).Width = 200
            ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleRight)
            TG.Columns(2).Width = 100
            ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleRight)
            TG.Columns(3).Width = 100
            ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)

        ElseIf rdoFloor.Checked Then

            SQL = "SELECT ISNULL(P.RACKNO, '') [Floor], SUM(D.AMOUNT) [Sales] " _
                & "FROM BILLDETAILS D, PRODUCTMASTER P " _
                & "WHERE D.PLUID = P.PLUID AND D.ShopID = " & ShopID & " AND BILLDT BETWEEN '{0}' AND '{1}' " _
                & "GROUP BY P.RACKNO"

            SQL = String.Format(SQL, Format(mebFrom.Value, "yyyy-MM-dd"), Format(mebTo.Value, "yyyy-MM-dd"))

            TG.DataSource = Nothing
            TG.Columns.Clear()
            TG.Columns.Add("", "Floor")
            TG.Columns.Add("", "Sales")
            TG.Columns(0).Width = 150
            TG.Columns(1).Width = 150

            Dim totalAmount As Double = 0

            With ESSA.OpenReader(SQL)
                TG.Rows.Clear()
                While .Read
                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .GetString(0).Trim
                    TG.Item(1, TG.Rows.Count - 1).Value = Format(.Item(1), "0.00")
                    totalAmount += .Item(1)
                End While
                .Close()
            End With

            TG.Rows.Add()
            TG.Rows(TG.Rows.Count - 1).DefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
            TG.Item(0, TG.Rows.Count - 1).Value = "TOTAL AMOUNT"
            TG.Item(1, TG.Rows.Count - 1).Value = Format(totalAmount, "0.00")

        ElseIf rbUserwise.Checked Then

            SQL = "SELECT UserName [USER], CONVERT(DECIMAL(18,2),SUM(CASH)) CASH, CONVERT(DECIMAL(18,2),SUM(CARD)) CARD, CONVERT(DECIMAL(18,2),SUM(UPI)) UPI FROM " _
                & "(SELECT U.UserName,BM.BillDt,BM.TermID,BP.Paid - BP.Refund NET , CASE(BP.PaymentDesc) " _
                & "When 'cahs' THEN 'CASH' " _
                & "WHEN 'CARD' THEN 'CARD' " _
                & "When 'CASH' THEN 'CASH' " _
                & "WHEN 'MAESTRO CARD' THEN 'CARD' " _
                & "WHEN 'MASTER CARD' THEN 'CARD' " _
                & "WHEN 'NEFT' THEN 'UPI' " _
                & "WHEN 'RUPAY' THEN 'CARD' " _
                & "WHEN 'UPI' THEN 'UPI' " _
                & "WHEN 'VISA' THEN 'CARD' " _
                & "END AS PaymentMode " _
                & "FROM BillMaster BM, Users U, BillPayments BP " _
                & "WHERE  BM.BillID = BP.BillId AND BM.UserId = U.UserID AND BM.ShopId = " & ShopID & " AND BM.BillDt BETWEEN '{0}' AND '{1}' "

            If cmbTerm.SelectedIndex > 0 Then
                SQL &= " And BM.TermId = " & Val(cmbTerm.Text)
            End If

            SQL &= ") A " _
                & " PIVOT " _
                & "( " _
                & "SUM(NET) " _
                & "FOR PaymentMode " _
                & "IN ([CASH],[CARD],[UPI]) " _
                & ") B GROUP BY UserName"

            SQL = String.Format(SQL, Format(mebFrom.Value, "yyyy-MM-dd"), Format(mebTo.Value, "yyyy-MM-dd"))

            TG.Columns.Clear()
            ESSA.LoadDataGrid(TG, SQL)
            TG.Columns(0).Width = 100
            TG.Columns(1).Width = 100
            ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleRight)
            TG.Columns(2).Width = 100
            ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleRight)
            TG.Columns(3).Width = 100
            ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)

        End If

    End Sub

    Private Sub SalesSummaryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "SELECT TERMID,CONVERT(VARCHAR,TERMID) TID FROM TERMINAL WHERE ShopID = " & ShopID & "  ORDER BY TERMID"
        ESSA.LoadCombo(cmbTerm, SQL, "TID", "TERMID", "ALL")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub TG_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellDoubleClick

        If e.RowIndex = -1 Then Exit Sub
        If e.RowIndex = TG.Rows.Count - 1 Then Exit Sub
        If Not rdoFloor.Checked Then Exit Sub

        FloorUpdater.Show()
        FloorUpdater.loadDataFromBill(Trim(TG.Item(0, e.RowIndex).Value), mebFrom.Value, mebTo.Value)

    End Sub

End Class