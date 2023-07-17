Public Class TaquaShopSettings

    Private Sub TaquaShopSettings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadSettings()

    End Sub

    Private Sub LoadSettings()

        SQL = "SELECT PARAM_VALUE FROM SETTINGS WHERE PARAM_NAME='ExportFileLocation';" _
            & "SELECT PARAM_VALUE FROM SETTINGS WHERE PARAM_NAME='EnableDeliveryFilter';" _
            & "SELECT PARAM_VALUE FROM SETTINGS WHERE PARAM_NAME='DeliveryFilterDate'"

        With ESSA.OpenReader(SQL)
            If .Read Then
                txtEFL.Text = .GetString(0).Trim
            End If
            .NextResult()
            If .Read Then
                chkEDF.Checked = IIf(Val(.GetString(0)) = 0, False, True)
            End If
            .NextResult()
            If .Read Then
                mebFDate.Value = CDate(.GetString(0)).Date
            End If
            .Close()
        End With

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        FBD.ShowDialog()
        txtEFL.Text = FBD.SelectedPath & "\"

    End Sub

    Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpdate.Click

        SQL = "SELECT PARAM_VALUE FROM SETTINGS WHERE PARAM_NAME='ExportFileLocation'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                ESSA.Execute("UPDATE SETTINGS SET PARAM_VALUE='" & txtEFL.Text.Trim & "' WHERE PARAM_NAME='ExportFileLocation'")
            Else
                ESSA.Execute("INSERT INTO SETTINGS VALUES ('" & "ExportFileLocation','" & txtEFL.Text.Trim & "')")
            End If
            .Close()
        End With

        SQL = "SELECT PARAM_VALUE FROM SETTINGS WHERE PARAM_NAME='EnableDeliveryFilter'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                ESSA.Execute("UPDATE SETTINGS SET PARAM_VALUE='" & IIf(chkEDF.Checked = True, 1, 0) & "' WHERE PARAM_NAME='EnableDeliveryFilter'")
            Else
                ESSA.Execute("INSERT INTO SETTINGS VALUES ('" & "EnableDeliveryFilter','" & IIf(chkEDF.Checked = True, 1, 0) & "')")
            End If
            .Close()
        End With

        SQL = "SELECT PARAM_VALUE FROM SETTINGS WHERE PARAM_NAME='DeliveryFilterDate'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                ESSA.Execute("UPDATE SETTINGS SET PARAM_VALUE='" & Format(mebFDate.Value, "yyyy-MM-dd") & "' WHERE PARAM_NAME='DeliveryFilterDate'")
            Else
                ESSA.Execute("INSERT INTO SETTINGS VALUES ('" & "DeliveryFilterDate','" & Format(mebFDate.Value, "yyyy-MM-dd") & "')")
            End If
            .Close()
        End With

        MsgBox("Settings updated successfully..!", vbExclamation)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

End Class