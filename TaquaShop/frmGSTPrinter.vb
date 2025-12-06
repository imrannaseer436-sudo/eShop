Imports System.Data.SqlClient
Public Class frmGSTPrinter

    Private Sub frmGSTPrinter_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Enter

                If Me.ActiveControl.Tag <> "1" Then

                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)

                End If

            Case Keys.Escape

                If pnlCustomerUpdate.Visible Then pnlCustomerUpdate.Hide() : Exit Sub
                If MsgBox("Do you want to exit..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
                Close()

        End Select


    End Sub

    Private Sub frmGSTPrinter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        '// Get address info

        Call GetShopAddress()

        '// Get terminal list

        SQL = "select convert(varchar,termid) termid from terminal where shopid = " & ShopID & " order by termid"
        ESSA.LoadCombo(cmbTerm, SQL, "termid", "", "All")

        '// Font header bold

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 6, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TG, 7, DataGridViewContentAlignment.MiddleCenter)

        '// Get customer list

        loadCustomerList()

    End Sub

    Private Sub loadCustomerList()

        SQL = "select customerid,customername from customers order by customername"
        ESSA.LoadCombo(cmbCustomer, SQL, "customername", "customerid")

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        SQL = "select b.billid,b.billno,b.termid,c.customername,b.totqty,b.totamt,b.customerid,b.billdt,b.remarks " _
            & "from billmaster b,customers c where " _
            & "b.customerid=c.customerid and b.shopid = " & ShopID & " and b.billdt between '" & Format(dtpFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

        If cmbTerm.SelectedIndex > 0 Then
            SQL &= " and b.termid=" & Val(cmbTerm.Text)
        End If

        SQL &= " order by b.termid,b.billno"

        With ESSA.OpenReader(SQL)

            TG.Rows.Clear()

            While .Read

                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .Item(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .Item(2)
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3).Trim
                TG.Item(4, TG.Rows.Count - 1).Value = .Item(4)
                TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
                TG.Item(6, TG.Rows.Count - 1).Value = IIf(.GetString(8).Trim.Contains("IGST"), "Yes", "No")
                TG.Item(10, TG.Rows.Count - 1).Value = .Item(6)
                TG.Item(11, TG.Rows.Count - 1).Value = Format(.GetDateTime(7).Date, "dd-MM-yyyy")
                TG.Item(12, TG.Rows.Count - 1).Value = .GetString(8).Trim

            End While

            .Close()

        End With

        lblCount.Text = TG.Rows.Count

    End Sub

    Private Sub btnReloadCustomer_Click(sender As Object, e As EventArgs) Handles btnReloadCustomer.Click

        loadCustomerList()
        cmbCustomer.Focus()

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 7 Then

            pnlCustomerUpdate.Visible = True
            cmbCustomer.SelectedValue = Val(TG.Item(10, e.RowIndex).Value)
            cmbCustomer.Focus()

        ElseIf e.ColumnIndex = 8 Then

            PrintGSTBill(TG, Val(TG.Item(0, e.RowIndex).Value), Val(TG.Item(9, e.RowIndex).Value))

        End If

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlCustomerUpdate.Visible = False

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        Dim Remarks As String = Trim(TG.Item(12, TG.CurrentRow.Index).Value)

        If Remarks.Contains("IGST") Then
            Remarks = IIf(ChkOtherState.Checked, Remarks, Mid(Remarks, 1, Remarks.Length - 4))
        Else
            Remarks = IIf(ChkOtherState.Checked, Remarks & " IGST", Remarks)
        End If

        SQL = "update billmaster set customerid={0},remarks='{2}',isupdated = 0 where billid={1}"
        ESSA.Execute(String.Format(SQL, cmbCustomer.SelectedValue, Val(TG.Item(0, TG.CurrentRow.Index).Value), Remarks))

        TG.Item(3, TG.CurrentRow.Index).Value = cmbCustomer.Text.Trim
        TG.Item(10, TG.CurrentRow.Index).Value = cmbCustomer.SelectedValue

        pnlCustomerUpdate.Visible = False

    End Sub

    Private Rpt As New rptGSTBill
    Private ShopName As String = ""
    Private ShopAdd1 As String = ""

    Private CustomerName As String = ""
    Private CustomerAdd1 As String = ""

    Private Sub GetCustomerName(iCustomerID As Integer)

        SQL = "select customername,address1,address2,city,phone,mobile from customers where customerid={0}"
        SQL = String.Format(SQL, iCustomerID)

        With ESSA.OpenReader(SQL)

            If .Read Then

                CustomerName = .GetString(0).Trim

                CustomerAdd1 = .GetString(1).Trim & vbCrLf

                If .GetString(2).Trim.Length > 0 Then

                    CustomerAdd1 &= .GetString(2).Trim & vbCrLf

                End If

                CustomerAdd1 &= .GetString(3).Trim & vbCrLf

                CustomerAdd1 &= "Phone : " & .GetString(3).Trim & vbCrLf

                CustomerAdd1 &= "GSTIN : " & .GetString(4).Trim & vbCrLf

            End If

            .Close()

        End With

    End Sub

    Private Sub GetShopAddress()

        '// Change shopid after finishing subject

        SQL = "select alias,address1,address2,city,state,vat from shops where shopid=2"

        With ESSA.OpenReader(SQL)

            If .Read Then

                '// Get the shopname
                ShopName = .GetString(0).Trim

                '// Get Address Line 1 
                ShopAdd1 = .GetString(1).Trim & vbCrLf

                '// Get Address Line 2
                If .GetString(2).Trim.Length > 0 Then
                    ShopAdd1 &= .GetString(2).Trim & vbCrLf
                End If

                '// Get Address City
                ShopAdd1 &= .GetString(3).Trim & vbCrLf

                '// Get Address State
                ShopAdd1 &= .GetString(4).Trim & ", INDIA" & vbCrLf

                '// Get GSTIN
                ShopAdd1 &= "GSTIN : " & .GetString(5).Trim

            End If

            .Close()

        End With

    End Sub

    Private Sub PrintGSTBill(DGV As DataGridView, iBillID As Long, iCustID As Integer)

        'GetCustomerName(iCustID)

        'SQL = "select (p.plucode + '/' + p.pluname) pludesc,p.hsncode,convert(varchar,qty) VCQty,Qty,p.UTax,Rate from billdetails d,productmaster p " _
        '    & "where d.pluid=p.pluid and d.billid=" & iBillID

        'ESSA.OpenConnection()
        'Using Adp As New SqlDataAdapter(SQL, Con)
        '    Using Tbl As New DataTable
        '        Adp.Fill(Tbl)
        '        Rpt.SetDataSource(Tbl)

        '        Rpt.SetParameterValue("ShopName", ShopName)
        '        Rpt.SetParameterValue("Address", ShopAdd1)

        '        Rpt.SetParameterValue("CustomerName", CustomerName)
        '        Rpt.SetParameterValue("CustomerAddress", CustomerAdd1)

        '        Rpt.SetParameterValue("InvNo", Val(DGV.Item(1, DGV.CurrentRow.Index).Value))
        '        Rpt.SetParameterValue("InvDt", Trim(DGV.Item(10, DGV.CurrentRow.Index).Value))
        '        Rpt.SetParameterValue("Supply", "Tamilnadu (33)")

        '        frmReportViewer.CRViewer.ReportSource = Rpt
        '        frmReportViewer.Visible = False
        '        frmReportViewer.Show()
        '    End Using
        'End Using
        'Con.Close()

        PrintGSTBillNew(iBillID, IIf(DGV.Item(6, DGV.CurrentRow.Index).Value = "Yes", True, False))

    End Sub

    Private Rpt2 As New rptGSTBill2
    Private Rpt3 As New rptGSTBill3
    Private Rpt4 As New CrystalDecisions.CrystalReports.Engine.ReportDocument

    Private Sub PrintGSTBillNew(iBillID As Long, IGST As Boolean)

        Rpt4 = IIf(IGST, Rpt3, Rpt2)

        'SQL = "select s.address1,s.address2,s.city,s.phone,s.cst," _
        '    & "c.customername,c.address1 caddress1,c.address2 caddress2,c.city ccity," _
        '    & "c.phone cphone,c.mobile cmobile," _
        '    & "(convert(varchar,bm.termid) + '-' + convert(varchar,bm.billno)) billno,bm.billdt," _
        '    & "p.pluname as plucode,p.hsncode,p.utax,bd.Qty,bd.Amount,bd.rate " _
        '    & "from shops s,customers c,billmaster bm,billdetails bd,productmaster p " _
        '    & "where bm.billid=bd.billid and bd.pluid=p.pluid and bm.billid={0} " _
        '    & "and bm.shopid=s.shopid and bm.customerid=c.customerid " _
        '    & "order by bd.sno"

        SQL = "select distinct s.address1,s.address2,s.city,s.phone,s.cst," _
            & "c.customername,c.address1 caddress1,c.address2 caddress2,c.city ccity," _
            & "c.phone cphone,c.mobile cmobile," _
            & "(convert(varchar,bm.termid) + '-' + convert(varchar,bm.billno)) billno,bm.billdt," _
            & "p.pluname as plucode,p.hsncode,p.utax,bd.Qty,bd.Amount,bd.rate,bd.pluid,t.mn,t.mx,t.val,bd.sno,c.state cstate " _
            & "from shops s,customers c,billmaster bm,billdetails bd,productmaster p,productattributes a,producttax t " _
            & "where bm.billid=bd.billid and bd.pluid=p.pluid and p.pluid = a.pluid and a.deptid = t.deptid and a.catid = t.catid and a.materialid= t.matid and t.isupdated = bm.isupdated and bm.billid={0} " _
            & "and bm.shopid=s.shopid and bm.customerid=c.customerid " _
            & "order by bd.sno"

        SQL = String.Format(SQL, iBillID)

        ESSA.OpenConnection()
        Using Adp As New SqlDataAdapter(SQL, Con)
            Using Tbl As New DataTable
                Adp.Fill(Tbl)
                Rpt4.SetDataSource(Tbl)
                frmReportViewer.CRViewer.ReportSource = Rpt4
                frmReportViewer.Visible = False
                frmReportViewer.Show()
            End Using
        End Using
        Con.Close()

    End Sub

    Private Sub TG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellContentClick

    End Sub
End Class