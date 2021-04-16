Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Partial Class resetpass
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click

        If Trim(TextBox1.Text) = "" And Trim(TextBox2.Text) = "" Then
            MsgBox(" Required Field user id or email missing")
            TextBox1.Focus()
            Exit Sub
        End If

        If Len(TextBox3.Text) <> 10 Then
            MsgBox(" invalid mobile no ")
            Exit Sub
        End If
        If IsNumeric(TextBox3.Text) = False Then
            MsgBox(" Invalid mobile no ")
            Exit Sub
        End If
        Dim c As Class1
        c = New Class1
        Dim smail As String
        Dim ustr, ustr2 As String
        Dim mobno As String
        ustr = ""
        smail = ""
        c.connect()
        If Trim(TextBox1.Text) = "" Then
            c.sql = "select * from register where email='" & Trim(TextBox2.Text) & "';"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            If c.dr.HasRows = False Then
                MsgBox(" email id does not exists ...")
                Exit Sub
            End If
            While c.dr.Read
                smail = c.dr("email")
            End While
            c.dr.Close()
            c.cmd.Dispose()

        Else
            c.sql = "select * from register where usrname='" & Trim(TextBox1.Text) & "';"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            If c.dr.HasRows = False Then
                MsgBox(" user id does not exists ...")
                Exit Sub
            End If
            While c.dr.Read
                ustr = c.dr("usrname")
            End While
            c.dr.Close()
            c.cmd.Dispose()


        End If
        c.sql = "select * from register where mobno=" & Val(TextBox3.Text) & ";"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        If c.dr.HasRows = False Then
            MsgBox(" Mobile No does not exists ...")
            Exit Sub
        End If
        While c.dr.Read
            mobno = c.dr("mobno")
            ustr2 = c.dr("usrname")
        End While
        c.dr.Close()
        c.cmd.Dispose()
        Dim rno As Double
        rno = CInt(Math.Ceiling(Rnd() * 1000)) + 1
        'MsgBox(rno)
        Dim newpass As String
        newpass = ustr2 & rno
        c.sql = "Update register set pass='" & newpass & "' where mobno=" & Val(mobno) & ";"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.sql = "Update login set passwd='" & newpass & "' where usrname='" & ustr2 & "';"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.disconnect()
        'send sms

        Dim sURL As String
        Dim objReader As StreamReader
        sURL = "http://apps.smslane.com/vendorsms/pushsms.aspx?user=aditicomforts&password=" _
        & "233257&msisdn=91" & mobno & "&sid=SMSLane&msg=Hi " & ustr2 & " Your new Password to login GROCART :" & newpass & "&fl=0"

        Dim sResponse As WebRequest
        sResponse = WebRequest.Create(sURL)
        Try
            Dim objStream As Stream
            objStream = sResponse.GetResponse.GetResponseStream()
            objReader = New StreamReader(objStream)
            Response.Write(objReader.ReadToEnd())
            objReader.Close()
            MsgBox(" Your new password sent to mobile no ... ")

            Response.Redirect("default.aspx")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






    End Sub
End Class
