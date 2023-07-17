'**************************************** Bismillah *****************************************
Public Class DayEndGenerator

    Private Sub btnGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGenerate.Click

        Me.Cursor = Cursors.WaitCursor

        Dim bex As New iBillExporter
        bex.GenerateDateFiles(mebDt.Value)
        MsgBox("File generated successfully..!", vbInformation)

        Me.Cursor = Cursors.Arrow

    End Sub

End Class