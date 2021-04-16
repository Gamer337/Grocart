Imports System.Data.OleDb
Partial Class Account_Login
    Inherits System.Web.UI.Page

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("~/Default.aspx")
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'hide menu
        Dim nmx As Menu
        nmx = CType(Master.FindControl("NavigationMenu"), Menu)
        nmx.Visible = False
        'end hide
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As Class1
        c = New Class1
        c.connect()
        c.sql = "delete from order_tmp;"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()



        c.sql = "select * from login;"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        While (c.dr.Read)
            If (c.dr("usrname") = Trim(TextBox1.Text)) Then
                If c.dr("passwd") = Trim(TextBox2.Text) Then
                    glbl.uname = Trim(TextBox1.Text)


                    Response.Redirect("~/Default5.aspx")
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

    Protected Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim rand As Random
        Dim x As Integer
        rand = New Random()
        x = rand.Next(1, 6)
        'TextBox1.Text = "hi" & rand.ToString

        'MsgBox("Hi" & x)


        Image1.ImageUrl = "~/grocartimg/download (" & x & ").jpg"

    End Sub

   
End Class
