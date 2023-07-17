Imports System.Data.SqlClient
Imports System.Net

Public Class DayEnd

    Private Rpt As New DayEndReport
    Private Url As String = ""
    Private BillCount As Integer = 0

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    'Private Function billCount(value As String) As Integer

    '    If value = "" Then Return 0

    '    Dim parts = value.Split("-")
    '    Dim one = Val(parts(0))
    '    Dim two = Val(parts(1))

    '    Return two - one

    'End Function

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If mebnbd.Value < Now.Date Then
            MsgBox("Sorry, Next business date should not below or same date..!", vbCritical)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        If chkdhb.Checked = True Then
            SQL = "DELETE FROM BILLDETAILSHOLD"
            ESSA.Execute(SQL)
        End If

        SQL = $"update shopsettings set businessdate='{ Format(mebnbd.Value, "yyyy-MM-dd") }' where shopid = {ShopID}"

        ESSA.Execute(SQL)

        'SQL = "update settings set param_value='" & Format(mebnbd.Value, "yyyy-MM-dd") & "' where param_name='BusinessDate'"
        'ESSA.Execute(SQL)

        'Dim iExp As New iBillExporter
        'iExp.GenerateDateFiles(DateAdd(DateInterval.Day, -1, mebnbd.Value))

        SQL = "SELECT PAYMENTTYPE,SUM(SALES-RFUND) AMT FROM V_PAYMENTSUMMARY WHERE ShopId = " & ShopID & " AND BILLDT='" & Format(Now.Date, "yyyy-MM-dd") & "'" _
            & " GROUP BY PAYMENTTYPE;" _
            & "Select Case(M.RackNo) " _
            & "When '0' THEN 'GROUND FLOOR' " _
            & "When '1' THEN 'FIRST FLOOR' " _
            & "When '2' THEN 'SECOND FLOOR' " _
            & "When '3' THEN 'THIRD FLOOR' " _
            & "ELSE 'UNKNOWN' " _
            & "End [Floor], CONVERT(int,SUM (D.Amount)) [Sales] " _
            & "FROM " _
            & "BillDetails D, ProductMaster M " _
            & "WHERE D.PluID = M.PluID And D.ShopId = " & ShopID & " AND D.BillDt = '" & Format(Now.Date, "yyyy-MM-dd") & "' " _
            & "GROUP BY M.RackNo "
        '& "SELECT TermId, Description, " _
        '& "CONVERT(VARCHAR, BMin) + '-' + CONVERT(VARCHAR, BMax) [Range]," _
        '& "BMax - BMin [Count] " _
        '& "FROM V_BillSeries2 " _
        '& "WHERE BillDt = '" & Format(mebnbd.Value, "yyyy-MM-dd") & "' " _
        '& "ORDER BY TermId"

        With ESSA.OpenReader(SQL)

            While .Read

                If .GetString(0).Trim = "CARD" Then
                    lblCard.Text = Format(.Item(1), "0.00")
                Else
                    lblCash.Text = Format(.Item(1), "0.00")
                End If

            End While

            .NextResult()

            dgvTerm.Rows.Clear()
            While .Read
                dgvTerm.Rows.Add()
                dgvTerm.Item(0, dgvTerm.Rows.Count - 1).Value = .GetString(0).Trim
                dgvTerm.Item(1, dgvTerm.Rows.Count - 1).Value = .Item(1)
            End While

            'TermTable.Columns.Clear()
            'TermTable.Columns.Add("TermId", Type.GetType("System.String"))
            'TermTable.Columns.Add("Range", Type.GetType("System.String"))
            'TermTable.Columns.Add("Count", Type.GetType("System.Int32"))

            'If .Read Then
            '    dgvTerm.Rows.Clear()
            '    For i As SByte = 0 To .FieldCount - 1
            '        TermTable.Rows.Add()
            '        dgvTerm.Rows.Add()
            '        dgvTerm.Item(0, dgvTerm.Rows.Count - 1).Value = FloorList.Item(Mid(.GetName(i), 2, 1))
            '        dgvTerm.Item(1, dgvTerm.Rows.Count - 1).Value = .GetString(i).Trim
            '        dgvTerm.Item(2, dgvTerm.Rows.Count - 1).Value = billCount(.GetString(i).Trim)

            '        Dim NewRow = TermTable.NewRow
            '        NewRow(0) = FloorList.Item(Mid(.GetName(i), 2, 1))
            '        NewRow(1) = .GetString(i).Trim
            '        NewRow(2) = billCount(.GetString(i).Trim)
            '        TermTable.Rows.Add(NewRow)
            '    Next
            'End If

            'If .Read Then
            '    lblTerm1.Text = Replace(.GetString(0).Trim, "-", " To ")
            '    lblTerm2.Text = Replace(.GetString(1).Trim, "-", " To ")
            'End If

            .Close()

        End With

        lblTotal.Text = Format(Val(lblCash.Text) + Val(lblCard.Text), "0.00")

        SQL = "SELECT COUNT(DISTINCT BillID) FROM BillDetails WHERE ShopID = " & ShopID & " AND BillDt = '" & Format(Now.Date, "yyyy-MM-dd") & "' "

        With ESSA.OpenReader(SQL)
            If .Read Then
                BillCount = .Item(0)
            End If
            .Close()
        End With

        Me.Cursor = Cursors.Arrow
        'If MsgBox("Congratualtions, Day end has been completed successfully" & vbCrLf & "Do you want to print summary..?", vbQuestion + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    Dim p As New iPrinter
        '    p.PrintDayEndReport(DateAdd(DateInterval.Day, -1, mebnbd.Value))
        'End If
        'Me.Close()
        btnUpdate.Enabled = False

    End Sub

    'Private FloorList As New Collection


    Private TempFilePath As String = ""
    Private PRINTER_READY As Boolean = True
    Private Sub DayEnd_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'FloorList.Add("Ground", "1")
        'FloorList.Add("Ground", "2")
        'FloorList.Add("Kids", "4")
        'FloorList.Add("Sarees", "5")
        'FloorList.Add("Mens", "6")

        TempFilePath = Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine) & "\"

        If System.IO.File.Exists(TempFilePath & "PrintFile.bat") = False Then
            PRINTER_READY = False
        Else
            PRINTER_READY = True
        End If

        Dim OS_NAME As String = My.Computer.Info.OSFullName.Trim
        If OS_NAME.Contains("Windows 7") Then
            chkDosPrinter.Checked = True
        Else
            chkDosPrinter.Checked = False
        End If

        mebnbd.Value = DateAdd(DateInterval.Day, 1, Now.Date)
        BillCount = 0
        LoadSms()

    End Sub

    Private Sub btnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMin.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub btnClose_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If chkDosPrinter.Checked = True Then

            If PRINTER_READY = True Then
                PRINT_DAYEND_REPORT()
            End If

        Else

            If chkFloorwise.Checked Then

                SQL = "Select Case(M.RackNo) " _
                & "When '0' THEN 'GROUND FLOOR' " _
                & "When '1' THEN 'FIRST FLOOR' " _
                & "When '2' THEN 'SECOND FLOOR' " _
                & "When '3' THEN 'THIRD FLOOR' " _
                & "ELSE 'UNKNOWN' " _
                & "End [Floor], Convert(int,SUM (D.Amount)) [Sales] " _
                & "FROM " _
                & "BillDetails D, ProductMaster M " _
                & "WHERE D.PluID = M.PluID And D.BillDt = '" & Format(Now.Date, "yyyy-MM-dd") & "' " _
                & "GROUP BY M.RackNo "

                'SQL = "SELECT Description TermId, " _
                '    & "CONVERT(VARCHAR, BMin) + '-' + CONVERT(VARCHAR, BMax) [Range]," _
                '    & "BMax - BMin [Count] " _
                '    & "FROM V_BillSeries2 " _
                '    & "WHERE BillDt = '" & Format(mebnbd.Value, "yyyy-MM-dd") & "' " _
                '    & "ORDER BY TermId"

                ESSA.OpenConnection()
                Using Adp As New SqlDataAdapter(SQL, Con)
                    Using TermTable As New DataTable
                        Adp.Fill(TermTable)
                        Rpt.Subreports(0).SetDataSource(TermTable)
                    End Using
                End Using
                Con.Close()

                'Rpt.SetParameterValue("BillCount", BillCount, "rptTerminalWise.rpt")

            End If

            Rpt.SetParameterValue("BillCount", BillCount, "rptTerminalWise.rpt")

            Rpt.SetParameterValue("Shop", ShopName)
            Rpt.SetParameterValue("Date", Now.Date)

            Rpt.SetParameterValue("Cash", Val(lblCash.Text))
            Rpt.SetParameterValue("Card", Val(lblCard.Text))

            'Rpt.SetParameterValue("Term1", lblTerm1.Text)
            'Rpt.SetParameterValue("Term2", lblTerm2.Text)

            Rpt.SetParameterValue("Bank", Val(lblCash.Text))
            Rpt.SetParameterValue("User", UserName)

            'frmReportViewer.CRViewer.ReportSource = Rpt
            'frmReportViewer.Visible = False
            'frmReportViewer.Show()
            Rpt.PrintToPrinter(Val(txtCopies.Text), True, 1, 1)

        End If

    End Sub

    Private Sub txtPhone_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPhone.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If txtPhone.Text.Trim.Length <> 10 Then
                MsgBox("Sorry, Mobile number should not exceed 10 digit..!", MsgBoxStyle.Information)
                txtPhone.SelectAll()
                txtPhone.Focus()
                Exit Sub
            ElseIf IsNumeric(txtPhone.Text) = False Then
                MsgBox("Sorry, Mobile number should be in numbers..!", MsgBoxStyle.Information)
                txtPhone.SelectAll()
                txtPhone.Focus()
                Exit Sub
            ElseIf lstPhone.FindStringExact(txtPhone.Text) <> -1 Then
                txtPhone.Clear()
                Exit Sub
            End If

            SQL = "insert into dayendsms values ('91" & txtPhone.Text.Trim & "')"
            ESSA.Execute(SQL)
            lstPhone.Items.Add("91" & txtPhone.Text)
            txtPhone.Clear()

        End If

    End Sub

    Private Sub LoadSms()

        SQL = "select phone from dayendsms"
        lstPhone.Items.Clear()
        With ESSA.OpenReader(SQL)
            While .Read
                lstPhone.Items.Add(.GetString(0).Trim)
            End While
            .Close()
        End With
        'ESSA.LoadListSimple(lstPhone, SQL, "phone", "")

    End Sub

    Private Sub SendSMS(ByVal iPhone As String)

        Dim request As HttpWebRequest
        Dim response As HttpWebResponse = Nothing
        Dim url As String

        Dim SCode As String = IIf(ShopID = 2, "TS-RPT", "TS-TUP")

        Dim GroundFloor As String = ""
        Dim FirstFloor As String = ""
        Dim SecondFloor As String = ""
        Dim ThirdFloor As String = ""
        Dim UNKNOWN As String = ""

        'Dim term1 As String = ""
        'Dim term2 As String = ""

        'If dgvTerm.Rows.Count > 0 Then
        '    term1 = dgvTerm.Item(1, 0).Value
        '    term2 = dgvTerm.Item(2, 0).Value
        'End If

        If dgvTerm.Rows.Count > 0 Then

            For i As Short = 0 To dgvTerm.Rows.Count - 1

                Select Case dgvTerm.Item(0, i).Value
                    Case "GROUND FLOOR"
                        GroundFloor = dgvTerm.Item(1, i).Value
                    Case "FIRST FLOOR"
                        FirstFloor = dgvTerm.Item(1, i).Value
                    Case "SECOND FLOOR"
                        SecondFloor = dgvTerm.Item(1, i).Value
                    Case "THIRD FLOOR"
                        ThirdFloor = dgvTerm.Item(1, i).Value
                    Case "UNKNOWN"
                        UNKNOWN = dgvTerm.Item(1, i).Value
                End Select

            Next

        End If

        'Dim message As String = ShopName & vbCrLf & Format(Now.Date, "dd-MMM-yyyy") & vbCrLf & "Total:" & Val(lblTotal.Text) & vbCrLf & "Card : " _
        '                      & Val(lblCard.Text) & vbCrLf & "Bank Cash: " & Val(lblCash.Text) _
        '                      & vbCrLf & "T1: " & term1 & vbCrLf _
        '                      & IIf(term2.Length > 0, "T2:" & term2, "")

        'Dim message As String = ShopName & vbCrLf & Format(Now.Date, "dd-MMM-yyyy") & vbCrLf & "Total:" & Val(lblTotal.Text) & vbCrLf & "Card : " _
        '                      & Val(lblCard.Text) & vbCrLf & "Bank Cash: " & Val(lblCash.Text) & vbCrLf _
        '                      & IIf(GroundFloor.Length > 0, "Ground Floor: " & GroundFloor & vbCrLf, "") _
        '                      & IIf(FirstFloor.Length > 0, "First Floor: " & FirstFloor & vbCrLf, "") _
        '                      & IIf(SecondFloor.Length > 0, "Second Floor: " & SecondFloor & vbCrLf, "") _
        '                      & IIf(ThirdFloor.Length > 0, "Third Floor: " & ThirdFloor & vbCrLf, "") _
        '                      & IIf(UNKNOWN.Length > 0, "Unknown: " & UNKNOWN, "")

        Dim message As String = "ESSA GARMENTS PRIVATE LIMITED, " & ShopCode & " (" & Format(Now.Date, "dd-MMM-yyyy") & ")" & vbCrLf & "Total:" & Val(lblTotal.Text) & vbCrLf & "Card:" _
                              & Val(lblCard.Text) & vbCrLf & "Bank Cash:" & Val(lblCash.Text) & vbCrLf _
                              & IIf(GroundFloor.Length > 0, "GF:" & GroundFloor, "GF:0.00") & vbCrLf _
                              & IIf(FirstFloor.Length > 0, "FF:" & FirstFloor, "FF:0.00") & vbCrLf _
                              & IIf(SecondFloor.Length > 0, "SF:" & SecondFloor, "SF:0.00") & vbCrLf _
                              & IIf(ThirdFloor.Length > 0, "TF:" & ThirdFloor, "TF:0.00")

        'MsgBox(message)
        'Exit Sub

        Try

            SmsApiUrl = Replace(SmsApiUrl, "@PhNo", iPhone)
            url = Replace(SmsApiUrl, "@Text", message)

            request = DirectCast(WebRequest.Create(url), HttpWebRequest)
            response = DirectCast(request.GetResponse(), HttpWebResponse)

        Catch ex As Exception

            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        If response.StatusCode = HttpStatusCode.OK Then
            MsgBox("Message Send Successfully..!")
        End If

        response.Close()

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        Dim Tmp As String = ""
        For i As SByte = 0 To lstPhone.Items.Count - 1
            Tmp &= lstPhone.Items(i) & ","
        Next

        If Tmp.Length > 0 Then
            Tmp = Mid(Tmp, 1, Tmp.Length - 1)
            SendSMS(Tmp)
        End If

    End Sub

    Private Sub lstPhone_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lstPhone.KeyUp

        If e.KeyCode = Keys.Delete Then
            If MsgBox("Are you sure, do you want to delete..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
            SQL = "delete dayendsms where phone='" & lstPhone.Text.Trim & "'"
            ESSA.Execute(SQL)
            LoadSms()
        End If

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        If PRINTER_READY = True Then
            PRINT_DAYEND_REPORT()
        Else
            Rpt.SetParameterValue("Shop", ShopName)
            Rpt.SetParameterValue("Date", Now.Date)

            Rpt.SetParameterValue("Cash", Val(lblCash.Text))
            Rpt.SetParameterValue("Card", Val(lblCard.Text))

            'Rpt.SetParameterValue("Term1", lblTerm1.Text)
            'Rpt.SetParameterValue("Term2", lblTerm2.Text)

            Rpt.SetParameterValue("Bank", Val(lblCard.Text))
            Rpt.SetParameterValue("User", UserName)

            Rpt.PrintToPrinter(Val(txtCopies.Text), True, 1, 1)
        End If

    End Sub

    Private Sub btnSSM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSSM.Click

        lblCash.Text = "0.00"
        lblCard.Text = "0.00"
        lblTotal.Text = "0.00"
        Dim GroundFloor As String = "0.00"
        Dim FirstFloor As String = "0.00"
        Dim SecondFloor As String = "0.00"
        Dim ThirdFloor As String = "0.00"


        'lblTerm1.Text = "17521 to 23212"
        'lblTerm2.Text = "1251 to 1252"

        Dim Tmp As String  = "ESSA GARMENTS PRIVATE LIMITED, " & ShopCode & " (" & Format(Now.Date, "dd-MMM-yyyy") & ")" & vbCrLf & "Total:" & Val(lblTotal.Text) & vbCrLf & "Card:" _
                              & Val(lblCard.Text) & vbCrLf & "Bank Cash:" & Val(lblCash.Text) & vbCrLf _
                              & IIf(GroundFloor.Length > 0, "GF:" & GroundFloor, "GF:0.00") & vbCrLf _
                              & IIf(FirstFloor.Length > 0, "FF:" & FirstFloor, "FF:0.00") & vbCrLf _
                              & IIf(SecondFloor.Length > 0, "SF:" & SecondFloor, "SF:0.00") & vbCrLf _
                              & IIf(ThirdFloor.Length > 0, "TF:" & ThirdFloor, "TF:0.00")

        For i As SByte = 0 To lstPhone.Items.Count - 1
            Tmp &= lstPhone.Items(i) & ","
        Next

        If Tmp.Length > 0 Then
            Tmp = Mid(Tmp, 1, Tmp.Length - 1)
            SendSMS(Tmp)
        End If

    End Sub

    Private Sub PRINT_DAYEND_REPORT()

        'FileOpen(1, TempFilePath & "PrintFile.prn", OpenMode.Output)
        'Print(1, Chr(27) & "@")
        'PrintLine(1, Chr(27) & "a1" & Chr(27) & "!8 " & "ESSA" & Chr(27) & "E0")
        'PrintLine(1, Chr(27) & "!8 " & pName)
        'Print(1, Chr(27) & "@")
        'PrintLine(1, Chr(27) & "a1" & pAdd1)
        'If pAdd2.Length > 0 Then PrintLine(1, pAdd2)
        'PrintLine(1, pCity)
        'PrintLine(1, "Phone: " & pPhon)
        'PrintLine(1, "GST: " & pGSTN)
        'PrintLine(1, Chr(27) & "!1" & " ESTIMATE BILL")
        'Print(1, Chr(27) & "@")

        ''SQL = "select termid,billno,billtime from billmaster where billid=" & iBillID & ";" _
        ''    & "select paymentdesc from billpayments where billid=" & iBillID & " order by sno"

        'SQL = "select distinct termid,billid,billdt,custname from billdetailsHOLD where billid=" & iBillID & ";"

        'With ESSA.OpenReader(SQL)
        '    If .Read Then
        '        PaymentDesc = .GetString(3).Trim
        '        Print(1, Chr(27) & "E1" & " Bill No: T" & .Item(0) & "-" & .Item(1))
        '        Msg = "Date: " & Format(.GetDateTime(2).Date, "dd-MM-yyyy")
        '        Print(1, TAB(73 - Msg.Length), Msg)
        '        Print(1, Chr(27), "E0")
        '    End If
        '    .Close()
        'End With

        'Print(1, Chr(27) & "@")
        'PrintLine(1, " --------------------------------------------------------------------")
        'Print(1, Chr(27) & "E1")
        'PrintLine(1, " SNO  DESCRIPTION                      QTY     RATE    D.AMT   AMOUNT")
        'Print(1, Chr(27) & "E0")
        'PrintLine(1, " --------------------------------------------------------------------")

        'SQL = "select p.pluname,d.qty,d.orate,d.amount,p.plucode,0 hsncode,0 utax " _
        '    & "from billdetailsHOLD d,productmaster p " _
        '    & "where d.pluid=p.pluid and d.billid=" & iBillID _
        '    & " order by d.sno"

        ''SQL = " select p.pluname,d.qty,d.orate,d.amount,p.plucode,h.hsncode,h.utax" _
        ''    & " from billdetails d,productmaster p,v_producthsn h" _
        ''    & " where d.pluid=p.pluid and d.pluid=h.pluid and d.billid=" & iBillID _
        ''    & " order by d.sno"

        'Dim TaxTot As Double = 0
        'Dim IGSTot As Double = 0
        'Dim SGSTot As Double = 0

        'Dim Tot As Double = 0
        'Dim Sno As Short = 1
        'Dim Amt As Double = 0
        'Dim Per As Double = 0
        'Dim Hlf As Double = 0
        'Dim Tax As Double = 0
        'Dim Qty As Double = 0
        'Dim Msg2 As String = ""

        'With ESSA.OpenReader(SQL)
        '    While .Read

        '        Print(1, TAB(2), Sno)
        '        Msg = Mid(.GetString(4).Trim & "/" & .GetString(0).Trim, 1, 28)

        '        Print(1, TAB(7), Msg)
        '        Msg = .Item(1)

        '        Print(1, TAB(43 - Msg.Length), Msg)
        '        Amt = .Item(1) * .Item(2)

        '        Msg = Format(.Item(1) * .Item(2), "0.00")
        '        Print(1, TAB(52 - Msg.Length), Msg)

        '        Msg = Format(Amt - .Item(3), "0.00")
        '        Print(1, TAB(61 - Msg.Length), Msg)

        '        Msg = Format(.Item(3), "0.00")
        '        PrintLine(1, TAB(70 - Msg.Length), Msg)

        '        'GST TAX PRINT OUT : BEGIN

        '        'If .Item(6) = 1 Then
        '        '    Per = 5.0F
        '        '    Hlf = 2.5F
        '        'Else
        '        '    Per = IIf(.Item(2) >= 1000, 12.0F, 5.0F)
        '        '    Hlf = IIf(.Item(2) >= 1000, 6.0F, 2.5F)
        '        'End If

        '        'Tax = (.Item(3) / (100 + Per)) * 100

        '        'TaxTot += Tax
        '        'IGSTot += ((Tax * Hlf) / 100)
        '        'SGSTot += ((Tax * Hlf) / 100)

        '        'Msg = Format(Tax, "0.00")
        '        'Msg2 = Format(Hlf, "0.00") & " %: " & Format((Tax * Hlf) / 100, "0.00")
        '        'PrintLine(1, TAB(7), Chr(27) & "M1" & "SALE : " & Msg, TAB(26), "CGST " & Msg2 & Chr(27) & "M0")

        '        'Msg = .GetString(5).Trim
        '        'Msg2 = Format(Hlf, "0.00") & " %: " & Format((Tax * Hlf) / 100, "0.00")
        '        'PrintLine(1, TAB(7), Chr(27) & "M1" & "HSN  : " & Msg, TAB(26), "SGST " & Msg2 & Chr(27) & "M0")

        '        'GST TAX PRINT OUT : END

        '        Tot += .Item(3)
        '        Qty += .Item(1)
        '        Sno += 1


        '    End While

        '    PrintLine(1, " --------------------------------------------------------------------")
        '    Msg = Format(Tot, "0.00")
        '    Msg2 = Format(Qty, "0")
        '    PrintLine(1, TAB(7), Chr(27) & "!1" & "TOTAL", TAB(35 - Msg2.Length), Msg2, TAB(52 - Msg.Length), Msg)
        '    PrintLine(1, Chr(27) & "@" & " --------------------------------------------------------------------")
        '    PrintLine(1, Chr(27) & "E1" & " Customer : " & PaymentDesc & Chr(27) & "E0")
        '    PrintLine(1)
        '    PrintLine(1)
        '    PrintLine(1, Chr(27) & "a1" & Chr(27) & "E1 " & "THANK YOU, VISIT AGAIN !" & Chr(27) & "E0")
        '    PrintLine(1)
        '    PrintLine(1)
        '    PrintLine(1)
        '    PrintLine(1)
        '    PrintLine(1, Chr(27) & "@" & Chr(29) & "V" + Chr(1))
        '    PrintLine(1)
        '    PrintLine(1)
        '    .Close()
        'End With

        Dim Msg As String = ""

        FileOpen(1, TempFilePath & "PrintFile.prn", OpenMode.Output)

        PrintLine(1, Chr(27) & "@")
        PrintLine(1, Chr(27) & "a1" & Chr(27) & "!1")
        PrintLine(1, ShopName)
        PrintLine(1, Now.Date)
        PrintLine(1, Chr(27) + "a0")
        Msg = Format(Val(lblCash.Text), "0.00")
        PrintLine(1, TAB(10), "CASH SALES", TAB(40 - Msg.Length), Msg)
        PrintLine(1)
        Msg = Format(Val(lblCard.Text), "0.00")
        PrintLine(1, TAB(10), "CARD SALES", TAB(40 - Msg.Length), Msg)
        PrintLine(1, TAB(5), " -------------------------------------")
        Msg = Format(Val(lblCard.Text) + Val(lblCash.Text), "0.00")
        PrintLine(1, TAB(10), "TOTAL", TAB(40 - Msg.Length), Msg)
        PrintLine(1, TAB(5), " -------------------------------------")
        PrintLine(1, Chr(27) + "a1 " + "BANK CASH")
        Msg = Format(Val(lblCash.Text), "0.00")
        PrintLine(1, Msg)
        PrintLine(1)
        PrintLine(1)
        PrintLine(1)
        PrintLine(1)
        PrintLine(1, Chr(27) & "@" & Chr(29) & "V" + Chr(1))

        FileClose(1)

        Process.Start(TempFilePath & "PrintFile.bat")

    End Sub

    Private CMD_RESET As Char = Chr(27) & "@ "
    Private CMD_CENTER As Char = Chr(27) & "a1 "
    Private CMD_LARGE As Char = Chr(27) & "!1 "
    Private CMD_BOLD_ON As Char = Chr(27) & "E1 "
    Private CMD_BOLD_OFF As Char = Chr(27) & "E0 "

End Class