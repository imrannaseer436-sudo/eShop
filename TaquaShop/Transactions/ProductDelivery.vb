'********************************************* Bismillah *****************************************
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel
Public Class ProductDelivery

    Private DeliveryID As UShort
    Private PluID As Integer
    Private DCode As String
    Private CostPrice As Double = 0
    Private RetailPrice As Double = 0
    Private App As Application
    Private xWB As Workbook
    Private xWS As Worksheet
    Private xDt(,) As Object
    Private isExcelOpen As Boolean = False

    Private Sub ProductDelivery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub RefreshForms()

        lblRAmt.Text = "0.00"
        LBLCAmt.Text = "0.00"
        lblStock.Text = "0"
        lblTQty.Text = "0"
        TG.Rows.Clear()
        ResetField()

    End Sub

    Private Sub ProductDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New System.Drawing.Font(TG.Font, FontStyle.Bold)
        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbDCLocation, SQL, "shopdesc", "shopid")


        GenerateDeliveryCode()
        cmbDCLocation.Select()

    End Sub

    Private Sub GenerateDeliveryCode()

        SQL = "select max(convert(int,substring(deliverycode,len(deliverycode)-4,len(deliverycode)))) from deliverymaster where deliveryto=" & cmbDCLocation.SelectedValue
        DeliveryID = ESSA.GenerateID(SQL)
        lblDCode.Text = ShopCode & Mid(cmbDCLocation.Text, cmbDCLocation.Text.Length - 4, cmbDCLocation.Text.Length).Trim & Format(DeliveryID, "000000")

        'SQL = "SELECT CONVERT(INT,SUBSTRING(DELIVERYCODE,LEN(DELIVERYCODE)-2,LEN(DELIVERYCODE))) FROM DELIVERYMASTERTEMP WHERE DELIVERYFROM=" & ShopID
        'DeliveryID = ESSA.GenerateID(SQL)
        'DCode = "Temp" & Mid(cmbDCLocation.Text, cmbDCLocation.Text.Length - 4, cmbDCLocation.Text.Length).Trim & Format(DeliveryID, "000000")

        'SQL = "select count(*) from deliverymastertemp where deliveryfrom=" & ShopID
        'DeliveryID = ESSA.GenerateID(SQL)
        'DCode = "Temp" & Mid(cmbDCLocation.Text, cmbDCLocation.Text.Length - 4, cmbDCLocation.Text.Length).Trim & Format(DeliveryID, "000000")

    End Sub

    Private AUTO_ENTRY_OK As Boolean = False

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            SQL = "select m.pluid,plucode,pluname,v.stock,costprice,retailprice from productmaster m,v_stockpos v where m.pluid=v.pluid and plucode='" & txtCode.Text.Trim & "' and v.location_id = " & ShopID & ""
            With ESSA.OpenReader(SQL)
                If .Read Then
                    PluID = .Item(0)
                    txtCode.Text = .GetString(1).Trim
                    txtProduct.Text = .GetString(2).Trim
                    lblStock.Text = .Item(3)
                    CostPrice = .Item(4)
                    RetailPrice = .Item(5)
                    txtQty.Focus()
                    AUTO_ENTRY_OK = True
                Else
                    txtCode.SelectAll()
                    TTip.Show("Sorry, Product code not found..!", txtCode, 0, 25, 2000)
                    AUTO_ENTRY_OK = False
                End If
                .Close()
            End With

            If chkAutoEntry.Checked = True Then
                If AUTO_ENTRY_OK Then
                    txtQty.Text = 1
                    txtQty_KeyDown(sender, e)
                End If
            End If

        End If

    End Sub

    Private Sub txtQty_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If Val(txtQty.Text) <= 0 Then
                TTip.Show("Quantity should not be zero..!", txtQty, 0, 25, 2000)
                Exit Sub
            End If

            Dim NRI = ESSA.FindGridIndex(TG, 0, PluID)

            If NRI = -1 Then

                If Val(txtQty.Text) > Val(lblStock.Text) Then
                    txtQty.SelectAll()
                    TTip.Show("Insufficient stock..!", txtQty, 0, 25, 2000)
                    Exit Sub
                End If

            Else

                If Val(TG.Item(3, NRI).Value) + Val(txtQty.Text) > Val(lblStock.Text) Then
                    txtQty.SelectAll()
                    TTip.Show("Insufficient stock..!", txtQty, 0, 25, 2000)
                    Exit Sub
                End If

            End If

            If NRI = -1 Then NRI = TG.Rows.Add

            TG.Item(0, NRI).Value = PluID
            TG.Item(1, NRI).Value = txtCode.Text
            TG.Item(2, NRI).Value = txtProduct.Text
            TG.Item(3, NRI).Value = Val(TG.Item(3, NRI).Value) + Val(txtQty.Text)
            TG.Item(4, NRI).Value = Format(CostPrice, "0.00")
            TG.Item(5, NRI).Value = Format(RetailPrice, "0.00")

            CalculateTotal()

            txtCode.Clear()
            txtProduct.Clear()
            txtQty.Clear()
            lblStock.Text = "0"
            txtCode.Focus()

        End If

    End Sub

    Private Sub ResetField()

        txtCode.Clear()
        txtProduct.Clear()
        txtQty.Clear()
        lblStock.Text = "0"
        txtCode.Focus()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        If TG.Rows.Count = 0 Then
            TTip.Show("No details to proceed..!", btnSend, 0, 25, 2000)
            Exit Sub
        ElseIf cmbDCLocation.SelectedIndex = -1 Then
            TTip.Show("Delivery location not selected..!", cmbDCLocation, 0, 25, 2000)
            cmbDCLocation.Focus()
            Exit Sub
        End If

        For j As Short = 0 To TG.Rows.Count - 1
            If TG.Rows(j).DefaultCellStyle.BackColor = Color.LavenderBlush Then
                TTip.Show("Stock mismatching..!", btnSend, 0, 25, 2000)
                Exit Sub
            End If
        Next

        Dim id As Integer = ESSA.GenerateID("select max(id) from deliverymaster")

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            GenerateDeliveryCode()

            SQL = "delete from deliverymastertemp where deliverycode='" & lblDCode.Text & "';" _
                & "delete from deliverydetailstemp where deliverycode='" & lblDCode.Text & "'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            SQL = "insert into deliverymaster values ( " _
                & id & ",'" _
                & lblDCode.Text.Trim & "','" _
                & Format(Now, "yyyy-MM-dd HH:mm:ssss") & "'," _
                & ShopID & "," _
                & cmbDCLocation.SelectedValue & "," _
                & Val(lblTQty.Text) & "," _
                & Val(LBLCAmt.Text) & "," _
                & Val(lblRAmt.Text) & ",0,'" _
                & txtRemarks.Text.Trim & "'," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(4, i).Value) > 0 Then

                    SQL = "insert into deliverydetails values (" _
                        & id & "," _
                        & Val(TG.Item(0, i).Value) & "," _
                        & Val(TG.Item(3, i).Value) & "," _
                        & Val(TG.Item(4, i).Value) & "," _
                        & Val(TG.Item(5, i).Value) & "," _
                        & i + 1 & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Trn.Commit()
            Con.Close()

            'GenerateDeliveryCode()

            'SQL = "insert into deliverymastertemp values ('" _
            '    & DCode & "','" _
            '    & Format(Now, "yyyy-MM-dd HH:mm:ssss") & "'," _
            '    & ShopID & "," _
            '    & cmbDCLocation.SelectedValue & "," _
            '    & Val(lblTQty.Text) & "," _
            '    & Val(LBLCAmt.Text) & "," _
            '    & Val(lblRAmt.Text) & ",0,'" _
            '    & txtRemarks.Text.Trim & "'," _
            '    & UserID & ",0,'" _
            '    & Format(Now, "yyyyMMddHHmmss") & "')"

            'Cmd.CommandText = SQL
            'Cmd.ExecuteNonQuery()

            'For i As Short = 0 To TG.Rows.Count - 1

            '    SQL = "insert into deliverydetailstemp values ('" _
            '        & DCode & "'," _
            '        & Val(TG.Item(0, i).Value) & "," _
            '        & Val(TG.Item(3, i).Value) & "," _
            '        & Val(TG.Item(4, i).Value) & "," _
            '        & Val(TG.Item(5, i).Value) & "," _
            '        & ShopID & "," _
            '        & cmbDCLocation.SelectedValue & "," _
            '        & i + 1 & ",0)"

            '    Cmd.CommandText = SQL
            '    Cmd.ExecuteNonQuery()

            'Next

            'Trn.Commit()
            'Con.Close()
            RefreshForms()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        RefreshForms()

    End Sub

    Private Sub CalculateTotal()

        Dim Tot As Double = 0
        Dim CAmt As Double = 0
        Dim RAmt As Double = 0
        Dim Tmp As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1
            Tot += Val(TG.Item(3, i).Value)
            Tmp = Val(TG.Item(3, i).Value) * Val(TG.Item(4, i).Value)
            CAmt += Tmp
            Tmp = Val(TG.Item(3, i).Value) * Val(TG.Item(5, i).Value)
            RAmt += Tmp
        Next

        lblTQty.Text = Tot
        lblCAmt.Text = Format(CAmt, "0.00")
        lblRAmt.Text = Format(RAmt, "0.00")

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        If isExcelOpen = True Then
            'xWB.Close()
            'App.Quit()

            'releaseObject(xWB)
            'releaseObject(App)
            isExcelOpen = False
        End If
        pnlImport.Visible = False

    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        pnlImport.Visible = True
        txtSelect.Focus()

    End Sub

    Private Sub btnXLImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub btnPick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPick.Click

        App = New Application
        OFD.ShowDialog()
        txtSelect.Text = OFD.FileName.Trim
        cmbSheet.Items.Clear()

        If txtSelect.Text = "" Then
            Exit Sub
        End If

        xWB = App.Workbooks.Open(txtSelect.Text)
        For Each sht As Worksheet In xWB.Worksheets
            cmbSheet.Items.Add(sht.Name)
        Next

        If cmbSheet.Items.Count > 0 Then
            cmbSheet.SelectedIndex = 0
            isExcelOpen = True
        End If

    End Sub

    Private Sub btnGetColumn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetColumn.Click

        If cmbSheet.Items.Count = 0 Then Exit Sub

        btnSendToDelivery.Enabled = True

        Dim xWS = CType(xWB.Worksheets(cmbSheet.Text), Worksheet)
        'Dim xWS As Worksheet = xWB.Worksheets(cmbSheet.Text)
        Dim xRg As Range = xWS.UsedRange
        xDt = xRg.Value(XlRangeValueDataType.xlRangeValueDefault)
        Dim xBd As Integer = xDt.GetUpperBound(0)
        Dim yBd As Integer = xDt.GetUpperBound(1)

        For k As Short = 1 To yBd
            If xDt(1, k) <> "" Then
                cmbName.Items.Add(xDt(1, k))
                cmbQty.Items.Add(xDt(1, k))
            End If
        Next

        cmbName.SelectedIndex = 0
        cmbQty.SelectedIndex = 0


    End Sub

    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub

    Private Sub ProductDelivery_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize

        pnlImport.Left = (Me.Width - pnlImport.Width) / 2
        pnlImport.Top = (Me.Height - pnlImport.Height) / 2

    End Sub

    Private Sub btnSendToDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendToDelivery.Click

        If ImportExcelData() = True Then

            SQL = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,SUM(X.QTY) QUANTITY,P.COSTPRICE,P.RETAILPRICE,V.STOCK " _
                & "FROM PRODUCTMASTER P,XLIMPORT001 X,V_STOCKPOS V WHERE P.PLUCODE=X.NAME AND P.PLUID=V.PLUID AND V.LOCATION_ID = " & ShopID & " GROUP BY P.PLUID,P.PLUCODE,P.PLUNAME" _
                & ",P.COSTPRICE,P.RETAILPRICE,V.STOCK ORDER BY P.PLUCODE"

            With ESSA.OpenReader(SQL)

                TG.Rows.Clear()

                While .Read
                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                    TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                    TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)

                    If .Item(3) > .Item(6) Then
                        'If .Item(6) > 0 Then
                        TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                        'End If
                        TG.Rows(TG.Rows.Count - 1).DefaultCellStyle.BackColor = Color.LavenderBlush
                        'TG.Item(3, TG.Rows.Count - 1).Value = .Item(6)
                    Else
                        TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                    End If

                    TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                    TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
                    TG.Item(6, TG.Rows.Count - 1).Value = Format(.Item(6), "0")

                End While

                .Close()

            End With

            CalculateTotal()
            btnHide.PerformClick()

        End If

        If isExcelOpen = True Then
            xWB.Close()
            App.Quit()

            releaseObject(xWB)
            releaseObject(App)
            isExcelOpen = False
        End If


    End Sub

    Private Sub CheckStock()

        For i As Short = 0 To TG.Rows.Count - 1

            SQL = "select "

        Next

    End Sub

    Private Function ImportExcelData() As Boolean

        ImportExcelData = True

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If isTableExists() = True Then
                SQL = "DELETE FROM XLIMPORT001"
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            Else
                SQL = "CREATE TABLE XLIMPORT001" _
                    & "([NAME] VARCHAR (50) NULL,[QTY] SMALLINT)"
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            End If

            For i As Short = 2 To xDt.GetUpperBound(0)

                If xDt(i, cmbName.SelectedIndex + 1) <> Nothing Then

                    SQL = "INSERT INTO XLIMPORT001 VALUES ('" _
                        & xDt(i, cmbName.SelectedIndex + 1) & "'," _
                        & Val(xDt(i, cmbQty.SelectedIndex + 1)) & ")"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Trn.Commit()
            Con.Close()
            MsgBox("Product imported..!", MsgBoxStyle.Information)

        Catch ex As SqlException
            ImportExcelData = False
            Trn.Rollback()
            Con.Close()
            If ex.Message.Contains("names are") = True Then
                MsgBox("Please assign column name properly..!", MsgBoxStyle.Critical)
            Else
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End If

            If isExcelOpen = True Then
                xWB.Close()
                App.Quit()

                releaseObject(xWB)
                releaseObject(App)
                isExcelOpen = False
            End If

        End Try

        'releaseObject(xWS)
        releaseObject(xDt)

    End Function

    Private Function isTableExists() As Boolean

        ESSA.OpenConnection()
        Try
            Using Cmd As New SqlCommand("SELECT COUNT(*) FROM XLIMPORT001", Con)
                Cmd.ExecuteNonQuery()
                isTableExists = True
            End Using
        Catch ex As SqlException
            isTableExists = False
        End Try
        Con.Close()

    End Function

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub txtQty_TextChanged(sender As Object, e As EventArgs) Handles txtQty.TextChanged

    End Sub
End Class