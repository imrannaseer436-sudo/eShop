Imports System.Drawing.Drawing2D
Public Class MainWindow

    Private Sub MainWindow_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        For Each ctl As Control In pnlMain.Controls
            If TypeOf (ctl) Is Form Then
                ctl.Dispose()
            End If
        Next

    End Sub

    Private Sub TaquaShop_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        With MenuList

            Dim NRI = .Rows.Add()
            .Item(2, NRI).Value = ""
            .Item(3, NRI).Value = "Customers"

            NRI = .Rows.Add()
            .Item(2, NRI).Value = ""
            .Item(3, NRI).Value = "Payment Type"

            NRI = .Rows.Add()
            .Item(2, NRI).Value = ""
            .Item(3, NRI).Value = "Product Received"

            NRI = .Rows.Add()
            .Item(2, NRI).Value = ""
            .Item(3, NRI).Value = "Product Report"

            NRI = .Rows.Add()
            .Item(2, NRI).Value = ""
            .Item(3, NRI).Value = "Sales Report"

            NRI = .Rows.Add()
            .Item(2, NRI).Value = ""
            .Item(3, NRI).Value = "Sales Return Report"

            NRI = .Rows.Add()
            .Item(2, NRI).Value = ""
            .Item(3, NRI).Value = "Stock Report - Tool"

        End With

        lblDate.Text = Now.Day & "," & Format(Now, "dddd") & vbCrLf & Format(Now, "MMMM " & "yyyy")
        lblUser.Text = "Welcome, " & UserName

        SQL = "select shopid,shopname from shops where shopcode='" & ShopCode & "'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                ShopID = .Item(0)
                ShopName = .GetString(1)
                lblApp.Text = .GetString(1) & "-" & ShopCode
                'tileShop.TileText = .GetString(1).Trim & " (" & ShopCode & ")"
            End If
            .Close()
        End With

        GetSMSApiSettings()

        TempFilePath = Environment.GetEnvironmentVariable("TEMP", EnvironmentVariableTarget.Machine) & "\"

        BarcodeFileLocation = TempFilePath & "barcode.prn"
        BarcodeBatchLocation = TempFilePath & "printlabel.bat"

    End Sub


    'Private Sub CreatePrintBAT()

    '    FileOpen(1, TempFilePath & "PrintFile.bat", OpenMode.Output)
    '    PrintLine(1, "NET USE lpt1 " & PrinterName)
    '    PrintLine(1, "Copy " & TempFilePath & "PrintFile.prn lpt1")
    '    PrintLine(1, "NET USE lpt1 /DELETE")
    '    FileClose(1)

    'End Sub

    Private Sub GetSMSApiSettings()

        Dim Username As String = ""
        Dim Password As String = ""

        Username = ESSA.GenerateData("select param_value from settings where param_name='SMSApiUN'")
        Password = ESSA.GenerateData("select param_value from settings where param_name='SMSApiPW'")
        SmsApiUrl = ESSA.GenerateData("select param_value from settings where param_name='SMSApi'")

        SmsApiUrl = Replace(SmsApiUrl, "@ID", Username)
        SmsApiUrl = Replace(SmsApiUrl, "@Pwd", Password)

    End Sub

    Private Sub LaunchForm(ByVal MyForm As Form)

        For Each ctl As Control In pnlMain.Controls
            If TypeOf (ctl) Is Form Then
                ctl.Dispose()
            End If
        Next

        With MyForm

            .FormBorderStyle = Windows.Forms.FormBorderStyle.None
            .TopLevel = False
            .Dock = DockStyle.Fill
            pnlMain.Controls.Add(MyForm)
            .Show()

        End With

    End Sub

    Private Sub PRODUCTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTSToolStripMenuItem.Click

        LaunchForm(ProductReport)

    End Sub

    Private Sub CUSTOMERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CUSTOMERSToolStripMenuItem.Click

        'LaunchForm(Customer)

        frmCustomer2.Visible = False
        frmCustomer2.Show()

    End Sub

    Private Sub SHOPSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOPSToolStripMenuItem.Click

        LaunchForm(Shops)

    End Sub

    Private Sub TERMINALSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TERMINALSToolStripMenuItem.Click

        LaunchForm(Terminals)

    End Sub

    Private Sub PAYMENTTYPEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PAYMENTTYPEToolStripMenuItem.Click

        LaunchForm(PaymentType)

    End Sub

    Private Sub USERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERSToolStripMenuItem.Click

        LaunchForm(Users)

    End Sub

    Private Sub PRODUCTDELIVERYToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTDELIVERYToolStripMenuItem.Click

        LaunchForm(ProductDelivery)

    End Sub

    Private Sub PRODUCTRECEIVEDToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTRECEIVEDToolStripMenuItem.Click

        ProductReceivedNew.Visible = False
        ProductReceivedNew.Show(Me)

    End Sub

    Private Sub PRODUCTCHECKERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTCHECKERToolStripMenuItem.Click

        LaunchForm(ProductChecker)

    End Sub

    Private Sub STOCKUPDATERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles STOCKUPDATERToolStripMenuItem.Click

        'LaunchForm(StockUpdater)
        LaunchForm(FrmStockAudit)

    End Sub

    Private Sub USERRIGHTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles USERRIGHTSToolStripMenuItem.Click

        Users.Show(Me)

    End Sub

    Private Sub LOGOUTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LOGOUTToolStripMenuItem.Click

        If MsgBox("Are you sure, do you want to sign out..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Login.Show()
        Me.Close()

    End Sub

    Private Sub tileExit_Click(ByVal sender As Object, ByVal e As System.EventArgs)

        Close()

    End Sub

    Private Sub IMPORTMASTERSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        ImportMasters.Show(Me)

    End Sub

    Private Sub SALESQUANTITYREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESQUANTITYREPORTToolStripMenuItem.Click

        LaunchForm(SalesQuantityReport)

    End Sub

    Private Sub SALESSUMMARYREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESSUMMARYREPORTToolStripMenuItem.Click

        LaunchForm(SalesSummaryReport)

    End Sub

    Private Sub SALESREPORTBILLWISEToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESREPORTBILLWISEToolStripMenuItem.Click

        LaunchForm(SalesReportBillWise)

    End Sub

    Private Sub PRODUCTREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTREPORTToolStripMenuItem.Click

        LaunchForm(ProductReport)

    End Sub

    Private Sub SayGoodbyeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SayGoodbyeToolStripMenuItem.Click

        DayEnd.Visible = False
        DayEnd.Show(Me)

    End Sub

    Private Sub OPENINGSTOCKToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        LaunchForm(OpeningStockEntry)

    End Sub

    Private Sub RECEIVEDREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIVEDREPORTToolStripMenuItem.Click

        LaunchForm(ProductReceivedReport)

    End Sub

    Private Sub DELIVRYREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELIVRYREPORTToolStripMenuItem.Click

        LaunchForm(DeliveryReport)

    End Sub

    Private Sub PRODUCTDELIVERYLISTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PRODUCTDELIVERYLISTToolStripMenuItem.Click

        LaunchForm(ProductDeliveryList)

    End Sub

    Private Sub DAYENDGENERATORSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DAYENDGENERATORSToolStripMenuItem.Click

        DayEndGenerator.Show(Me)

    End Sub

    Private Sub SHOPSETTINGSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SHOPSETTINGSToolStripMenuItem.Click

        TaquaShopSettings.Show(Me)

    End Sub

    Private Sub ToolsToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolsToolStripMenuItem1.Click



    End Sub

    Private Sub SALESRETURNEDREPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SALESRETURNEDREPORTToolStripMenuItem.Click

        LaunchForm(ProductReturnReport)

    End Sub

    Private Sub MenuList_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MenuList.CellContentClick

    End Sub

    Private Sub MenuList_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MenuList.CellDoubleClick

        Select Case e.RowIndex

            Case 0
                frmCustomer2.Visible = False
                frmCustomer2.Show()
            Case 1
                LaunchForm(PaymentType)
                
            Case 2
                ProductReceivedNew.Visible = False
                ProductReceivedNew.Show(Me)

            Case 3
                LaunchForm(ProductReport)
            Case 4
                LaunchForm(SalesReportBillWise)
            Case 5
                LaunchForm(ProductReturnReport)
            Case 6
                'frmReportsWindow.Show()
                frmStockReportNew.Show()
                'Form1.Show()

        End Select

    End Sub

    Private Sub UNUSEDPRODUCTSToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UNUSEDPRODUCTSToolStripMenuItem.Click

        UnusedProducts.Visible = False
        UnusedProducts.Show(Me)

    End Sub

    Private Sub RECEIVEDIMPORTToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RECEIVEDIMPORTToolStripMenuItem.Click

        ReceivedImport.Visible = False
        ReceivedImport.Show(Me)

    End Sub

    Private Sub CATEGORYUPDATERToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CATEGORYUPDATERToolStripMenuItem.Click

        CategoryUpdater.Visible = False
        CategoryUpdater.Show(Me)

    End Sub

    Private Sub CreditBillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CreditBillToolStripMenuItem.Click

        LaunchForm(CreditBill)

    End Sub

    Private Sub CODEREADERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CODEREADERToolStripMenuItem.Click

        CodeReaderAdv.Visible = False
        CodeReaderAdv.Show(Me)

    End Sub

    Private Sub SALESREPORTNEWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALESREPORTNEWToolStripMenuItem.Click

        frmSalesReport2.Visible = False
        frmSalesReport2.Show(Me)

    End Sub

    Private Sub PRODUCTVERIFIERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTVERIFIERToolStripMenuItem.Click

        'frmVerifier.Visible = False
        'frmVerifier.Show(Me)
        Verifier.Visible = False
        Verifier.Show(Me)

    End Sub

    Private Sub EMessangerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EMessangerToolStripMenuItem.Click

        frmEMessage.Visible = False
        frmEMessage.Show(Me)

    End Sub

    Private Sub GSTBILLPRINTERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GSTBILLPRINTERToolStripMenuItem.Click

        frmGSTPrinter.Visible = False
        frmGSTPrinter.Show(Me)

    End Sub

    Private Sub CODEHISTORYToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CODEHISTORYToolStripMenuItem.Click

        frmCodeHistory.Visible = False
        frmCodeHistory.Show(Me)

    End Sub

    Private Sub VENDORSYNCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDORSYNCToolStripMenuItem.Click

        frmProductSync.Visible = False
        frmProductSync.Show(Me)

    End Sub

    Private Sub SALESCOMMISSIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALESCOMMISSIONToolStripMenuItem.Click

        SalesPerson.Visible = False
        SalesPerson.Show(Me)

    End Sub

    Private Sub LABELPRINTINGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LABELPRINTINGToolStripMenuItem.Click

        LablePrinting.Visible = False
        LablePrinting.Show(Me)

    End Sub

    Private Sub FINANCIALYEARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FINANCIALYEARToolStripMenuItem.Click

        If Not IsAdmin Then
            MsgBox("Access denied!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        frmFinancialYearUpdate.Visible = False
        frmFinancialYearUpdate.Show(Me)

    End Sub

    Private Sub DAYENDToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DAYENDToolStripMenuItem.Click

        frmDayEnd.Visible = False
        frmDayEnd.Show(Me)

    End Sub

    Private Sub RATEUPDATERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RATEUPDATERToolStripMenuItem.Click

        If Not IsAdmin Then
            MsgBox("Access denied!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        frmRateUpdater.Visible = False
        frmRateUpdater.Show(Me)

    End Sub

    Private Sub PRINTERSETTINGSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRINTERSETTINGSToolStripMenuItem.Click

        frmPrinterLocations.Visible = False
        frmPrinterLocations.Show(Me)

    End Sub

    Private Sub COLORUPDATERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COLORUPDATERToolStripMenuItem.Click

        frmColorUpdater.Visible = False
        frmColorUpdater.Show(Me)

    End Sub

    Private Sub DISCOUNTUPDATERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DISCOUNTUPDATERToolStripMenuItem.Click

        DiscountUpdater.Visible = False
        DiscountUpdater.Show(Me)

    End Sub

    Private Sub DISCOUNTASSIGNERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DISCOUNTASSIGNERToolStripMenuItem.Click

        DiscountAssigner.Visible = False
        DiscountAssigner.Show()

    End Sub

    Private Sub FLOORUPDATERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FLOORUPDATERToolStripMenuItem.Click

        FloorUpdater.Visible = False
        FloorUpdater.Show()

    End Sub

    Private Sub PRODUCTRECEIVEDREIMPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTRECEIVEDREIMPORTToolStripMenuItem.Click

        frmProductImport.Visible = False
        frmProductImport.Show()

    End Sub


    Private Sub DenominationToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DenominationToolStripMenuItem.Click

        Denomination.Visible = False
        Denomination.Show()

    End Sub

    Private Sub DUEDAYSREPORTToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DUEDAYSREPORTToolStripMenuItem.Click

        LaunchForm(frmDueReport)

    End Sub

    Private Sub STOCKREPORTSWToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles STOCKREPORTSWToolStripMenuItem.Click

        LaunchForm(StockReportSW)

    End Sub

    Private Sub VENDORFINDERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VENDORFINDERToolStripMenuItem.Click

        frmVendorFind.Visible = False
        frmVendorFind.Show()

    End Sub

    Private Sub PAYMENTTIMEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PAYMENTTIMEToolStripMenuItem.Click

        frmPaymentTime.Visible = False
        frmPaymentTime.Show()

    End Sub

    Private Sub BillUpdaterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BillUpdaterToolStripMenuItem.Click

        frmBillUpdater.Visible = False
        frmBillUpdater.Show()

    End Sub

    Private Sub SALESREPORTSPWISEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALESREPORTSPWISEToolStripMenuItem.Click

        LaunchForm(frmSalesReportSPWise)

    End Sub

    Private Sub SALESREPORTCATWISEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SALESREPORTCATWISEToolStripMenuItem.Click

        LaunchForm(SalesReportCatWise)

    End Sub

End Class