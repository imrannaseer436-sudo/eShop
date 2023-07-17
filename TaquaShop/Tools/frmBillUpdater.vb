Imports System.Data.SqlClient

Public Class frmBillUpdater

    Private BillId As Long = 0
    Private TermId As Short = 0

    Private Sub frmBillUpdater_Load(sender As Object, e As EventArgs) Handles Me.Load

        ESSA.AlignCenter(Me, MainWindow)

        SQL = "SELECT PAYMENTID,PAYMENTDESC FROM PAYMENTTYPE ORDER BY PAYMENTID"
        ESSA.LoadCombo(cmbPmtType, SQL, "PAYMENTDESC", "PAYMENTID")

        txtBillNo.Focus()
        GetShopAddress()

    End Sub

    Private Sub btnLoad2_Click(sender As Object, e As EventArgs) Handles btnLoad2.Click

        If txtBillNo.Text = "" Then
            MsgBox("Please fill the billno..!", MsgBoxStyle.Critical)
            txtBillNo.Focus()
            Exit Sub
        End If

        BillId = GetBillId(txtBillNo.Text)

        If BillId = 0 Then
            MsgBox("please enter valid bill no..!", MsgBoxStyle.Critical)
            txtBillNo.SelectAll()
            txtBillNo.Focus()
            Exit Sub
        End If

        SQL = "SELECT TotAmt, TermId FROM BillMaster WHERE BillId = " & BillId

        With ESSA.OpenReader(SQL)

            If .Read Then

                LblBillAmt.Text = Format(.Item(0), "0.00")
                TermId = .Item(1)

            End If
            .Close()
        End With

        SQL = "SELECT PaymentId, PaymentDesc, RefNo, RefDt, Paid, Refund FROM BillPayments WHERE BillId =" & BillId

        With ESSA.OpenReader(SQL)
            dgvPmt.Rows.Clear()
            While .Read

                Dim row = dgvPmt.Rows.Add
                dgvPmt.Item(0, row).Value = .Item(0)
                dgvPmt.Item(1, row).Value = .GetString(1)
                dgvPmt.Item(2, row).Value = .GetString(2)
                dgvPmt.Item(3, row).Value = Format(.GetDateTime(3), "dd-MM-yyyy")
                dgvPmt.Item(4, row).Value = .Item(4)
                dgvPmt.Item(5, row).Value = .Item(5)

            End While
            .Close()
        End With

    End Sub

    'Private Function GetBillId2(input As String) As Long

    '    SQL = "SELECT BillId FROM BillMaster WHERE TermId =" & cmbTermId.Text & " AND BillNo = " & Val(txtBillNo.Text) & " AND " _
    '        & "BillDt ='" & Format(Now.Date, "yyyy-MM-dd") & "'"

    '    With ESSA.OpenReader(SQL)

    '        If .Read Then
    '            GetBillId2 = .Item(0)
    '        Else
    '            GetBillId2 = 0
    '        End If
    '        .Close()
    '    End With

    '    Return GetBillId2

    'End Function

    Private Sub txtPAmt_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPAmt.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Val(txtPAmt.Text) = 0 Then
                MsgBox("Invalid payment amount..!", MsgBoxStyle.Critical)
                txtPAmt.Focus()
                Exit Sub
                'ElseIf cmbPmtType.SelectedIndex > 0 Then
                '    If Val(txtPAmt.Text) + PaymentTotal() > Val(LblBillAmt.Text) Then
                '        MsgBox("Payment amount is higher than required..!", MsgBoxStyle.Critical)
                '        txtPAmt.Text = Format(Val(LblBillAmt.Text) - PaymentTotal(), "0.00")
                '        Exit Sub
                '    End If
            ElseIf Val(txtPAmt.Text) + PaymentTotal() > Val(LblBillAmt.Text) Then
                MsgBox("Payment amount is higher than required..!", MsgBoxStyle.Critical)
                txtPAmt.Text = Format(Val(LblBillAmt.Text) - PaymentTotal(), "0.00")
                Exit Sub
            End If

            Dim NRI = ESSA.FindGridIndex(dgvPmt, 0, cmbPmtType.SelectedValue)
            If NRI = -1 Then NRI = dgvPmt.Rows.Add

            dgvPmt.Item(0, NRI).Value = cmbPmtType.SelectedValue
            dgvPmt.Item(1, NRI).Value = cmbPmtType.Text
            dgvPmt.Item(2, NRI).Value = txtRefNo.Text
            dgvPmt.Item(3, NRI).Value = Format(dtpRef.Value, "dd/MM/yyyy")
            dgvPmt.Item(4, NRI).Value = Format(Val(txtPAmt.Text), "0.00")

            If Val(txtPAmt.Text) > Val(LblBillAmt.Text) Then
                dgvPmt.Item(5, NRI).Value = Format(Val(txtPAmt.Text) - Val(LblBillAmt.Text), "0.00")
            Else
                dgvPmt.Item(5, NRI).Value = 0
            End If

            txtRefNo.Clear()
            txtPAmt.Clear()
            cmbPmtType.Focus()

            If PaymentTotal() = Val(LblBillAmt.Text) Then
                btnUpdate2.PerformClick()
            End If

        End If

    End Sub

    Public Function PaymentTotal() As Double

        PaymentTotal = 0
        For i As SByte = 0 To dgvPmt.Rows.Count - 1
            PaymentTotal += Val(dgvPmt.Item(4, i).Value)
        Next

    End Function

    Private Sub txtPAmt_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPAmt.KeyUp

        If e.KeyCode = Keys.Left Then
            cmbPmtType.Focus()
        End If

    End Sub

    Private Sub txtBillNo_KeyDown(sender As Object, e As KeyEventArgs) Handles txtBillNo.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnLoad2.PerformClick()
            cmbPmtType.Focus()
        End If

    End Sub

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click

        If PaymentTotal() <> Val(LblBillAmt.Text) Then
            MsgBox("Payment amount is either exceeding or falling behind required amount..!", MsgBoxStyle.Critical)
            cmbPmtType.Focus()
            Exit Sub
        ElseIf BillId = 0 Then
            MsgBox("Invalid bill number..!", MsgBoxStyle.Critical)
            txtBillNo.Focus()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim cmd = Con.CreateCommand
        Dim trn = Con.BeginTransaction
        cmd.Transaction = trn

        Try

            SQL = "DELETE FROM BillPayments WHERE BillId =" & BillId
            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

            For j As SByte = 0 To dgvPmt.Rows.Count - 1

                SQL = "insert into billpayments values (" _
                    & BillId & "," _
                    & ShopID & "," _
                    & Val(dgvPmt.Item(0, j).Value) & ",'" _
                    & dgvPmt.Item(1, j).Value & "'," _
                    & Val(dgvPmt.Item(4, j).Value) & "," _
                    & Val(dgvPmt.Item(5, j).Value) & ",'" _
                    & dgvPmt.Item(2, j).Value & "','" _
                    & Format(CDate(dgvPmt.Item(3, j).Value), "yyyy-MM-dd") & "'," _
                    & j + 1 & "," _
                    & TermId & ",'" _
                    & Format(Now.Date, "yyyy-MM-dd") & "',0,1)"

                cmd.CommandText = SQL
                cmd.ExecuteNonQuery()

            Next

            trn.Commit()
            SendFileToPrinter(BillId, 2)
            Con.Close()

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
            trn.Rollback()
            Con.Close()

        End Try

        RefreshForm()

    End Sub

    Private Sub RefreshForm()

        txtBillNo.Clear()
        txtRefNo.Clear()
        txtPAmt.Clear()
        dgvPmt.Rows.Clear()
        BillId = 0
        TermId = 0
        txtBillNo.Focus()

    End Sub

    Private PaymentDesc As String = ""
    Private CopyName As String = ""

    Private Sub SendFileToPrinter(iBillID As Long, iCopies As SByte)

        PrintBillGST(iBillID, iCopies)

        If POSPrinterName = "RP4200" Then
            RawPrinterHelper.SendFileToPrinter(POSPrinterName, TempFilePath & "PrintFile.prn")
        Else
            Process.Start(TempFilePath & "PrintFile.bat")
        End If

    End Sub

    Private Msg As String = ""

    Private pName As String = ""
    Private pAdd1 As String = ""
    Private pAdd2 As String = ""
    Private pCity As String = ""
    Private pPhon As String = ""
    Private pGSTN As String = ""

    Private Sub GetShopAddress()

        SQL = "select alias,address1,address2,city,state,phone,cst from shops where shopid=" & ShopID
        With ESSA.OpenReader(SQL)
            If .Read Then
                pName = .GetString(0).Trim
                pAdd1 = .GetString(1).Trim
                pAdd2 = .GetString(2).Trim
                pCity = .GetString(3).Trim & ", " & .GetString(4).Trim & " CODE: 33"
                pPhon = .GetString(5).Trim
                pGSTN = .GetString(6).Trim
            End If
        End With

    End Sub

    Dim tBillNo As String = ""
    Dim pmtTable As New DataTable
    Dim hideTerminal As Boolean = False

    Private Sub PrintBillGST(iBillID As Long, iCopies As SByte)

        FileOpen(1, TempFilePath & "PrintFile.prn", OpenMode.Output)
        For i As SByte = 1 To iCopies

            If i = 1 Then
                CopyName = "Duplicate"
            ElseIf i = 2 Then
                CopyName = "Original"
            End If

            Print(1, Chr(27) & "@")
            PrintLine(1, Chr(27) & "a1" & Chr(27) & "E1 " & "ESSA" & Chr(27) & "E0")
            PrintLine(1, Chr(27) & "!8 " & pName)
            Print(1, Chr(27) & "@")
            PrintLine(1, Chr(27) & "a1" & pAdd1)
            If pAdd2.Length > 0 Then PrintLine(1, pAdd2)
            PrintLine(1, pCity)
            PrintLine(1, "Phone: " & pPhon)
            PrintLine(1, "GSTIN: " & pGSTN)
            PrintLine(1, Chr(27) & "!1" & " TAX INVOICE")
            Print(1, Chr(27) & "@")
            PrintLine(1, Chr(27) & "a1 " & CopyName & Chr(27) & "a0")

            SQL = "select termid,billno,billtime,refno from billmaster where billid=" & iBillID

            With ESSA.OpenReader(SQL)
                If .Read Then


                    If HideTerminal = True Then
                        tBillNo = " Bill No: " & .Item(1) & " "
                        Print(1, Chr(27) & "E1" & " Bill No: " & .Item(1))
                    Else
                        tBillNo = " Bill No: T" & .Item(0) & "-" & .Item(1) & " "
                        Print(1, Chr(27) & "E1" & " Bill No: T" & .Item(0) & "-" & .Item(1))
                    End If

                    Msg = "Date: " & Format(.GetDateTime(2), "dd-MM-yyyy hh:mm tt")
                    Print(1, TAB(72 - Msg.Length), Msg)
                    Print(1, Chr(27), "E0")
                    If .GetString(3).Trim.Length > 0 Then
                        Print(1, Chr(27) & "@")
                        PrintLine(1, " Ref No:   " & .GetString(3).Trim)
                    End If
                End If
                .Close()
            End With

            SQL = "select paymentdesc,paid from billpayments where billid=" & iBillID & " order by sno"
            ESSA.OpenConnection()
            Using Adp As New SqlDataAdapter(SQL, Con)
                pmtTable.Clear()
                Adp.Fill(pmtTable)
            End Using
            Con.Close()

            Print(1, Chr(27) & "@")
            PrintLine(1, " --------------------------------------------------------------------")
            Print(1, Chr(27) & "E1")
            PrintLine(1, " SNO  DESCRIPTION                      QTY     RATE    D.AMT   AMOUNT")
            Print(1, Chr(27) & "E0")
            PrintLine(1, " --------------------------------------------------------------------")

            'SQL = " select p.pluname,d.qty,d.orate,d.amount,p.plucode,h.hsncode,h.utax" _
            '    & " from billdetails d,productmaster p,v_producthsn h" _
            '    & " where d.pluid=p.pluid and d.pluid=h.pluid and d.billid=" & iBillID _
            '    & " order by d.sno"

            'NEW CODE : YASEEN

            'SQL = "SELECT M.Pluname,D.Qty,D.Rate,D.Amount,M.PluCode,M.HSNCode,ISNULL(T.Mn,5) Mn,ISNULL(T.Mx,5) Mx, ISNULL(T.Val,1000) Val " _
            '       & "FROM BillDetails D, ProductMaster M, ProductAttributes A,ProductTax T " _
            '       & "WHERE D.PluID = M.PluID AND M.PluID = A.PluId AND " _
            '       & "T.DeptId = A.DeptId AND T.CatId = A.CatId AND T.MatId = A.MaterialId AND D.BillId = " _
            '       & iBillID & " ORDER BY D.SNO"

            SQL = "SELECT DISTINCT M.Pluname,D.Qty,D.ORate,D.Amount,M.PluCode,M.HSNCode,ISNULL(T.Mn,5) Mn,ISNULL(T.Mx,5) Mx, ISNULL(T.Val,1000) Val,D.PluID,D.Rate,D.SNo " _
                & "FROM BillDetails D, ProductMaster M, ProductAttributes A,ProductTax T  " _
                & "WHERE D.PluID = M.PluID AND M.PluID = A.PluId AND " _
                & "T.DeptId = A.DeptId AND T.CatId = A.CatId AND T.MatId = A.MaterialId  AND D.BillID = " _
                & iBillID & " ORDER BY D.SNo"


            ' OLD CODE : ABU
            'SQL = " select p.pluname,d.qty,d.rate,d.amount,p.plucode,p.hsncode,p.utax" _
            '    & " from billdetails d,productmaster p " _
            '    & " where d.pluid=p.pluid and d.billid=" & iBillID _
            '    & " order by d.sno"

            Dim TaxTot As Double = 0
            Dim IGSTot As Double = 0
            Dim SGSTot As Double = 0

            Dim Tot As Double = 0
            Dim Sno As Short = 1
            Dim Amt As Double = 0
            Dim Per As Double = 0
            Dim Hlf As Double = 0
            Dim Tax As Double = 0
            Dim Qty As Double = 0
            Dim Msg2 As String = ""
            Dim VAR_DISCOUNT As Double = 0
            Dim VAR_SUBTOTAL As Double = 0

            With ESSA.OpenReader(SQL)
                While .Read

                    Print(1, TAB(2), Sno)

                    Msg = Mid(.GetString(4).Trim & "/" & .GetString(0).Trim, 1, 28)
                    Print(1, TAB(7), Msg)

                    Msg = .Item(1)
                    Print(1, TAB(43 - Msg.Length), Msg)

                    Amt = .Item(1) * .Item(2)
                    Msg = Format(.Item(2), "0.00")
                    Print(1, TAB(52 - Msg.Length), Msg)

                    Msg = Format(Amt - .Item(3), "0.00")
                    Print(1, TAB(61 - Msg.Length), Msg)

                    VAR_SUBTOTAL += Amt
                    VAR_DISCOUNT += (Amt - .Item(3))

                    Msg = Format(.Item(3), "0.00")
                    PrintLine(1, TAB(70 - Msg.Length), Msg)

                    'GST TAX PRINT OUT : BEGIN

                    If Val(.Item(10)) >= Val(.Item(8)) Then
                        Per = .Item(7)
                        Hlf = .Item(7) * 0.5
                    Else
                        Per = .Item(6)
                        Hlf = .Item(6) * 0.5
                    End If

                    'If .Item(6) = 1 Then
                    '    Per = 5.0F
                    '    Hlf = 2.5F
                    'Else
                    '    Per = IIf(.Item(2) >= 1000, 12.0F, 5.0F)
                    '    Hlf = IIf(.Item(2) >= 1000, 6.0F, 2.5F)
                    'End If

                    Tax = (.Item(3) / (100 + Per)) * 100

                    If Tax > 0 Then

                        TaxTot += Tax
                        IGSTot += ((Tax * Hlf) / 100)
                        SGSTot += ((Tax * Hlf) / 100)

                    End If

                    Msg = Format(Tax, "0.00")
                    Msg2 = Format(Hlf, "0.00") & " %: " & Format((Tax * Hlf) / 100, "0.00")
                    PrintLine(1, TAB(7), Chr(27) & "M1" & "SALE : " & Msg, TAB(26), "CGST " & Msg2 & Chr(27) & "M0")

                    Msg = .GetString(5).Trim
                    Msg2 = Format(Hlf, "0.00") & " %: " & Format((Tax * Hlf) / 100, "0.00")
                    PrintLine(1, TAB(7), Chr(27) & "M1" & "HSN  : " & Msg, TAB(26), "SGST " & Msg2 & Chr(27) & "M0")

                    'GST TAX PRINT OUT : END

                    Tot += .Item(3)
                    If .Item(1) > 0 Then
                        Qty += .Item(1)
                    End If
                    Sno += 1

                End While

                PrintLine(1, " --------------------------------------------------------------------" & Chr(27) & "!1")

                Msg = Format(VAR_SUBTOTAL, "0.00")
                Msg2 = Format(Qty, "0")

                If VAR_DISCOUNT > 0 Then

                    Msg = Format(VAR_DISCOUNT, "0.00")
                    PrintLine(1, " ITEMS:" & Msg2, TAB(20), "DISCOUNT", TAB(47 - Msg.Length), Msg)

                    Msg = Format(Tot, "0.00")
                    PrintLine(1, TAB(20), "BILL AMOUNT", TAB(47 - Msg.Length), Msg)

                Else

                    Msg = Format(Tot, "0.00")
                    PrintLine(1, " ITEMS:" & Msg2, TAB(20), "BILL AMOUNT", TAB(47 - Msg.Length), Msg)

                End If

                PrintLine(1, Chr(27) & "@" & " --------------------------------------------------------------------")
                PrintLine(1, TAB(2), "SALE AMOUNT : " & Format(TaxTot, "0.00"), TAB(26), "CGST : " & Format(IGSTot, "0.00"), TAB(43), "SGST : " & Format(SGSTot, "0.00"))
                PrintLine(1)
                Print(1, TAB(2), "E.& O.E")
                Msg = PaymentDesc
                For p As SByte = 0 To pmtTable.Rows.Count - 1
                    Msg = pmtTable.Rows(p).Item(0) & " / " & Format(Val(pmtTable.Rows(p).Item(1)), "0.00")
                    PrintLine(1, TAB(70 - Msg.Length), Msg)
                Next
                'PrintLine(1)
                'PrintLine(1, Chr(27) & "a1" & Chr(27) & "E1 " & "THANK YOU, VISIT AGAIN !" & Chr(27) & "E0")
                'PrintLine(1)   
                PrintLine(1)
                Dim PrintString = getBarcodeStr(iBillID) + vbCrLf
                Print(1, Chr(27) & "a1" & PrintString)

                PrintLine(1, Chr(27) & "a1" & Chr(27) & "!1 " & tBillNo)
                PrintLine(1, Chr(27) & "@")
                PrintLine(1, Chr(27) & "a1" & Chr(27) & "E1 " & "THANK YOU, VISIT AGAIN !" & Chr(27) & "E0")
                PrintLine(1)
                PrintLine(1)
                PrintLine(1)
                PrintLine(1)
                PrintLine(1, Chr(27) & "@" & Chr(29) & "V" + Chr(1))
                .Close()
            End With

        Next

        FileClose(1)

    End Sub

    Public GS As String = Chr(&H1D)

    Public Function getBarcodeStr(ibillId As Long) As String

        getBarcodeStr = ""
        SQL = "SELECT TermId , BillNo  FROM BillMaster WHERE BillId =" & ibillId

        With ESSA.OpenReader(SQL)
            If .Read Then

                Dim billNo As String = "T" & .Item(0) & "-" & .Item(1)
                getBarcodeStr = GS & "h" & Chr(80) 'Bardcode Hieght
                getBarcodeStr = getBarcodeStr & GS & "w" & Chr(1) 'Barcode Width
                getBarcodeStr = getBarcodeStr & GS & "f" & Chr(0) 'Font for HRI characters
                getBarcodeStr = getBarcodeStr & GS & "H" & Chr(2) 'Position of HRI characters
                getBarcodeStr = getBarcodeStr & GS & "k" & Chr(69) & Chr(Len(billNo)) 'Print Barcode Smb 39
                getBarcodeStr = getBarcodeStr & billNo & Chr(0) & vbCrLf 'Print Text Under
                getBarcodeStr = getBarcodeStr & GS & "d" & Chr(3) '& vbCrLf
                'getBarcodeStr = getBarcodeStr & GS & "@"
                Return getBarcodeStr

            End If
            .Close()
        End With

    End Function

    Private Sub LblClose_Click(sender As Object, e As EventArgs) Handles LblClose.Click

        Me.Close()

    End Sub

    Private Sub LblMin_Click(sender As Object, e As EventArgs) Handles LblMin.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub frmBillUpdater_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown

        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            If Me.ActiveControl.Tag <> "1" Then
                e.SuppressKeyPress = True
                Me.ProcessTabKey(True)
            End If
        End If

    End Sub

    Private Sub cmbPmtType_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmbPmtType.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            cmbPmtType.SelectedIndex = cmbPmtType.FindStringExact(cmbPmtType.Text)
            If cmbPmtType.SelectedIndex = -1 Then
                MsgBox("Incorrect payment mode..!", MsgBoxStyle.Critical)
                Exit Sub
            End If

            Dim Amt = Val(LblBillAmt.Text) - PaymentTotal()

            If cmbPmtType.SelectedIndex = 0 Then
                txtPAmt.Text = Format(Amt, "0.00")
                txtRefNo.Enabled = False
                dtpRef.Enabled = False
                txtPAmt.Focus()
            Else
                txtPAmt.Text = Format(Amt, "0.00")
                txtRefNo.Enabled = True
                dtpRef.Enabled = True
                txtRefNo.Focus()
            End If

        End If

    End Sub

    Private Function GetBillId(input As String) As Long

        Dim termId = input.Chars(1)
        Dim billNo = input.Substring(3)

        SQL = "SELECT BillId FROM BillMaster WHERE TermId =" & Val(termId) & " AND BillNo = " & Val(billNo) & " AND " _
            & "BillDt ='" & Format(Now.Date, "yyyy-MM-dd") & "'"

        With ESSA.OpenReader(SQL)

            If .Read Then
                GetBillId = .Item(0)
            Else
                GetBillId = 0
            End If
            .Close()
        End With

        Return GetBillId

    End Function

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click

        dgvPmt.Rows.Clear()

    End Sub

End Class