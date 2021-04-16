Imports System.Data.OleDb
Partial Class Default8
    Inherits System.Web.UI.Page
   
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        If Not IsPostBack Then
            glbl.x = Request.QueryString("pid")
            Dim y As String
            y = Request.QueryString("fn")
            Image1.ImageUrl = y
        Dim c As Class1
        c = New Class1
            c.sql = "select * from products where pid=" & glbl.x & ";"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        c.dr.Read()
            glbl.prc = c.dr("mrp")
            'MsgBox(prce)
        Label2.Text = " Brand : " & c.dr("brand") & "<br> Product :" & c.dr("pgroup") & "<br>Product Name:" & c.dr("pname") & " <br>MRP:" & c.dr("mrp") & "<br> Supplied By :" & c.dr("sname") & "<br> Offer :" & c.dr("offer")
        c.dr.Close()
        c.cmd.Dispose()
        c.disconnect()

        End If

        If Not IsPostBack Then
            Dim c1 As Class1
            c1 = New Class1
            c1.connect()

            c1.sql = "select * from order_tmp where usrname='" & glbl.uname & "';"
            SqlDataSource1.SelectCommand = c1.sql
            GridView1.DataBind()
            c1.disconnect()




        End If

    End Sub

    

    Protected Sub button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button2.Click
        'Response.Redirect("~/cart.aspx")
        Dim c As Class1
        c = New Class1
        Dim qty As Int16
        Dim max As Int16
        c.sql = "select max(ordno) from order_data;"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        While (c.dr.Read)
            If IsDBNull(c.dr(0)) Then
                max = 1
            Else
                max = c.dr(0) + 1
            End If
        End While
        c.dr.Close()
        c.cmd.Dispose()
        c.sql = "select c_id from register where usrname='" & glbl.uname & "';"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        c.dr.Read()
        glbl.c_id = c.dr(0)
        c.dr.Close()
        c.cmd.Dispose()
        qty = Val(TextBox2.Text)
        ' c.sql = "insert into order_data values(" & max & "," & glbl.x & "," & glbl.c_id & "," & qty & "," & glbl.prc & ",'" & Format(System.DateTime.Now, "MM/dd/yyyy") & "');"
        ' c.cmd = New OleDbCommand(c.sql, c.cn)
        ' c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.disconnect()
        ''to do

        Dim c1 As Class1
        c1 = New Class1
        c1.connect()

        c1.sql = "select max(slno) from order_tmp where usrname='" & glbl.uname & "';"
        c1.cmd = New OleDbCommand(c1.sql, c1.cn)
        c1.dr = c1.cmd.ExecuteReader
        Dim sno As Int16
        sno = 0
        While c1.dr.Read
            If IsDBNull(c1.dr(0)) Then
                sno = "1"
            Else
                sno = c1.dr(0) + 1
            End If
        End While
        c1.dr.Close()
        c1.cmd.Dispose()
        'read product
        c1.sql = "select * from products where pid=" & glbl.x
        c1.cmd = New OleDbCommand(c1.sql, c1.cn)
        c1.dr = c1.cmd.ExecuteReader
        Dim cmd2 As OleDbCommand
        While c1.dr.Read
            glbl.sid = c1.dr("s_id")
            c1.sql = "insert into order_tmp values('" & glbl.uname & "'," & sno & "," & glbl.x & ",'" & c1.dr("brand") & "','" & c1.dr("pname") & "'," & glbl.prc & "," & c1.dr("taxp") & ",'" & c1.dr("sname") & "'," & qty & "," & (qty * glbl.prc) + ((qty * glbl.prc) * c1.dr("taxp") / 100) & ",'" & c1.dr("unit") & "'," & c1.dr("weight") & ");"
            cmd2 = New OleDbCommand(c1.sql, c1.cn)
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()
        End While
        c1.dr.Close()
        c1.cmd.Dispose()
        c1.disconnect()

        SqlDataSource1.SelectCommand = "select * from order_tmp where usrname='" & glbl.uname & "';"
        GridView1.DataBind()

    End Sub

    Protected Sub button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button3.Click
        Response.Redirect("~/Default5.aspx")

    End Sub

    Protected Sub button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles button4.Click
        Response.Redirect("~/Cart.aspx")

    End Sub
End Class
