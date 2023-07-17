'************************************************ Bismillah *****************************************************
Imports System.Data.SqlClient
Public Class SalesQuantityReport

    Private Sub SalesQuantityReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'SQL = "select catid,catdesc from category order by catdesc"
        'ESSA.LoadComboSimple(CmbCat, SQL, "catdesc", "catid", "All Category(s)")

        SQL = "select convert(varchar,termid) term from terminal order by termid" ' where shopid=" & ShopID
        ESSA.LoadCombo(cmbTerm, SQL, "term", "", "All")

    End Sub

    Private Sub CmbCat_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbCat.SelectedIndexChanged

        If CmbCat.SelectedIndex = -1 Then Exit Sub
        SQL = "select scatid,scatdesc from subcategory1 " & IIf(CmbCat.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(CmbCat), "") & " order by scatdesc"
        ESSA.LoadComboSimple(CmbSCat1, SQL, "scatdesc", "scatid", "All Category(s)")

    End Sub

    Private Sub CmbSCat1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmbSCat1.SelectedIndexChanged

        If CmbSCat1.SelectedIndex = -1 Then Exit Sub
        SQL = "select scatid,scatdesc from subcategory2 " & IIf(CmbSCat1.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(CmbSCat1), "") & " order by scatdesc"
        ESSA.LoadComboSimple(cmbSCat2, SQL, "scatdesc", "scatid", "All Category(s)")

    End Sub

    Private Sub cmbSCat2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbSCat2.SelectedIndexChanged

        If cmbSCat2.SelectedIndex = -1 Then Exit Sub
        SQL = "select scatid,scatdesc from subcategory3 " & IIf(cmbSCat2.SelectedIndex > 0, " where pvscatid=" & ESSA.GetItemValue(cmbSCat2), "") & " order by scatdesc"
        ESSA.LoadComboSimple(cmbSCat3, SQL, "scatdesc", "scatid", "All Category(s)")

    End Sub

    Private Sub btnCatFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCatFilter.Click

        pnlCatFilter.Visible = True
        CmbCat.Focus()

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlCatFilter.Visible = False

    End Sub

    Private Sub LoadData()

        SQL = "select p.plucode 'CODE',p.pluname 'PRODUCT DESCRIPTION',p.units 'UOM',sum(d.qty) 'QUANTITY',sum(d.amount) 'AMOUNT',l.catdesc 'CATEGORY',l.scatdesc1 'SUBCATEGORY-1',l.scatdesc2 'SUBCATEGORY-2',l.scatdesc3 'SUBCATEGORY-3' from productmaster p,billdetails d," _
            & "productlevels l where p.pluid=l.pluid and p.pluid=d.pluid and d.billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "'"

        If cmbTerm.SelectedIndex > 0 Then
            SQL &= " and d.termid=" & cmbTerm.Text
        End If

        If CmbCat.SelectedIndex > 0 Then
            SQL &= " and l.catid=" & ESSA.GetItemValue(CmbCat)
        End If

        If CmbSCat1.SelectedIndex > 0 Then
            SQL &= " and l.scatid1=" & ESSA.GetItemValue(CmbSCat1)
        End If

        If cmbSCat2.SelectedIndex > 0 Then
            SQL &= " and l.scatid2=" & ESSA.GetItemValue(cmbSCat2)
        End If

        If cmbSCat3.SelectedIndex > 0 Then
            SQL &= " and l.scatid3=" & ESSA.GetItemValue(cmbSCat3)
        End If

        If txtPlucode.Text.Trim.Length > 0 Then
            SQL &= " and p.plucode like '%" & txtPlucode.Text & "%'"
        End If

        SQL &= " and d.qty>0 group by p.plucode,p.pluname,p.units,l.catdesc,l.scatdesc1,l.scatdesc2,l.scatdesc3 order by p.plucode"

        ESSA.LoadDataGrid(TG, SQL)
        TG.Columns(0).Width = 100
        TG.Columns(1).Width = 250
        TG.Columns(2).Width = 100
        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight)
        TG.Columns(3).Width = 80
        TG.Columns(4).Width = 80
        TG.Columns(5).Width = 120
        TG.Columns(6).Width = 120
        TG.Columns(7).Width = 120
        TG.Columns(8).Width = 120

        Dim TQty As Double = 0
        For i As Integer = 0 To TG.Rows.Count - 1
            TQty += Val(TG.Item(3, i).Value)
        Next
        lblQty.Text = TQty

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        LoadData()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnFilter_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFilter.Click

        LoadData()
        pnlCatFilter.Visible = False

    End Sub

End Class