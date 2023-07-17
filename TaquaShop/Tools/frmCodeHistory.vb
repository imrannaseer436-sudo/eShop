Public Class frmCodeHistory

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        Dim Qty As Double = 0

        SQL = "select pluid from productmaster where plucode='" & txtCode.Text.Trim & "'"
        If Not ESSA.ISFound(SQL) Then
            TG.Rows.Clear()
            lblTQty.Text = "0"
            MsgBox("Sorry, Incorrect product code..!", MsgBoxStyle.Critical)
            txtCode.Focus()
            Exit Sub
        End If

        SQL = "select deliverydate,TTYPE, QTY from v_currentstockpos v, productmaster p where v.pluid=p.pluid " _
            & "and p.plucode='{0}' and qty>0 and v.location_id = " & ShopID & " order by deliverydate"

        SQL = String.Format(SQL, txtCode.Text.Trim)

        With ESSA.OpenReader(SQL)
            TG.Rows.Clear()
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = Format(.GetDateTime(0).Date, "dd-MM-yyyy")
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(2, TG.Rows.Count - 1).Value = .Item(2)
            End While
            .Close()
        End With

        SQL = "select stock from v_stockpos v,productmaster p where v.pluid=p.pluid and v.location_id = " & ShopID & " and p.plucode='" _
            & txtCode.Text.Trim & "'"

        lblTQty.Text = ESSA.GetData(SQL)

    End Sub

    Private Sub frmCodeHistory_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        ESSA.AlignHeader(TG, 2, DataGridViewContentAlignment.MiddleRight)

    End Sub

End Class