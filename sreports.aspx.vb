Imports System.Data.OleDb
Partial Class sreports
    Inherits System.Web.UI.Page

    Protected Sub TextBox1_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.PreRender
        'Calendar1.Visible = True

    End Sub

    Protected Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub

    Protected Sub TextBox2_PreRender(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.PreRender
        ' Calendar2.Visible = True

    End Sub

    Protected Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged

    End Sub

    Protected Sub Calendar1_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar1.SelectionChanged

        TextBox1.Text = Format(Calendar1.SelectedDate, "dd/MM/yyyy")
        TextBox2.Focus()
        Calendar1.Visible = False

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Calendar1.Visible = False
            Calendar1.Visible = False

        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If (Calendar1.Visible = True) Then
            Calendar1.Visible = False
        Else
            Calendar1.Visible = True
        End If


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        If (Calendar2.Visible = True) Then
            Calendar2.Visible = False
        Else
            Calendar2.Visible = True
        End If
    End Sub

    Protected Sub Calendar2_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Calendar2.SelectionChanged
        TextBox2.Text = Format(Calendar2.SelectedDate, "dd/MM/yyyy")
        Button3.Focus()

        Calendar2.Visible = False
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim c As Class1
        c = New Class1
        c.sql = "delete from sales_tmp;"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.sql = "select * from sales where sid=" & glbl.sid & " and status='" & DropDownList1.SelectedItem.Text & "' and (bdt between '" & Format(CDate(TextBox1.Text), "MM/dd/yyyy") & "' and '" & Format(CDate(TextBox2.Text), "MM/dd/yyyy") & "') ;"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        MsgBox(TextBox1.Text & "-" & TextBox2.Text)

        MsgBox(c.sql)

        c.dr = c.cmd.ExecuteReader
        Dim s As String
        Dim cmd2 As OleDbCommand

        While c.dr.Read
            s = "insert into sales_tmp values(" & c.dr(0) & "," & c.dr(1) & "," & c.dr(2) & "," & c.dr(3) & "," & c.dr(4) & ",'" & Format(c.dr(5), "MM/dd/yyyy") & "'," & c.dr(6) & ",'" & c.dr(7) & "');"
            cmd2 = New OleDbCommand(s, c.cn)
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()


        End While
        c.dr.Close()

        c.cmd.Dispose()
        c.disconnect()
        GridView1.DataBind()

    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Response.Redirect("default11.aspx")

    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Response.Redirect("~/ordersummary.aspx")
    End Sub
End Class
