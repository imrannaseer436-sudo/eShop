'********************************************** Bismillah *********************************************
Imports System.Data.SqlClient
Imports System.IO
Public Class iBillExporter

    Private ExportFileLocaton As String = ""

    Public Sub GenerateDateFiles(ByVal iBillDate As Date)

        If GetExportFileLocation() = False Then Exit Sub
        Dim xData As String = ""
        Dim xFDC As String = "tinyint smallint bigint smallmoney money float single"

        Try

            FileOpen(1, ExportFileLocaton & "WH01" & ShopCode & Format(iBillDate, "ddMMyyyy") & ".dat", OpenMode.Output)

            SQL = "select * from billmaster where billdt='" & Format(iBillDate, "yyyy-MM-dd") & "' order by billid;" _
                & "select * from BILLDETAILS where billdt='" & Format(iBillDate, "yyyy-MM-dd") & "' order by billid,sno;" _
                & "select * from BILLPAYMENTS where billdt='" & Format(iBillDate, "yyyy-MM-dd") & "' order by billid,sno"

            With ESSA.OpenReader(SQL)

                If .HasRows Then

                    PrintLine(1, "DELETE FROM billmaster_" & ShopCode & " WHERE BILLDT='" & Format(iBillDate, "yyyy-MM-dd") & "' and SHOPID=" & ShopID)
                    PrintLine(1, "DELETE FROM BILLDETAILS_" & ShopCode & " WHERE BILLDT='" & Format(iBillDate, "yyyy-MM-dd") & "' and SHOPID=" & ShopID)
                    PrintLine(1, "DELETE FROM BILLPAYMENTS_" & ShopCode & " WHERE BILLDT='" & Format(iBillDate, "yyyy-MM-dd") & "' and SHOPID=" & ShopID)

                    While .Read

                        xData = "INSERT INTO billmaster_" & ShopCode & " VALUES ("

                        For FC As SByte = 0 To .FieldCount - 1
                            If xFDC.Contains(.GetDataTypeName(FC)) = True Then
                                xData &= .Item(FC) & ","
                            Else
                                If .GetDataTypeName(FC).Contains("date") Then
                                    If .GetName(FC) = "BillDt" Then
                                        xData &= "'" & Format(.GetDateTime(FC), "yyyy-MM-dd") & "',"
                                    Else
                                        xData &= "'" & Format(.GetDateTime(FC), "yyyy-MM-dd hh:mm:ssss") & "',"
                                    End If
                                Else
                                    xData &= "'" & .Item(FC) & "',"
                                End If
                            End If
                        Next

                        xData = Mid(xData, 1, xData.Length - 1) & ")"
                        PrintLine(1, xData)

                    End While

                End If

                .NextResult()

                If .HasRows Then

                    While .Read

                        xData = "INSERT INTO BILLDETAILS_" & ShopCode & " VALUES ("

                        For FC As SByte = 0 To .FieldCount - 1
                            If xFDC.Contains(.GetDataTypeName(FC)) = True Then
                                xData &= .Item(FC) & ","
                            Else
                                If .GetDataTypeName(FC).Contains("date") Then
                                    xData &= "'" & Format(.GetDateTime(FC), "yyyy-MM-dd") & "',"
                                Else
                                    xData &= "'" & .Item(FC) & "',"
                                End If
                            End If
                        Next

                        xData = Mid(xData, 1, xData.Length - 1) & ")"
                        PrintLine(1, xData)

                    End While

                End If

                .NextResult()

                If .HasRows Then

                    While .Read

                        xData = "INSERT INTO BILLPAYMENTS_" & ShopCode & " VALUES ("

                        For FC As SByte = 0 To .FieldCount - 1
                            If xFDC.Contains(.GetDataTypeName(FC)) = True Then
                                xData &= .Item(FC) & ","
                            Else
                                If .GetDataTypeName(FC).Contains("date") Then
                                    xData &= "'" & Format(.GetDateTime(FC), "yyyy-MM-dd") & "',"
                                Else
                                    xData &= "'" & .Item(FC) & "',"
                                End If
                            End If
                        Next

                        xData = Mid(xData, 1, xData.Length - 1) & ")"
                        PrintLine(1, xData)

                    End While

                End If

                .Close()

            End With

            FileClose(1)

        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
            FileClose(1)
        End Try

    End Sub

    Private Function GetExportFileLocation() As Boolean

        GetExportFileLocation = False

        SQL = "select param_value from settings where param_name='ExportFileLocation'"
        With ESSA.OpenReader(SQL)
            If .Read Then
                GetExportFileLocation = True
                ExportFileLocaton = .GetString(0).Trim
            End If
            .Close()
        End With

        If GetExportFileLocation = False Then
            MsgBox("Sorry, Export File Location Not Found..!", MsgBoxStyle.Critical)
        End If

    End Function

End Class
