Imports System.Data.SqlClient

Public Class frmProductImport

    Private Sub frmProductImport_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        SQL = "SELECT DeliveryCode FROM ReceivedMaster ORDER BY UniqueID"
        ESSA.LoadCombo(cmbCode, SQL, "DeliveryCode")

    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click

        If MsgBox("Do you want to import?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Using Cmd As New SqlCommand("SP_ImportProductDelivery", Con)
            Cmd.CommandType = CommandType.StoredProcedure
            Cmd.Parameters.AddWithValue("DeliveryCode", cmbCode.Text.Trim)
            Cmd.ExecuteNonQuery()
        End Using
        Con.Close()

        MsgBox("Imported Successfully!", MsgBoxStyle.Exclamation)

    End Sub

End Class