'******************************* in the name of Allah, most merciful, most compassionate ************************
Imports System.ComponentModel
Imports System.Data.SqlClient
Imports System.IO
Imports System.Runtime.Remoting.Messaging
Imports Syncfusion.Windows.Forms.Tools.Win32API

Public Class ProductReceivedNew

    Private TotCP As Double = 0
    Private TotRP As Double = 0
    Private ExportFileLocaton As String = ""
    Private UniqueID As String = ""

    Private Sub ProductReceivedNew_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadDeliveryCode()

        SQL = "SELECT DISTINCT ScannedBy FROM SR_Info ORDER BY ScannedBy"
        ESSA.LoadCombo(CmbScanner, SQL, "ScannedBy")
        CmbScanner.Text = ""

        SQL = "SELECT DISTINCT ReceivedBy FROM SR_Info ORDER BY ReceivedBy"
        ESSA.LoadCombo(CmbReceiver, SQL, "ReceivedBy")
        CmbReceiver.Text = ""

        cmbFloor.Items.AddRange({0, 1, 2, 3, 4, 5, ""})
        cmbFloor.SelectedIndex = 0

        ESSA.AlignHeader(TG, 10, DataGridViewContentAlignment.MiddleCenter)

    End Sub

    Private Function GetExportFileLocation() As Boolean

        GetExportFileLocation = False

        SQL = "select param_value from settings where param_name='ExportFileLocation'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                GetExportFileLocation = True
                ExportFileLocaton = .GetString(0).Trim
            End If
            .Close()
        End With

        If GetExportFileLocation = False Then
            MsgBox("Sorry, Export File Location Not Found..!", MsgBoxStyle.Critical)
        End If

    End Function

    Private Sub LoadDeliveryCode()

        'Retail Store
        SQL = $"select deliveryfrom,deliverycode from deliverymaster where deliveryto =  {ShopID} and status = 0 order by deliverycode"
        'Taqua Store
        'SQL = "select deliveryfrom,deliverycode from receivedmastertemp order by deliverycode"
        ESSA.LoadCombo(cmbDCode, SQL, "deliverycode", "deliveryfrom")

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        UniqueID = ""

        SQL = "select remarks from deliverymaster where deliverycode='" & cmbDCode.Text.Trim & "'"
        'SQL = "select remarks,uniqueid from receivedmastertemp where deliverycode='" & cmbDCode.Text.Trim & "'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                txtRemarks.Text = .GetString(0).Trim
                'If IsDBNull(.Item(1)) = False Then UniqueID = .GetString(1).Trim
            End If
            .Close()
        End With

        SQL = "select d.pluid,p.plucode 'CODE',p.pluname 'PRODUCT DESCRIPTION',p.units,d.Quantity 'DELIVERED',d.Quantity 'RECEIVED',d.costprice,d.retailprice from " _
            & " deliverydetails d,deliverymaster m, productmaster p where d.pluid=p.pluid and m.id = d.id and m.deliverycode='" & cmbDCode.Text.Trim & "'" _
            & " order by d.sno"

        'Taqua Store
        'SQL = "select d.pluid,p.plucode 'CODE',p.pluname 'PRODUCT DESCRIPTION',p.units,d.Quantity 'DELIVERED',d.Quantity 'RECEIVED',d.costprice,d.retailprice from " _
        '    & "receiveddetailstemp d,productmaster p where d.pluid=p.pluid and d.deliverycode='" & cmbDCode.Text.Trim & "'" _
        '    & " order by d.sno"

        With ESSA.OpenReader(SQL)

            TG.Rows.Clear()

            While .Read

                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = TG.Rows.Count
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(4, TG.Rows.Count - 1).Value = .GetString(3).Trim
                TG.Item(5, TG.Rows.Count - 1).Value = .Item(4)
                TG.Item(6, TG.Rows.Count - 1).Value = .Item(5)
                TG.Item(7, TG.Rows.Count - 1).Value = 0
                TG.Item(8, TG.Rows.Count - 1).Value = .Item(6)
                TG.Item(9, TG.Rows.Count - 1).Value = .Item(7)
                TG.Item(10, TG.Rows.Count - 1).Value = ""

            End While

            .Close()

        End With

        GetTotal()

    End Sub

    Private Sub GetTotal()

        Dim A As Double = 0
        Dim B As Double = 0
        Dim C As Double = 0
        Dim T As Double = 0

        TotCP = 0
        TotRP = 0

        For i As Short = 0 To TG.Rows.Count - 1

            A += Val(TG.Item(5, i).Value)
            B += Val(TG.Item(6, i).Value)
            C += Val(TG.Item(7, i).Value)

            T = Val(TG.Item(6, i).Value) * Val(TG.Item(8, i).Value)
            TotCP += T

            T = Val(TG.Item(6, i).Value) * Val(TG.Item(9, i).Value)
            TotRP += T

        Next

        lblDel.Text = A
        lblRcv.Text = B
        lblVar.Text = A - B

    End Sub

    Private Sub TG_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellEndEdit

        If Val(TG.Item(6, e.RowIndex).Value) > Val(TG.Item(5, e.RowIndex).Value) Then
            TG.Item(6, e.RowIndex).Value = Val(TG.Item(5, e.RowIndex).Value)
        End If

        GetTotal()
        TG.Item(7, e.RowIndex).Value = Val(TG.Item(5, e.RowIndex).Value) - Val(TG.Item(6, e.RowIndex).Value)

    End Sub

    Private Sub CheckVariation(Optional ByVal ISReject As Boolean = False)

        TGTmp.Rows.Clear()

        If ISReject = False Then

            For i As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(7, i).Value) <> 0 Then

                    TGTmp.Rows.Add()
                    TGTmp.Item(0, TGTmp.Rows.Count - 1).Value = TG.Item(0, i).Value
                    TGTmp.Item(1, TGTmp.Rows.Count - 1).Value = Val(TG.Item(7, i).Value)
                    TGTmp.Item(2, TGTmp.Rows.Count - 1).Value = Val(TG.Item(8, i).Value)
                    TGTmp.Item(3, TGTmp.Rows.Count - 1).Value = Val(TG.Item(9, i).Value)

                End If

            Next

        Else

            For i As Short = 0 To TG.Rows.Count - 1

                TGTmp.Rows.Add()
                TGTmp.Item(0, TGTmp.Rows.Count - 1).Value = TG.Item(0, i).Value
                TGTmp.Item(1, TGTmp.Rows.Count - 1).Value = Val(TG.Item(5, i).Value)
                TGTmp.Item(2, TGTmp.Rows.Count - 1).Value = Val(TG.Item(8, i).Value)
                TGTmp.Item(3, TGTmp.Rows.Count - 1).Value = Val(TG.Item(9, i).Value)

            Next


        End If

    End Sub

    Private Function validateFloor() As Boolean

        validateFloor = True

        For i As Short = 0 To TG.Rows.Count - 1

            If Trim(TG.Item(10, i).Value) = "" Then
                validateFloor = False
                Exit For
            End If

        Next

    End Function

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        If cmbDCode.SelectedIndex = -1 Then
            MsgBox("Delivery code not found..!", MsgBoxStyle.Information)
            cmbDCode.Focus()
            Exit Sub
        ElseIf TG.Rows.Count = 0 Then
            MsgBox("No details to save..!", MsgBoxStyle.Information)
            Exit Sub
            'ElseIf Not validateFloor Then
            '    MsgBox("Please update all floor informations ?", MsgBoxStyle.Information)
            '    Exit Sub
            'ElseIf CmbScanner.Text = "" Then
            '    MsgBox("Please fill the scanner info..!", MsgBoxStyle.Critical)
            '    CmbScanner.Focus()
            '    Exit Sub
            'ElseIf CmbReceiver.Text = "" Then
            '    MsgBox("Please fill the receiver info..!", MsgBoxStyle.Critical)
            '    CmbReceiver.Focus()
            '    Exit Sub
        End If

        If MsgBox("Are you sure, do you want to save..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        PnlLoading.Visible = True : PnlLoading.Refresh()
        Dim id As Integer = ESSA.GenerateID("select max(id) from receivedmaster")

        Call CheckVariation()

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try
            'IMRAN
            Dim cnt As Integer = 0
            SQL = $"SELECT COUNT(*) FROM ReceivedMaster WHERE DeliveryTo = {ShopID} AND DeliveryCode = '{cmbDCode.Text}'"
            Dim command As New SqlCommand(SQL, Con, Trn)
            cnt = command.ExecuteScalar()

            If cnt > 0 Then
                MsgBox("Delivery Already Imported..!", MsgBoxStyle.Critical)
                TG.Rows.Clear()
                PnlLoading.Visible = False
                Exit Sub
            End If
            'IMRAN 

            SQL = "insert into receivedmaster values ( " _
                & id & ",'" _
                & cmbDCode.Text.Trim & "','" _
                & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & cmbDCode.SelectedValue & "," _
                & ShopID & "," _
                & Val(lblDel.Text) & "," _
                & TotCP & "," _
                & TotRP & ",0,'" _
                & txtRemarks.Text.Trim & "'," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            'SQL = $"update deliverymaster set status = 1 
            'where deliverycode = '{cmbDCode.Text.Trim}'"

            'Cmd.CommandText = SQL
            'Cmd.ExecuteNonQuery()

            If (Val(lblVar.Text) = 0) Then
                SQL = $"update deliverymaster set status = 1 
                where deliverycode = '{cmbDCode.Text.Trim}'"
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            ElseIf (Val(lblVar.Text) <> 0) Then
                SQL = $"update deliverymaster set status = 2 
                where deliverycode = '{cmbDCode.Text.Trim}'"
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()
            End If

            SQL = "INSERT INTO SR_Info VALUES('" _
                    & cmbDCode.Text.Trim & "','" _
                    & CmbScanner.Text.Trim & "','" _
                    & CmbReceiver.Text.Trim & "',GetDate())"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                SQL = "insert into receiveddetails values (" _
                    & id & "," _
                    & Val(TG.Item(0, i).Value) & "," _
                    & Val(TG.Item(6, i).Value) & "," _
                    & Val(TG.Item(8, i).Value) & "," _
                    & Val(TG.Item(9, i).Value) & "," _
                    & Val(TG.Item(1, i).Value) & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                'SQL = "update productmaster set rackno='" _
                '    & Trim(TG.Item(10, i).Value) & "' where " _
                '    & "pluid=" & Val(TG.Item(0, i).Value)

                'Cmd.CommandText = SQL
                'Cmd.ExecuteNonQuery()

            Next

            SQL = "DELETE FROM PriceMaster WHERE ShopID = " & ShopID & " AND PluId IN 
            (SELECT PluId FROM DeliveryDetails D,DeliveryMaster M
            WHERE D.ID = M.ID AND M.DeliveryCode = '" & cmbDCode.Text.Trim & "')"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            SQL = $"INSERT INTO PriceMaster
            SELECT {ShopID},D.PluID,D.CostPrice,D.RetailPrice,D.RetailPrice,D.RetailPrice,1,
            '{Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")}','{Format(DateTime.Now, "yyyy-MM-dd HH:mm:ss")}',{UserID},{UserID},P.Discount
            from ProductMaster P
            INNER JOIN DeliveryDetails D ON P.PluId = D.Pluid
            INNER JOIN DeliveryMaster M ON M.ID = D.ID AND 
            M.DeliveryCode = '{cmbDCode.Text.Trim}'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            'SQL = "DELETE FROM RECEIVEDMASTERTEMP WHERE DELIVERYCODE='" & cmbDCode.Text.Trim & "';" _
            '    & "DELETE FROM RECEIVEDDETAILSTEMP WHERE DELIVERYCODE='" & cmbDCode.Text.Trim & "'"

            'Cmd.CommandText = SQL
            'Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        'SQL = $"select sum(dd.quantity) delivery,sum(rd.quantity) received 
        'from deliverydetails dd,deliverymaster dm,
        'receivedmaster rm,receiveddetails rd
        'where dd.id = dm.id and rm.id = rd.id and 
        'dm.deliverycode = rm.deliverycode and d.deliverycode = '{cmbDCode.Text.Trim}'"
        'With ESSA.OpenReader(SQL)

        '    If .Read Then
        '        If (.Item(0) = .Item(1)) Then
        '            SQL = $"update deliverymaster set status = 1 
        '            where deliverycode = '{cmbDCode.Text.Trim}'"
        '            ESSA.Execute(SQL)
        '        ElseIf (.Item(0) <> .Item(1)) Then
        '            SQL = $"update deliverymaster set status = 2 
        '            where deliverycode = '{cmbDCode.Text.Trim}'"
        '            ESSA.Execute(SQL)
        '        End If
        '    End If

        'End With

        'If TGTmp.Rows.Count > 0 Then
        '    CreateDelivery()
        'End If

        PnlLoading.Visible = False
        MsgBox("Entry saved successfully..!", MsgBoxStyle.Information)
        RefreshForms()

    End Sub

    Private Sub RefreshForms()

        cmbDCode.Focus()
        txtRemarks.Clear()
        CmbScanner.Text = ""
        CmbReceiver.Text = ""
        TG.Rows.Clear()
        TGTmp.Rows.Clear()
        LoadDeliveryCode()
        GetTotal()

    End Sub

    Private Sub CreateDelivery()

        Dim Remark As String = InputBox("Enter remarks here..!")

        SQL = "select count(*) from deliverymaster where deliveryto=" & cmbDCode.SelectedValue
        Dim DeliveryID = ESSA.GenerateID(SQL)

        SQL = "select shopcode from shops where shopid=" & cmbDCode.SelectedValue
        Dim DCode As String = ESSA.GenerateData(SQL)

        DCode = ShopCode & DCode.Trim & Format(DeliveryID, "000000")

        Dim TotQt As Double = 0
        Dim TotCP As Double = 0
        Dim TotRP As Double = 0
        Dim TmpAm As Double = 0

        For i As Short = 0 To TGTmp.Rows.Count - 1

            TotQt += Val(TGTmp.Item(1, i).Value)

            TmpAm = Val(TGTmp.Item(1, i).Value) * Val(TGTmp.Item(2, i).Value)
            TotCP += TmpAm

            TmpAm = Val(TGTmp.Item(1, i).Value) * Val(TGTmp.Item(3, i).Value)
            TotRP += TmpAm

        Next

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            SQL = "DELETE FROM RECEIVEDMASTERTEMP WHERE DELIVERYCODE='" & cmbDCode.Text.Trim & "';" _
                & "DELETE FROM RECEIVEDDETAILSTEMP WHERE DELIVERYCODE='" & cmbDCode.Text.Trim & "'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            SQL = "insert into deliverymaster values ('" _
                & DCode & "','" _
                & Format(Now, "yyyy-MM-dd hh:mm:ssss") & "'," _
                & ShopID & "," _
                & cmbDCode.SelectedValue & "," _
                & TotQt & "," _
                & TotCP & "," _
                & TotRP & ",0,'" _
                & Remark & "'," _
                & UserID & ",0)"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TGTmp.Rows.Count - 1

                SQL = "insert into deliverydetails values ('" _
                    & DCode & "'," _
                    & Val(TGTmp.Item(0, i).Value) & "," _
                    & Val(TGTmp.Item(1, i).Value) & "," _
                    & Val(TGTmp.Item(2, i).Value) & "," _
                    & Val(TGTmp.Item(3, i).Value) & "," _
                    & ShopID & "," _
                    & cmbDCode.SelectedValue & "," _
                    & i + 1 & ",0)"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub

        End Try

        GenerateExportedData(DCode)

    End Sub

    Private Sub btnReject_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReject.Click

        If MsgBox("Are you sure, do you want to reject..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub
        SQL = $"update deliverymaster Set status = 3 
        where deliverycode = '{cmbDCode.Text.Trim}'"
        ESSA.Execute(SQL)


        'For I As Short = 0 To TG.Rows.Count - 1
        '    TG.Item(6, I).Value = 0
        '    TG.Item(7, I).Value = TG.Item(5, I).Value
        'Next

        'CheckVariation(True)

        'If TGTmp.Rows.Count > 0 Then
        '    CreateDelivery()
        'End If

        MsgBox("Delivery rejected successfully...!", MsgBoxStyle.Information)
        RefreshForms()

    End Sub

    Private Sub GenerateExportedData(ByVal iDCode As String)

        Dim iQry As String = ""

        SQL = "SELECT * FROM DELIVERYMASTER WHERE DELIVERYCODE='" & iDCode & "';" _
            & "SELECT * FROM DELIVERYDETAILS WHERE DELIVERYCODE='" & iDCode & "';"

        With ESSA.OpenReader(SQL)

            iQry = "DELETE FROM RECEIVEDMASTERTEMP WHERE DELIVERYCODE='" & iDCode & "'" & vbCrLf

            If .Read Then

                iQry &= "INSERT INTO RECEIVEDMASTERTEMP VALUES ('" _
                     & iDCode & "','" _
                     & Format(.GetDateTime(1), "yyyy-MM-dd hh:mm:ssss") & "'," _
                     & .Item(2) & "," _
                     & .Item(3) & "," _
                     & .Item(4) & "," _
                     & .Item(5) & "," _
                     & .Item(6) & "," _
                     & .Item(7) & ",'" _
                     & .GetString(8).Trim & "'," _
                     & .Item(9) & "," _
                     & .Item(10) & ")" & vbCrLf

            End If

            .NextResult()

            iQry &= "DELETE FROM RECEIVEDDETAILSTEMP WHERE DELIVERYCODE='" & iDCode & "'" & vbCrLf

            While .Read

                iQry &= "INSERT INTO RECEIVEDDETAILSTEMP VALUES ('" _
                     & .GetString(0).Trim & "'," _
                     & .Item(1) & "," _
                     & .Item(2) & "," _
                     & .Item(3) & "," _
                     & .Item(4) & "," _
                     & .Item(5) & "," _
                     & .Item(6) & "," _
                     & .Item(7) & "," _
                     & .Item(8) & ")" & vbCrLf

            End While

            .Close()

        End With

        If iQry.Length > 0 Then

            Using sw As StreamWriter = New StreamWriter(ExportFileLocaton & ShopCode & Format(Now, "yyMMddhhmmss") & ".DAT", True)
                sw.Write(iQry)
            End Using

        End If

    End Sub

    Private Sub btnDone_Click(sender As Object, e As EventArgs) Handles btnDone.Click

        For i As Short = 0 To TG.Rows.Count - 1
            TG.Item(10, i).Value = cmbFloor.Text.Trim
        Next

    End Sub

End Class