Imports System.ComponentModel
Imports System.Data.SqlClient
Imports Zuby.ADGV

Public Class FloorUpdater

    Private data As New DataTable
    Private bindingSource1 As New BindingSource

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        If chkShowAll.Checked Then

            SQL = "SELECT P.PluId, P.Plucode, P.Pluname, P.RackNo, A.Department, A.Category, A.Style, A.Pattern, A.Material " _
                & "FROM ProductMaster P, ProductAttributes A, V_StockPos V " _
                & "WHERE P.PluId = A.PluId AND P.PluId = V.PluId AND V.Stock>0"

        Else

            SQL = "SELECT P.PluId, P.Plucode, P.Pluname, P.RackNo, A.Department, A.Category, A.Style, A.Pattern, A.Material " _
                & "FROM ProductMaster P, ProductAttributes A, ReceivedDetails V " _
                & "WHERE P.PluId = A.PluId AND P.PluId = V.PluId AND V.DeliveryCode='" _
                & cmbDeliveryCode.Text.Trim & "'"

        End If

        loadData(SQL)

    End Sub

    Public Sub loadDataFromBill(rackNo As String, fromDate As Date, toDate As Date)

        SQL = "SELECT P.PluId, P.Plucode, P.Pluname, P.RackNo, A.Department," _
            & "A.Category, A.Style, A.Pattern, A.Material " _
            & "FROM (SELECT P.PluId, P.Plucode, P.Pluname, P.RackNo FROM ProductMaster P, BillDetails V " _
            & "WHERE P.PluId = V.PluId AND V.BillDt BETWEEN '{1}' AND '{2}' AND P.RackNo='{0}') P " _
            & "LEFT OUTER JOIN (SELECT A.PluId, A.Department, A.Category, A.Style, A.Pattern, A.Material FROM ProductAttributes A) A " _
            & "ON P.PluId = A.PluId"

        'SQL = "SELECT P.PluId, P.Plucode, P.Pluname, P.RackNo, A.Department, A.Category, A.Style, A.Pattern, A.Material " _
        '    & "FROM ProductMaster P, ProductAttributes A, BillDetails V " _
        '    & "WHERE P.PluId = A.PluId AND P.PluId = V.PluId " _
        '    & "AND P.RackNo='{0}' AND V.BillDt BETWEEN '{1}' AND '{2}'"

        SQL = String.Format(SQL, rackNo, sqlDate(fromDate), sqlDate(toDate))

        loadData(SQL)

    End Sub

    Private Sub loadData(iSql As String)

        setLoader()

        ESSA.OpenConnection()
        Using adp As New SqlDataAdapter(SQL, Con)
            data.Clear()
            adp.Fill(data)
        End Using
        Con.Close()

        dgvList.CleanFilterAndSort()
        bindingSource1.DataSource = data
        dgvList.DataSource = bindingSource1.DataSource

        pnlLoad.Hide()

    End Sub

    Private Sub dgvList_SortStringChanged(sender As Object, e As AdvancedDataGridView.SortEventArgs) Handles dgvList.SortStringChanged

        bindingSource1.Sort = dgvList.SortString

    End Sub

    Private Sub dgvList_FilterStringChanged(sender As Object, e As AdvancedDataGridView.FilterEventArgs) Handles dgvList.FilterStringChanged

        bindingSource1.Filter = dgvList.FilterString

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlFloorUpdate.Hide()

    End Sub

    Private Sub FloorUpdater_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        pbar1.CheckForIllegalCrossThreadCalls = False
        lblPerc.CheckForIllegalCrossThreadCalls = False

        cmbFloor.Items.AddRange({0, 1, 2, 3, 4, 5, ""})
        cmbFloor.SelectedIndex = 0

        SQL = "SELECT DISTINCT DeliveryCode, UniqueID FROM ReceivedMaster ORDER BY UniqueID"
        ESSA.LoadCombo(cmbDeliveryCode, SQL, "DeliveryCode")

        dgvList.ColumnHeadersDefaultCellStyle.Font = New Font(dgvList.Font, FontStyle.Bold)

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        pnlFloorUpdate.Show()
        cmbFloor.Focus()
        btnUpdate2.Enabled = dgvList.Rows.Count > 0

    End Sub

    Private Sub FloorUpdater_Resize(sender As Object, e As EventArgs) Handles Me.Resize

        ESSA.AlignCenter(pnlFloorUpdate, Me)
        ESSA.AlignCenter(pnlLoad, Me)

    End Sub

    Private Sub setLoader(Optional message As String = "Loading, Please Wait..!")

        lblMessage.Text = message
        pnlLoad.Show()
        pnlLoad.Refresh()

    End Sub

    Private Sub btnUpdate2_Click(sender As Object, e As EventArgs) Handles btnUpdate2.Click

        If dgvList.Rows.Count = 0 Then Exit Sub

        If MsgBox("Are you sure, do you want to update..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        setLoader("Updating, Please Wait..!")

        pnlFloorUpdate.Hide()

        bgw1.RunWorkerAsync()

    End Sub

    Private errorMessage As String = ""

    Private Sub bgw1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles bgw1.DoWork

        Dim gd1 = (From a In dgvList.Rows.Cast(Of DataGridViewRow)() Select New With {Key .PluId = a.Cells("PluId").Value.ToString()}).ToList()

        pbar1.Value = 0
        pbar1.Maximum = gd1.Count
        pbar1.Step = 1
        lblPerc.Text = "0 %"

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand

        Try

            For Each results In gd1

                SQL = "UPDATE ProductMaster SET RackNo='" _
                    & cmbFloor.Text.Trim & "' WHERE PluId=" _
                    & Val(results.PluId)

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

                pbar1.PerformStep()
                lblPerc.Text = Int((pbar1.Value / pbar1.Maximum) * 100) & " %"

            Next

            Con.Close()

        Catch ex As SqlException

            Con.Close()
            errorMessage = ex.Message
            e.Cancel = True

        End Try

    End Sub

    Private Sub bgw1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles bgw1.RunWorkerCompleted

        If e.Cancelled Then
            MsgBox(errorMessage, MsgBoxStyle.Critical)
        Else
            pbar1.Value = pbar1.Maximum
            MsgBox("Floor details updated successfully..!", MsgBoxStyle.Information)
        End If

        pnlLoad.Hide()

    End Sub

End Class