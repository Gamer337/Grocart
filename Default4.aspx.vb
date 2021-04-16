Imports System.Data.OleDb
Partial Class Default4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'hide menu
        Dim nmx As Menu
        nmx = CType(Master.FindControl("NavigationMenu"), Menu)
        nmx.Visible = False
        'end hide
    End Sub



    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As Class1
        c = New Class1()
        c.sql = "select max(s_id) from supplier;"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        While (c.dr.Read)
            If IsDBNull(c.dr(0)) Then
                TextBox1.Text = "1"
            Else
                TextBox1.Text = c.dr(0) + 1
            End If
        End While
        c.dr.Close()
        c.cmd.Dispose()
        c.disconnect()

        If Trim(TextBox2.Text) = "" Then
            L2.Visible = True
            TextBox2.Focus()
            Exit Sub
        Else
            L2.Visible = False
        End If

        If Trim(TextBox3.Text) = "" Then
            L3.Visible = True
            TextBox3.Focus()
            Exit Sub
        Else
            L3.Visible = False
        End If

        If (IsNumeric(TextBox4.Text)) = False Then
            L4.Visible = True
            TextBox4.Focus()
            Exit Sub
        Else
            L4.Visible = False
        End If
        If Len(TextBox4.Text) <> 10 Then
            L4.Visible = True
            L4.Text = "Enter 10 Digit Mobile Number"
            TextBox6.Focus()
            Exit Sub
        End If

        If Trim(TextBox5.Text) = "" Then
            L5.Visible = True
            TextBox5.Focus()
            Exit Sub
        Else
            L5.Visible = False
        End If

        If IsNumeric(TextBox6.Text) = False Then
            L6.Visible = True
            TextBox6.Focus()
            Exit Sub
        Else
            L6.Visible = False
        End If
        If Len(TextBox6.Text) <> 6 Then
            L6.Visible = True
            L6.Text = "Enter 6 Digit CityPin"
            TextBox6.Focus()
            Exit Sub
        End If


        If Trim(TextBox7.Text) = "" Then
            L7.Visible = True
            TextBox7.Focus()
            Exit Sub
        Else
            L7.Visible = False
        End If

        If Trim(TextBox8.Text) = "" Then
            L8.Visible = True
            TextBox8.Focus()
            Exit Sub
        Else
            L8.Visible = False
        End If

        If Trim(TextBox9.Text) = "" Then
            L9.Visible = True
            TextBox9.Focus()
            Exit Sub
        Else
            L9.Visible = False
        End If

        If Trim(TextBox10.Text) = "" Then
            L9.Visible = True
            L10.Visible = True
            TextBox10.Focus()
            Exit Sub
        Else
            L9.Visible = False
            L10.Visible = False
        End If

        If Trim(TextBox9.Text) <> Trim(TextBox10.Text) Then
            L10.Text = "Passwords Don't Match"
            L10.Visible = True
            TextBox10.Focus()
            Exit Sub
        End If

        Dim merr, mailerr As Boolean
        merr = False
        mailerr = False
        c.sql = "select * from supplier where mobno=" & Val(TextBox4.Text)
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        If c.dr.HasRows = True Then
            merr = True
        End If
        c.dr.Close()
        c.cmd.Dispose()
        c.sql = "select * from supplier where semail='" & Trim(TextBox8.Text) & "';"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        If c.dr.HasRows = True Then
            mailerr = True
        End If
        c.dr.Close()
        c.cmd.Dispose()
        If merr = True Then
            L4.Visible = True
            L4.Text = "* Mobile Already Registered"
            Exit Sub
        Else
            L4.Text = ""
        End If

        If mailerr = True Then
            L8.Visible = True
            L8.Text = "* Already  registered "
            Exit Sub
        Else
            L8.Text = ""
        End If
        c.connect()
        c.sql = "Insert into supplier values(" & Val(TextBox1.Text) & ",'" & Trim(TextBox2.Text) & "','" & Trim(TextBox3.Text) & "'," & Val(TextBox4.Text) & ",'" & Trim(TextBox5.Text) & "'," & Val(TextBox6.Text) & ",'" & Trim(TextBox7.Text) & "','" & Trim(TextBox8.Text) & "','" & Trim(TextBox9.Text) & "');"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.disconnect()
        MsgBox(" Hi Supplier Registered ... ")
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("default.aspx")

    End Sub
End Class
