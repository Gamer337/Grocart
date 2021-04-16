Imports System.Data.OleDb
Partial Class Account_Register
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'hide menu
        Dim nmx As Menu
        nmx = CType(Master.FindControl("NavigationMenu"), Menu)
        nmx.Visible = False
        'end hide
    End Sub


    Protected Sub UserName_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles UserName.TextChanged

    End Sub

    Protected Sub CreateUserButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As Class1
        c = New Class1()
        c.sql = "select max(c_id) from register;"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        While (c.dr.Read)
            If IsDBNull(c.dr(0)) Then
                TextBox5.Text = "1"
            Else
                TextBox5.Text = c.dr(0) + 1
            End If
        End While
        c.dr.Close()
        c.cmd.Dispose()
        c.disconnect()

        If Trim(TextBox1.Text) = "" Then
            L1.Visible = True
            TextBox1.Focus()
            Exit Sub
        Else
            L1.Visible = False
        End If

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

        If Trim(TextBox4.Text) = "" Then
            L4.Visible = True
            TextBox4.Focus()
            Exit Sub
        Else
            L4.Visible = False
        End If
        If IsNumeric(TextBox7.Text) = False Then
            L10.Visible = True
            TextBox7.Focus()
            Exit Sub
        Else
            L10.Visible = False
        End If
        If Len(TextBox7.Text) <> 6 Then
            L10.Visible = True
            L10.Text = "Enter 6 Digit CityPin"
            TextBox7.Focus()
            Exit Sub
        End If

        If (IsNumeric(TextBox6.Text)) = False Then
            L9.Visible = True
            TextBox6.Focus()
            Exit Sub
        Else
            L9.Visible = False
        End If
        If Len(TextBox6.Text) <> 10 Then
            L9.Visible = True
            L9.Text = "Enter 10 Digit Mobile Number"
            TextBox6.Focus()
            Exit Sub
        End If

        If Trim(UserName.Text) = "" Then
            L5.Visible = True
            UserName.Focus()
            Exit Sub
        Else
            L5.Visible = False
        End If

        If Trim(Email.Text) = "" Then
            L6.Visible = True
            Email.Focus()
            Exit Sub
        Else
            L6.Visible = False
        End If

        If Trim(Password.Text) = "" Then
            L7.Visible = True
            Password.Focus()
            Exit Sub
        Else
            L7.Visible = False
        End If

        If Trim(ConfirmPassword.Text) = "" Then
            L8.Visible = True
            L7.Visible = True
            ConfirmPassword.Focus()
            Exit Sub
        Else
            L8.Visible = False
            L7.Visible = False
        End If

        If Trim(Password.Text) <> Trim(ConfirmPassword.Text) Then
            L8.Text = "Passwords Don't Match"
            L8.Visible = True
            ConfirmPassword.Focus()
            Exit Sub
        End If

        'check for duplicate mob email
        Dim merr, mailerr As Boolean
        merr = False
        mailerr = False
        c.sql = "select * from register where mobno=" & Val(TextBox6.Text)
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        If c.dr.HasRows = True Then
            '    MsgBox(" Mobile No already registred by someone")
            '   Exit Sub
            merr = True
        End If
        c.dr.Close()
        c.cmd.Dispose()
        c.sql = "select * from register where email='" & Trim(Email.Text) & "';"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        If c.dr.HasRows = True Then
            'MsgBox(" email is already registered by someone !!")
            'Exit Sub
            mailerr = True

        End If
        c.dr.Close()
        c.cmd.Dispose()
        If merr = True Then
            L9.Visible = True
            L9.Text = "* Mobile Already Registered"
            Exit Sub
        Else
            L9.Text = ""
        End If

        If mailerr = True Then
            L6.Visible = True
            L6.Text = "* Already  registered "
            Exit Sub
        Else
            L6.Text = ""
        End If

        c.sql = "Insert into register values(" & Val(TextBox5.Text) & ",'" & Trim(TextBox1.Text) _
        & "','" & Trim(TextBox2.Text) & "','" & Trim(TextBox3.Text) & "','" & Trim(TextBox4.Text) _
        & "'," & Val(TextBox7.Text) & "," & Val(TextBox6.Text) & ",'" & Trim(UserName.Text) _
        & "','" & Trim(Email.Text) & "','" & Trim(Password.Text) & "');"

        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()

        c.sql = "Insert into login values('" & Trim(UserName.Text) & "','" & Trim(Password.Text) & "');"

        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.disconnect()
        MsgBox(" Hi Registration Succeded ... Please use Login")
        Response.Redirect("~/Account/Login.aspx")

    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Response.Redirect("~/Default.aspx")
    End Sub

  

End Class
