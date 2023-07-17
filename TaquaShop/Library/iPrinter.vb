Imports Microsoft.VisualBasic.PowerPacks.Printing.Compatibility.VB6
Public Class iPrinter

#Region "I N I T I A L I Z E R"
    Private POSPrn As Printer
    Private iStr As String = ""
    Private Msg As String = ""
#End Region

#Region "COMMON FUNCTION"

    Private Function SetPrinterName(ByVal PrinterName As String, ByVal AppPath As String) As Boolean

        SetPrinterName = True

        Dim prnPrinter As Printer
        For Each prnPrinter In Printers
            If prnPrinter.DeviceName = PrinterName Then
                POSPrn = prnPrinter
                Exit For
            End If
        Next

        If POSPrn Is Nothing Then
            MsgBox("Please check your printer turned on..!", MsgBoxStyle.Critical)
            SetPrinterName = False
            Exit Function
        End If

        POSPrn.DocumentName = "ERP System"
        POSPrn.PrintAction = Printing.PrintAction.PrintToPrinter


    End Function

    Private Function ConnectToPrinter() As Boolean

        ConnectToPrinter = SetPrinterName(POSPrinterName, My.Application.Info.DirectoryPath)

    End Function

    Private Sub DrawLine()

        POSPrn.DrawWidth = 2
        POSPrn.Line(POSPrn.Width, POSPrn.CurrentY)

    End Sub

    Private Sub SetPOSFont(ByVal Size As Single, Optional ByVal Name As String = "Consolas", Optional ByVal ISBold As Boolean = False)

        POSPrn.FontName = Name
        POSPrn.FontSize = Size
        POSPrn.FontBold = ISBold

    End Sub

    Private Sub PrintText(ByVal iText As String, ByVal ISCenterAlign As Boolean)

        If ISCenterAlign = True Then
            POSPrn.CurrentX = (POSPrn.Width - POSPrn.TextWidth(iText)) / 2
        End If

        POSPrn.Print(iText)

    End Sub

#End Region

    Public Sub PrintDayEndReport(ByVal DT As Date)

        Dim Tot As Double = 0
        ConnectToPrinter()
        SetPOSFont(15, , True)
        PrintText("DAYEND SUMMARY", True)
        Msg = "(" & Format(Now, "dd-MMM-yyyy") & ")"
        SetPOSFont(16, , True)
        PrintText(Msg, True)
        POSPrn.Print("")

        SQL = "SELECT PAYMENTTYPE,SUM(SALES-RFUND) SAL FROM V_PAYMENTSUMMARY " _
            & "WHERE BILLDT='" & Format(DT, "yyyy-MM-dd") & "' GROUP BY BTYPE,PAYMENTTYPE ORDER BY BTYPE"
        With ESSA.OpenReader(SQL)
            While .Read
                Msg = Format(.Item(1), "0.00")
                POSPrn.Print(.GetString(0).Trim + Space(20 - Msg.Length) & Msg)
                Tot += .Item(1)
            End While
            .Close()
        End With

        Msg = "-----------------"
        POSPrn.Print(Space(25 - Msg.Length) & Msg)
        Msg = Format(Tot, "0.00")
        POSPrn.Print("TOTAL" + Space(19 - Msg.Length) & Msg)
        Msg = "-----------------"
        POSPrn.Print(Space(25 - Msg.Length) & Msg)
        POSPrn.Print("")
        POSPrn.Print("")
        POSPrn.EndDoc()

    End Sub

End Class


