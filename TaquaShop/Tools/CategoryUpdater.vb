'****************************** in the name of Allah, Most Merciful, Most Compassionate ********************************
Imports System.Data.SqlClient
Imports Microsoft.Office.Interop.Excel

Public Class CategoryUpdater

    Private CatID(0 To 5) As Short
    Private CatDesc(0 To 5) As String
    Private App As Application
    Private xWB As Workbook
    Private xWS As Worksheet
    Private xDt(,) As Object
    Private isExcelOpen As Boolean = False

    Private Sub PopulateTreeview()

        SQL = "select catid,catdesc from category order by catid;" _
            & "select pvscatid,scatid,scatdesc from categorylevels where cattype=1 order by pvscatid,scatid"

        With ESSA.OpenReader(SQL)

            tvCat.Nodes.Clear()

            While .Read
                tvCat.Nodes.Add(.Item(0), .GetString(1).Trim)
            End While

            .NextResult()

            While .Read

                Dim TN As TreeNode() = tvCat.Nodes.Find(.Item(0), True)
                If TN.Length > 0 Then
                    TN(0).Nodes.Add(.Item(1), .GetString(2).Trim)
                End If

            End While

            .Close()

        End With

    End Sub

    Private Sub CategoryUpdater_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        PopulateTreeview()

        SQL = "select deliveryfrom,deliverycode from receivedmaster order by deliverycode"
        ESSA.LoadCombo(cmbDCode, SQL, "deliverycode", "deliveryfrom")

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlCat.Visible = False

    End Sub

    Private Sub btnSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelect.Click

        'If TG.Rows.Count = 0 Then Exit Sub
        pnlCat.Visible = True

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub tvCat_NodeMouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tvCat.NodeMouseDoubleClick

        If e.Node Is Nothing Then Exit Sub
        If MsgBox("Are you sure, do you want to update category..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        For i As SByte = 0 To 5
            CatID(i) = 0
            CatDesc(i) = ""
        Next

        txtSCat.Text = e.Node.FullPath
        CatID(e.Node.Level) = e.Node.Name
        CatDesc(e.Node.Level) = e.Node.Text

        Dim t = e.Node.Parent
        Do Until t Is Nothing
            CatID(t.Level) = t.Name
            CatDesc(t.Level) = t.Text
            t = t.Parent
        Loop

        Dim k As Short = 0

        For i As Short = 0 To TG.Rows.Count - 1

            If Val(TG.Item(0, i).Value) > 0 Then

                TG.Item(16, i).Value = txtSCat.Text.Trim

                k = 4

                For c As SByte = 0 To 5

                    TG.Item(k, i).Value = CatID(c)
                    TG.Item(k + 1, i).Value = CatDesc(c)

                    k += 2

                Next

            End If

        Next

        pnlCat.Visible = False

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        SQL = "select d.pluid,p.plucode,p.pluname,L.CATID,L.CATDESC,L.SCATID1,L.SCATDESC1,L.SCATID2,L.SCATDESC2,L.SCATID3,L.SCATDESC3," _
            & "L.SCATID4,L.SCATDESC4,L.SCATID5,L.SCATDESC5,P.CATLINK from " _
            & "receiveddetails d,productmaster p,PRODUCTLEVELS L where P.PLUID=L.PLUID AND d.pluid=p.pluid and deliverycode='" & cmbDCode.Text.Trim & "'" _
            & " order by d.sno"

        LoadGrid(SQL)

    End Sub

    Private Sub LoadGrid(ByVal iSQL As String)

        With ESSA.OpenReader(iSQL)

            TG.Rows.Clear()

            While .Read

                TG.Rows.Add()
                TG.Item(1, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = .GetString(2).Trim
                TG.Item(4, TG.Rows.Count - 1).Value = .Item(3)
                If IsDBNull(.Item(4)) = False Then TG.Item(5, TG.Rows.Count - 1).Value = .GetString(4).Trim
                TG.Item(6, TG.Rows.Count - 1).Value = .Item(5)
                If IsDBNull(.Item(6)) = False Then TG.Item(7, TG.Rows.Count - 1).Value = .GetString(6).Trim
                TG.Item(8, TG.Rows.Count - 1).Value = .Item(7)
                If IsDBNull(.Item(8)) = False Then TG.Item(9, TG.Rows.Count - 1).Value = .GetString(8).Trim
                TG.Item(10, TG.Rows.Count - 1).Value = .Item(9)
                If IsDBNull(.Item(10)) = False Then TG.Item(11, TG.Rows.Count - 1).Value = .GetString(10).Trim
                TG.Item(12, TG.Rows.Count - 1).Value = .Item(11)
                If IsDBNull(.Item(12)) = False Then TG.Item(13, TG.Rows.Count - 1).Value = .GetString(12).Trim
                TG.Item(14, TG.Rows.Count - 1).Value = .Item(13)
                If IsDBNull(.Item(14)) = False Then TG.Item(15, TG.Rows.Count - 1).Value = .GetString(14).Trim
                If IsDBNull(.Item(15)) = False Then TG.Item(16, TG.Rows.Count - 1).Value = .GetString(15).Trim
                'TG.Item(16, TG.Rows.Count - 1).Value = .Item(15)
                'TG.Item(17, TG.Rows.Count - 1).Value = .GetString(16).Trim

            End While

            .Close()

        End With

    End Sub

    Private Sub btnSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSelectAll.Click

        For i As Short = 0 To TG.Rows.Count - 1
            TG.Item(0, i).Value = 1
        Next

    End Sub

    Private Sub btnDeselect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeselect.Click

        For i As Short = 0 To TG.Rows.Count - 1
            TG.Item(0, i).Value = 0
        Next

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        If TG.Rows.Count = 0 Then Exit Sub
        If MsgBox("Are you sure, do you want to update..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            For i As Integer = 0 To TG.Rows.Count - 1

                If Val(TG.Item(0, i).Value) > 0 Then

                    SQL = "update productmaster set catlink='" _
                        & TG.Item(16, i).Value & "' where pluid=" _
                        & Val(TG.Item(1, i).Value)

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                    SQL &= "UPDATE PRODUCTLEVELS SET CATID=" & Val(TG.Item(4, i).Value) & "," _
                        & "CATDESC='" & TG.Item(5, i).Value & "'," _
                        & "SCATID1=" & Val(TG.Item(6, i).Value) & "," _
                        & "SCATDESC1='" & TG.Item(7, i).Value & "'," _
                        & "SCATID2=" & Val(TG.Item(8, i).Value) & "," _
                        & "SCATDESC2='" & TG.Item(9, i).Value & "'," _
                        & "SCATID3=" & Val(TG.Item(10, i).Value) & "," _
                        & "SCATDESC3='" & TG.Item(11, i).Value & "'," _
                        & "SCATID4=" & Val(TG.Item(12, i).Value) & "," _
                        & "SCATDESC4='" & TG.Item(13, i).Value & "'," _
                        & "SCATID5=" & Val(TG.Item(14, i).Value) & "," _
                        & "SCATDESC5='" & TG.Item(15, i).Value & "' WHERE PLUID=" & Val(TG.Item(1, i).Value)

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As SqlException
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        MsgBox("Category updated successfully..!", MsgBoxStyle.Information)

    End Sub

    Private Sub btnMin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMin.Click

        Me.WindowState = FormWindowState.Minimized

    End Sub

    Private Sub AddProducts(ByVal iSQL As String)

        With ESSA.OpenReader(iSQL)

            'TG.Rows.Clear()

            If .HasRows Then

                While .Read

                    TG.Rows.Add()
                    If IsDBNull(.Item(0)) = False Then TG.Item(1, TG.Rows.Count - 1).Value = .Item(0)
                    If IsDBNull(.Item(1)) = False Then TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1).Trim
                    If IsDBNull(.Item(2)) = False Then TG.Item(3, TG.Rows.Count - 1).Value = .GetString(2).Trim
                    If IsDBNull(.Item(3)) = False Then TG.Item(4, TG.Rows.Count - 1).Value = .Item(3)
                    If IsDBNull(.Item(4)) = False Then TG.Item(5, TG.Rows.Count - 1).Value = .GetString(4).Trim
                    If IsDBNull(.Item(5)) = False Then TG.Item(6, TG.Rows.Count - 1).Value = .Item(5)
                    If IsDBNull(.Item(6)) = False Then TG.Item(7, TG.Rows.Count - 1).Value = .GetString(6).Trim
                    If IsDBNull(.Item(7)) = False Then TG.Item(8, TG.Rows.Count - 1).Value = .Item(7)
                    If IsDBNull(.Item(8)) = False Then TG.Item(9, TG.Rows.Count - 1).Value = .GetString(8).Trim
                    If IsDBNull(.Item(9)) = False Then TG.Item(10, TG.Rows.Count - 1).Value = .Item(9)
                    If IsDBNull(.Item(10)) = False Then TG.Item(11, TG.Rows.Count - 1).Value = .GetString(10).Trim
                    If IsDBNull(.Item(11)) = False Then TG.Item(12, TG.Rows.Count - 1).Value = .Item(11)
                    If IsDBNull(.Item(12)) = False Then TG.Item(13, TG.Rows.Count - 1).Value = .GetString(12).Trim
                    If IsDBNull(.Item(13)) = False Then TG.Item(14, TG.Rows.Count - 1).Value = .Item(13)
                    If IsDBNull(.Item(14)) = False Then TG.Item(15, TG.Rows.Count - 1).Value = .GetString(14).Trim
                    If IsDBNull(.Item(15)) = False Then TG.Item(16, TG.Rows.Count - 1).Value = .GetString(15).Trim
                    'TG.Item(16, TG.Rows.Count - 1).Value = .Item(15)
                    'TG.Item(17, TG.Rows.Count - 1).Value = .GetString(16).Trim

                End While

                txtCode.Clear()

            Else

                TTip.Show("Sorry, Product code not found..!", txtCode, 0, 25, 2000)
                txtCode.SelectAll()

            End If

            .Close()

        End With

    End Sub

    Private Sub txtCode_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            'If txtSCat.Text.Trim = "" Then
            '    TTip.Show("Please select category before you enter new code..!", txtCode, 0, 25, 2000)
            '    txtCode.Clear()
            '    Exit Sub
            'End If

            SQL = "select p.pluid,p.plucode,p.pluname,L.CATID,L.CATDESC,L.SCATID1,L.SCATDESC1,L.SCATID2,L.SCATDESC2,L.SCATID3,L.SCATDESC3," _
                & "L.SCATID4,L.SCATDESC4,L.SCATID5,L.SCATDESC5,P.CATLINK from " _
                & "productmaster p,PRODUCTLEVELS L where P.PLUID=L.PLUID and p.plucode='" & txtCode.Text.Trim & "'"

            AddProducts(SQL)

        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        TG.Rows.Clear()

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

        'Dim xWS = CType(xWB.Worksheets(cmbSheet.Text), Worksheet)
        Dim xWS As Worksheet = xWB.Worksheets(cmbSheet.Text)
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

    Private Sub btnSendToDelivery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSendToDelivery.Click

        If ImportExcelData() = True Then

            SQL = "select distinct p.pluid,p.plucode,p.pluname,L.CATID,L.CATDESC,L.SCATID1,L.SCATDESC1,L.SCATID2,L.SCATDESC2,L.SCATID3,L.SCATDESC3," _
                & "L.SCATID4,L.SCATDESC4,L.SCATID5,L.SCATDESC5,P.CATLINK from " _
                & "XLIMPORT001 d,productmaster p,PRODUCTLEVELS L where P.PLUID=L.PLUID AND d.name=p.plucode"


            LoadGrid(SQL)

            'SQL = "SELECT P.PLUID,P.PLUCODE,P.PLUNAME,SUM(X.QTY) QUANTITY,P.COSTPRICE,P.RETAILPRICE " _
            '    & "FROM PRODUCTMASTER P,XLIMPORT001 X WHERE P.PLUCODE=X.NAME GROUP BY P.PLUID,P.PLUCODE,P.PLUNAME" _
            '    & ",P.COSTPRICE,P.RETAILPRICE ORDER BY P.PLUCODE"

            'With ESSA.OpenReader(SQL)

            '    TG.Rows.Clear()

            '    While .Read
            '        TG.Rows.Add()
            '        TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
            '        TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
            '        TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
            '        TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
            '        TG.Item(4, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
            '        TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
            '    End While

            '    .Close()

            'End With

            'CalculateTotal()
            btniHide.PerformClick()

        End If

        'If isExcelOpen = True Then
        '    xWB.Close()
        '    App.Quit()

        '    releaseObject(xWB)
        '    releaseObject(App)
        '    isExcelOpen = False
        'End If

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

                If xDt(i, cmbName.SelectedIndex + 1) <> "" Then

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

        releaseObject(xWS)

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

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btniHide.Click

        If isExcelOpen = True Then
            xWB.Close()
            App.Quit()

            releaseObject(xWB)
            releaseObject(App)
            isExcelOpen = False
        End If
        pnlImport.Visible = False

    End Sub

    Private Sub btnImport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnImport.Click

        pnlImport.Visible = True
        txtSelect.Focus()

    End Sub

End Class