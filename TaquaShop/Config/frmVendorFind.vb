Public Class frmVendorFind

    Private Sub btnFind_Click(sender As Object, e As EventArgs) Handles btnFind.Click

        txtVendor.Text = ""

        SQL = "SELECT P.VendorId,V.VendorName FROM ProductMaster P, Vendors V WHERE P.VendorId = V.VendorId AND P.PluCode = '" & txtCode.Text.Trim & "'"

        With ESSA.OpenReader(SQL)
            If .Read Then
                txtVendor.Text = .GetString(1)
            Else
                MsgBox("Code not found.", MsgBoxStyle.Critical)
                txtCode.SelectAll()
                txtCode.Focus()
            End If
            .Close()
        End With

    End Sub
End Class