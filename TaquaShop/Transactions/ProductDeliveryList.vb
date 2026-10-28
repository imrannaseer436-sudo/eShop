'************************************ Bismillah ***********************************************
Imports System.Data.SqlClient
Imports System.Threading.Tasks
Imports CrystalDecisions.CrystalReports.Engine
Imports Microsoft.Office.Interop

Public Class ProductDeliveryList

    Private DeliveryID As UShort

    Private Sub ProductDelivery_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Select Case e.KeyCode

            Case Keys.Escape
                Close()
            Case Keys.Enter
                If Me.ActiveControl.Tag <> "1" Then
                    e.SuppressKeyPress = True
                    Me.ProcessTabKey(True)
                End If

        End Select

    End Sub

    Private Sub RefreshForms()

        cmbDCode.Text = ""
        GenerateDeliveryCode()
        lblTQty.Text = "0"
        txtRemarks.Clear()
        TG.Rows.Clear()

    End Sub

    Private Sub ProductDelivery_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        TG.ColumnHeadersDefaultCellStyle.Font = New Font(TG.Font, FontStyle.Bold)
        TG.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        TG.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        ESSA.AlignHeader(DGV, 3, DataGridViewContentAlignment.MiddleRight)
        ESSA.AlignHeader(DGV, 4, DataGridViewContentAlignment.MiddleRight)

        'DGV.Columns(3).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight
        'DGV.Columns(4).HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleRight

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbDCLocation, SQL, "shopdesc", "shopid")

        SQL = "select shopid,(shopname+' - '+shopcode) shopdesc from shops where shopid<>" & ShopID & " order by shopid"
        ESSA.LoadCombo(cmbFilter, SQL, "shopdesc", "shopid", "All Location(S)")

        'Imran
        Try

            SQL = "SELECT MIN(DeliveryDate) " &
              "FROM DeliveryMaster " &
              "WHERE DeliveryFrom = " & ShopID

            Using cmd As New SqlCommand(SQL, Con)

                If Con.State = ConnectionState.Closed Then
                    Con.Open()
                End If

                Dim obj As Object = cmd.ExecuteScalar()

                If obj IsNot Nothing AndAlso Not IsDBNull(obj) Then
                    DtpFromDate.Value = Convert.ToDateTime(obj)
                Else
                    DtpFromDate.Value = Now.Date
                End If

            End Using

        Catch ex As Exception

            DtpFromDate.Value = Now.Date

        End Try

        'LoadDeliveryList()
        'Imran

        cmbDCLocation.Select()

    End Sub

    Private Sub GenerateDeliveryCode()

        SQL = "select max(convert(int,substring(deliverycode,len(deliverycode)-4,len(deliverycode)))) from deliverymaster where deliveryto=" & cmbDCLocation.SelectedValue
        DeliveryID = ESSA.GenerateID(SQL)
        lblDCode.Text = ShopCode & Mid(cmbDCLocation.Text, cmbDCLocation.Text.Length - 4, cmbDCLocation.Text.Length).Trim & Format(DeliveryID, "000000")

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Close()

    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click

        If TG.Rows.Count = 0 Then
            TTip.Show("No details to proceed..!", btnSend, 0, 25, 2000)
            Exit Sub
        ElseIf cmbDCLocation.SelectedIndex = -1 Then
            TTip.Show("Delivery location not selected..!", cmbDCLocation, 0, 25, 2000)
            cmbDCLocation.Focus()
            Exit Sub
        End If

        ESSA.OpenConnection()
        Dim Cmd = Con.CreateCommand
        Dim Trn = Con.BeginTransaction
        Cmd.Transaction = Trn

        Try

            GenerateDeliveryCode()

            SQL = "delete from deliverymastertemp where deliverycode='" & cmbDCode.Text.Trim & "';" _
                & "delete from deliverydetailstemp where deliverycode='" & cmbDCode.Text.Trim & "'"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            SQL = "insert into deliverymaster values ('" _
                & lblDCode.Text.Trim & "','" _
                & Format(Now, "yyyy-MM-dd HH:mm:ssss") & "'," _
                & ShopID & "," _
                & cmbDCLocation.SelectedValue & "," _
                & Val(lblTQty.Text) & "," _
                & Val(lblTCP.Text) & "," _
                & Val(lblTRP.Text) & ",0,'" _
                & txtRemarks.Text.Trim & "'," _
                & UserID & ",0,'" _
                & Format(Now, "yyyyMMddHHmmss") & "')"

            Cmd.CommandText = SQL
            Cmd.ExecuteNonQuery()

            For i As Short = 0 To TG.Rows.Count - 1

                If Val(TG.Item(4, i).Value) > 0 Then

                    SQL = "insert into deliverydetails values ('" _
                        & lblDCode.Text.Trim & "'," _
                        & Val(TG.Item(0, i).Value) & "," _
                        & Val(TG.Item(4, i).Value) & "," _
                        & Val(TG.Item(5, i).Value) & "," _
                        & Val(TG.Item(6, i).Value) & "," _
                        & ShopID & "," _
                        & cmbDCLocation.SelectedValue & "," _
                        & i + 1 & ",0)"

                    Cmd.CommandText = SQL
                    Cmd.ExecuteNonQuery()

                End If

            Next

            Trn.Commit()
            Con.Close()

        Catch ex As Exception
            Trn.Rollback()
            Con.Close()
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try

        'If MsgBox("Challan delivered successfully, Do you want to print challan..!", vbQuestion + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    PrintDeliveryReport()
        'End If

        MsgBox("Challan delivered successfully..!", MsgBoxStyle.Information)
        RefreshForms()

    End Sub

    Private Sub btnReset_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReset.Click

        RefreshForms()

    End Sub

    'Private Sub PrintDeliveryReport()

    '    SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
    '        & "s1.shopname dfrom,s2.shopname dto from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p where " _
    '        & "m.deliveryfrom = s.shopid And m.deliverycode = d.deliverycode And d.pluid = p.pluid And m.deliveryfrom = s1.shopid " _
    '        & " And m.deliveryto = s2.shopid and m.deliverycode='" & lblDCode.Text & "' order by d.sno"

    '    ESSA.OpenConnection()

    '    Using Adp As New SqlDataAdapter(SQL, Con)
    '        Using Tbl As New DataTable
    '            Adp.Fill(Tbl)
    '            Rpt.SetDataSource(Tbl)
    '            Rpt.PrintToPrinter(1, False, 0, 0)
    '        End Using
    '    End Using

    '    Con.Close()

    'End Sub

    Private Sub cmbDCLocation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbDCLocation.SelectedIndexChanged

        If cmbDCLocation.SelectedIndex = -1 Then Exit Sub

        SQL = "SELECT REMARKS,DELIVERYCODE FROM DELIVERYMASTERTEMP WHERE DELIVERYTO=" & IIf(cmbDCLocation.SelectedValue.ToString.Contains("DataRow"), "0", cmbDCLocation.SelectedValue) _
            & " ORDER BY DELIVERYCODE"
        ESSA.LoadCombo(cmbDCode, SQL, "DELIVERYCODE", "REMARKS")

    End Sub



    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click

        If cmbDCode.SelectedIndex = -1 Then
            TTip.Show("Delivery code not found..!", cmbDCode, 0, 25, 2000)
            Exit Sub
        End If

        Dim Tot As Double = 0

        SQL = "select p.pluid,p.plucode,p.pluname,d.quantity,pm.costprice,pm.retailprice from productmaster p,deliverydetails d,deliverymaster m,pricemaster pm " _
            & "where p.pluid=d.pluid and m.id = d.id and d.pluid = pm.pluid and pm.shopid = " & ShopID & " and m.status = 0 and m.deliverycode='" & cmbDCode.Text.Trim & "' order by sno"

        TG.Rows.Clear()

        txtRemarks.Text = cmbDCode.SelectedValue

        With ESSA.OpenReader(SQL)
            While .Read
                TG.Rows.Add()
                TG.Item(0, TG.Rows.Count - 1).Value = .Item(0)
                TG.Item(1, TG.Rows.Count - 1).Value = .GetString(1)
                TG.Item(2, TG.Rows.Count - 1).Value = .GetString(2)
                TG.Item(3, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(4, TG.Rows.Count - 1).Value = .Item(3)
                TG.Item(5, TG.Rows.Count - 1).Value = Format(.Item(4), "0.00")
                TG.Item(6, TG.Rows.Count - 1).Value = Format(.Item(5), "0.00")
                Tot += .Item(3)
            End While
            .Close()
        End With

        lblTQty.Text = Tot

        If TG.Rows.Count > 0 Then
            TG.CurrentCell = TG.Item(4, 0)
            TG.Focus()
        End If

        CalculateTotal()

    End Sub
    Private Sub TG_CellEndEdit(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles TG.CellEndEdit

        If Val(TG.Item(4, e.RowIndex).Value) > Val(TG.Item(3, e.RowIndex).Value) Then
            TG.Item(4, e.RowIndex).Value = Val(TG.Item(3, e.RowIndex).Value)
        End If

        CalculateTotal()

    End Sub

    Private Sub TG_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TG.KeyUp

        If e.KeyCode = Keys.F9 Then
            If MsgBox("Are you sure, Do you want to remove product..!", MsgBoxStyle.Question + MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                TG.Rows.RemoveAt(TG.CurrentRow.Index)
            End If
            TG.Focus()
        End If

    End Sub

    Private Sub TG_RowsRemoved(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowsRemovedEventArgs) Handles TG.RowsRemoved

        CalculateTotal()

    End Sub

    Private Sub CalculateTotal()

        Dim Tot As Short = 0
        Dim Tmp As Double = 0
        Dim CTot As Double = 0
        Dim RTot As Double = 0

        For i As Short = 0 To TG.Rows.Count - 1

            Tot += Val(TG.Item(4, i).Value)
            Tmp = Val(TG.Item(4, i).Value) * Val(TG.Item(5, i).Value)
            CTot += Tmp
            Tmp = Val(TG.Item(4, i).Value) * Val(TG.Item(6, i).Value)
            RTot += Tmp

        Next

        lblTQty.Text = Tot
        lblTCP.Text = Format(CTot, "0.00")
        lblTRP.Text = Format(RTot, "0.00")

    End Sub

    Private Sub btnFilter_Click(sender As Object, e As EventArgs) Handles btnFilter.Click

        LoadDeliveryList()

        'SQL = "select m.deliverycode,m.deliverydate,s.shopname,m.TotalQty,m.totcp " _
        '    & "from DeliveryMaster m,Shops s " _
        '    & "where m.DeliveryTo=s.shopid and m.deliveryfrom = " & ShopID & " "

        'If cmbFilter.SelectedIndex > 0 Then
        '    SQL &= " and m.deliveryto=" & cmbFilter.SelectedValue
        'End If

        'SQL &= " order by deliverydate desc"

        'With ESSA.OpenReader(SQL)
        '    DGV.Rows.Clear()
        '    While .Read
        '        DGV.Rows.Add()
        '        DGV.Item(0, DGV.Rows.Count - 1).Value = .GetString(0).Trim
        '        DGV.Item(1, DGV.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
        '        DGV.Item(2, DGV.Rows.Count - 1).Value = .GetString(2).Trim
        '        DGV.Item(3, DGV.Rows.Count - 1).Value = .Item(3)
        '        DGV.Item(4, DGV.Rows.Count - 1).Value = Format(.Item(4), "0.00")
        '    End While
        '    .Close()
        'End With

    End Sub

    Private Sub btnHide_Click(sender As Object, e As EventArgs) Handles btnHide.Click

        pnlList.Visible = False

    End Sub

    Private Async Sub DGV_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV.CellClick

        If e.RowIndex = -1 Then Exit Sub

        If e.ColumnIndex = 5 Then

            PrintDeliveryChallan(Trim(DGV.Item(0, e.RowIndex).Value))

        End If

        If e.ColumnIndex = 6 Then

            Await GenerateInvoice(Trim(DGV.Item(0, e.RowIndex).Value))

        End If

    End Sub

    Private Sub btnReprint_Click(sender As Object, e As EventArgs) Handles btnReprint.Click

        pnlList.Visible = True
        cmbFilter.Focus()

    End Sub

    Private Rpt As New RptDeliveryChallan

    Private Sub PrintDeliveryChallan(deliveryCode As String)

        Using nCon As New SqlConnection(ConStr)

            nCon.Open()

            Try

                'SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
                '    & "s1.shopname dfrom,s2.shopname dto,l.scatdesc1 from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p,productlevels l where p.pluid=l.pluid and " _
                '    & "m.deliveryfrom = s.shopid And m.deliverycode = d.deliverycode And d.pluid = p.pluid And m.deliveryfrom = s1.shopid " _
                '    & " And m.deliveryto = s2.shopid and m.deliverycode='" & deliveryCode & "' order by d.sno"

                'SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
                '    & "s1.shopname dfrom,s2.shopname dto,'' scatdesc1 from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p where " _
                '    & "m.deliveryfrom = s.shopid And m.deliverycode = d.deliverycode And d.pluid = p.pluid And m.deliveryfrom = s1.shopid " _
                '    & " And m.deliveryto = s2.shopid and m.deliverycode='" & deliveryCode & "' order by d.sno"

                SQL = "select s.alias,s.city,m.deliverycode,m.deliverydate,p.plucode,p.pluname,p.units,d.quantity," _
                    & "s1.shopname dfrom,s2.shopname dto,a.category scatdesc1,m.remarks from deliverymaster m,shops s,shops s1,shops s2,deliverydetails d,productmaster p,productattributes a where " _
                    & "m.deliveryfrom = s.shopid And m.id = d.id And d.pluid = p.pluid and p.pluid = a.pluid and m.deliveryfrom = s1.shopid " _
                    & " And m.deliveryto = s2.shopid and m.deliverycode='" & deliveryCode & "' order by d.sno"

                Using Adp As New SqlDataAdapter(SQL, nCon)

                    Using Tbl As New DataTable
                        Adp.Fill(Tbl)
                        Rpt.SetDataSource(Tbl)
                        frmReportViewer.CRViewer.ReportSource = Rpt
                        frmReportViewer.Visible = False
                        frmReportViewer.Show()
                    End Using

                End Using

            Catch ex As SqlException

                MsgBox(ex.Message, MsgBoxStyle.Critical)

            End Try

            nCon.Close()

        End Using

    End Sub

    Private Async Function GenerateInvoice(DeliveryCode As String) As Task

        Dim InvoiceRpt As New Invoice

        Using nCon As New SqlConnection(ConStr)
            Try
                Await nCon.OpenAsync()

                Dim fromShopName, fromShopAddress, fromShopGst, fromShopMobile As String
                Dim toShopName, toShopAddress, toShopGst, toShopMobile As String
                Dim invNo, invDt As String

                ' Fetch header details
                SQL = "SELECT DM.DeliveryCode, DM.DeliveryDate, 
                   S1.Alias [FCName], S1.Address1 + ' ' + S1.Address2 + ' ' + S1.City + ', ' + S1.State [FCAddress], S1.Phone [FCPhone], S1.CST [FCGst],
                   S2.Alias [TCName], S2.Address1 + S2.Address2 + S2.City + ',' + S2.State [TCAddress],S2.Phone [TCPhone], S2.CST [TCGst]
                   FROM DeliveryMaster DM
                   INNER JOIN Shops S1 ON DM.DeliveryFrom = S1.ShopID
                   INNER JOIN Shops S2 ON DM.DeliveryTo = S2.ShopID
                   WHERE DM.DeliveryCode = @DeliveryCode"

                Using cmd As New SqlCommand(SQL, nCon)
                    cmd.Parameters.AddWithValue("@DeliveryCode", DeliveryCode)
                    Using reader As SqlDataReader = Await cmd.ExecuteReaderAsync()
                        If Await reader.ReadAsync() Then
                            fromShopName = reader("FCName").ToString()
                            fromShopAddress = reader("FCAddress").ToString()
                            fromShopGst = reader("FCGst").ToString()
                            fromShopMobile = reader("FCPhone").ToString()
                            toShopName = reader("TCName").ToString()
                            toShopAddress = reader("TCAddress").ToString()
                            toShopGst = reader("TCGst").ToString()
                            toShopMobile = reader("TCPhone").ToString()
                            invNo = reader("DeliveryCode").ToString()
                            invDt = Format(reader("DeliveryDate"), "dd-MM-yyyy")
                        End If
                    End Using
                End Using

                ' Fetch tax data for subreport
                SQL = "SELECT 
                    TaxType,
                    SUM(Taxable) AS Taxable,
                    TaxPerc
                FROM
                (
                    -- Intra-state: CGST
                    SELECT 
                        'CGST' AS TaxType,
                        SUM(DD.Quantity * DD.CostPrice) AS Taxable,
                        (CASE WHEN DD.CostPrice > PT.Val THEN PT.Mx ELSE PT.Mn END) / 2 AS TaxPerc
                    FROM DeliveryMaster DM
                    JOIN DeliveryDetails DD ON DM.Id = DD.Id 
                        AND DM.DeliveryCode = @DeliveryCode
                    JOIN ProductAttributes PA ON PA.PluId = DD.PluID
                    JOIN ProductTax PT ON PT.DeptId = PA.DeptId AND PT.CatId = PA.CatId AND PT.MatId = PA.MaterialId
                    AND PT.IsUpdated = @TaxVersion
                    JOIN Shops S1 ON S1.ShopID = DM.DeliveryFrom
                    JOIN Shops S2 ON S2.ShopID = DM.DeliveryTo
                    WHERE S1.State = S2.State
                    GROUP BY S1.State, S2.State, DD.CostPrice, PT.Val, PT.Mx, PT.Mn

                    UNION ALL

                    -- Intra-state: SGST
                    SELECT 
                        'SGST' AS TaxType,
                        SUM(DD.Quantity * DD.CostPrice) AS Taxable,
                        (CASE WHEN DD.CostPrice > PT.Val THEN PT.Mx ELSE PT.Mn END) / 2 AS TaxPerc
                    FROM DeliveryMaster DM
                    JOIN DeliveryDetails DD ON DM.Id = DD.Id 
                        AND DM.DeliveryCode = @DeliveryCode
                    JOIN ProductAttributes PA ON PA.PluId = DD.PluID
                    JOIN ProductTax PT ON PT.DeptId = PA.DeptId AND PT.CatId = PA.CatId AND PT.MatId = PA.MaterialId
                    AND PT.IsUpdated = @TaxVersion
                    JOIN Shops S1 ON S1.ShopID = DM.DeliveryFrom
                    JOIN Shops S2 ON S2.ShopID = DM.DeliveryTo
                    WHERE S1.State = S2.State
                    GROUP BY S1.State, S2.State, DD.CostPrice, PT.Val, PT.Mx, PT.Mn

                    UNION ALL

                    -- Inter-state: IGST
                    SELECT 
                        'IGST' AS TaxType,
                        SUM(DD.Quantity * DD.CostPrice) AS Taxable,
                        (CASE WHEN DD.CostPrice > PT.Val THEN PT.Mx ELSE PT.Mn END) AS TaxPerc
                    FROM DeliveryMaster DM
                    JOIN DeliveryDetails DD ON DM.Id = DD.Id 
                        AND DM.DeliveryCode = @DeliveryCode
                    JOIN ProductAttributes PA ON PA.PluId = DD.PluID
                    JOIN ProductTax PT ON PT.DeptId = PA.DeptId AND PT.CatId = PA.CatId AND PT.MatId = PA.MaterialId
                    AND PT.IsUpdated = @TaxVersion
                    JOIN Shops S1 ON S1.ShopID = DM.DeliveryFrom
                    JOIN Shops S2 ON S2.ShopID = DM.DeliveryTo
                    WHERE S1.State <> S2.State
                    GROUP BY S1.State, S2.State, DD.CostPrice, PT.Val, PT.Mx, PT.Mn
                ) AS SUB
                GROUP BY TaxType, TaxPerc"
                Using cmd As New SqlCommand(SQL, nCon)
                    cmd.Parameters.AddWithValue("@DeliveryCode", DeliveryCode)
                    cmd.Parameters.AddWithValue("@TaxVersion", TaxVersion)

                    Using Adp As New SqlDataAdapter(cmd)
                        Dim Tbl As New DataTable()
                        Adp.Fill(Tbl)
                        ' Verify if subreports exist
                        If InvoiceRpt.Subreports.Count > 0 Then
                            Dim subRpt = InvoiceRpt.Subreports("TaxBreakup")
                            If subRpt IsNot Nothing Then
                                subRpt.SetDataSource(Tbl)
                            Else
                                MsgBox("Subreport 'TaxBreakup' not found.")
                            End If
                        Else
                            MsgBox("No subreports found in the main report.")
                        End If
                    End Using
                End Using

                ' Fetch main invoice data
                SQL = "SELECT Description, HSN, Pcs, Rate, [Dis%], [GST%] FROM (SELECT DM.DeliveryCode,A.Category [Description],    
                    T.HSN, SUM(DD.Quantity) Pcs, DD.CostPrice [Rate], 0 [Dis%],        
                    CASE WHEN DD.CostPrice > T.Val    
                    THEN T.Mx    
                    ELSE T.Mn    
                    END AS [GST%]   
                    FROM DeliveryMaster DM    
                    INNER JOIN DeliveryDetails DD ON DM.Id = DD.Id       
                    INNER JOIN ProductAttributes A ON A.PluId = DD.PluID    
                    INNER JOIN ProductTax T ON T.DeptId = A.DeptId AND T.CatId = A.CatId AND     
                    T.MatId = A.MaterialId AND T.IsUpdated = @TaxVersion   
                    WHERE DM.DeliveryCode = @DeliveryCode
                    GROUP BY DM.DeliveryCode, A.Category, T.HSN, DD.CostPrice, T.Val, T.Mx, T.Mn) A"
                Using cmd As New SqlCommand(SQL, nCon)
                    cmd.Parameters.AddWithValue("@DeliveryCode", DeliveryCode)
                    cmd.Parameters.AddWithValue("@TaxVersion", TaxVersion)
                    Using Adp As New SqlDataAdapter(cmd)
                        Dim Tbl As New DataTable()
                        Adp.Fill(Tbl)
                        InvoiceRpt.SetDataSource(Tbl)
                        InvoiceRpt.SetParameterValue("FromCompanyName", fromShopName)
                        InvoiceRpt.SetParameterValue("FromCompanyAddress", fromShopAddress)
                        InvoiceRpt.SetParameterValue("FromCompanyGST", "GSTIN : " + fromShopGst)
                        InvoiceRpt.SetParameterValue("FromCompanyMobile", "Mobile : " + fromShopMobile)
                        InvoiceRpt.SetParameterValue("ToCompanyName", toShopName)
                        InvoiceRpt.SetParameterValue("ToCompanyAddress", toShopAddress)
                        InvoiceRpt.SetParameterValue("ToCompanyGST", "GSTIN : " + toShopGst)
                        InvoiceRpt.SetParameterValue("ToCompanyMobile", "Mobile : " + toShopMobile)
                        InvoiceRpt.SetParameterValue("InvNo", invNo)
                        InvoiceRpt.SetParameterValue("InvDate", invDt)
                        frmReportViewer.CRViewer.ReportSource = InvoiceRpt
                        frmReportViewer.Visible = False
                        frmReportViewer.Show()
                    End Using
                End Using

            Catch ex As SqlException
                MsgBox($"SQL Error: {ex.Message}", MsgBoxStyle.Critical)
            Catch ex As Exception
                MsgBox($"Unexpected Error: {ex.Message}", MsgBoxStyle.Critical)
            Finally
                If nCon.State = ConnectionState.Open Then nCon.Close()
            End Try
        End Using
    End Function


    Private Sub cmbDCLocation_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbDCLocation.KeyDown

        If e.KeyCode = Keys.Enter Then

            If cmbDCLocation.SelectedIndex = -1 Then Exit Sub

            SQL = "SELECT REMARKS,DELIVERYCODE FROM DELIVERYMASTERTEMP WHERE DELIVERYTO=" & cmbDCLocation.SelectedValue _
                & " ORDER BY DELIVERYCODE"
            ESSA.LoadCombo(cmbDCode, SQL, "DELIVERYCODE", "REMARKS")

        End If

    End Sub

    Private Sub LoadDeliveryList()

        SQL = "SELECT m.deliverycode,m.deliverydate,s.shopname,m.TotalQty,m.totcp " _
        & "FROM DeliveryMaster m, Shops s " _
        & "WHERE m.DeliveryTo = s.shopid " _
        & "AND m.deliveryfrom = " & ShopID

        If cmbFilter.SelectedIndex > 0 Then
            SQL &= " AND m.deliveryto = " & cmbFilter.SelectedValue
        End If

        SQL &= " AND m.deliverydate >= '" & Format(DtpFromDate.Value, "yyyy-MM-dd") & "'" _
        & " AND m.deliverydate < '" & Format(DtpToDate.Value.AddDays(1), "yyyy-MM-dd") & "'"

        SQL &= " ORDER BY m.deliverydate DESC"

        With ESSA.OpenReader(SQL)

            DGV.Rows.Clear()

            While .Read
                DGV.Rows.Add()

                DGV.Item(0, DGV.Rows.Count - 1).Value = .GetString(0).Trim
                DGV.Item(1, DGV.Rows.Count - 1).Value = Format(.GetDateTime(1).Date, "dd-MM-yyyy")
                DGV.Item(2, DGV.Rows.Count - 1).Value = .GetString(2).Trim
                DGV.Item(3, DGV.Rows.Count - 1).Value = .Item(3)
                DGV.Item(4, DGV.Rows.Count - 1).Value = Format(.Item(4), "0.00")
            End While

            .Close()

        End With

    End Sub

    Private Sub ExportDeliveryToExcel()

        Try

            '----------------------------------------------------------
            ' 1. Get DeliveryCodes from all rows in DGV
            '----------------------------------------------------------
            Dim DeliveryCodes As New List(Of String)

            For i As Integer = 0 To DGV.Rows.Count - 1

                If DGV.Rows(i).IsNewRow Then Continue For

                If DGV.Item(0, i).Value IsNot Nothing AndAlso
               Not IsDBNull(DGV.Item(0, i).Value) Then

                    Dim DeliveryCode As String =
                    DGV.Item(0, i).Value.ToString().Trim()

                    If DeliveryCode <> "" AndAlso
                   Not DeliveryCodes.Contains(DeliveryCode) Then

                        DeliveryCodes.Add(DeliveryCode)

                    End If

                End If

            Next

            '----------------------------------------------------------
            ' 2. Check DeliveryCodes
            '----------------------------------------------------------
            If DeliveryCodes.Count = 0 Then
                MessageBox.Show("No Delivery Code found in the grid.",
                            "Export",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)
                Exit Sub
            End If

            '----------------------------------------------------------
            ' 3. Create SQL parameter placeholders
            '----------------------------------------------------------
            Dim placeholders As New List(Of String)

            For i As Integer = 0 To DeliveryCodes.Count - 1
                placeholders.Add("@DeliveryCode" & i)
            Next

            '----------------------------------------------------------
            ' 4. SQL Query
            '----------------------------------------------------------
            Dim SQL As String =
            "SELECT Description, HSN, SUM(Pcs) AS Pcs, Rate, " &
            "SUM(Pcs * Rate) AS TAXABLE, " &
            "[Dis%], [GST%], " &
            "SUM(Pcs * Rate) * [GST%] / 100 AS GST, " &
            "SUM(Pcs * Rate) + " &
            "(SUM(Pcs * Rate) * [GST%] / 100) AS [Total Amount] " &
            "FROM (" &
            "SELECT DM.DeliveryCode, " &
            "A.Category AS Description, " &
            "T.HSN, " &
            "SUM(DD.Quantity) AS Pcs, " &
            "DD.CostPrice AS Rate, " &
            "0 AS [Dis%], " &
            "CASE " &
            "WHEN DD.CostPrice > T.Val THEN T.Mx " &
            "ELSE T.Mn " &
            "END AS [GST%] " &
            "FROM DeliveryMaster DM " &
            "INNER JOIN DeliveryDetails DD ON DM.Id = DD.Id " &
            "INNER JOIN ProductAttributes A ON A.PluId = DD.PluID " &
            "INNER JOIN ProductTax T ON T.DeptId = A.DeptId " &
            "AND T.CatId = A.CatId " &
            "AND T.MatId = A.MaterialId " &
            "AND T.IsUpdated = @TaxVersion " &
            "WHERE DM.DeliveryCode IN (" &
            String.Join(",", placeholders) &
            ") " &
            "GROUP BY DM.DeliveryCode, A.Category, T.HSN, " &
            "DD.CostPrice, T.Val, T.Mx, T.Mn" &
            ") A " &
            "GROUP BY Description, HSN, Rate, [Dis%], [GST%]"

            '----------------------------------------------------------
            ' 5. Get Data
            '----------------------------------------------------------
            Dim dt As New DataTable

            Using con As New SqlConnection(ConStr)

                Using cmd As New SqlCommand(SQL, con)

                    ' Tax Version
                    cmd.Parameters.AddWithValue("@TaxVersion", TaxVersion)

                    ' Delivery Codes
                    For i As Integer = 0 To DeliveryCodes.Count - 1

                        cmd.Parameters.AddWithValue(
                        "@DeliveryCode" & i,
                        DeliveryCodes(i)
                    )

                    Next

                    Using da As New SqlDataAdapter(cmd)

                        ' Display SQL Query
                        Debug.WriteLine("SQL Query: " & cmd.CommandText)

                        ' Display Parameters
                        For Each p As SqlParameter In cmd.Parameters
                            Debug.WriteLine(p.ParameterName & " = " &
                    If(p.Value Is Nothing OrElse IsDBNull(p.Value),
                       "NULL",
                       p.Value.ToString()))
                        Next

                        da.Fill(dt)

                    End Using

                End Using

            End Using

            '----------------------------------------------------------
            ' 6. Check Data
            '----------------------------------------------------------
            If dt.Rows.Count = 0 Then

                MessageBox.Show("No delivery details found.",
                            "Export",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information)

                Exit Sub

            End If

            '----------------------------------------------------------
            ' 7. Create Excel
            '----------------------------------------------------------
            Dim excelApp As New Excel.Application()

            Dim workbook As Excel.Workbook =
            excelApp.Workbooks.Add()

            Dim worksheet As Excel.Worksheet =
            DirectCast(workbook.Sheets(1), Excel.Worksheet)

            '----------------------------------------------------------
            ' 8. Excel Headers
            '----------------------------------------------------------
            Dim headers() As String = {
            "Description",
            "HSN",
            "Pcs",
            "Rate",
            "TAXABLE",
            "Dis%",
            "GST%",
            "GST",
            "Total Amount"
        }

            For c As Integer = 0 To headers.Length - 1

                worksheet.Cells(1, c + 1) = headers(c)

            Next

            '----------------------------------------------------------
            ' 9. Excel Data
            '----------------------------------------------------------
            For r As Integer = 0 To dt.Rows.Count - 1

                For c As Integer = 0 To dt.Columns.Count - 1

                    worksheet.Cells(r + 2, c + 1) =
                    dt.Rows(r)(c).ToString()

                Next

            Next

            '----------------------------------------------------------
            ' 10. Format Header
            '----------------------------------------------------------
            Dim headerRange As Excel.Range =
            worksheet.Range(
                worksheet.Cells(1, 1),
                worksheet.Cells(1, headers.Length)
            )

            headerRange.Font.Bold = True

            '----------------------------------------------------------
            ' 11. Format Numbers
            '----------------------------------------------------------
            worksheet.Columns("C").NumberFormat = "0"
            worksheet.Columns("D").NumberFormat = "0.00"
            worksheet.Columns("E").NumberFormat = "0.00"
            worksheet.Columns("F").NumberFormat = "0.00"
            worksheet.Columns("G").NumberFormat = "0.00"
            worksheet.Columns("H").NumberFormat = "0.00"
            worksheet.Columns("I").NumberFormat = "0.00"

            '----------------------------------------------------------
            ' 12. Auto Fit Columns
            '----------------------------------------------------------
            worksheet.Columns.AutoFit()

            '----------------------------------------------------------
            ' 13. Save Excel to Desktop
            '----------------------------------------------------------
            Dim filePath As String =
            IO.Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.Desktop
                ),
                "Delivery Summary.xlsx"
            )

            ' If file already exists, create another filename
            Dim counter As Integer = 1

            While IO.File.Exists(filePath)

                filePath =
                IO.Path.Combine(
                    Environment.GetFolderPath(
                        Environment.SpecialFolder.Desktop
                    ),
                    "Delivery Summary (" & counter & ").xlsx"
                )

                counter += 1

            End While

            workbook.SaveAs(filePath)

            '----------------------------------------------------------
            ' 14. Close Excel
            '----------------------------------------------------------
            workbook.Close()
            excelApp.Quit()

            '----------------------------------------------------------
            ' 15. Release COM Objects
            '----------------------------------------------------------
            Runtime.InteropServices.Marshal.ReleaseComObject(worksheet)
            Runtime.InteropServices.Marshal.ReleaseComObject(workbook)
            Runtime.InteropServices.Marshal.ReleaseComObject(excelApp)

            '----------------------------------------------------------
            ' 16. Success Message
            '----------------------------------------------------------
            MessageBox.Show(
            "Delivery details exported successfully." &
            vbCrLf & vbCrLf &
            "Delivery Codes: " & DeliveryCodes.Count &
            vbCrLf &
            "Rows Exported: " & dt.Rows.Count &
            vbCrLf & vbCrLf &
            "File: " & filePath,
            "Export Completed",
            MessageBoxButtons.OK,
            MessageBoxIcon.Information
        )

        Catch ex As Exception

            MessageBox.Show(
            "Error while exporting to Excel:" &
            vbCrLf & vbCrLf &
            ex.Message,
            "Export Error",
            MessageBoxButtons.OK,
            MessageBoxIcon.Error
        )

        End Try

    End Sub
    Private Sub BtnDownloadAsExcel_Click(sender As Object, e As EventArgs) Handles BtnDownloadAsExcel.Click

        ExportDeliveryToExcel()

    End Sub

    'Private Sub BtnGrouped_Click(sender As Object, e As EventArgs) Handles BtnGrouped.Click

    '    '=======================================================
    '    ' 1. Validate destination
    '    '=======================================================
    '    If cmbFilter.SelectedIndex <= 0 OrElse
    '       cmbFilter.SelectedValue Is Nothing OrElse
    '       IsDBNull(cmbFilter.SelectedValue) Then

    '        MessageBox.Show("Please select a destination location.", "Grouped Delivery",
    '                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        cmbFilter.Focus()
    '        Exit Sub
    '    End If

    '    'For Each row As DataGridViewRow In DGV.Rows

    '    '    If row.IsNewRow Then Continue For

    '    '    If cmbFilter.SelectedValue.ToString() <> row.Cells(2).Value.ToString() Then
    '    '        MessageBox.Show("cmbFilter location and Rows are not same", "Grouped Delivery",
    '    '                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '    '        Exit Sub
    '    '    End If

    '    'Next

    '    Dim ToShopId As Integer

    '    If Not Integer.TryParse(cmbFilter.SelectedValue.ToString(), ToShopId) Then

    '        MessageBox.Show("Invalid destination location.", "Grouped Delivery",
    '                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        cmbFilter.Focus()
    '        Exit Sub

    '    End If

    '    '=======================================================
    '    ' 2. Validate dates
    '    '=======================================================
    '    If DtpFromDate.Value.Date > DtpToDate.Value.Date Then

    '        MessageBox.Show("From Date cannot be greater than To Date.", "Grouped Delivery",
    '                        MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        DtpFromDate.Focus()
    '        Exit Sub

    '    End If

    '    '=======================================================
    '    ' 3. Confirmation
    '    '=======================================================
    '    If MessageBox.Show("Are you sure, do you want to generate transfer receipt..?", "Grouped Delivery",
    '                       MessageBoxButtons.YesNo, MessageBoxIcon.Question) <> DialogResult.Yes Then
    '        Exit Sub

    '    End If

    '    BtnGrouped.Enabled = False

    '    Dim Trn As SqlTransaction = Nothing

    '    Try

    '        If Con.State = ConnectionState.Closed Then
    '            Con.Open()
    '        End If

    '        Trn = Con.BeginTransaction()

    '        '=======================================================
    '        ' 4. Check delivery records
    '        '=======================================================
    '        SQL = "SELECT COUNT(*) " &
    '              "FROM DeliveryMaster " &
    '              "WHERE DeliveryFrom = @FromShop " &
    '              "AND DeliveryTo = @ToShop " &
    '              "AND DeliveryDate >= @FromDate " &
    '              "AND DeliveryDate < DATEADD(DAY, 1, @ToDate)"

    '        Dim DeliveryCount As Integer

    '        Using Cmd As New SqlCommand(SQL, Con, Trn)

    '            Cmd.Parameters.AddWithValue("@FromShop", ShopID)
    '            Cmd.Parameters.AddWithValue("@ToShop", ToShopId)
    '            Cmd.Parameters.AddWithValue("@FromDate", DtpFromDate.Value.Date)
    '            Cmd.Parameters.AddWithValue("@ToDate", DtpToDate.Value.Date)

    '            DeliveryCount = Convert.ToInt32(Cmd.ExecuteScalar())

    '        End Using

    '        If DeliveryCount = 0 Then

    '            Trn.Rollback()
    '            Trn = Nothing

    '            MessageBox.Show("No delivery found for the selected location and date range.", "Grouped Delivery",
    '                            MessageBoxButtons.OK, MessageBoxIcon.Information)
    '            Exit Sub

    '        End If

    '        '=======================================================
    '        ' 5. Insert GroupedDeliveryMaster
    '        '=======================================================
    '        Dim GroupedDeliveryMasterId As Integer

    '        SQL = "INSERT INTO GroupedDeliveryMaster " &
    '              "(FromShopId, ToShopId, FromDate, ToDate, CreatedBy, CreatedAt) " &
    '              "OUTPUT INSERTED.Id " &
    '              "VALUES " &
    '              "(@FromShopId, @ToShopId, @FromDate, @ToDate, @CreatedBy, @CreatedAt)"

    '        Using Cmd As New SqlCommand(SQL, Con, Trn)

    '            Cmd.Parameters.AddWithValue("@FromShopId", ShopID)
    '            Cmd.Parameters.AddWithValue("@ToShopId", ToShopId)
    '            Cmd.Parameters.AddWithValue("@FromDate", DtpFromDate.Value.Date)
    '            Cmd.Parameters.AddWithValue("@ToDate", DtpToDate.Value.Date)
    '            Cmd.Parameters.AddWithValue("@CreatedBy", UserID)
    '            Cmd.Parameters.AddWithValue("@CreatedAt", DateTime.Now)

    '            GroupedDeliveryMasterId = Convert.ToInt32(Cmd.ExecuteScalar())

    '        End Using

    '        '=======================================================
    '        ' 6. Insert GroupedDeliveryDetails
    '        '=======================================================
    '        SQL = "INSERT INTO GroupedDeliveryDetails " &
    '              "(GroupedDeliveryMasterId, DeliveryCode, Quantity, TotalCost) " &
    '              "SELECT @MasterId, DeliveryCode, TotalQty, TotCP " &
    '              "FROM DeliveryMaster " &
    '              "WHERE DeliveryFrom = @FromShop " &
    '              "AND DeliveryTo = @ToShop " &
    '              "AND DeliveryDate >= @FromDate " &
    '              "AND DeliveryDate < DATEADD(DAY, 1, @ToDate)"

    '        Using Cmd As New SqlCommand(SQL, Con, Trn)

    '            Cmd.Parameters.AddWithValue("@MasterId", GroupedDeliveryMasterId)
    '            Cmd.Parameters.AddWithValue("@FromShop", ShopID)
    '            Cmd.Parameters.AddWithValue("@ToShop", ToShopId)
    '            Cmd.Parameters.AddWithValue("@FromDate", DtpFromDate.Value.Date)
    '            Cmd.Parameters.AddWithValue("@ToDate", DtpToDate.Value.Date)

    '            Cmd.ExecuteNonQuery()

    '        End Using

    '        '=======================================================
    '        ' 7. Commit
    '        '=======================================================
    '        Trn.Commit()
    '        Trn = Nothing

    '        '=======================================================
    '        ' 8. Get From Shop / To Shop details
    '        '=======================================================
    '        Dim FromCompanyName As String = ""
    '        Dim FromCompanyAddress As String = ""
    '        Dim FromCompanyGST As String = ""
    '        Dim FromCompanyMobile As String = ""

    '        Dim ToCompanyName As String = ""
    '        Dim ToCompanyAddress As String = ""
    '        Dim ToCompanyGST As String = ""
    '        Dim ToCompanyMobile As String = ""

    '        SQL = "SELECT " &
    '              "S1.Alias AS FromCompanyName, " &
    '              "S1.Address1 + ' ' + S1.Address2 + ' ' + S1.City + ', ' + S1.State AS FromCompanyAddress, " &
    '              "S1.CST AS FromCompanyGST, " &
    '              "S1.Phone AS FromCompanyMobile, " &
    '              "S2.Alias AS ToCompanyName, " &
    '              "S2.Address1 + ' ' + S2.Address2 + ' ' + S2.City + ', ' + S2.State AS ToCompanyAddress, " &
    '              "S2.CST AS ToCompanyGST, " &
    '              "S2.Phone AS ToCompanyMobile " &
    '              "FROM Shops S1 " &
    '              "CROSS JOIN Shops S2 " &
    '              "WHERE S1.ShopID = @FromShop " &
    '              "AND S2.ShopID = @ToShop"

    '        Using Cmd As New SqlCommand(SQL, Con)

    '            Cmd.Parameters.AddWithValue("@FromShop", ShopID)
    '            Cmd.Parameters.AddWithValue("@ToShop", ToShopId)

    '            Using Reader As SqlDataReader = Cmd.ExecuteReader()

    '                If Reader.Read() Then

    '                    FromCompanyName =
    '                        If(IsDBNull(Reader("FromCompanyName")),
    '                           "",
    '                           Reader("FromCompanyName").ToString())

    '                    FromCompanyAddress =
    '                        If(IsDBNull(Reader("FromCompanyAddress")),
    '                           "",
    '                           Reader("FromCompanyAddress").ToString())

    '                    FromCompanyGST =
    '                        If(IsDBNull(Reader("FromCompanyGST")),
    '                           "",
    '                           Reader("FromCompanyGST").ToString())

    '                    FromCompanyMobile =
    '                        If(IsDBNull(Reader("FromCompanyMobile")),
    '                           "",
    '                           Reader("FromCompanyMobile").ToString())


    '                    ToCompanyName =
    '                        If(IsDBNull(Reader("ToCompanyName")),
    '                           "",
    '                           Reader("ToCompanyName").ToString())

    '                    ToCompanyAddress =
    '                        If(IsDBNull(Reader("ToCompanyAddress")),
    '                           "",
    '                           Reader("ToCompanyAddress").ToString())

    '                    ToCompanyGST =
    '                        If(IsDBNull(Reader("ToCompanyGST")),
    '                           "",
    '                           Reader("ToCompanyGST").ToString())

    '                    ToCompanyMobile =
    '                        If(IsDBNull(Reader("ToCompanyMobile")),
    '                           "",
    '                           Reader("ToCompanyMobile").ToString())

    '                End If

    '            End Using

    '        End Using


    '        '=======================================================
    '        ' 9. Main Report Data
    '        '=======================================================
    '        Dim Dataset As New DataSet
    '        Dim MainTbl As New DataTable("DeliveryValueReport")

    '        SQL = "SELECT " &
    '              "GD.DeliveryCode, " &
    '              "DM.DeliveryDate, " &
    '              "S.ShopName, " &
    '              "GD.Quantity AS TotalQty, " &
    '              "GD.TotalCost AS TotalCP, " &
    '              "DM.TotRP AS TotalRP, " &
    '              "'' AS UserName " &
    '              "FROM GroupedDeliveryDetails GD " &
    '              "INNER JOIN DeliveryMaster DM " &
    '              "ON DM.DeliveryCode = GD.DeliveryCode " &
    '              "INNER JOIN Shops S " &
    '              "ON S.ShopID = DM.DeliveryTo " &
    '              "WHERE GD.GroupedDeliveryMasterId = @MasterId " &
    '              "ORDER BY DM.DeliveryDate, GD.DeliveryCode"


    '        Using Cmd As New SqlCommand(SQL, Con)

    '            Cmd.Parameters.AddWithValue("@MasterId",
    '                                        GroupedDeliveryMasterId)

    '            Using Adp As New SqlDataAdapter(Cmd)

    '                Adp.Fill(MainTbl)

    '            End Using

    '        End Using

    '        Dataset.Tables.Add(MainTbl)

    '        If MainTbl.Rows.Count = 0 Then

    '            MessageBox.Show("No delivery details found for the grouped receipt.",
    '                            "Grouped Delivery",
    '                            MessageBoxButtons.OK,
    '                            MessageBoxIcon.Information)

    '            Exit Sub

    '        End If


    '        '=======================================================
    '        ' 10. TaxBreakup Subreport Data
    '        '=======================================================
    '        '=======================================================
    '        ' 10. TaxBreakup Subreport Data
    '        '=======================================================
    '        Dim TaxTbl As New DataTable("TaxBreakup")

    '        SQL = "SELECT
    '                        X.TaxType,
    '                        SUM(X.Taxable) AS Taxable,
    '                        X.TaxPerc
    '                    FROM
    '                    (
    '                        SELECT
    '                            'CGST' AS TaxType,
    '                            SUM(DD.Quantity * DD.CostPrice) AS Taxable,
    '                            (CASE
    '                                WHEN DD.CostPrice > PT.Val
    '                                THEN PT.Mx
    '                                ELSE PT.Mn
    '                             END) / 2 AS TaxPerc
    '                        FROM GroupedDeliveryDetails GD
    '                        INNER JOIN DeliveryMaster DM
    '                            ON DM.DeliveryCode = GD.DeliveryCode
    '                        INNER JOIN DeliveryDetails DD
    '                            ON DM.Id = DD.Id
    '                        INNER JOIN ProductAttributes PA
    '                            ON PA.PluId = DD.PluID
    '                        INNER JOIN ProductTax PT
    '                            ON PT.DeptId = PA.DeptId
    '                            AND PT.CatId = PA.CatId
    '                            AND PT.MatId = PA.MaterialId
    '                            AND PT.IsUpdated = @TaxVersion
    '                        INNER JOIN Shops S1
    '                            ON S1.ShopID = DM.DeliveryFrom
    '                        INNER JOIN Shops S2
    '                            ON S2.ShopID = DM.DeliveryTo
    '                        WHERE GD.GroupedDeliveryMasterId = @MasterId
    '                            AND S1.State = S2.State
    '                        GROUP BY
    '                            DD.CostPrice,
    '                            PT.Val,
    '                            PT.Mx,
    '                            PT.Mn

    '                        UNION ALL

    '                        SELECT
    '                            'SGST' AS TaxType,
    '                            SUM(DD.Quantity * DD.CostPrice) AS Taxable,
    '                            (CASE
    '                                WHEN DD.CostPrice > PT.Val
    '                                THEN PT.Mx
    '                                ELSE PT.Mn
    '                             END) / 2 AS TaxPerc
    '                        FROM GroupedDeliveryDetails GD
    '                        INNER JOIN DeliveryMaster DM
    '                            ON DM.DeliveryCode = GD.DeliveryCode
    '                        INNER JOIN DeliveryDetails DD
    '                            ON DM.Id = DD.Id
    '                        INNER JOIN ProductAttributes PA
    '                            ON PA.PluId = DD.PluID
    '                        INNER JOIN ProductTax PT
    '                            ON PT.DeptId = PA.DeptId
    '                            AND PT.CatId = PA.CatId
    '                            AND PT.MatId = PA.MaterialId
    '                            AND PT.IsUpdated = @TaxVersion
    '                        INNER JOIN Shops S1
    '                            ON S1.ShopID = DM.DeliveryFrom
    '                        INNER JOIN Shops S2
    '                            ON S2.ShopID = DM.DeliveryTo
    '                        WHERE GD.GroupedDeliveryMasterId = @MasterId
    '                            AND S1.State = S2.State
    '                        GROUP BY
    '                            DD.CostPrice,
    '                            PT.Val,
    '                            PT.Mx,
    '                            PT.Mn

    '                        UNION ALL

    '                        SELECT
    '                            'IGST' AS TaxType,
    '                            SUM(DD.Quantity * DD.CostPrice) AS Taxable,
    '                            CASE
    '                                WHEN DD.CostPrice > PT.Val
    '                                THEN PT.Mx
    '                                ELSE PT.Mn
    '                            END AS TaxPerc
    '                        FROM GroupedDeliveryDetails GD
    '                        INNER JOIN DeliveryMaster DM
    '                            ON DM.DeliveryCode = GD.DeliveryCode
    '                        INNER JOIN DeliveryDetails DD
    '                            ON DM.Id = DD.Id
    '                        INNER JOIN ProductAttributes PA
    '                            ON PA.PluId = DD.PluID
    '                        INNER JOIN ProductTax PT
    '                            ON PT.DeptId = PA.DeptId
    '                            AND PT.CatId = PA.CatId
    '                            AND PT.MatId = PA.MaterialId
    '                            AND PT.IsUpdated = @TaxVersion
    '                        INNER JOIN Shops S1
    '                            ON S1.ShopID = DM.DeliveryFrom
    '                        INNER JOIN Shops S2
    '                            ON S2.ShopID = DM.DeliveryTo
    '                        WHERE GD.GroupedDeliveryMasterId = @MasterId
    '                            AND S1.State <> S2.State
    '                        GROUP BY
    '                            DD.CostPrice,
    '                            PT.Val,
    '                            PT.Mx,
    '                            PT.Mn
    '                    ) AS X
    '                    GROUP BY
    '                        X.TaxType,
    '                        X.TaxPerc;"


    '        Using CmdTax As New SqlCommand(SQL, Con)

    '            CmdTax.Parameters.AddWithValue("@MasterId",
    '                                GroupedDeliveryMasterId)

    '            CmdTax.Parameters.AddWithValue("@TaxVersion",
    '                               TaxVersion)

    '            Using AdpTax As New SqlDataAdapter(CmdTax)

    '                AdpTax.Fill(TaxTbl)

    '            End Using

    '        End Using

    '        Dataset.Tables.Add(TaxTbl)
    '        '=======================================================
    '        ' 11. Create Crystal Report
    '        '=======================================================
    '        Dim RptGrouped As New DeliveryValueReport


    '        'Main report
    '        RptGrouped.SetDataSource(Dataset)
    '        RptGrouped.Subreports("TaxBreakup").SetDataSource(Dataset.Tables(1))

    '        'TaxBreakup subreport
    '        If RptGrouped.Subreports.Count > 0 Then

    '            Dim TaxBreakupRpt As ReportDocument =
    '                RptGrouped.Subreports("TaxBreakup")

    '            TaxBreakupRpt.SetDataSource(TaxTbl)

    '        End If


    '        '=======================================================
    '        ' 12. Report Parameters
    '        '=======================================================
    '        RptGrouped.SetParameterValue(
    '            "TNo",
    '            GroupedDeliveryMasterId.ToString()
    '        )

    '        RptGrouped.SetParameterValue(
    '            "TDate",
    '            DateTime.Now
    '        )

    '        RptGrouped.SetParameterValue(
    '            "FromCompanyName",
    '            FromCompanyName
    '        )

    '        RptGrouped.SetParameterValue(
    '            "FromCompanyAddress",
    '            FromCompanyAddress
    '        )

    '        RptGrouped.SetParameterValue(
    '            "FromCompanyGST",
    '            "GSTIN : " & FromCompanyGST
    '        )

    '        RptGrouped.SetParameterValue(
    '            "FromCompanyMobile",
    '            "Mobile : " & FromCompanyMobile
    '        )

    '        RptGrouped.SetParameterValue(
    '            "ToCompanyName",
    '            ToCompanyName
    '        )

    '        RptGrouped.SetParameterValue(
    '            "ToCompanyAddress",
    '            ToCompanyAddress
    '        )

    '        RptGrouped.SetParameterValue(
    '            "ToCompanyGST",
    '            "GSTIN : " & ToCompanyGST
    '        )

    '        RptGrouped.SetParameterValue(
    '            "ToCompanyMobile",
    '            "Mobile : " & ToCompanyMobile
    '        )


    '        '=======================================================
    '        ' 13. Show Report
    '        '=======================================================
    '        frmReportViewer.CRViewer.ReportSource = RptGrouped

    '        frmReportViewer.Visible = False

    '        frmReportViewer.Show()


    '    Catch ex As Exception

    '        If Trn IsNot Nothing Then

    '            Try
    '                Trn.Rollback()
    '            Catch
    '            End Try

    '        End If


    '        MessageBox.Show(
    '            "Error generating grouped delivery receipt: " &
    '            ex.Message,
    '            "Error",
    '            MessageBoxButtons.OK,
    '            MessageBoxIcon.Error
    '        )


    '    Finally

    '        BtnGrouped.Enabled = True

    '    End Try

    'End Sub

End Class