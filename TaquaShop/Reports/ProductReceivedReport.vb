'****************************************** Bismillah ****************************
Imports System.Data.SqlClient
Public Class ProductReceivedReport

    Private Sub ProductReceivedReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname + ' - ' + shopcode) sname from shops where shopid<>" & ShopID _
            & " order by shopid"
        ESSA.LoadCombo(cmbSource, SQL, "sname", "shopid", "All Source(s)")

        'SQL = "select min(deliverydate) from receivedmaster"
        'With ESSA.OpenReader(SQL)
        '    If .Read Then
        '        mebFrom.Value = .GetDateTime(0).Date
        '    End If
        '    .Close()
        'End With

    End Sub

    Private Sub LoadDeliveryList()

        SQL = "select deliverycode from receivedmaster where deliverydate between '" _
            & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        If cmbSource.SelectedIndex > 0 Then
            SQL &= " and deliveryfrom=" & cmbSource.SelectedValue
        End If

        SQL &= " and deliveryto = " & ShopID & " order by deliverydate"

        ESSA.LoadCombo(cmbDCode, SQL, "deliverycode", "", "All")

    End Sub
    Private Sub cmbSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSource.SelectedIndexChanged

        If cmbSource.SelectedIndex = -1 Then Exit Sub

        LoadDeliveryList()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub ShowSummaryReport()

        SQL = "SELECT A.*,ISNULL(B.ScannedBy,'NOT GIVEN') 'SCANNED BY', ISNULL(B.ReceivedBy,'NOT GIVEN') 'RECEIVED BY' FROM" _
            & "(Select m.deliverycode 'D.C CODE',m.deliverydate 'DATE',s.shopname 'DELIVERY FROM',m.totalqty 'QUANTITY',m.totcp 'COST VALUE' from " _
            & "shops s,receivedmaster m where s.shopid=m.deliveryfrom and m.deliveryto = " & ShopID & " and convert(date,m.deliverydate) between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        'SQL = "select m.deliverycode 'D.C CODE',m.deliverydate 'DATE',s.shopname 'DELIVERY FROM',m.totalqty 'QUANTITY',m.totcp 'COST VALUE' from " _
        '    & "shops s,receivedmaster m where s.shopid=m.deliveryfrom and m.deliverydate between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
        '    & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        If cmbSource.SelectedIndex > 0 Then
            SQL &= " and m.deliveryfrom=" & cmbSource.SelectedValue
        End If

        'If cmbSource.SelectedIndex > 0 Then
        '    SQL &= " and m.deliveryto=" & cmbSource.SelectedValue
        'End If

        If cmbDCode.SelectedIndex > 0 Then
            SQL &= " and m.deliverycode='" & cmbDCode.Text & "'"
        End If

        SQL &= ") A LEFT JOIN (SELECT * FROM SR_Info) B " _
            & "On A.[D.C CODE] = B.DeliveryCode " _
            & "order by A.DATE"

        'SQL &= " order by s.shopid,m.deliverydate"

        ESSA.LoadDataGrid(TG, SQL)
        Dim TQty As Double = 0
        For i As Integer = 0 To TG.Rows.Count - 1
            TQty += Val(TG.Item(3, i).Value)
        Next
        lblQty.Text = TQty

        'If TG.Rows.Count > 0 Then
        '    TG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill)
        'End If

    End Sub

    Private Sub ShowDetailsReport()

        SQL = "select p.plucode 'CODE',p.pluname 'PRODUCT DESCRIPTION',p.units 'UOM',d.QUANTITY from receiveddetails d, receivedmaster m,productmaster p where " _
            & "p.pluid=d.pluid and m.id = d.id and m.deliveryto = " & ShopID & ""

        If cmbSource.SelectedIndex > 0 Then
            SQL &= " and m.deliveryfrom=" & cmbSource.SelectedValue
        End If

        If cmbDCode.SelectedIndex > 0 Then
            SQL &= " and m.deliverycode='" & cmbDCode.Text & "'"
        End If

        SQL &= " order by d.sno"

        ESSA.LoadDataGrid(TG, SQL)
        Dim TQty As Double = 0
        For i As Integer = 0 To TG.Rows.Count - 1
            TQty += Val(TG.Item(3, i).Value)
        Next
        lblQty.Text = TQty
        'If TG.Rows.Count > 0 Then
        '    TG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill)
        'End If
        'TG.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill)

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If rdoSummary.Checked = True Then
            ShowSummaryReport()
        Else
            ShowDetailsReport()
        End If

    End Sub

    Private Sub mebFrom_ValueChanged(sender As Object, e As EventArgs) Handles mebFrom.ValueChanged

        LoadDeliveryList()

    End Sub

    Private Sub mebTo_ValueChanged(sender As Object, e As EventArgs) Handles mebTo.ValueChanged

        LoadDeliveryList()

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlSearch.Visible = False

    End Sub

    Private Sub btnCodeSearch_Click(sender As Object, e As EventArgs) Handles btnCodeSearch.Click

        pnlSearch.Visible = True
        txtCode.Focus()

    End Sub

    Private Sub DeliveryReport_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.AlignCenter(pnlSearch, Me)

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        Dim Qty As Double = 0

        SQL = "select pluid from productmaster where plucode='" & txtCode.Text.Trim & "'"
        If Not ESSA.ISFound(SQL) Then
            MsgBox("Sorry, Incorrect product code..!", MsgBoxStyle.Critical)
            txtCode.Focus()
            Exit Sub
        End If

        SQL = "select m.deliverycode,m.deliverydate,d.quantity from receivedmaster m,receiveddetails d," _
            & "productmaster p where p.pluid=d.pluid and " _
            & "m.id=d.id and m.deliveryto = " & ShopID & " and p.plucode='{0}' order by m.deliverydate"

        SQL = String.Format(SQL, txtCode.Text.Trim)

        With ESSA.OpenReader(SQL)
            DGV.Rows.Clear()
            While .Read
                DGV.Rows.Add()
                DGV.Item(0, DGV.Rows.Count - 1).Value = .GetString(0).Trim
                DGV.Item(1, DGV.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                DGV.Item(2, DGV.Rows.Count - 1).Value = .Item(2)
                Qty += .Item(2)
            End While
            .Close()
        End With

        lblTQty.Text = Qty

    End Sub

End Class