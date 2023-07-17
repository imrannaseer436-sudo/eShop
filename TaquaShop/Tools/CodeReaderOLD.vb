Imports System.Data.SqlClient
Imports System.Net.NetworkInformation
Public Class CodeReaderOLD

    Private iPluID As Integer = 0
    Private MacID As String = ""
    Private AlterMode As Boolean = False
    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then

            iPluID = 0

            SQL = "SELECT PLUID FROM PRODUCTMASTER WHERE PLUCODE='" & txtCode.Text.Trim & "'"
            With ESSA.OpenReader(SQL)
                If .Read Then
                    iPluID = .Item(0)
                End If
                .Close()
            End With

            If iPluID = 0 Then
                MsgBox("Sorry, Product Code Not Found..!", vbCritical)
                txtCode.Focus()
                Exit Sub
            End If

            e.SuppressKeyPress = True

            If InsertCode(iPluID, txtCode.Text.Trim.ToUpper) > 0 Then

                txtCode.Clear()
                txtCode.Focus()

            End If

        End If

    End Sub

    Private Function InsertCode(PluID As Integer, iCode As String) As Integer

        TG.Rows.Add()
        TG.Item(0, TG.Rows.Count - 1).Value = PluID
        TG.Item(1, TG.Rows.Count - 1).Value = TG.Rows.Count
        TG.Item(2, TG.Rows.Count - 1).Value = iCode
        TG.FirstDisplayedScrollingRowIndex = TG.Rows.Count - 1

        Dim IStr = "INSERT INTO CODEREADER VALUES (" _
                 & PluID & ",'" _
                 & iCode & "'," _
                 & TG.Rows.Count & ",'" _
                 & MacID & "')"

        Return ESSA.Execute(IStr)

    End Function

    Private Sub btnCA_Click(sender As Object, e As EventArgs) Handles btnCA.Click

        If MsgBox("Do you want to delete all details.!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim Rl = Val(InputBox("Answer the following Question to proceed delete..?" & vbCrLf + "17 X 8 + 5 = ?"))

        If Rl = 141 Then
            ESSA.Execute("DELETE FROM CODEREADER WHERE MACID='" & MacID & "'")
            TG.Rows.Clear()
            MsgBox("Entry deleted successfully..!", MsgBoxStyle.Information)
        Else
            MsgBox("Incorrect Answer..!", vbInformation)
        End If

    End Sub

    Private Sub LoadAllDetails()

        TG.Rows.Clear()

        With ESSA.OpenReader("SELECT * FROM CODEREADER WHERE MACID='" & MacID & "' ORDER BY SNO")

            While .Read

                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = TG.Rows.Count
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1).Trim

            End While

            .Close()

        End With

        If TG.Rows.Count > 0 Then
            TG.FirstDisplayedScrollingRowIndex = TG.Rows.Count - 1
        End If

    End Sub

    Private Sub CodeReader_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MacID = getMacAddress()
        lblMacID.Text = MacID

        LoadDeparments()
        LoadColors()
        LoadAllDetails()
        txtCode.Select()

        TGLst.ColumnHeadersDefaultCellStyle.Font = New Font(TGLst.Font, FontStyle.Bold)

        ESSA.AlignHeader(TGLst, 1, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TGLst, 5, DataGridViewContentAlignment.MiddleRight)

    End Sub

    Private Sub LoadDeparments()

        SQL = "SELECT CATID,CATDESC FROM ESERVER.EWAREHOUSE1213.DBO.CATEGORY ORDER BY CATDESC"
        ESSA.LoadComboSimple(cmbDept, SQL, "CATDESC", "CATID")

    End Sub

    Private Sub LoadColors()

        SQL = "SELECT CID,COLOR FROM COLORS ORDER BY COLOR"
        ESSA.LoadComboSimple(cmbColors, SQL, "COLOR", "CID")

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 3 Then

            If MsgBox("Do you want to remove current row.!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            ESSA.Execute("DELETE FROM CODEREADER WHERE MACID='" & MacID & "' AND SNO=" & Val(TG.Item(1, e.RowIndex).Value))

            MsgBox("Entry deleted successfully..!", MsgBoxStyle.Information)

            TG.Rows.RemoveAt(e.RowIndex)
            txtCode.Focus()

        End If

    End Sub
    Private Function getMacAddress() As String

        Dim nics() As NetworkInterface = _
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString

    End Function

    Private EntryNo As Short = 0
    Private Edit As Boolean = False

    Private Sub GenerateEntryNo()

        EntryNo = ESSA.GenerateID("select max(eno) from crmaster")

    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        If MsgBox("Do you want to save..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            If Edit = True Then

                SQL = "DELETE FROM CRMASTER WHERE ENO=" & EntryNo & ";" _
                    & "DELETE FROM CRDETAIL WHERE ENO=" & EntryNo
                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Else

                GenerateEntryNo()

            End If

            SQL = "INSERT INTO CRMASTER VALUES (" _
                & EntryNo & ",'" _
                & Format(Now, "yyyy-MM-dd HH:mm:ss") & "','" _
                & lblMacID.Text.Trim & "'," _
                & Val(TG.Rows.Count) & "," _
                & UserID & ")"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Integer = 0 To TG.Rows.Count - 1

                SQL = "INSERT INTO CRDETAIL VALUES (" _
                    & EntryNo & "," _
                    & Val(TG.Item(0, i).Value) & ",'" _
                    & Trim(TG.Item(2, i).Value) & "'," _
                    & i + 1 & "," _
                    & ESSA.GetItemValue(cmbDept) & "," _
                    & ESSA.GetItemValue(cmbCat) & "," _
                    & ESSA.GetItemValue(cmbSCat1) & "," _
                    & ESSA.GetItemValue(cmbSCat2) & "," _
                    & ESSA.GetItemValue(cmbSCat3) & ",0," _
                    & ESSA.GetItemValue(cmbColors) & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            Trn.Commit()
            Con.Close()

            MsgBox("Entry Saved Successfully..!", MsgBoxStyle.Information)

            Edit = False
            lblEdit.Visible = Edit
            btnAlter.Text = "&Alter Category"
            cmbColors.SelectedIndex = cmbColors.FindStringExact("NO COLOR")

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub cmbDept_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbDept.SelectedIndexChanged

        If cmbDept.SelectedIndex = -1 Then Exit Sub

        SQL = "SELECT SCATID,SCATDESC FROM ESERVER.EWAREHOUSE1213.DBO.SUBCATEGORY1 WHERE LEN(SCATDESC)>0 AND PVSCATID=" & ESSA.GetItemValue(cmbDept) & " ORDER BY SCATDESC"
        ESSA.LoadComboSimple(cmbCat, SQL, "SCATDESC", "SCATID")

    End Sub

    Private Sub cmbCat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbCat.SelectedIndexChanged

        If cmbCat.SelectedIndex = -1 Then Exit Sub

        SQL = "SELECT SCATID,SCATDESC FROM ESERVER.EWAREHOUSE1213.DBO.SUBCATEGORY2 WHERE LEN(SCATDESC)>0 AND PVSCATID=" & ESSA.GetItemValue(cmbCat) & " ORDER BY SCATDESC"
        ESSA.LoadComboSimple(cmbSCat1, SQL, "SCATDESC", "SCATID")

    End Sub

    Private Sub cmbSCat1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat1.SelectedIndexChanged

        If cmbSCat1.SelectedIndex = -1 Then Exit Sub

        SQL = "SELECT SCATID,SCATDESC FROM ESERVER.EWAREHOUSE1213.DBO.SUBCATEGORY3 WHERE LEN(SCATDESC)>0 AND PVSCATID=" & ESSA.GetItemValue(cmbSCat1) & " ORDER BY SCATDESC"
        ESSA.LoadComboSimple(cmbSCat2, SQL, "SCATDESC", "SCATID")

    End Sub

    Private Sub cmbSCat2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbSCat2.SelectedIndexChanged

        If cmbSCat2.SelectedIndex = -1 Then Exit Sub

        SQL = "SELECT SCATID,SCATDESC FROM ESERVER.EWAREHOUSE1213.DBO.SUBCATEGORY4 WHERE LEN(SCATDESC)>0 AND PVSCATID=" & ESSA.GetItemValue(cmbSCat2) & " ORDER BY SCATDESC"
        ESSA.LoadComboSimple(cmbSCat3, SQL, "SCATDESC", "SCATID")

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

        LoadDeparments()
        LoadColors()

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        pnlList.Visible = False

    End Sub

    Private Sub LoadEntryList()

        SQL = "select distinct m.eno,m.edt,c.catdesc,s1.scatdesc,s2.scatdesc,s3.scatdesc,s4.scatdesc,''," _
            & "m.qty,c.catid,s1.scatid,s2.scatid,s3.scatid,s4.scatid " _
            & "from crmaster m,crdetail d,category c,subcategory1 s1,subcategory2 s2," _
            & "subcategory3 s3,subcategory4 s4 " _
            & "where m.eno=d.eno and d.catid=c.catid and d.scatid1=s1.scatid and d.scatid2=s2.scatid " _
            & "and d.scatid3=s3.scatid and d.scatid4=s4.scatid and m.macid='" & lblMacID.Text.Trim & "' order by m.eno"

        With ESSA.OpenReader(SQL)
            TGLst.Rows.Clear()
            While .Read
                TGLst.Rows.Add()
                TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
                TGLst.Item(1, TGLst.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                TGLst.Item(2, TGLst.Rows.Count - 1).Value = .GetString(2).Trim
                TGLst.Item(3, TGLst.Rows.Count - 1).Value = .GetString(3).Trim
                TGLst.Item(4, TGLst.Rows.Count - 1).Value = .GetString(4).Trim
                TGLst.Item(5, TGLst.Rows.Count - 1).Value = .GetString(5).Trim
                TGLst.Item(6, TGLst.Rows.Count - 1).Value = .GetString(6).Trim
                TGLst.Item(7, TGLst.Rows.Count - 1).Value = .GetString(7).Trim
                TGLst.Item(8, TGLst.Rows.Count - 1).Value = .Item(8)
                TGLst.Item(11, TGLst.Rows.Count - 1).Value = .Item(9)
                TGLst.Item(12, TGLst.Rows.Count - 1).Value = .Item(10)
                TGLst.Item(13, TGLst.Rows.Count - 1).Value = .Item(11)
                TGLst.Item(14, TGLst.Rows.Count - 1).Value = .Item(12)
                TGLst.Item(15, TGLst.Rows.Count - 1).Value = .Item(13)
            End While
            .Close()
        End With

    End Sub

    Private Sub btnAlter_Click(sender As Object, e As EventArgs) Handles btnAlter.Click

        LoadEntryList()
        pnlList.Visible = True

    End Sub

    Private Sub TGLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TGLst.CellClick

        If e.RowIndex = -1 Then Exit Sub

        lblCatTree.Text = Trim(TGLst.Item(2, e.RowIndex).Value) _
                         & " -> " & Trim(TGLst.Item(3, e.RowIndex).Value) _
                         & " -> " & Trim(TGLst.Item(4, e.RowIndex).Value) _
                         & " -> " & Trim(TGLst.Item(5, e.RowIndex).Value) _
                         & " -> " & Trim(TGLst.Item(6, e.RowIndex).Value)

        If e.ColumnIndex = 9 Then

            Edit = True
            lblEdit.Visible = Edit
            btnAlter.Text = "&Cancel Edit"

            cmbDept.SelectedIndex = cmbDept.FindStringExact(Trim(TGLst.Item(2, e.RowIndex).Value))
            cmbCat.SelectedIndex = cmbCat.FindStringExact(Trim(TGLst.Item(3, e.RowIndex).Value))
            cmbSCat1.SelectedIndex = cmbSCat1.FindStringExact(Trim(TGLst.Item(4, e.RowIndex).Value))
            cmbSCat2.SelectedIndex = cmbSCat2.FindStringExact(Trim(TGLst.Item(5, e.RowIndex).Value))
            cmbSCat3.SelectedIndex = cmbSCat3.FindStringExact(Trim(TGLst.Item(6, e.RowIndex).Value))

            'ESSA.GetItemValue = Val(TGLst.Item(11, e.RowIndex).Value)
            'cmbCat.SelectedValue = Val(TGLst.Item(12, e.RowIndex).Value)
            'cmbSCat1.SelectedValue = Val(TGLst.Item(13, e.RowIndex).Value)
            'cmbSCat2.SelectedValue = Val(TGLst.Item(14, e.RowIndex).Value)
            'cmbSCat3.SelectedValue = Val(TGLst.Item(15, e.RowIndex).Value)

            SQL = "select d.pluid,d.plucode from crdetail d,crmaster m where m.eno=d.eno and m.eno={0} order by d.sno"
            With ESSA.OpenReader(String.Format(SQL, Val(TGLst.Item(0, e.RowIndex).Value)))
                TG.Rows.Clear()
                While .Read
                    TG.Rows.Add()
                    TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                    TG.Item(1, TG.Rows.Count - 1).Value = TG.Rows.Count
                    TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1).Trim
                End While
                .Close()
            End With

            pnlList.Visible = False

        End If

    End Sub

End Class