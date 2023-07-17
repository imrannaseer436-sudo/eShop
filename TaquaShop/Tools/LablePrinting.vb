'****************************************** Bismillah ****************************************************
Imports System.Data.SqlClient
Imports System.Drawing.Printing

Public Class LablePrinting

    Private PLUCODE_1 As String = ""
    Private PLUCODE_2 As String = ""
    Private PLUNAME_1 As String = ""
    Private PLUNAME_2 As String = ""
    Private RTPRICE_1 As String = ""
    Private RTPRICE_2 As String = ""
    Private DESCRPN_1 As String = ""
    Private DESCRPN_2 As String = ""
    Private MFDDATE_1 As String = ""
    Private MFDDATE_2 As String = ""



    Private Sub PrintBarcode()

        Dim xStr As String()
        Dim xTmp As String = ""

        'xStr = System.IO.File.ReadAllLines(My.Application.Info.DirectoryPath & "\Lables\" & BarcodeFormat)
        xStr = System.IO.File.ReadAllLines(My.Application.Info.DirectoryPath & "\Lables\" & cmbLableFormat.Text.Trim)

        For i As Short = 0 To TGTmp.Rows.Count - 1 Step 2

            PLUCODE_1 = TGTmp.Item(0, i).Value
            If i < TGTmp.Rows.Count - 1 Then
                PLUCODE_2 = TGTmp.Item(0, i + 1).Value
            Else
                PLUCODE_2 = ""
            End If

            PLUNAME_1 = TGTmp.Item(1, i).Value
            If i < TGTmp.Rows.Count - 1 Then
                PLUNAME_2 = TGTmp.Item(1, i + 1).Value
            Else
                PLUNAME_2 = ""
            End If

            RTPRICE_1 = Format(Val(TGTmp.Item(2, i).Value), "0.00")
            If i < TGTmp.Rows.Count - 1 Then
                RTPRICE_2 = Format(Val(TGTmp.Item(2, i + 1).Value), "0.00")
            Else
                RTPRICE_2 = ""
            End If

            DESCRPN_1 = TGTmp.Item(3, i).Value
            If i < TGTmp.Rows.Count - 1 Then
                DESCRPN_2 = TGTmp.Item(3, i + 1).Value
            Else
                DESCRPN_2 = ""
            End If

            'MFDDATE_1 = txtDate.Text
            MFDDATE_1 = TGTmp.Item(4, i).Value
            If i < TGTmp.Rows.Count - 1 Then
                'MFDDATE_2 = txtDate.Text
                MFDDATE_2 = TGTmp.Item(4, i + 1).Value
            Else
                MFDDATE_2 = ""
            End If

            For Each Ln As String In xStr

                If Ln.Contains("&PLUCODE_1") = True Then
                    xTmp &= Ln.Replace("&PLUCODE_1", PLUCODE_1) + Environment.NewLine
                ElseIf Ln.Contains("&PLUCODE_2") = True Then
                    xTmp &= Ln.Replace("&PLUCODE_2", PLUCODE_2) + Environment.NewLine
                ElseIf Ln.Contains("&PLUNAME_1") = True Then
                    xTmp &= Ln.Replace("&PLUNAME_1", PLUNAME_1) + Environment.NewLine
                ElseIf Ln.Contains("&PLUNAME_2") = True Then
                    xTmp &= Ln.Replace("&PLUNAME_2", PLUNAME_2) + Environment.NewLine
                ElseIf Ln.Contains("&RTPRICE_1") = True Then
                    xTmp &= Ln.Replace("&RTPRICE_1", RTPRICE_1) + Environment.NewLine
                ElseIf Ln.Contains("&RTPRICE_2") = True Then
                    xTmp &= Ln.Replace("&RTPRICE_2", RTPRICE_2) + Environment.NewLine
                ElseIf Ln.Contains("&DESCRPN_1") = True Then
                    xTmp &= Ln.Replace("&DESCRPN_1", DESCRPN_1) + Environment.NewLine
                ElseIf Ln.Contains("&DESCRPN_2") = True Then
                    xTmp &= Ln.Replace("&DESCRPN_2", DESCRPN_2) + Environment.NewLine
                ElseIf Ln.Contains("&MFD_1") = True Then
                    xTmp &= Ln.Replace("&MFD_1", MFDDATE_1) + Environment.NewLine
                ElseIf Ln.Contains("&MFD_2") = True Then
                    xTmp &= Ln.Replace("&MFD_2", MFDDATE_2) + Environment.NewLine
                Else
                    xTmp &= Ln + Environment.NewLine
                End If

            Next

            xTmp &= "" + Environment.NewLine

        Next

        'BarcodeFileLocation = cmbPrinter.SelectedValue & cmbPrinter.Text.Trim & ".prn"
        'BarcodeBatchLocation = cmbPrinter.SelectedValue & cmbPrinter.Text.Trim & ".bat"

        'Dim prnDlg As New PrintDialog
        'If prnDlg.ShowDialog = DialogResult.Cancel Then Exit Sub

        'Dim PrinterName = prnDlg.PrinterSettings.PrinterName
        BarcodeFileLocation = IO.Path.GetTempPath() & "\PrintLabel.prn"

        FileOpen(1, BarcodeFileLocation, OpenMode.Output, OpenAccess.Write)
        Print(1, xTmp)
        FileClose(1)

        RawPrinterHelper.SendFileToPrinter(cmbPrinter.Text.Trim, BarcodeFileLocation)

        'Process.Start(BarcodeBatchLocation)

        If MsgBox("Lable send to printer successfully, Do you want clear entries..!", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            btnReset.PerformClick()
        Else
            txtCode.Focus()
        End If

    End Sub

    Private Sub LablePrinting_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.F5
                btnReset.PerformClick()
            Case Keys.Escape
                If pnlBatch.Visible = True Then pnlBatch.Visible = False : Exit Sub
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        If MsgBox("Are you sure, do you want to close..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        Me.Close()

    End Sub

    Public Sub LoadProducts(ByVal iSQL As String)

        With ESSA.OpenReader(iSQL)

            While .Read

                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                TG.Item(5, TG.Rows.Count - 1).Value = .GetString(5)
                TG.Item(6, TG.Rows.Count - 1).Value = .GetString(6).Trim

            End While

            .Close()

        End With

    End Sub

    Private Sub txtCopy_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCopy.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True
            Dim Code = CombineCode()

            If Code.Length > 0 Then

                SQL = "select pluid,plucode,pluname,retailprice,id from productmaster where plucode in " _
                    & Code & " order by pluid"
                With ESSA.OpenReader(SQL)

                    While .Read

                        Dim NRI = ESSA.FindGridIndex(TG, 1, .GetString(1))
                        If NRI = -1 Then NRI = TG.Rows.Add()

                        TG.Item(0, NRI).Value = .Item(0)
                        TG.Item(1, NRI).Value = .GetString(1)
                        TG.Item(2, NRI).Value = .GetString(2)
                        TG.Item(3, NRI).Value = Val(txtCopy.Text)
                        TG.Item(4, NRI).Value = Format(.Item(3), "0.00")
                        TG.Item(5, NRI).Value = .GetString(4)

                    End While

                    .Close()

                End With

                If chkCPC.Checked = True Then
                    txtCode.Clear()
                    txtBegin.Clear()
                    txtInc.Clear()
                    txtEnd.Clear()

                End If

                txtCode.Focus()

            End If

        End If

    End Sub

    Private Function CombineCode() As String

        CombineCode = ""

        For i As SByte = Val(txtBegin.Text) To Val(txtEnd.Text) Step Val(txtInc.Text)

            CombineCode &= "'" & txtCode.Text & i & "',"

        Next

        If CombineCode.Length > 0 Then

            CombineCode = "(" & Mid(CombineCode, 1, CombineCode.Length - 1) & ")"

        End If

    End Function

    Private Sub ResetField()

        txtCode.Clear()
        txtInc.Clear()
        txtCopy.Clear()
        txtBegin.Clear()
        txtEnd.Clear()
        txtCode.Focus()

    End Sub

    Private Sub LablePrinting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TGBatch.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        Try
            cmbLableFormat.Items.Clear()
            Dim DI As New IO.DirectoryInfo(My.Application.Info.DirectoryPath & "\Lables\")
            Dim Fl As IO.FileInfo() = DI.GetFiles()
            For Each nfl In Fl
                cmbLableFormat.Items.Add(nfl.Name.Trim)
            Next
            If cmbLableFormat.Items.Count > 0 Then
                cmbLableFormat.SelectedIndex = 1
            End If
        Catch ex As IO.DirectoryNotFoundException
            MsgBox("Sorry, Lable Format Directory not defined..!", MsgBoxStyle.Information)
        End Try

        LoadPrinters()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        txtDate.Clear()
        TG.Rows.Clear()
        TGTmp.Rows.Clear()
        ResetField()

    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        If cmbPrinter.SelectedIndex = -1 Then
            MsgBox("Please select printer.", MsgBoxStyle.Critical)
            Exit Sub
        End If

        TGTmp.Rows.Clear()

        For i As Short = 0 To TG.Rows.Count - 1

            For j As Short = 1 To Val(TG.Item(3, i).Value)

                TGTmp.Rows.Add()
                TGTmp.Item(0, TGTmp.Rows.Count - 1).Value = TG.Item(1, i).Value
                TGTmp.Item(1, TGTmp.Rows.Count - 1).Value = Mid(TG.Item(2, i).Value, 1, 23)
                TGTmp.Item(2, TGTmp.Rows.Count - 1).Value = TG.Item(4, i).Value
                TGTmp.Item(3, TGTmp.Rows.Count - 1).Value = TG.Item(5, i).Value
                TGTmp.Item(4, TGTmp.Rows.Count - 1).Value = TG.Item(6, i).Value

            Next

        Next

        If TGTmp.Rows.Count > 0 Then
            PrintBarcode()
        End If

        pnlSelectPrinter.Hide()

    End Sub

    Private Sub lblEM_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblEM.Click

        If lblEM.Text = "Multi Entry Mode" Then
            lblEM.Text = "Single Entry Mode"
            pnlSE.Visible = False
            txtCode.Focus()
        ElseIf lblEM.Text = "Single Entry Mode" Then
            lblEM.Text = "Multi Entry Mode"
            pnlSE.Visible = True
            txtPlucode.Focus()
        End If

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            Dim NRI = ESSA.FindGridIndex(TG, 1, TGBatch.Item(1, 0).Value)
            If NRI = -1 Then NRI = TG.Rows.Add()

            TG.Item(0, NRI).Value = TGBatch.Item(0, 0).Value
            TG.Item(1, NRI).Value = TGBatch.Item(1, 0).Value
            TG.Item(2, NRI).Value = TGBatch.Item(2, 0).Value
            TG.Item(3, NRI).Value = Val(TG.Item(3, NRI).Value) + Val(txtQty.Text)
            TG.Item(4, NRI).Value = Format(Val(TGBatch.Item(4, 0).Value), "0.00")
            TG.Item(5, NRI).Value = TGBatch.Item(5, 0).Value

            If chkCPC.Checked = True Then
                txtPlucode.Clear()
                txtCopy.Clear()
            End If
            txtPlucode.Focus()

        End If

    End Sub

    Private Sub txtPlucode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPlucode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If chkExcludeBatch.Checked Then
                SQL = "select p.pluid,p.plucode,p.pluname,1,p.retailprice,p.id from productmaster p where p.plucode='" & txtPlucode.Text.Trim & "'"
            Else
                SQL = "select p.pluid,p.plucode,p.pluname,b.batchid,b.rate,p.id from productmaster p,productbatch b where p.plucode='" & txtPlucode.Text.Trim & "'" _
                & " and p.pluid=b.pluid order by b.batchid"
            End If



            TGBatch.Rows.Clear()
            With ESSA.OpenReader(SQL)

                If .HasRows Then

                    While .Read
                        TGBatch.Rows.Add()
                        TGBatch.Item(0, TGBatch.Rows.Count - 1).Value = .Item(0)
                        TGBatch.Item(1, TGBatch.Rows.Count - 1).Value = .GetString(1)
                        TGBatch.Item(2, TGBatch.Rows.Count - 1).Value = .GetString(2)
                        TGBatch.Item(3, TGBatch.Rows.Count - 1).Value = .Item(3)
                        TGBatch.Item(4, TGBatch.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                        TGBatch.Item(5, TGBatch.Rows.Count - 1).Value = .GetString(5)
                    End While

                    If TGBatch.Rows.Count > 1 Then
                        pnlBatch.Visible = True
                        txtBatch.Focus()
                    Else
                        txtQty.Focus()
                    End If

                Else

                    TTip.Show("Sorry, Product code not found..!", txtPlucode, 0, 25, 2000)
                    txtPlucode.SelectAll()

                End If
                .Close()
            End With

        End If

    End Sub

    Private Sub txtBatch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBatch.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True
            txtCP.Focus()
        End If

    End Sub

    Private Sub txtBatch_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBatch.KeyUp

        If e.KeyCode = Keys.Down Then
            TGBatch.Focus()
        ElseIf e.KeyCode <> Keys.Enter Then
            ESSA.FindAndSelect(TGBatch, 3, txtBatch.Text)
        End If

    End Sub

    Private Sub txtCP_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCP.KeyDown

        If e.KeyCode = Keys.Enter Then

            e.SuppressKeyPress = True

            Dim NRI = ESSA.FindGridIndex(TG, 1, TGBatch.Item(1, TGBatch.CurrentRow.Index).Value)
            If NRI = -1 Then NRI = TG.Rows.Add()

            TG.Item(0, NRI).Value = TGBatch.Item(0, TGBatch.CurrentRow.Index).Value
            TG.Item(1, NRI).Value = TGBatch.Item(1, TGBatch.CurrentRow.Index).Value
            TG.Item(2, NRI).Value = TGBatch.Item(2, TGBatch.CurrentRow.Index).Value
            TG.Item(3, NRI).Value = Val(TG.Item(3, NRI).Value) + Val(txtCP.Text)
            TG.Item(4, NRI).Value = Format(Val(TGBatch.Item(4, TGBatch.CurrentRow.Index).Value), "0.00")
            TG.Item(5, NRI).Value = TGBatch.Item(5, TGBatch.CurrentRow.Index).Value

            pnlBatch.Visible = False
            txtBatch.Clear()
            txtCP.Clear()

            If chkCPC.Checked = True Then
                txtPlucode.Clear()
                txtCopy.Clear()
            End If
            txtPlucode.Focus()

        End If

    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.Delete Then
            TG.Rows.RemoveAt(TG.CurrentRow.Index)
        End If

    End Sub

    Private Sub btnShowDialog_Click(sender As Object, e As EventArgs) Handles btnShowDialog.Click

        pnlSelectPrinter.Show()
        cmbPrinter.Focus()

    End Sub

    Private Sub LoadPrinters()

        For Each PrinterList In PrinterSettings.InstalledPrinters
            cmbPrinter.Items.Add(PrinterList)
        Next

        If cmbPrinter.Items.Count > 0 Then
            cmbPrinter.SelectedIndex = 0
        End If

        'SQL = "SELECT Name, Location FROM PrinterLocations ORDER BY Id"
        'ESSA.LoadCombo(cmbPrinter, SQL, "Name", "Location")

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlSelectPrinter.Hide()

    End Sub

    Private Sub btnOnePlusOne_Click(sender As Object, e As EventArgs) Handles btnOnePlusOne.Click

        Dim newSize = InputBox("Enter description:", "", "1+1")
        If newSize.Length > 0 Then
            For i As Short = 0 To TG.Rows.Count - 1
                TG.Item(5, i).Value = newSize
            Next
        End If

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        If TG.Rows.Count < 1 Then
            TTip.Show("Data is empty..!", btnSend, 0, 25, 2000)
            Exit Sub
        End If

        TGTmp.Rows.Clear()

        For i As Short = 0 To TG.Rows.Count - 1

            For j As Short = 1 To Val(TG.Item(3, i).Value)

                TGTmp.Rows.Add()
                TGTmp.Item(0, TGTmp.Rows.Count - 1).Value = TG.Item(1, i).Value
                TGTmp.Item(1, TGTmp.Rows.Count - 1).Value = TG.Item(2, i).Value
                TGTmp.Item(2, TGTmp.Rows.Count - 1).Value = TG.Item(4, i).Value
                TGTmp.Item(3, TGTmp.Rows.Count - 1).Value = TG.Item(5, i).Value

                TGTmp.Item(4, TGTmp.Rows.Count - 1).Value = TG.Item(6, i).Value

            Next

        Next

        SendLabel()

    End Sub

    Private Sub SendLabel()

        Dim PrintId As Integer = Val(InputBox("Enter Id", "Lable Printing"))

        If PrintId <> 0 Then

            ESSA.OpenConnection()
            Dim Cmd = Con.CreateCommand
            Dim trn = Con.BeginTransaction
            Cmd.Transaction = trn
            Try

                SQL = "DELETE FROM LablePrint WHERE Id =" & PrintId

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                For i As Integer = 0 To TGTmp.Rows.Count - 1

                    SQL = "INSERT INTO LablePrint (Id,Plucode,Pluname,Size,Retail_Price,Ref) VALUES( " _
                    & PrintId & ",'" _
                    & TGTmp.Item(0, i).Value & "','" _
                    & TGTmp.Item(1, i).Value & "','" _
                    & TGTmp.Item(3, i).Value & "'," _
                    & Format(Val(TGTmp.Item(2, i).Value), "0.00") & ",'" _
                    & txtDate.Text.Trim & "')"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                Next

                trn.Commit()
                Con.Close()
                If MsgBox("Lable send to printer successfully, Do you want clear entries..!", MsgBoxStyle.Information + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    btnReset.PerformClick()
                Else
                    txtCode.Focus()
                End If

            Catch ex As Exception

                trn.Rollback()
                Con.Close()
                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

        Else

            MsgBox("Please enter id..!", MsgBoxStyle.Critical)
            Exit Sub

        End If

    End Sub

End Class
