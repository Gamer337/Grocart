Imports System.Data.OleDb
Partial Class Default7
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'hide menu
        Dim nmx As Menu
        nmx = CType(Master.FindControl("NavigationMenu"), Menu)
        nmx.Visible = False
        'end hide
    End Sub


    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Then
            L1.Visible = True
            TextBox1.Focus()
        Else
            L1.Visible = False
        End If

        If Trim(TextBox2.Text) = "" Then
            L2.Visible = True
            TextBox2.Focus()
        Else
            L2.Visible = False
        End If

        Dim c As Class1
        c = New Class1()
        c.connect()
        c.sql = "select * from supplier;"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        While (c.dr.Read)
            If (c.dr("susrname") = Trim(TextBox1.Text)) Then
                If c.dr("spasswd") = Trim(TextBox2.Text) Then
                    glbl.sid = c.dr("s_id")
                    glbl.sname = c.dr("sname")
                    glbl.uname = Trim(TextBox1.Text)
                    Response.Redirect("~/supplieroption.aspx")
                    Response.End()
                Else
                    MsgBox(" Wrong Password ")
                    Exit Sub
                End If
            End If
        End While
        MsgBox(" Invalid Userid /email")
        c = Nothing
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("~/Default.aspx")
    End Sub
End Class
