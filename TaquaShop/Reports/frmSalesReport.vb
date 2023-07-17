Public Class frmSalesReport

    Private Sub frmSalesReport_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            If pnlAdvanceSearch.Visible = True Then
                pnlAdvanceSearch.Visible = False
            End If
        End If

    End Sub

    Private Sub frmSalesReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmbCols.SelectedIndex = 0

        SQL = "SELECT VENDORID,VENDORNAME FROM VENDORS ORDER BY VENDORNAME"
        ESSA.LoadCombo(cmbVendor, SQL, "VENDORNAME", "VENDORID", "ALL VENDOR(S)")

        SQL = "SELECT CATID,CATDESC FROM CATEGORY ORDER BY CATDESC"
        ESSA.LoadCombo(cmbCat, SQL, "CATDESC", "CATID", "ALL CATEGORY(S)")

        SQL = "SELECT SCATID,SCATDESC FROM SUBCATEGORY1 ORDER BY SCATDESC"
        ESSA.LoadCombo(cmbSCat, SQL, "SCATDESC", "SCATID", "ALL CATEGORY(S)")

        SQL = "select distinct id from productmaster where id is not null"
        With ESSA.OpenReader(SQL)
            LstSize.Items.Clear()
            While .Read
                LstSize.Items.Add(.GetString(0).Trim)
            End While
            .Close()
        End With

        TGTOT.Rows.Add()

    End Sub

    Private Sub frmSalesReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        TG.Columns(13).Width = TG.Width - 1100
        TGTOT.Columns(13).Width = TGTOT.Width - 1100

        ESSA.AlignCenter(pnlLoading, Me)
        ESSA.AlignCenter(pnlAdvanceSearch, Me)

    End Sub

    Private Function PopulateReport(iCatID As Short, iSCatID As Short, iReportType As SByte) As String

        PopulateReport = ""

        'Report Type
        '0 - Normal Report
        '1 - Sales Report

        'If iReportType = 0 Then

        '    PopulateReport = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,P.UNITS,V.INWARDS,V.SALES,(V.INWARDS-V.SALES) STOCK," _
        '            & "P.RETAILPRICE,L.CATDESC,ISNULL(L.SCATDESC1,''),ISNULL(L.SCATDESC2,''),N.VENDORNAME,L.CATID,L.SCATID1,P.ID " _
        '            & "FROM PRODUCTMASTER P,V_INOUTREPORT V,PRODUCTLEVELS L,VENDORS N,V_PRODUCTSIZE S " _
        '            & "WHERE P.PLUID = V.PLUID AND P.PLUID=L.PLUID AND P.VENDORID=N.VENDORID AND P.PLUID=S.PLUID"

        '    If cmbVendor.SelectedIndex > 0 Then
        '        PopulateReport &= " AND P.VENDORID=" & cmbVendor.SelectedValue
        '    End If

        '    If iCatID > 0 Then
        '        PopulateReport &= " AND L.CATID=" & iCatID
        '    End If

        '    If iSCatID > 0 Then
        '        PopulateReport &= " AND L.SCATID1=" & iSCatID
        '    End If

        '    If cmbCols.SelectedIndex > 0 Then

        '        If chkExact.Checked = True Then
        '            PopulateReport &= " AND " & IIf(cmbCols.SelectedIndex = 1, "P.PLUCODE", "P.PLUNAME") & "='" & txtText.Text.Trim & "'"
        '        Else
        '            PopulateReport &= " AND " & IIf(cmbCols.SelectedIndex = 1, "P.PLUCODE", "P.PLUNAME") & " LIKE '%" & txtText.Text.Trim & "%'"
        '        End If

        '    End If

        '    If chkERF.Checked = True Then
        '        If Val(txtFrom.Text) >= 0 And Val(txtTo.Text) >= 0 Then
        '            PopulateReport &= " AND P.RETAILPRICE BETWEEN " & Val(txtFrom.Text) & " AND " & Val(txtTo.Text)
        '        End If
        '    End If

        '    If chkESF.Checked = True Then
        '        If Val(txtFrom2.Text) >= 0 And Val(txtTo2.Text) >= 0 Then
        '            PopulateReport &= " AND CONVERT(INT,S.SIZE) BETWEEN " & Val(txtFrom2.Text) & " AND " & Val(txtTo2.Text)
        '        End If
        '    End If

        '    PopulateReport &= " ORDER BY P.PLUNAME"

        'ElseIf iReportType = 1 Then

        '    PopulateReport = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,P.UNITS,0,V.QTY,0," _
        '                    & "V.RATE,L.CATDESC,ISNULL(L.SCATDESC1,''),ISNULL(L.SCATDESC2,''),N.VENDORNAME,L.CATID,L.SCATID1,P.ID " _
        '                    & "FROM PRODUCTMASTER P,BILLDETAILS V,PRODUCTLEVELS L,VENDORS N,V_PRODUCTSIZE S " _
        '                    & "WHERE P.PLUID=S.PLUID AND P.PLUID = V.PLUID AND P.PLUID=L.PLUID AND P.VENDORID=N.VENDORID AND V.QTY>0 AND " _
        '                    & "V.BILLDT BETWEEN '" & Format(dtpFr.Value, "yyyy-MM-dd") & "' AND '" _
        '                    & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

        '    If cmbVendor.SelectedIndex > 0 Then
        '        PopulateReport &= " AND P.VENDORID=" & cmbVendor.SelectedValue
        '    End If

        '    If cmbCat.SelectedIndex > 0 Then
        '        PopulateReport &= " AND L.CATID=" & cmbCat.SelectedValue
        '    End If

        '    If cmbSCat.SelectedIndex > 0 Then
        '        PopulateReport &= " AND L.SCATID1=" & cmbSCat.SelectedValue
        '    End If

        '    If chkERF.Checked = True Then
        '        If Val(txtFrom.Text) >= 0 And Val(txtTo.Text) >= 0 Then
        '            PopulateReport &= " AND V.RATE BETWEEN " & Val(txtFrom.Text) & " AND " & Val(txtTo.Text)
        '        End If
        '    End If

        '    If chkESF.Checked = True Then
        '        If Val(txtFrom2.Text) >= 0 And Val(txtTo2.Text) >= 0 Then
        '            PopulateReport &= " AND CONVERT(INT,S.SIZE) BETWEEN " & Val(txtFrom2.Text) & " AND " & Val(txtTo2.Text)
        '        End If
        '    End If

        '    PopulateReport &= " ORDER BY P.PLUNAME"

        'End If


        '// Update script with multiple size selector
        '// The view productsize has been removed due to error


        Dim sizeList As String = ""

        If chkESF.Checked Then

            For Each item As String In LstSize.CheckedItems

                sizeList &= "'" & item & "',"

            Next

            If sizeList.Length > 0 Then

                sizeList = Mid(sizeList, 1, sizeList.Length - 1)

            End If

        End If

        If iReportType = 0 Then

            PopulateReport = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,P.UNITS,V.INWARDS,V.SALES,(V.INWARDS-V.SALES) STOCK," _
                    & "P.RETAILPRICE,L.CATDESC,ISNULL(L.SCATDESC1,''),ISNULL(L.SCATDESC2,''),N.VENDORNAME,L.CATID,L.SCATID1,P.ID " _
                    & "FROM PRODUCTMASTER P,V_INOUTREPORT V,PRODUCTLEVELS L,VENDORS N " _
                    & "WHERE P.PLUID = V.PLUID AND P.PLUID=L.PLUID AND P.VENDORID=N.VENDORID"

            If cmbVendor.SelectedIndex > 0 Then
                PopulateReport &= " AND P.VENDORID=" & cmbVendor.SelectedValue
            End If

            If iCatID > 0 Then
                PopulateReport &= " AND L.CATID=" & iCatID
            End If

            If iSCatID > 0 Then
                PopulateReport &= " AND L.SCATID1=" & iSCatID
            End If

            If cmbCols.SelectedIndex > 0 Then

                If chkExact.Checked = True Then
                    PopulateReport &= " AND " & IIf(cmbCols.SelectedIndex = 1, "P.PLUCODE", "P.PLUNAME") & "='" & txtText.Text.Trim & "'"
                Else
                    PopulateReport &= " AND " & IIf(cmbCols.SelectedIndex = 1, "P.PLUCODE", "P.PLUNAME") & " LIKE '%" & txtText.Text.Trim & "%'"
                End If

            End If

            If chkRemoveZero.Checked Then

                PopulateReport &= " AND (V.INWARDS-V.SALES)>0"

            End If

            If chkERF.Checked = True Then
                If Val(txtFrom.Text) >= 0 And Val(txtTo.Text) >= 0 Then
                    PopulateReport &= " AND P.RETAILPRICE BETWEEN " & Val(txtFrom.Text) & " AND " & Val(txtTo.Text)
                End If
            End If

            If chkESF.Checked = True Then

                PopulateReport &= " AND P.ID IN (" & sizeList & ")"

                'If Val(txtFrom2.Text) >= 0 And Val(txtTo2.Text) >= 0 Then
                '    PopulateReport &= " AND CONVERT(INT,S.SIZE) BETWEEN " & Val(txtFrom2.Text) & " AND " & Val(txtTo2.Text)
                'End If

            End If

            PopulateReport &= " ORDER BY P.PLUNAME"

        ElseIf iReportType = 1 Then

            PopulateReport = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,P.UNITS,0,V.QTY,0," _
                            & "V.RATE,L.CATDESC,ISNULL(L.SCATDESC1,''),ISNULL(L.SCATDESC2,''),N.VENDORNAME,L.CATID,L.SCATID1,P.ID " _
                            & "FROM PRODUCTMASTER P,BILLDETAILS V,PRODUCTLEVELS L,VENDORS N " _
                            & "WHERE P.PLUID = V.PLUID AND P.PLUID=L.PLUID AND P.VENDORID=N.VENDORID AND V.QTY>0 AND " _
                            & "V.BILLDT BETWEEN '" & Format(dtpFr.Value, "yyyy-MM-dd") & "' AND '" _
                            & Format(dtpTo.Value, "yyyy-MM-dd") & "'"

            If cmbVendor.SelectedIndex > 0 Then
                PopulateReport &= " AND P.VENDORID=" & cmbVendor.SelectedValue
            End If

            If cmbCat.SelectedIndex > 0 Then
                PopulateReport &= " AND L.CATID=" & cmbCat.SelectedValue
            End If

            If cmbSCat.SelectedIndex > 0 Then
                PopulateReport &= " AND L.SCATID1=" & cmbSCat.SelectedValue
            End If

            If chkERF.Checked = True Then
                If Val(txtFrom.Text) >= 0 And Val(txtTo.Text) >= 0 Then
                    PopulateReport &= " AND V.RATE BETWEEN " & Val(txtFrom.Text) & " AND " & Val(txtTo.Text)
                End If
            End If

            If chkESF.Checked = True Then

                PopulateReport &= " AND P.ID IN (" & sizeList & ")"

            End If

            'If chkESF.Checked = True Then
            '    If Val(txtFrom2.Text) >= 0 And Val(txtTo2.Text) >= 0 Then
            '        PopulateReport &= " AND CONVERT(INT,S.SIZE) BETWEEN " & Val(txtFrom2.Text) & " AND " & Val(txtTo2.Text)
            '    End If
            'End If

            PopulateReport &= " ORDER BY P.PLUNAME"

            End If

    End Function

    Private Sub DisplayReport(iCatID As Short, iSCatID As Short, iSQL As String)

        pnlLoading.Visible = True : pnlLoading.Refresh()

        Dim INW_TOT As Double = 0
        Dim SAL_TOT As Double = 0
        Dim STK_TOT As Double = 0
        Dim AMT_TOT As Double = 0

        TG.SuspendLayout()

        TG.Rows.Clear()
        With ESSA.OpenReader(iSQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(3).Trim
                TG.Item(4, TG.Rows.Count - 1).Value = .Item(4)
                TG.Item(5, TG.Rows.Count - 1).Value = .Item(5)
                TG.Item(6, TG.Rows.Count - 1).Value = .Item(6)
                TG.Item(7, TG.Rows.Count - 1).Value = Format(.Item(7), "0.00")
                TG.Item(8, TG.Rows.Count - 1).Value = .GetString(8).Trim
                TG.Item(9, TG.Rows.Count - 1).Value = .GetString(9).Trim
                TG.Item(10, TG.Rows.Count - 1).Value = .GetString(10).Trim
                TG.Item(13, TG.Rows.Count - 1).Value = .GetString(11).Trim
                TG.Item(14, TG.Rows.Count - 1).Value = .GetString(14).Trim
                TG.Item(16, TG.Rows.Count - 1).Value = .Item(12)
                TG.Item(17, TG.Rows.Count - 1).Value = .Item(13)
                INW_TOT += Val(.Item(4))
                SAL_TOT += Val(.Item(5))
                STK_TOT += Val(.Item(6))
                AMT_TOT += Val(.Item(5)) * Val(.Item(7))
            End While
            .Close()
        End With

        TGTOT.Item(2, 0).Value = "GRAND TOTAL"
        TGTOT.Item(4, 0).Value = INW_TOT
        TGTOT.Item(5, 0).Value = SAL_TOT
        TGTOT.Item(6, 0).Value = STK_TOT
        TGTOT.Item(7, 0).Value = ""

        If chkSalesReport.Checked = True Then
            TGTOT.Item(6, 0).Value = "TOTAL"
            TGTOT.Item(7, 0).Value = Format(AMT_TOT, "0.00")
        End If

        TG.ResumeLayout()
        pnlLoading.Visible = False

    End Sub

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs)

        DisplayReport(0, 0, PopulateReport(0, 0, 0))

    End Sub

    Private Sub cmbCols_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCols.SelectedIndexChanged

        If cmbCols.SelectedIndex = 0 Then
            txtText.Enabled = False
        Else
            txtText.Enabled = True
        End If

    End Sub
    Private Sub btnAdvSearch_Click(sender As Object, e As EventArgs) Handles btnAdvSearch.Click

        pnlAdvanceSearch.Visible = True
        dtpFr.Focus()

    End Sub

    Private Sub btnDisplay2_Click(sender As Object, e As EventArgs) Handles btnDisplay2.Click

        pnlAdvanceSearch.Visible = False

        If chkSalesReport.Checked = True Then

            lblReportTitle.Text = "SALES REPORT"
            SQL = PopulateReport(0, 0, 1)
            DisplayReport(0, 0, SQL)

        Else

            Dim nCatID As Short = 0
            Dim SCatID As Short = 0

            If cmbCat.SelectedIndex > 0 Then
                nCatID = cmbCat.SelectedValue
            End If

            If cmbSCat.SelectedIndex > 0 Then
                SCatID = cmbSCat.SelectedValue
            End If

            SQL = PopulateReport(nCatID, SCatID, 0)
            DisplayReport(0, 0, SQL)
            lblReportTitle.Text = "STATUS REPORT"

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        cmbCat.SelectedIndex = 0
        cmbSCat.SelectedIndex = 0

    End Sub

    Private Sub btnReset2_Click(sender As Object, e As EventArgs) Handles btnReset2.Click

        cmbVendor.SelectedIndex = 0

    End Sub

    Private Sub chkERF_CheckedChanged(sender As Object, e As EventArgs) Handles chkERF.CheckedChanged

        txtFrom.Enabled = chkERF.Checked
        txtTo.Enabled = chkERF.Checked

        If chkERF.Enabled = True Then
            txtFrom.Focus()
        End If

    End Sub

    Private Sub chkESF_CheckedChanged(sender As Object, e As EventArgs) Handles chkESF.CheckedChanged

        txtFrom2.Enabled = chkESF.Checked
        txtTo2.Enabled = chkESF.Checked

        If chkESF.Enabled = True Then
            txtFrom2.Focus()
        End If

        LstSize.Enabled = chkESF.Checked

    End Sub

    Private Sub chkSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkSelectAll.CheckedChanged

        For i As Short = 0 To LstSize.Items.Count - 1

            LstSize.SetItemChecked(i, chkSelectAll.Checked)

        Next

    End Sub

    Private Sub chkSalesReport_CheckedChanged(sender As Object, e As EventArgs) Handles chkSalesReport.CheckedChanged

        chkRemoveZero.Visible = Not chkSalesReport.Checked

    End Sub

End Class