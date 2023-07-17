'************************************ Bismillah ***********************************************
Imports System.Data.SqlClient
Public Class ProductDeliveryList

    Private DeliveryID As UShort

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

        cmbDCode.Text = ""
        GenerateDeliveryCode()
        lblTQty.Text = "0"
        txtRemarks.Clear()
        TG.Rows.Clear()

    End Sub

    Private Sub ProductDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        ESSA.AlignHeader(DGV, 3, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(DGV, 4, DataGridViewContentAlignment.MiddleRight)

        'DGV.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGV.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbDCLocation, SQL, "shopdesc", "shopid")

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbFilter, SQL, "shopdesc", "shopid", "All Location(S)")

        cmbDCLocation.Select()

    End Sub

    Private Sub GenerateDeliveryCode()

        SQL = "select max(convert(int,substring(deliverycode,len(deliverycode)-4,len(deliverycode)))) from deliverymaster where deliveryto=" & cmbDCLocation.SelectedValue
        DeliveryID = ESSA.GenerateID(SQL)
        lblDCode.Text = ShopCode & Mid(cmbDCLocation.Text, cmbDCLocation.Text.Length - 4, cmbDCLocation.Text.Length).Trim & Format(DeliveryID, "000000")

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

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            GenerateDeliveryCode()

            SQL = "delete from deliverymastertemp where deliverycode='" & cmbDCode.Text.Trim & "';" _
                & "delete from deliverydetailstemp where deliverycode='" & cmbDCode.Text.Trim & "'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            SQL = "insert into deliverymaster values ('" _
                & lblDCode.Text.Trim & "','" _
                & Format(Now, "yyyy-MM-dd HH:mm:ssss") & "'," _
                & ShopID & "," _
                & cmbDCLocation.SelectedValue & "," _
                & Val(lblTQty.Text) & "," _
                & Val(lblTCP.Text) & "," _
                & Val(lblTRP.Text) & ",0,'" _
                & txtRemarks.Text.Trim & "'," _
                & UserID & ",0,'" _
                & Format(Now, "yyyyMMddHHmmss") & "')"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(4, i).Value) > 0 Then

                    SQL = "insert into deliverydetails values ('" _
                        & lblDCode.Text.Trim & "'," _
                        & Val(TG.Item(0, i).Value) & "," _
                        & Val(TG.Item(4, i).Value) & "," _
                        & Val(TG.Item(5, i).Value) & "," _
                        & Val(TG.Item(6, i).Value) & "," _
                        & ShopID & "," _
                        & cmbDCLocation.SelectedValue & "," _
                        & i + 1 & ",0)"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        'If MsgBox("Challan delivered successfully, Do you want to print challan..!", vbQuestion + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    PrintDeliveryReport()
        'End If

        MsgBox("Challan delivered successfully..!", MsgBoxStyle.Information)
        RefreshForms()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        RefreshForms()

    End Sub

    'Private Sub PrintDeliveryReport()

    '    SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
    '        & "s1.shopname dfrom,s2.shopname dto from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p where " _
    '        & "m.deliveryfrom = s.shopid And m.deliverycode = d.deliverycode And d.pluid = p.pluid And m.deliveryfrom = s1.shopid " _
    '        & " And m.deliveryto = s2.shopid and m.deliverycode='" & lblDCode.Text & "' order by d.sno"

    '    ESSA.OpenConnection()

    '    Using Adp As New SqlDataAdapter(SQL, Con)
    '        Using Tbl As New DataTable
    '            Adp.Fill(Tbl)
    '            Rpt.SetDataSource(Tbl)
    '            Rpt.PrintToPrinter(1, False, 0, 0)
    '        End Using
    '    End Using

    '    Con.Close()

    'End Sub

    Private Sub cmbDCLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDCLocation.SelectedIndexChanged

        If cmbDCLocation.SelectedIndex = -1 Then Exit Sub

        SQL = "SELECT REMARKS,DELIVERYCODE FROM DELIVERYMASTERTEMP WHERE DELIVERYTO=" & IIf(cmbDCLocation.SelectedValue.ToString.Contains("DataRow"), "0", cmbDCLocation.SelectedValue) _
            & " ORDER BY DELIVERYCODE"
        ESSA.LoadCombo(cmbDCode, SQL, "DELIVERYCODE", "REMARKS")

    End Sub



    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If cmbDCode.SelectedIndex = -1 Then
            TTip.Show("Delivery code not found..!", cmbDCode, 0, 25, 2000)
            Exit Sub
        End If

        Dim Tot As Double = 0

        SQL = "select p.pluid,p.plucode,p.pluname,d.quantity,d.costprice,d.retailprice from productmaster p,deliverydetailstemp d " _
            & "where p.pluid=d.pluid and d.deliverycode='" & cmbDCode.Text.Trim & "' order by sno"

        TG.Rows.Clear()

        txtRemarks.Text = cmbDCode.SelectedValue

        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(4, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                TG.Item(6, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
                Tot += .Item(3)
            End While
            .Close()
        End With

        lblTQty.Text = Tot

        If TG.Rows.Count > 0 Then
            TG.CurrentCell = TG.Item(4, 0)
            TG.Focus()
        End If

        CalculateTotal()

    End Sub
    Private Sub TG_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellEndEdit

        If Val(TG.Item(4, e.RowIndex).Value) > Val(TG.Item(3, e.RowIndex).Value) Then
            TG.Item(4, e.RowIndex).Value = Val(TG.Item(3, e.RowIndex).Value)
        End If

        CalculateTotal()

    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.F9 Then
            If MsgBox("Are you sure, Do you want to remove product..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TG.Rows.RemoveAt(TG.CurrentRow.Index)
            End If
            TG.Focus()
        End If

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub CalculateTotal()

        Dim Tot As Short = 0
        Dim Tmp As Double = 0
        Dim CTot As Double = 0
        Dim RTot As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            Tot += Val(TG.Item(4, i).Value)
            Tmp = Val(TG.Item(4, i).Value) * Val(TG.Item(5, i).Value)
            CTot += Tmp
            Tmp = Val(TG.Item(4, i).Value) * Val(TG.Item(6, i).Value)
            RTot += Tmp

        Next

        lblTQty.Text = Tot
        lblTCP.Text = Format(CTot, "0.00")
        lblTRP.Text = Format(RTot, "0.00")

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        SQL = "select m.deliverycode,m.deliverydate,s.shopname,m.TotalQty,m.totcp " _
            & "from DeliveryMaster m,Shops s " _
            & "where m.DeliveryTo=s.shopid and m.deliveryfrom = " & ShopID & " "

        If cmbFilter.SelectedIndex > 0 Then
            SQL &= " and m.deliveryto=" & cmbFilter.SelectedValue
        End If

        SQL &= " order by deliverydate desc"

        With ESSA.OpenReader(SQL)
            DGV.Rows.Clear()
            While .Read
                DGV.Rows.Add()
                DGV.Item(0, DGV.Rows.Count - 1).Value = .GetString(0).Trim
                DGV.Item(1, DGV.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                DGV.Item(2, DGV.Rows.Count - 1).Value = .GetString(2).Trim
                DGV.Item(3, DGV.Rows.Count - 1).Value = .Item(3)
                DGV.Item(4, DGV.Rows.Count - 1).Value = Format(.Item(4), "0.00")
            End While
            .Close()
        End With

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlList.Visible = False

    End Sub

    Private Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 5 Then

            PrintDeliveryChallan(Trim(DGV.Item(0, e.RowIndex).Value))

        End If

    End Sub

    Private Sub btnReprint_Click(sender As Object, e As EventArgs) Handles btnReprint.Click

        pnlList.Visible = True
        cmbFilter.Focus()

    End Sub

    Private Rpt As New RptDeliveryChallan

    Private Sub PrintDeliveryChallan(deliveryCode As String)

        Using nCon As New SqlConnection(ConStr)

            nCon.Open()

            Try

                'SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
                '    & "s1.shopname dfrom,s2.shopname dto,l.scatdesc1 from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p,productlevels l where p.pluid=l.pluid and " _
                '    & "m.deliveryfrom = s.shopid And m.deliverycode = d.deliverycode And d.pluid = p.pluid And m.deliveryfrom = s1.shopid " _
                '    & " And m.deliveryto = s2.shopid and m.deliverycode='" & deliveryCode & "' order by d.sno"

                'SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
                '    & "s1.shopname dfrom,s2.shopname dto,'' scatdesc1 from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p where " _
                '    & "m.deliveryfrom = s.shopid And m.deliverycode = d.deliverycode And d.pluid = p.pluid And m.deliveryfrom = s1.shopid " _
                '    & " And m.deliveryto = s2.shopid and m.deliverycode='" & deliveryCode & "' order by d.sno"

                SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
                    & "s1.shopname dfrom,s2.shopname dto,a.category scatdesc1,m.remarks from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p,productattributes a where " _
                    & "m.deliveryfrom = s.shopid And m.id = d.id And d.pluid = p.pluid and p.pluid = a.pluid and m.deliveryfrom = s1.shopid " _
                    & " And m.deliveryto = s2.shopid and m.deliverycode='" & deliveryCode & "' order by d.sno"

                Using Adp As New SqlDataAdapter(SQL, nCon)

                    Using Tbl As New DataTable
                        Adp.Fill(Tbl)
                        Rpt.SetDataSource(Tbl)
                        frmReportViewer.CRViewer.ReportSource = Rpt
                        frmReportViewer.Visible = False
                        frmReportViewer.Show()
                    End Using

                End Using

            Catch ex As SqlException

                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

            nCon.Close()

        End Using

    End Sub

    Private Sub cmbDCLocation_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDCLocation.KeyDown

        If e.KeyCode = Keys.Enter Then

            If cmbDCLocation.SelectedIndex = -1 Then Exit Sub

            SQL = "SELECT REMARKS,DELIVERYCODE FROM DELIVERYMASTERTEMP WHERE DELIVERYTO=" & cmbDCLocation.SelectedValue _
                & " ORDER BY DELIVERYCODE"
            ESSA.LoadCombo(cmbDCode, SQL, "DELIVERYCODE", "REMARKS")

        End If

    End Sub
End Class