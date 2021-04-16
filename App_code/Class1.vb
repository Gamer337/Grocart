Imports Microsoft.VisualBasic
Imports System.Data.OleDb
Public Class glbl
    Public Shared uname As String
    Public Shared sid As Integer
    Public Shared sname As String
    Public Shared pid As Integer
    Public Shared c_id As Integer
    Public Shared prc As Double
    Public Shared x As Integer
    Public Shared ono As Integer
    Public Shared supn As String
End Class
Public Class Class1
    Public cn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public sql As String
    Public fn As String
   

    Public Sub connect()
        cn = New OleDbConnection
        cn.ConnectionString = "Provider=SQLNCLI.1;Data Source=.\sqlexpress;Integrated Security=SSPI;Initial Catalog=vgdb"
        cn.Open()
    End Sub
    Public Sub disconnect()
        cn = Nothing

    End Sub
End Class

