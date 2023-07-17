'***************************************** Bismillah **********************************
Imports System.Data.SqlClient
Public Class SalesReportBillWise

    Private Sub SalesReportBillWise_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)

        SQL = "select convert(varchar,termid) term from terminal order by termid" ' where shopid=" & ShopID
        ESSA.LoadCombo(cmbTerm, SQL, "term", "", "All")

        SQL = "SELECT UserId,UserName FROM Users ORDER BY UserName"
        ESSA.LoadCombo(cmbUser, SQL, "Username", "UserId", "All")

        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 6, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 7, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 8, DataGridViewContentAlignment.MiddleRight)


    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        pnlLoading.Show() : pnlLoading.Refresh()

        TG.Columns(9).Width = 200

        Dim TQty As Double = 0
        Dim TAmt As Double = 0

        'yaseen new code

        SQL = "SELECT M.BILLNO,M.BILLDT,M.TERMID,M.TOTQTY,M.TOTAMT,M.DISAMT,ISNULL(SUM(CASH),0) CASH,ISNULL(SUM(CARD),0) CARD, ISNULL(SUM(UPI),0) UPI, " _
               & " M.REMARKS,U.USERNAME,M.BILLTIME,C.CustomerName,C.Phone " _
               & " FROM BillMaster M " _
               & " INNER JOIN Customers C ON C.CustomerId = M.CustomerId" _
               & " INNER JOIN USERS U On U.UserID = M.UserID And M.ShopId = " & ShopID & " AND M.BillDt BETWEEN '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        If cmbTerm.SelectedIndex > 0 Then
            SQL &= " AND M.TERMID=" & Val(cmbTerm.Text)
        End If

        If cmbUser.SelectedIndex > 0 Then
            SQL &= " AND M.UserId = " & cmbUser.SelectedValue
        End If

        If TxtCustMobile.Text <> String.Empty Then
            If ChkMobile.Checked Then
                SQL &= " AND C.Phone LIKE '%" & TxtCustMobile.Text.Trim & "%'"
            Else
                SQL &= " And C.CustomerName Like '%" & TxtCustMobile.Text.Trim & "%'"
            End If
        End If

        SQL &= " Left Join V_BillPayments2 V On V.BILLID = M.BillID " _
                & "GROUP BY M.BILLNO,M.BILLDT,M.TERMID,M.TOTQTY,M.TOTAMT,M.DISAMT,M.REMARKS,U.USERNAME,M.BILLTIME,C.CustomerName,C.Phone " _
                & " ORDER BY M.BillNo"

        'yaseen old code

        'SQL = "SELECT A.BILLNO,A.BILLDT,A.TERMID,A.TOTQTY,A.TOTAMT,A.DISAMT,ISNULL(B.CASH,0),ISNULL(B.CARD,0),ISNULL(B.UPI,0),A.REMARKS,A.USERNAME,A.BILLTIME FROM " _
        '    & "(SELECT DISTINCT M.BILLID,M.BILLNO,M.BILLDT,M.TERMID,M.TOTQTY,M.TOTAMT,M.DISAMT,M.REMARKS,U.USERNAME,M.BILLTIME " _
        '    & "FROM BILLMASTER M,BILLDETAILS D,USERS U WHERE M.USERID=U.USERID AND M.BILLID=D.BILLID AND M.BILLDT BETWEEN '" _
        '    & Format(mebFrom.Value, "yyyy-MM-dd") & "' AND '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"


        'If cmbTerm.SelectedIndex > 0 Then
        '    SQL &= " AND M.TERMID=" & Val(cmbTerm.Text)
        'End If

        'If cmbUser.SelectedIndex > 0 Then
        '    SQL &= " AND M.UserId = " & cmbUser.SelectedValue
        'End If

        'SQL &= ") A LEFT OUTER JOIN " _
        '    & "(SELECT BILLID,SUM(CASH) CASH,SUM(CARD) CARD, SUM(UPI) UPI FROM V_BILLPAYMENTS2 GROUP BY BILLID) B " _
        '    & "ON A.BILLID=B.BILLID ORDER BY A.BILLNO"

        'server abu code

        'SQL = "select a.billno 'BILL NO',a.billdt 'DATE',a.TERMID,a.totqty 'QUANTITY',BAMT 'B.AMOUNT',DIS 'DISCOUNT',isnull(B.PAID,0) 'NET AMT',b.PAYMENT,a.REMARKS,a.username 'USER' from " _
        '    & "(select m.billid,m.shopid,m.billno,m.billdt,m.TERMID,m.totqty,convert(decimal(10,2),m.totamt+m.disamt) BAMT,convert(decimal(10,2),m.disamt) DIS,convert(decimal(10,2),m.totamt) NAMT,m.REMARKS,u.username from " _
        '    & "billmaster m,users u where m.userid=u.userid and m.billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
        '    & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        'If cmbTerm.SelectedIndex > 0 Then
        '    SQL &= " and m.termid=" & Val(cmbTerm.Text)
        'End If

        'SQL &= ") a left outer join " _
        '    & "(select billid,shopid,paymentdesc PAYMENT,PAID from billpayments where billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
        '    & Format(mebTo.Value, "yyyy-MM-dd") & "') b on a.billid=b.billid and a.shopid=b.shopid order by a.billno"

        'ESSA.LoadDataGrid(TG, SQL)
        'ESSA.AlignHeader(TG, 0, DataGridViewContentAlignment.MiddleLeft, 100)
        'ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleCenter, 100)
        'ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleLeft, 40)
        'ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight, 100)
        'ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight, 100)
        'ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight, 100)
        'ESSA.AlignHeader(TG, 6, DataGridViewContentAlignment.MiddleRight, 100)
        'ESSA.AlignHeader(TG, 7, DataGridViewContentAlignment.MiddleLeft, 100)
        'ESSA.AlignHeader(TG, 8, DataGridViewContentAlignment.MiddleLeft, 160)
        'ESSA.AlignHeader(TG, 9, DataGridViewContentAlignment.MiddleLeft, 60)

        TG.SuspendLayout()
        TG.Rows.Clear()

        Try

            With ESSA.OpenReader(SQL)
                While .Read
                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                    TG.Item(1, TG.Rows.Count - 1).Value = Format(.GetDateTime(1), "dd-MM-yyyy")
                    TG.Item(2, TG.Rows.Count - 1).Value = .Item(2)
                    TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                    TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4) + Math.Round(.Item(5), 0), "0.00")
                    TG.Item(5, TG.Rows.Count - 1).Value = Format(Math.Round(.Item(5), 0), "0.00")
                    TG.Item(6, TG.Rows.Count - 1).Value = Format(.Item(6), "0.00")
                    TG.Item(7, TG.Rows.Count - 1).Value = Format(.Item(7), "0.00")
                    TG.Item(8, TG.Rows.Count - 1).Value = Format(.Item(8), "0.00")
                    TG.Item(9, TG.Rows.Count - 1).Value = .GetString(9)
                    TG.Item(10, TG.Rows.Count - 1).Value = .GetString(10)
                    TG.Item(11, TG.Rows.Count - 1).Value = Format(.GetDateTime(11), "hh:mm:ss tt")
                    TG.Item(12, TG.Rows.Count - 1).Value = .GetString(12).ToUpper
                    TG.Item(13, TG.Rows.Count - 1).Value = .GetString(13)
                    TQty += Val(TG.Item(3, TG.Rows.Count - 1).Value)
                    TAmt += Val(TG.Item(6, TG.Rows.Count - 1).Value) + Val(TG.Item(7, TG.Rows.Count - 1).Value) + Val(TG.Item(8, TG.Rows.Count - 1).Value)
                End While
            End With

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

        TG.ResumeLayout()
        pnlLoading.Hide()
        lblBillCount.Text = TG.Rows.Count
        lblQty.Text = TQty
        lblAmt.Text = Format(TAmt, "0.00")

    End Sub

    Private Sub SalesReportBillWise_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.AlignCenter(pnlLoading, Me)

    End Sub

End Class