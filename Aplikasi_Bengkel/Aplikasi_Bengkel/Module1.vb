﻿Imports System.Data.OleDb

Module Module1
    Public Conn As OleDbConnection
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public str As String

    Public Sub Koneksi()
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & Application.StartupPath & "\DB_Bengkel.accdb"
        Conn = New OleDbConnection(str)
        If Conn.State = ConnectionState.Closed Then
            Conn.Open()
        End If
    End Sub
End Module

