'****************************************** Bismillah ****************************
Imports System.Data.SqlClient
Public Class DeliveryReport

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If rdoSummary.Checked = True Then

            SQL = "select M.DELIVERYCODE 'DELIVERY CODE',M.DELIVERYDATE 'DATE',S.SHOPNAME,SUM(D.QUANTITY) DELIVERED FROM " _
                & "DELIVERYMASTER M,DELIVERYDETAILS D,SHOPS S WHERE M.ID=D.ID AND M.DELIVERYTO=S.SHOPID AND M.DELIVERYFROM = " & ShopID & ""

            If cmbSource.SelectedIndex > 0 Then
                SQL &= " AND M.DELIVERYTO=" & cmbSource.SelectedValue
            End If

            If cmbDCode.SelectedIndex Then
                SQL &= " AND M.DELIVERYCODE='" & cmbDCode.Text & "'"
            End If

            SQL &= " GROUP BY M.DELIVERYCODE,M.DELIVERYDATE,S.SHOPNAME " _
                & "ORDER BY M.DELIVERYDATE"

            ESSA.LoadDataGrid(TG, SQL)
            TG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Dim TQty As Double = 0
            For i As Integer = 0 To TG.Rows.Count - 1
                TQty += Val(TG.Item(3, i).Value)
            Next
            lblQty.Text = TQty
            lblCVal.Text = Format(0, "0.00")
            lblRVal.Text = Format(0, "0.00")

        Else

            SQL = "SELECT M.DELIVERYCODE 'DELIVERY CODE',M.DELIVERYDATE 'DATE',P.PLUCODE,P.PLUNAME,P.UNITS,D.QUANTITY,P.COSTPRICE [C.PRICE],P.RETAILPRICE [R.PRICE] FROM DELIVERYMASTER M,DELIVERYDETAILS D," _
                & "PRODUCTMASTER P WHERE D.PLUID=P.PLUID AND M.ID=D.ID AND M.DELIVERYCODE='" & cmbDCode.Text.Trim & "' ORDER BY D.SNO"

            ESSA.LoadDataGrid(TG, SQL)
            TG.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            Dim TQty As Double = 0
            Dim CVal As Double = 0
            Dim RVal As Double = 0

            For i As Integer = 0 To TG.Rows.Count - 1
                TQty += Val(TG.Item(5, i).Value)
                CVal += Val(TG.Item(6, i).Value)
                RVal += Val(TG.Item(7, i).Value)
            Next

            lblQty.Text = TQty
            lblCVal.Text = Format(CVal, "0.00")
            lblRVal.Text = Format(RVal, "0.00")

        End If



    End Sub

    Private Sub DeliveryReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select shopid,(shopname + ' - ' + shopcode) sname from shops where shopid<>" & ShopID _
          & " order by shopid"
        ESSA.LoadCombo(cmbSource, SQL, "sname", "shopid", "All Source(s)")

        ESSA.AlignHeader(DGV, 2, DataGridViewContentAlignment.MiddleRight)

    End Sub

    Private Sub cmbSource_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSource.SelectedIndexChanged

        If cmbSource.SelectedIndex = -1 Then Exit Sub

        SQL = "SELECT DELIVERYCODE FROM DELIVERYMASTER WHERE DELIVERYFROM = " & ShopID & ""

        If cmbSource.SelectedIndex > 0 Then
            SQL &= " AND DELIVERYTO=" & cmbSource.SelectedValue
        End If

        SQL &= " ORDER BY DELIVERYTO,DELIVERYDATE"

        ESSA.LoadCombo(cmbDCode, SQL, "DELIVERYCODE", "", "All")

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        Dim Qty As Double = 0

        SQL = "select pluid from productmaster where plucode='" & txtCode.Text.Trim & "'"
        If Not ESSA.ISFound(SQL) Then
            MsgBox("Sorry, Incorrect product code..!", MsgBoxStyle.Critical)
            txtCode.Focus()
            Exit Sub
        End If

        SQL = "select m.deliverycode,m.deliverydate,d.quantity from deliverymaster m,deliverydetails d," _
            & "productmaster p where p.pluid=d.pluid and " _
            & "m.id=d.id and m.deliveryfrom = " & ShopID & " and p.plucode='{0}' order by m.deliverydate"

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

    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            btnFilter.PerformClick()
        End If

    End Sub

End Class