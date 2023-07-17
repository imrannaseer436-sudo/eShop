Public Class ProductChecker

    Private Sub ProductChecker_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TGV_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TGV.CellContentClick

    End Sub

    Private Sub TGV_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles TGV.Resize

        TGV.Columns(2).Width = TGV.Width - 400

    End Sub

End Class