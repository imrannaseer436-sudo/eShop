'********************** in the name of Allah, most merciful, most compassionate **********************************
Imports System.Data.SqlClient
Imports Microsoft.VisualBasic.Compatibility
Public Class ProductReturnReport

    Private Sub ProductReturnReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        SQL = "select convert(varchar,termid) term from terminal order by termid" ' where shopid=" & ShopID
        ESSA.LoadCombo(cmbTerm, SQL, "term", "", "All")

    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        Dim Tot As Double = 0

        SQL = "select m.billno 'BILL NO',m.billdt 'DATE',m.termid 'TERM ID',p.plucode 'CODE',-d.qty 'QUANTITY',d.RATE,-d.AMOUNT 'AMOUNT',l.department 'SUBCATEGORY-1',l.category 'SUBCATEGORY-2' from " _
            & "billmaster m,billdetails d,productmaster p,productattributes l where m.billid=d.billid and d.pluid=p.pluid and m.shopid = " & ShopID & " " _
            & "and p.pluid=l.pluid and m.billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "' and d.qty<0"

        If cmbTerm.SelectedIndex > 0 Then
            SQL &= " and m.termid=" & Val(cmbTerm.Text)
        End If

        SQL &= "order by m.termid,m.billno"

        ESSA.LoadDataGrid(TG, SQL)
        ESSA.AlignHeader(TG, 0, DataGridViewContentAlignment.MiddleLeft, 60)
        ESSA.AlignHeader(TG, 1, DataGridViewContentAlignment.MiddleCenter, 80)
        ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleLeft, 60)
        ESSA.AlignHeader(TG, 3, DataGridViewContentAlignment.MiddleLeft, 100)
        ESSA.AlignHeader(TG, 4, DataGridViewContentAlignment.MiddleRight, 60)
        ESSA.AlignHeader(TG, 5, DataGridViewContentAlignment.MiddleRight, 60)
        ESSA.AlignHeader(TG, 6, DataGridViewContentAlignment.MiddleRight, 60)
        ESSA.AlignHeader(TG, 7, DataGridViewContentAlignment.MiddleLeft, 100)
        ESSA.AlignHeader(TG, 8, DataGridViewContentAlignment.MiddleLeft, 100)
        lblTQty.Text = ESSA.GetColTotal(TG, 4)
        lblAmt.Text = Format(ESSA.GetColTotal(TG, 6), "0.00")

    End Sub

    Private Sub txtProd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtProd.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            SQL = "select pluid,plucode from productmaster where plucode='" & txtProd.Text.Trim & "'"
            With ESSA.OpenReader(SQL)
                If .Read Then
                    LstProd.Items.Add(New VB6.ListBoxItem(.GetString(1).Trim, .Item(0)))
                    lblTItems.Text = LstProd.Items.Count
                    txtProd.Clear()
                Else
                    TTip.Show("Product code not found..!", txtProd, 0, 25, 2000)
                End If
                .Close()
            End With

        End If

    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click

        TGList.Rows.Clear()
        txtProd.Clear()
        LstProd.Items.Clear()
        lblTItems.Text = LstProd.Items.Count

    End Sub

    Private Sub LstProd_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles LstProd.KeyUp

        If e.KeyCode = Keys.Delete Then
            LstProd.Items.RemoveAt(LstProd.SelectedIndex)
            lblTItems.Text = LstProd.Items.Count
        End If

    End Sub

    Private Sub btnHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHide.Click

        pnlVerifier.Visible = False

    End Sub

    Private Sub btnVerify_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerify.Click

        CombineData()

        SQL = "select p.pluid,p.plucode,sum(v.req) r,sum(v.rcvd) rv,sum(v.req-v.rcvd) bal from " _
            & "productmaster p,v_returnverifier v where p.pluid=v.pluid group by p.pluid,p.plucode order by p.plucode"

        TGList.Rows.Clear()

        With ESSA.OpenReader(SQL)
            While .Read
                TGList.Rows.Add()
                TGList.Item(0, TGList.Rows.Count - 1).Value = .Item(0)
                TGList.Item(1, TGList.Rows.Count - 1).Value = .GetString(1).Trim
                TGList.Item(2, TGList.Rows.Count - 1).Value = .Item(2)
                TGList.Item(3, TGList.Rows.Count - 1).Value = .Item(3)
                TGList.Item(4, TGList.Rows.Count - 1).Value = .Item(4)
            End While
            .Close()
        End With

    End Sub

    Private Sub CombineData()

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand

        SQL = "delete from tblreturnverifier_01;delete from tblreturnverifier_02"
        Cmd.CommandText = SQL
        Cmd.ExecuteNonQuery()

        For i As Short = 0 To LstProd.Items.Count - 1

            SQL = "insert into tblreturnverifier_01 values (" _
                & VB6.GetItemData(LstProd, i) & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

        Next

        SQL = "insert into tblreturnverifier_02 " _
            & "select pluid,-qty from billdetails where billdt between '" & Format(mebFrom.Value, "yyyy-MM-dd") & "' and '" _
            & Format(mebTo.Value, "yyyy-MM-dd") & "' and qty<0"

        If cmbTerm.SelectedIndex > 0 Then
            SQL &= " and termid=" & Val(cmbTerm.Text)
        End If

        Cmd.CommandText = SQL
        Cmd.ExecuteNonQuery()

        Con.Close()

    End Sub

    Private Sub btnVerifier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVerifier.Click

        pnlVerifier.Visible = True
        txtProd.Focus()

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub
End Class