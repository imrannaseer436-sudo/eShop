Imports System.Data.SqlClient
Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Threading.Tasks
Imports Excel = Microsoft.Office.Interop.Excel

Public Class CodeReaderAdv

    Private Sub CodeReaderAdv_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        MacID = getMacAddress()
        lblMacID.Text = MacID

        TGLst.ColumnHeadersDefaultCellStyle.Font = New Font(TGLst.Font, FontStyle.Bold)

        ESSA.AlignHeader(TGLst, 1, DataGridViewContentAlignment.MiddleCenter)
        ESSA.AlignHeader(TGLst, 5, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignCenter(pnlLoading, Me)

        LoadAttributes()
        ResetAttributes()
        LoadAllDetails()

        txtCode.Select()

    End Sub

    Private Sub ResetAttributes()

        cmbBrand.SelectedValue = 1
        cmbCatalog.SelectedValue = 1
        cmbCat.SelectedValue = 1
        cmbColor.SelectedValue = 1
        cmbDept.SelectedValue = 1
        cmbMts.SelectedValue = 1
        cmbPattern.SelectedValue = 1
        cmbSleeve.SelectedValue = 1
        cmbStyle.SelectedValue = 1
        cmbIsStich.SelectedIndex = 0

    End Sub

    Private Sub SelectAttributes()

        cmbBrand.SelectedIndex = cmbBrand.FindStringExact(cmbBrand.Text)
        cmbCatalog.SelectedIndex = cmbCatalog.FindStringExact(cmbCatalog.Text)
        cmbCat.SelectedIndex = cmbCat.FindStringExact(cmbCat.Text)
        cmbColor.SelectedIndex = cmbColor.FindStringExact(cmbColor.Text)
        cmbDept.SelectedIndex = cmbDept.FindStringExact(cmbDept.Text)
        cmbMts.SelectedIndex = cmbMts.FindStringExact(cmbMts.Text)
        cmbPattern.SelectedIndex = cmbPattern.FindStringExact(cmbPattern.Text)
        cmbSleeve.SelectedIndex = cmbSleeve.FindStringExact(cmbSleeve.Text)
        cmbStyle.SelectedIndex = cmbStyle.FindStringExact(cmbStyle.Text)

    End Sub

    Private Sub LoadAttributes()

        SQL = "SELECT BrandId,Brand FROM TSBrand  ORDER BY Brand"
        ESSA.LoadCombo(cmbBrand, SQL, "Brand", "BrandId")

        SQL = "SELECT CatalogId,Catalog FROM TSCatalog  ORDER BY Catalog"
        ESSA.LoadCombo(cmbCatalog, SQL, "Catalog", "CatalogId")

        SQL = "SELECT CatId,Category FROM TSCategory  ORDER BY Category"
        ESSA.LoadCombo(cmbCat, SQL, "Category", "CatId")

        SQL = "SELECT  ColorId,Color FROM  TSColor WHERE IsActive=1 ORDER BY Color"
        ESSA.LoadCombo(cmbColor, SQL, "Color", "ColorId")

        SQL = "SELECT  DeptId,Department FROM   TSDepartment  ORDER BY Department"
        ESSA.LoadCombo(cmbDept, SQL, "Department", "DeptId")

        SQL = "SELECT  MaterialId,Material FROM   TSMaterial  ORDER BY Material"
        ESSA.LoadCombo(cmbMts, SQL, "Material", "MaterialId")

        SQL = "SELECT  PatternId,Pattern FROM   TSPattern  ORDER BY Pattern"
        ESSA.LoadCombo(cmbPattern, SQL, "Pattern", "PatternId")

        SQL = "SELECT  SleeveId,Sleeve FROM   TSSleeve  ORDER BY Sleeve"
        ESSA.LoadCombo(cmbSleeve, SQL, "Sleeve", "SleeveId")

        SQL = "SELECT  StyleId,Style  FROM   TSStyle  ORDER BY Style "
        ESSA.LoadCombo(cmbStyle, SQL, "Style", "StyleId")

    End Sub

    Private Sub btnReload_Click(sender As Object, e As EventArgs) Handles btnReload.Click

        LoadAttributes()
        ResetAttributes()

    End Sub


    Private iPluID As Integer = 0
    Private MacID As String = ""
    'Private AlterMode As Boolean = False

    Private count As Short = 0
    Private Sub txtCode_KeyDown(sender As Object, e As KeyEventArgs) Handles txtCode.KeyDown

        If e.KeyCode = Keys.Enter Then
            e.SuppressKeyPress = True

            If ChkCodeFilter.Checked Then
                ApplyFilter(True)
                Exit Sub
            End If

            count = 1
            If ChkCounter.Checked Then
                count = Val(InputBox("Please enter no of pcs?"))
            End If
            If count = 0 Then count = 1

            If ChkSkipRate.Checked Then
                AddItems(count)
                generateCatLink(TG.Item(0, TG.Rows.Count - 1).Value)
            Else
                Me.ProcessTabKey(True)
            End If
            'Me.ProcessTabKey(True)
        End If

        'If e.KeyCode = Keys.Enter Then

        '    iPluID = 0

        '    SQL = "SELECT PLUID FROM PRODUCTMASTER WHERE PLUCODE='" & txtCode.Text.Trim & "'"
        '    With ESSA.OpenReader(SQL)
        '        If .Read Then
        '            iPluID = .Item(0)
        '        End If
        '        .Close()
        '    End With

        '    If iPluID = 0 Then
        '        MsgBox("Sorry, Product Code Not Found..!", vbCritical)
        '        txtCode.Focus()
        '        Exit Sub
        '    End If

        '    e.SuppressKeyPress = True

        '    If InsertCode(iPluID, txtCode.Text.Trim.ToUpper) > 0 Then

        '        txtCode.Clear()
        '        txtCode.Focus()

        '    End If

        'End If

    End Sub

    Private Function InsertCode(PluID As Integer, iCode As String, Rate As Double, Count As Short) As Integer

        For i As Short = 1 To Count

            TG.Rows.Add()

            Dim sNo As Integer = If(TG.Rows.Count = 1, 1, Val(TG.Item(1, Math.Max(TG.Rows.Count - 2, 0)).Value) + 1)

            TG.Item(0, TG.Rows.Count - 1).Value = PluID
            TG.Item(1, TG.Rows.Count - 1).Value = sNo
            TG.Item(2, TG.Rows.Count - 1).Value = iCode
            TG.Item(3, TG.Rows.Count - 1).Value = Format(Rate, "0.00")
            TG.FirstDisplayedScrollingRowIndex = TG.Rows.Count - 1
            TG.CurrentCell = TG(2, TG.Rows.Count - 1)

            Dim IStr = "INSERT INTO CODEREADER VALUES (" _
                 & PluID & ",'" _
                 & iCode & "'," _
                 & sNo & ",'" _
                 & MacID & "'," _
                 & Val(txtRate.Text) & ", GETDATE(), NEWID(), " & ShopID & ")"

            ESSA.Execute(IStr)

        Next

        Return Count

    End Function

    Private Sub btnCA_Click(sender As Object, e As EventArgs) Handles btnCA.Click

        If MsgBox("Do you want to delete all details.!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Dim Rl = Val(InputBox("Answer the following Question to proceed delete..?" & vbCrLf + "17 X 8 + 5 = ?"))

        If Rl = 141 Then
            ESSA.Execute("DELETE FROM CODEREADER WHERE SHOPID = " & ShopID & " AND MACID='" & MacID & "'")
            TG.Rows.Clear()
            MsgBox("Entry deleted successfully..!", MsgBoxStyle.Information)
        Else
            MsgBox("Incorrect Answer..!", vbInformation)
        End If

    End Sub

    Private Sub LoadAllDetails()

        TG.Rows.Clear()

        With ESSA.OpenReader("SELECT * FROM CODEREADER WHERE MACID='" & MacID & "' AND ShopId = " & ShopID & " ORDER BY SNO")

            While .Read

                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .Item(2)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1).Trim
                TG.Item(3, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")

            End While

            .Close()

        End With

        If TG.Rows.Count > 0 Then
            TG.FirstDisplayedScrollingRowIndex = TG.Rows.Count - 1
        End If

    End Sub

    Private Sub TG_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TG.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 4 Then

            If MsgBox("Do you want to remove current row.!", MsgBoxStyle.Critical + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

            ESSA.Execute("DELETE FROM CODEREADER WHERE ShopId = " & ShopID & " AND MACID='" & MacID & "' AND SNO=" & Val(TG.Item(1, e.RowIndex).Value) & " AND PluId=" & Val(TG.Item(0, e.RowIndex).Value))

            MsgBox("Entry deleted successfully..!", MsgBoxStyle.Information)

            TG.Rows.RemoveAt(e.RowIndex)
            txtCode.Focus()

        End If

        If e.ColumnIndex = 2 Then

            iPluID = TG.Item(0, e.RowIndex).Value

            SQL = "SELECT " _
              & "A.DeptId," _
              & "A.CatId," _
              & "A.StyleId," _
              & "A.PatternId," _
              & "A.MaterialId," _
              & "A.ColorId," _
              & "A.SleeveId," _
              & "A.BrandId," _
              & "A.CatalogId, " _
              & "M.IsTaxable " _
              & "FROM ProductAttributes A,ProductMaster M " _
              & "WHERE A.PluId = M.PluId AND A.PluId = " & iPluID

            With ESSA.OpenReader(SQL)

                If .Read Then
                    cmbDept.SelectedValue = .Item(0)
                    cmbCat.SelectedValue = .Item(1)
                    cmbStyle.SelectedValue = .Item(2)
                    cmbPattern.SelectedValue = .Item(3)
                    cmbMts.SelectedValue = .Item(4)
                    cmbColor.SelectedValue = .Item(5)
                    cmbSleeve.SelectedValue = .Item(6)
                    cmbBrand.SelectedValue = .Item(7)
                    cmbCatalog.SelectedValue = .Item(8)
                    cmbIsStich.SelectedIndex = .Item(9)
                End If
                .Close()
            End With

        End If

    End Sub

    Private Function getMacAddress() As String

        Dim nics() As NetworkInterface =
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString

    End Function

    Private EntryNo As Short = 0
    Private Edit As Boolean = False

    Private Sub GenerateEntryNo()

        EntryNo = ESSA.GenerateID("select max(eno) from crmaster")

    End Sub

    Private Function ValidateAttributes() As Boolean

        ValidateAttributes = True

        For Each ctl In Me.Controls

            If TypeOf ctl Is ComboBox Then
                If CType(ctl, ComboBox).SelectedIndex = -1 Then
                    ValidateAttributes = False
                    Exit For
                End If
            End If

        Next

    End Function
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click

        SelectAttributes()

        If Not ValidateAttributes() Then
            MsgBox("Please select attribute properly.!", MsgBoxStyle.Critical)
            Exit Sub
        End If

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
                & UserID & ", 0)"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Integer = 0 To TG.Rows.Count - 1

                SQL = "INSERT INTO CRDETAIL VALUES (" _
                    & EntryNo & "," _
                    & Val(TG.Item(0, i).Value) & ",'" _
                    & Trim(TG.Item(2, i).Value) & "'," _
                    & i + 1 & "," _
                    & cmbDept.SelectedValue & "," _
                    & cmbCat.SelectedValue & "," _
                    & cmbStyle.SelectedValue & "," _
                    & cmbPattern.SelectedValue & "," _
                    & cmbMts.SelectedValue & "," _
                    & cmbColor.SelectedValue & "," _
                    & cmbSleeve.SelectedValue & "," _
                    & cmbBrand.SelectedValue & "," _
                    & cmbCatalog.SelectedValue & "," _
                    & cmbIsStich.SelectedIndex & ", NULL," _
                    & Val(TG.Item(3, i).Value) & ")"

                Cmd.CommandText = SQL
                Cmd.ExecuteNonQuery()

            Next

            SQL = "DELETE FROM CodeReader WHERE MacID='" & lblMacID.Text.Trim & "'"
            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            Trn.Commit()
            Con.Close()

            MsgBox("Entry Saved Successfully..!", MsgBoxStyle.Information)

            Edit = False
            lblEdit.Visible = Edit
            ResetAttributes()
            TG.Rows.Clear()

        Catch ex As SqlException

            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub


    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        pnlList.Visible = False

    End Sub

    Private Sub btnEntryViewer_Click(sender As Object, e As EventArgs) Handles btnEntryViewer.Click

        CodeReaderView.Visible = False
        CodeReaderView.Show()

    End Sub

    Private Sub btnSyncAttrib_Click(sender As Object, e As EventArgs) Handles btnSyncAttrib.Click

        If MsgBox("Sync Attributes ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then Exit Sub

        Try

            ESSA.OpenConnection()
            Using Cmd As New SqlCommand()
                Cmd.Connection = Con
                Cmd.CommandType = CommandType.StoredProcedure
                Cmd.CommandText = "SyncAttributes"
                Cmd.ExecuteNonQuery()
            End Using
            Con.Close()

            MsgBox("Attributes has been synced..!", MsgBoxStyle.Exclamation)

        Catch ex As SqlException
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Private Sub txtRate_KeyDown(sender As Object, e As KeyEventArgs) Handles txtRate.KeyDown

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

            If InsertCode(iPluID, txtCode.Text.Trim.ToUpper, Val(txtRate.Text), count) > 0 Then

                txtCode.Clear()
                txtRate.Clear()
                txtCode.Focus()

            End If

        End If

    End Sub

    'Private Sub LoadEntryList()

    '    SQL = "select distinct m.eno,m.edt,c.catdesc,s1.scatdesc,s2.scatdesc,s3.scatdesc,s4.scatdesc,''," _
    '        & "m.qty,c.catid,s1.scatid,s2.scatid,s3.scatid,s4.scatid " _
    '        & "from crmaster m,crdetail d,category c,subcategory1 s1,subcategory2 s2," _
    '        & "subcategory3 s3,subcategory4 s4 " _
    '        & "where m.eno=d.eno and d.catid=c.catid and d.scatid1=s1.scatid and d.scatid2=s2.scatid " _
    '        & "and d.scatid3=s3.scatid and d.scatid4=s4.scatid and m.macid='" & lblMacID.Text.Trim & "' order by m.eno"

    '    With ESSA.OpenReader(SQL)
    '        TGLst.Rows.Clear()
    '        While .Read
    '            TGLst.Rows.Add()
    '            TGLst.Item(0, TGLst.Rows.Count - 1).Value = .Item(0)
    '            TGLst.Item(1, TGLst.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
    '            TGLst.Item(2, TGLst.Rows.Count - 1).Value = .GetString(2).Trim
    '            TGLst.Item(3, TGLst.Rows.Count - 1).Value = .GetString(3).Trim
    '            TGLst.Item(4, TGLst.Rows.Count - 1).Value = .GetString(4).Trim
    '            TGLst.Item(5, TGLst.Rows.Count - 1).Value = .GetString(5).Trim
    '            TGLst.Item(6, TGLst.Rows.Count - 1).Value = .GetString(6).Trim
    '            TGLst.Item(7, TGLst.Rows.Count - 1).Value = .GetString(7).Trim
    '            TGLst.Item(8, TGLst.Rows.Count - 1).Value = .Item(8)
    '            TGLst.Item(11, TGLst.Rows.Count - 1).Value = .Item(9)
    '            TGLst.Item(12, TGLst.Rows.Count - 1).Value = .Item(10)
    '            TGLst.Item(13, TGLst.Rows.Count - 1).Value = .Item(11)
    '            TGLst.Item(14, TGLst.Rows.Count - 1).Value = .Item(12)
    '            TGLst.Item(15, TGLst.Rows.Count - 1).Value = .Item(13)
    '        End While
    '        .Close()
    '    End With

    'End Sub

    'Private Sub btnAlter_Click(sender As Object, e As EventArgs) Handles btnAlter.Click

    '    LoadEntryList()
    '    pnlList.Visible = True

    'End Sub

    'Private Sub TGLst_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles TGLst.CellClick

    '    If e.RowIndex = -1 Then Exit Sub

    '    lblCatTree.Text = Trim(TGLst.Item(2, e.RowIndex).Value) _
    '                     & " -> " & Trim(TGLst.Item(3, e.RowIndex).Value) _
    '                     & " -> " & Trim(TGLst.Item(4, e.RowIndex).Value) _
    '                     & " -> " & Trim(TGLst.Item(5, e.RowIndex).Value) _
    '                     & " -> " & Trim(TGLst.Item(6, e.RowIndex).Value)

    '    If e.ColumnIndex = 9 Then

    '        Edit = True
    '        lblEdit.Visible = Edit
    '        btnAlter.Text = "&Cancel Edit"

    '        cmbDept.SelectedIndex = cmbDept.FindStringExact(Trim(TGLst.Item(2, e.RowIndex).Value))
    '        cmbCat.SelectedIndex = cmbCat.FindStringExact(Trim(TGLst.Item(3, e.RowIndex).Value))
    '        cmbSCat1.SelectedIndex = cmbSCat1.FindStringExact(Trim(TGLst.Item(4, e.RowIndex).Value))
    '        cmbSCat2.SelectedIndex = cmbSCat2.FindStringExact(Trim(TGLst.Item(5, e.RowIndex).Value))
    '        cmbSCat3.SelectedIndex = cmbSCat3.FindStringExact(Trim(TGLst.Item(6, e.RowIndex).Value))

    '        'ESSA.GetItemValue = Val(TGLst.Item(11, e.RowIndex).Value)
    '        'cmbCat.SelectedValue = Val(TGLst.Item(12, e.RowIndex).Value)
    '        'cmbSCat1.SelectedValue = Val(TGLst.Item(13, e.RowIndex).Value)
    '        'cmbSCat2.SelectedValue = Val(TGLst.Item(14, e.RowIndex).Value)
    '        'cmbSCat3.SelectedValue = Val(TGLst.Item(15, e.RowIndex).Value)

    '        SQL = "select d.pluid,d.plucode from crdetail d,crmaster m where m.eno=d.eno and m.eno={0} order by d.sno"
    '        With ESSA.OpenReader(String.Format(SQL, Val(TGLst.Item(0, e.RowIndex).Value)))
    '            TG.Rows.Clear()
    '            While .Read
    '                TG.Rows.Add()
    '                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
    '                TG.Item(1, TG.Rows.Count - 1).Value = TG.Rows.Count
    '                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(1).Trim
    '            End While
    '            .Close()
    '        End With

    '        pnlList.Visible = False

    '    End If

    'End Sub

    Private Sub ChkSkipRate_CheckedChanged(sender As Object, e As EventArgs) Handles ChkSkipRate.CheckedChanged

        txtRate.Clear()
        txtRate.Enabled = Not ChkSkipRate.Checked

    End Sub

    Private Sub generateCatLink(input As Integer)

        Dim link As String = ""
        SQL = "SELECT DeptId,Department,CatId,Category,StyleId,Style,MaterialId,Material FROM ProductAttributes WHERE PluId = " & input

        With ESSA.OpenReader(SQL)
            If .Read Then

                If Val(.Item(0)) > 1 Then
                    link &= .GetString(1).Trim & "->"
                End If

                If Val(.Item(2)) > 1 Then
                    link &= .GetString(3).Trim & "->"
                End If

                If Val(.Item(4)) > 1 Then
                    link &= .GetString(5).Trim & "->"
                End If

                If Val(.Item(6)) > 1 Then
                    link &= .GetString(7).Trim & "->"
                End If

                If link.Length > 0 Then
                    link = Mid(link, 1, link.Length - 2)
                End If

            End If
            .Close()
        End With

        lblLink.Text = link

    End Sub

    Private Sub UpdateAttributes(input As Integer)

        If iPluID = 0 Then
            MsgBox("Already updated..!", MsgBoxStyle.Critical)
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim cmd = Con.CreateCommand()
        Dim trn = Con.BeginTransaction
        cmd.Transaction = trn

        Try

            'ESSA.OpenConnection()
            'Using cmd As New SqlCommand("SP_UpdateAttributes", Con)
            '    'cmd.CommandText = "SP_UpdateAttributes"
            '    cmd.CommandType = CommandType.StoredProcedure
            '    cmd.CommandTimeout = 0
            '    cmd.Parameters.Clear()
            '    cmd.Parameters.AddWithValue("@DeptId", cmbDept.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Department", cmbDept.Text.Trim)
            '    cmd.Parameters.AddWithValue("@CatId", cmbCat.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Category", cmbCat.Text.Trim)
            '    cmd.Parameters.AddWithValue("@StyleId", cmbStyle.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Style", cmbStyle.Text.Trim)
            '    cmd.Parameters.AddWithValue("@PatternId", cmbPattern.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Pattern", cmbPattern.Text.Trim)
            '    cmd.Parameters.AddWithValue("@MaterialId", cmbMts.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Material", cmbMts.Text.Trim)
            '    cmd.Parameters.AddWithValue("@ColorId", cmbColor.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Color", cmbColor.Text.Trim)
            '    cmd.Parameters.AddWithValue("@SleeveId", cmbSleeve.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Sleeve", cmbSleeve.Text.Trim)
            '    cmd.Parameters.AddWithValue("@BrandId", cmbBrand.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Brand", cmbBrand.Text.Trim)
            '    cmd.Parameters.AddWithValue("@CatalogId", cmbCatalog.SelectedValue)
            '    cmd.Parameters.AddWithValue("@Catalog", cmbCatalog.Text.Trim)
            '    cmd.Parameters.AddWithValue("@IsTaxable", cmbIsStich.SelectedIndex)
            '    cmd.Parameters.AddWithValue("@UTax", cmbIsStich.SelectedIndex)
            '    cmd.Parameters.AddWithValue("@PluId", input)
            '    cmd.ExecuteNonQuery()
            'End Using

            SQL = "Update ProductAttributes SET DeptId = " _
            & cmbDept.SelectedValue & ",Department = '" _
            & cmbDept.Text.Trim & "',CatId = " _
            & cmbCat.SelectedValue & ",Category = '" _
            & cmbCat.Text.Trim & "',StyleId = " _
            & cmbStyle.SelectedValue & ",Style = '" _
            & cmbStyle.Text.Trim & "',PatternId = " _
            & cmbPattern.SelectedValue & ",Pattern = '" _
            & cmbPattern.Text.Trim & "',MaterialId = " _
            & cmbMts.SelectedValue & ",Material = '" _
            & cmbMts.Text.Trim & "',ColorId = " _
            & cmbColor.SelectedValue & ",Color = '" _
            & cmbColor.Text.Trim & "',SleeveId = " _
            & cmbSleeve.SelectedValue & ",Sleeve = '" _
            & cmbSleeve.Text.Trim & "',BrandId = " _
            & cmbBrand.SelectedValue & ",Brand = '" _
            & cmbBrand.Text.Trim & "',CatalogId = " _
            & cmbCatalog.SelectedValue & ",Catalog = '" _
            & cmbCatalog.Text.Trim & "',IsUpdated = 2" _
            & " WHERE PluId = " & input & ""

            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

            SQL = "Update ProductMaster SET IsTaxable = " _
                & cmbIsStich.SelectedIndex & ",UTax = " _
                & cmbIsStich.SelectedIndex & ", IsUpdated = 2 WHERE PluId = " & input & ""

            cmd.CommandText = SQL
            cmd.ExecuteNonQuery()

            trn.Commit()
            Con.Close()
            MsgBox("Updated Successfully..!", MsgBoxStyle.Information)
            ResetAttributes()

        Catch ex As Exception

            trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)

        End Try

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click

        If Not LoadHsn() Then
            MsgBox("HSN not available..!", MsgBoxStyle.Critical)
            Exit Sub
        End If
        If (MsgBox("Confirm Update..?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)) = MsgBoxResult.No Then Exit Sub
        UpdateAttributes(iPluID)
        iPluID = 0

    End Sub

    Private Function LoadHsn() As Boolean

        LoadHsn = False

        SQL = "SELECT HSN FROM ProductTax WHERE DeptId = " _
            & cmbDept.SelectedValue & " AND CatId = " _
            & cmbCat.SelectedValue & " AND MatId = " _
            & cmbMts.SelectedValue & ""

        With ESSA.OpenReader(SQL)
            If .Read Then
                LoadHsn = True
            End If
            .Close()
        End With

    End Function

    Private Sub AddItems(count As Short)

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

        'Dim Count As Short = 1
        'Dim Code As String = ""

        'If txtCode.Text.Trim.Contains("*") Then
        '    Dim split = txtCode.Text.Trim.Split("*")
        '    Code = split(0)
        '    Count = split(1)
        'Else
        '    Code = txtCode.Text.Trim
        'End If

        If InsertCode(iPluID, txtCode.Text.Trim.ToUpper, Val(txtRate.Text), count) > 0 Then

            txtCode.Clear()
            txtRate.Clear()
            txtCode.Focus()

        End If

    End Sub

    Private Sub txtRate_TextChanged(sender As Object, e As EventArgs) Handles txtRate.TextChanged

    End Sub

    Private Sub txtCode_TextChanged(sender As Object, e As EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Async Sub BtnDownload_Click(sender As Object, e As EventArgs) Handles BtnDownload.Click

        If MsgBox("Did you completed scanning all products ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.No Then
            Exit Sub
        End If

        pnlLoading.Visible = True

        ' Specify your SQL query
        'Dim sqlQuery As String = $"SELECT P.PLUCODE [BARCODE],P.PLUNAME [DESC],P.ID [SIZE],P.COSTPRICE,COUNT(C.PLUID) QTY,
        'COUNT(C.PLUID) * P.COSTPRICE [VALUE]
        'FROM PRODUCTMASTER P
        'INNER JOIN CODEREADER C ON C.PLUID = P.PLUID AND C.SHOPID = { ShopID }
        'GROUP BY P.PLUCODE, P.PLUNAME, P.ID, P.COSTPRICE"

        Dim sqlQuery As String = $"SELECT P.PLUCODE [BARCODE], P.PLUNAME [DESC], P.ID [SIZE], COALESCE(PM.COSTPRICE, P.COSTPRICE) AS COSTPRICE,
        COUNT(C.PLUID) QTY, COUNT(C.PLUID) * COALESCE(PM.COSTPRICE, P.COSTPRICE) AS [VALUE]
        FROM PRODUCTMASTER P
        LEFT JOIN PRICEMASTER PM ON PM.PLUID = P.PLUID AND PM.ShopId = {ShopID}
        LEFT JOIN CODEREADER C ON C.PLUID = COALESCE(PM.PLUID, P.PLUID) AND C.SHOPID = {ShopID}
        GROUP BY P.PLUCODE, P.PLUNAME, P.ID, P.COSTPRICE, PM.COSTPRICE
        HAVING 
        COUNT(C.PLUID) <> 0"

        Try
            ' Create a SqlConnection
            Using connection As New SqlConnection(ConStr)
                ' Open the connection
                Await connection.OpenAsync()

                ' Create a SqlCommand
                Using command As New SqlCommand(sqlQuery, connection)
                    ' Execute the query and get the data using SqlDataReader
                    Using reader As SqlDataReader = Await command.ExecuteReaderAsync()
                        ' Create a new Excel application
                        Dim excelApp As New Excel.Application()

                        ' Add a new workbook
                        Dim workbook As Excel.Workbook = excelApp.Workbooks.Add()

                        ' Add a new worksheet
                        Dim worksheet As Excel.Worksheet = workbook.Sheets(1)

                        ' Write the column headers
                        For col = 1 To reader.FieldCount
                            worksheet.Cells(1, col).Value = reader.GetName(col - 1)
                        Next

                        ' Write the data to the Excel worksheet
                        Dim row As Integer = 2
                        While Await reader.ReadAsync()
                            For col = 1 To reader.FieldCount
                                worksheet.Cells(row, col).Value = reader(col - 1)
                            Next
                            row += 1
                        End While

                        ' Autofit columns
                        worksheet.UsedRange.Columns.AutoFit()

                        ' Get the desktop path
                        Dim desktopPath As String = Environment.GetFolderPath(Environment.SpecialFolder.Desktop)

                        ' Save the workbook on the desktop
                        Dim fileName As String = $"{ShopName} Stock {Now:dd-MM-yyyy hh.mm}.xlsx"
                        Dim filePath As String = Path.Combine(desktopPath, fileName)
                        workbook.SaveAs(filePath)

                        ' Close the Excel application
                        excelApp.Quit()

                        ' Release resources
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)

                        pnlLoading.Visible = False

                        MessageBox.Show("Data exported to excel successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Using
                End Using
            End Using
        Catch ex As Exception
            pnlLoading.Visible = False
            MessageBox.Show("Error exporting data to Excel: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    ' Function to count only visible rows
    Private Sub UpdateVisibleRowCount()
        Dim visibleCount As Integer = TG.Rows.Cast(Of DataGridViewRow)().Count(Function(row) row.Visible)
        LblTotalPcs.Text = visibleCount.ToString()
    End Sub

    ' Update visible row count when rows are added
    Private Sub TG_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles TG.RowsAdded
        UpdateVisibleRowCount()
    End Sub

    ' Update visible row count when rows are removed
    Private Sub TG_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved
        UpdateVisibleRowCount()
    End Sub


    Private Async Function ApplyFilter(isFiltered As Boolean) As Task
        If txtCode.Text.Trim = String.Empty AndAlso isFiltered Then
            Return
        End If

        Dim filterColumnIndex As Integer = 2 ' The column index you want to filter (zero-based index)
        pnlLoading.Visible = True
        Dim filterText As String = txtCode.Text.ToUpper()

        ' Run filtering on a background thread
        Await Task.Run(Sub()
                           For Each row As DataGridViewRow In TG.Rows
                               Dim visible As Boolean = True ' Default: Show row

                               If isFiltered Then
                                   Dim cell As DataGridViewCell = row.Cells(filterColumnIndex)
                                   If cell.Value Is Nothing OrElse cell.Value.ToString().ToUpper() <> filterText Then
                                       visible = False ' Hide row
                                   End If
                               End If

                               ' Update row visibility on UI thread
                               Me.Invoke(Sub()
                                             row.Visible = visible
                                         End Sub)
                           Next
                       End Sub)
        UpdateVisibleRowCount()
        pnlLoading.Visible = False
    End Function


    Private Async Sub ChkCodeFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ChkCodeFilter.CheckedChanged

        Await ApplyFilter(ChkCodeFilter.Checked)

    End Sub
End Class