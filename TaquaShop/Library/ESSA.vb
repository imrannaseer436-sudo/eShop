'*********************** In the name of Allah, Most Merciful, Most Compassionate ****************
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports Microsoft.VisualBasic.Compatibility
Public Class ESSA

    Public Shared Function getMacAddress() As String

        Dim nics() As Net.NetworkInformation.NetworkInterface =
              Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString

    End Function

    Public Shared Function GenerateData(ByVal iSQL As String) As Object

        ESSA.OpenConnection()
        Using Cmd As New SqlCommand(iSQL, Con)
            GenerateData = Cmd.ExecuteScalar
        End Using
        Con.Close()

    End Function

    Public Shared Sub AlignHeader(ByVal DGV As DataGridView, ByVal Col As SByte, ByVal Align As DataGridViewContentAlignment, Optional ByVal iWidth As Integer = 0)

        With DGV
            If iWidth > 0 Then
                .Columns(Col).Width = iWidth
            End If
            .Columns(Col).HeaderCell.Style.Alignment = Align
            .Columns(Col).DefaultCellStyle.Alignment = Align
            .Columns(Col).SortMode = DataGridViewColumnSortMode.NotSortable
        End With

    End Sub


    Public Shared Sub LoadVendors(ByVal cmb As ComboBox, Optional ByVal Header As String = "")

        SQL = "select vendorid,vendorname from vendors order by vendorname"
        ESSA.LoadCombo(cmb, SQL, "vendorname", "vendorid", Header)

    End Sub

    Public Shared Function GetColTotal(ByVal DGV As DataGridView, ByVal Col As SByte) As Double

        GetColTotal = 0
        For i As Integer = 0 To DGV.Rows.Count - 1
            GetColTotal += Val(DGV.Item(Col, i).Value)
        Next

    End Function

    Public Shared Sub LoadDataGrid(ByVal DGV As DataGridView, ByVal Qry As String)

        Using Con As New SqlConnection(ConStr)

            Con.Open()

            Using Adp As New SqlDataAdapter(Qry, Con)

                Adp.SelectCommand.CommandTimeout = 3000

                Using Tbl As New DataTable
                    Adp.Fill(Tbl)
                    DGV.DataSource = Nothing
                    DGV.DataSource = Tbl
                End Using

            End Using

            Con.Close()

        End Using

    End Sub

    Public Shared Sub MoveNextCell(ByVal DGV As DataGridView, ByVal FirstCol As Integer, ByVal LastCol As Integer, ByVal Addrows As Boolean)

        If DGV.CurrentRow.Index = DGV.Rows.Count - 1 Then 'If it is last row 

            If DGV.CurrentCell.ColumnIndex = LastCol Then

                If Addrows = True Then
                    DGV.Rows.Add()
                    DGV.CurrentCell = DGV.Item(FirstCol, DGV.Rows.Count - 1)
                End If

            Else
                SendKeys.Send("{Tab}")
            End If

        Else

            If DGV.CurrentCell.ColumnIndex = LastCol Then
                DGV.CurrentCell = DGV.Item(FirstCol, DGV.CurrentRow.Index)
            Else
                SendKeys.Send("{Up}")
                SendKeys.Send("{Tab}")
            End If

        End If

    End Sub

    Public Shared Sub OpenConnection()

        Con = New SqlConnection(ConStr)

        Try
            Con.Open()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Sub

    Public Shared Function FindGridIndex(ByVal DGV As DataGridView, ByVal FindCol As Byte, ByVal FindValue As String) As Integer

        FindGridIndex = -1
        For i As Integer = 0 To DGV.Rows.Count - 1
            If DGV.Item(FindCol, i).Value = FindValue Then
                FindGridIndex = i
                Exit For
            End If
        Next

    End Function

    Public Shared Sub FindAndSelect(ByVal DGV As DataGridView, ByVal FindCol As Integer, ByVal Findvalue As String)

        For i As Integer = 0 To DGV.Rows.Count - 1
            If IsDBNull(DGV.Item(FindCol, i).Value) = False Then
                If Mid(DGV.Item(FindCol, i).Value, 1, Len(Findvalue)) = Findvalue Then
                    DGV.CurrentCell = DGV.Item(DGV.FirstDisplayedCell.ColumnIndex, i)
                    DGV.FirstDisplayedScrollingRowIndex = i
                    Exit For
                End If
            End If
        Next

    End Sub

    Public Shared Function FindAndSelectReturnStatus(ByVal DGV As DataGridView, ByVal FindCol As Integer, ByVal Findvalue As String) As Boolean

        FindAndSelectReturnStatus = False

        For i As Integer = 0 To DGV.Rows.Count - 1
            If Mid(DGV.Item(FindCol, i).Value, 1, Len(Findvalue)) = Findvalue Then
                DGV.CurrentCell = DGV.Item(DGV.FirstDisplayedCell.ColumnIndex, i)
                DGV.FirstDisplayedScrollingRowIndex = i
                FindAndSelectReturnStatus = True
                Exit For
            End If
        Next

    End Function

    Public Shared Function OpenReader(ByVal Qry As String) As SqlDataReader

        OpenConnection()
        OpenReader = Nothing

        Using Cmd As New SqlCommand(Qry, Con)
            Try
                Cmd.CommandTimeout = 0
                OpenReader = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Con.Close()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using

    End Function

    Public Shared Function GenerateID(ByVal Qry As String) As Integer

        GenerateID = 1
        Try
            OpenConnection()
            Using Cmd As New SqlCommand(Qry, Con)
                Dim Tmp = Cmd.ExecuteScalar
                If IsDBNull(Tmp) = False Then
                    GenerateID = CInt(Tmp) + 1
                Else
                    GenerateID = 1
                End If
            End Using
            Con.Close()
        Catch ex As Exception
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Function

    Public Shared Sub ClearTextBox(ByVal BaseControl As Control)

        For Each ctl As Control In BaseControl.Controls
            If TypeOf ctl Is TextBox Then
                CType(ctl, TextBox).Clear()
            End If
        Next

    End Sub

    Public Shared Sub ClearTextBox(ByVal BaseControl As Control, ByVal ExcludeTag As String)

        For Each ctl As Control In BaseControl.Controls
            If ctl.Tag <> ExcludeTag Then
                If TypeOf ctl Is TextBox Then
                    CType(ctl, TextBox).Clear()
                End If
            End If
        Next

    End Sub

    Public Shared Function ISFound(ByVal Qry As String) As Boolean
        ISFound = False
        Try

            OpenConnection()
            Using Cmd As New SqlCommand(Qry, Con)
                Dim Tmp = Cmd.ExecuteReader(CommandBehavior.CloseConnection)
                If Tmp.HasRows Then
                    ISFound = True
                End If
                Tmp.Close()
            End Using

        Catch ex As SqlException
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    Public Shared Function Execute(ByVal Qry As String) As Integer

        Execute = 0

        Try
            Using nCon As New SqlConnection(ConStr)
                nCon.Open()
                Using Cmd As New SqlCommand(Qry, nCon)
                    Execute = Cmd.ExecuteNonQuery
                End Using
                nCon.Close()
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Function

    Public Shared Async Function ExecuteScalarAsync(ByVal Qry As String) As Task(Of Object)
        Try
            Using nCon As New SqlConnection(ConStr)
                nCon.Open()
                Using Cmd As New SqlCommand(Qry, nCon)
                    Dim result As Object = Await Cmd.ExecuteScalarAsync()

                    ' 🔥 Handle NULL case explicitly
                    If result Is DBNull.Value OrElse result Is Nothing Then
                        Return Nothing ' Return explicit Nothing instead of vbEmpty
                    End If

                    Return result ' ✅ Return the actual value
                End Using
            End Using
        Catch ex As SqlException
            MsgBox("Database Error: " & ex.Message, MsgBoxStyle.Critical)
            Return Nothing ' Return Nothing on error
        End Try
    End Function


    Public Shared Function GetData(ByVal Qry As String) As Double

        GetData = 0

        Try
            Using nCon As New SqlConnection(ConStr)
                nCon.Open()
                Using Cmd As New SqlCommand(Qry, nCon)
                    Dim Tmp = Cmd.ExecuteScalar
                    If IsDBNull(Tmp) = False Then
                        GetData = CType(Tmp, Double)
                    End If
                End Using
                nCon.Close()
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

    End Function

    Public Shared Function GetDataObj(ByVal Qry As String) As Object

        GetDataObj = vbNull

        Try
            Using nCon As New SqlConnection(ConStr)
                nCon.Open()
                Using Cmd As New SqlCommand(Qry, nCon)
                    GetDataObj = Cmd.ExecuteScalar
                End Using
                nCon.Close()
            End Using
        Catch ex As SqlException
            GetDataObj = vbNull
        End Try

    End Function

    'Public Shared Function GetData(ByVal Qry As String) As Double

    '    GetData = 0
    '    OpenConnection()
    '    Dim Cmd As New SqlCommand(Qry, Con)
    '    Dim Tmp = Cmd.ExecuteScalar
    '    If IsDBNull(Tmp) = False Then
    '        GetData = CDbl(Tmp)
    '    End If
    '    Cmd.Dispose()
    '    Con.Close()

    '    'Try
    '    '    Using nCon As New SqlConnection(ConStr)
    '    '        nCon.Open()
    '    '        Using Cmd As New SqlCommand(Qry, nCon)
    '    '            Dim Tmp = Cmd.ExecuteScalar
    '    '            If IsDBNull(Tmp) = False Then
    '    '                GetData = CType(Tmp, Double)
    '    '            End If
    '    '        End Using
    '    '        nCon.Close()
    '    '    End Using
    '    'Catch ex As SqlException
    '    '    MsgBox(ex.Message, MsgBoxStyle.Critical)
    '    'End Try

    'End Function

    Public Shared Sub LoadList(ByVal Lst As ListBox, ByVal Qry As String, ByVal Name As String, Optional ByVal ID As String = "")

        Using nCon As New SqlConnection(ConStr)
            nCon.Open()
            Using Adp As New SqlDataAdapter(Qry, nCon)
                Using Tbl As New DataSet
                    Adp.Fill(Tbl)
                    Lst.DataSource = Nothing
                    Lst.DataSource = Tbl.Tables(0)
                    Lst.DisplayMember = Name
                    Lst.ValueMember = ID
                End Using
            End Using
            nCon.Close()
        End Using

    End Sub

    Public Shared Sub LoadCombo(ByVal Cmb As ComboBox, ByVal Qry As String, ByVal Name As String, Optional ByVal ID As String = "", Optional ByVal Header As String = "")

        Cmb.DataSource = Nothing
        Using nCon As New SqlConnection(ConStr)
            nCon.Open()
            Using Adp As New SqlDataAdapter(Qry, nCon)
                Using Tbl As New DataSet
                    Adp.Fill(Tbl)

                    If Header <> "" Then
                        Dim Tr As DataRow
                        Tr = Tbl.Tables(0).NewRow
                        Tr(Name) = Header
                        Tbl.Tables(0).Rows.InsertAt(Tr, 0)
                    End If

                    Cmb.DataSource = Tbl.Tables(0)
                    Cmb.DisplayMember = Name
                    Cmb.ValueMember = ID
                End Using
            End Using
            nCon.Close()
        End Using

    End Sub

    Public Shared Function DeleteData(ByVal Table1 As String, ByVal Feild1 As String, ByVal Value1 As String) As String

        DeleteData = "delete from " & Table1 & " where " & Feild1 & "=" & Value1

    End Function

    Public Shared Function DeleteData(ByVal Table1 As String, ByVal Feild1 As String, ByVal Value1 As String, ByVal Table2 As String, ByVal Feild2 As String, ByVal Value2 As String) As String

        DeleteData = "delete from " & Table1 & " where " & Feild1 & "=" & Value1 & ";" _
                    & "delete from " & Table2 & " where " & Feild2 & "=" & Value2
    End Function

    Public Shared Sub LoadComboSimple(ByVal Cmb As ComboBox, ByVal SQL As String, ByVal Name As String, Optional ByVal ID As String = "", Optional ByVal Header As String = "")

        Cmb.Text = ""
        Cmb.Items.Clear()
        With OpenReader(SQL)
            If .HasRows Then
                While .Read
                    Cmb.Items.Add(New VB6.ListBoxItem(.Item(Name), IIf(ID <> "", .Item(ID), 0)))
                End While
            End If
            If Header <> "" Then
                Cmb.Items.Insert(0, Header)
            End If
            If Cmb.Items.Count > 0 Then Cmb.SelectedIndex = 0
            .Close()
        End With

    End Sub

    Public Shared Sub LoadListSimple(ByVal Lst As ListBox, ByVal SQL As String, ByVal Name As String, Optional ByVal ID As String = "")

        Lst.Items.Clear()
        With OpenReader(SQL)
            If .HasRows Then
                While .Read
                    Lst.Items.Add(New VB6.ListBoxItem(.Item(Name), IIf(ID <> "", .Item(ID), 0)))
                End While
            End If
            .Close()
        End With

    End Sub

    Public Shared Function GetItemValue(ByVal Cmb As ComboBox) As Integer

        If Cmb.SelectedIndex = -1 Then
            GetItemValue = -1
        Else
            GetItemValue = VB6.GetItemData(Cmb, Cmb.SelectedIndex)
        End If

    End Function

    Public Shared Sub AlignCenter(iPanel As Control, iParent As Control)

        iPanel.Left = (iParent.Width - iPanel.Width) / 2
        iPanel.Top = (iParent.Height - iPanel.Height) / 2

    End Sub

    Public Shared Async Function OpenReaderAsync(ByVal Qry As String) As Task(Of SqlDataReader)
        Await OpenConnectionAsync()
        Dim reader As SqlDataReader = Nothing

        Using Cmd As New SqlCommand(Qry, Con)
            Try
                Cmd.CommandTimeout = 0
                reader = Await Cmd.ExecuteReaderAsync(CommandBehavior.CloseConnection)
            Catch ex As SqlException
                Con.Close()
                MsgBox(ex.Message, MsgBoxStyle.Critical)
            End Try
        End Using

        Return reader
    End Function

    Public Shared Async Function OpenConnectionAsync() As Task
        Con = New SqlConnection(ConStr)

        Try
            Await Con.OpenAsync()
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Function

    Public Shared Async Function LoadComboAsync(ByVal Cmb As ComboBox, ByVal Qry As String, ByVal Name As String, Optional ByVal ID As String = "", Optional ByVal Header As String = "") As Task
        Cmb.DataSource = Nothing

        Using nCon As New SqlConnection(ConStr)
            Await nCon.OpenAsync()

            Using Adp As New SqlDataAdapter(Qry, nCon)
                Using Tbl As New DataSet
                    Await Task.Run(Sub() Adp.Fill(Tbl))

                    If Header <> "" Then
                        Dim Tr As DataRow
                        Tr = Tbl.Tables(0).NewRow
                        Tr(Name) = Header
                        Tbl.Tables(0).Rows.InsertAt(Tr, 0)
                    End If

                    Cmb.DataSource = Tbl.Tables(0)
                    Cmb.DisplayMember = Name
                    Cmb.ValueMember = ID
                End Using
            End Using

            nCon.Close()
        End Using
    End Function

    Public Shared Async Function ExecuteAsync(ByVal Qry As String) As Task(Of Boolean)

        Try
            Using nCon As New SqlConnection(ConStr)
                Await nCon.OpenAsync()
                Using Cmd As New SqlCommand(Qry, nCon)
                    Await Cmd.ExecuteNonQueryAsync()
                    Return True
                End Using
            End Using
        Catch ex As SqlException
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try

        Return False

    End Function

    Private Shared Sub ComboBox_FilterTextUpdate(sender As Object, e As EventArgs)
        Dim cmb As ComboBox = DirectCast(sender, ComboBox)
        Dim text As String = cmb.Text
        Dim fullTable As DataTable = TryCast(cmb.Tag, DataTable)
        If fullTable Is Nothing Then Return

        Dim filtered As DataTable = fullTable.Clone()
        ' 🔹 Preserve the "All ..." header row, so that selectedIndex > 0 works
        If fullTable.Rows.Count > 0 Then
            filtered.ImportRow(fullTable.Rows(0))
        End If

        For i As Integer = 1 To fullTable.Rows.Count - 1
            Dim row As DataRow = fullTable.Rows(i)
            If row(cmb.DisplayMember).ToString().IndexOf(text, StringComparison.OrdinalIgnoreCase) >= 0 Then
                filtered.ImportRow(row)
            End If
        Next

        If filtered.Rows.Count > 0 Then
            cmb.DataSource = filtered
            cmb.DisplayMember = cmb.DisplayMember
            If cmb.ValueMember <> "" Then cmb.ValueMember = cmb.ValueMember

            ' 🚀 to obtain what user typed
            cmb.BeginInvoke(New Action(Sub()
                                           cmb.SelectedIndex = -1
                                           cmb.Text = text
                                           cmb.SelectionStart = text.Length
                                       End Sub))

            cmb.DroppedDown = True
            Cursor.Current = Cursors.Default
        End If
    End Sub

    Public Shared Sub EnableContainsFilter(ByVal Cmb As ComboBox)
        ' Ensure we keep the current data
        Dim currentTable As DataTable = TryCast(Cmb.DataSource, DataTable)
        If currentTable IsNot Nothing Then
            ' Store a copy of the full data for filtering
            Cmb.Tag = currentTable.Copy()

            ' Attach shared handler (avoid duplicate handlers)
            RemoveHandler Cmb.TextUpdate, AddressOf ComboBox_FilterTextUpdate
            AddHandler Cmb.TextUpdate, AddressOf ComboBox_FilterTextUpdate
        End If
    End Sub

    Private Shared Sub EnableContainsFilterForAllControls(parent As Control)
        For Each ctrl As Control In parent.Controls
            If TypeOf ctrl Is ComboBox Then
                EnableContainsFilter(DirectCast(ctrl, ComboBox))
            ElseIf ctrl.HasChildren Then
                EnableContainsFilterForAllControls(ctrl)
            End If
        Next
    End Sub

    Public Shared Sub EnableContainsFilterForAll(frm As Form)
        EnableContainsFilterForAllControls(frm)
    End Sub

End Class
