Imports System.Data.OleDb

Partial Class Account_pedit
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Trim(TextBox1.Text) = "" Then
            MsgBox(" Invalid Name ")
            TextBox1.Focus()
            Exit Sub
        End If
        If Trim(TextBox2.Text) = "" Then
            MsgBox(" Invalid Address")
            TextBox2.Focus()
            Exit Sub
        End If
        If Trim(TextBox3.Text) = "" Then
            MsgBox(" Invalid City ")
            TextBox3.Focus()
            Exit Sub
        End If
        
        If Trim(TextBox4.Text) = "" Then
            MsgBox(" Invalid landmark ")
            TextBox4.Focus()
            Exit Sub
        End If
        If Len(TextBox5.Text) <> 6 Then
            MsgBox(" Invalid City Pin ")
            TextBox5.Focus()
            Exit Sub
        End If
        If Val(TextBox6.Text) = "" Then
            MsgBox(" Invalid Mob NO. ")
            TextBox6.Focus()
            Exit Sub
        End If
        If Trim(TextBox7.Text) = "" Then
            MsgBox(" Invalid Email Id ")
            TextBox7.Focus()
            Exit Sub
        End If
        If Trim(TextBox8.Text) = "" Then
            MsgBox(" Invalid password ")
            TextBox7.Focus()
            Exit Sub
        End If
        If Trim(TextBox9.Text) <> Trim(TextBox10.Text) Then
            MsgBox(" Invalid password ")
            TextBox10.Focus()
            Exit Sub
        End If
            'do rest validation

            'update here
            Dim s As String
            s = MsgBox("Are you sure Update Profile ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If s = MsgBoxResult.Yes Then
                Dim c As Class1
                c = New Class1

                c.connect()
                c.sql = "Update register set cname='" & Trim(TextBox1.Text) & "',address='" & Trim(TextBox2.Text) & "',city='" & Trim(TextBox3.Text) _
                    & "',lndmrk='" & Trim(TextBox4.Text) & "',citypin=" & Val(TextBox5.Text) & ",mobno=" & Val(TextBox6.Text) & ",email='" _
                    & Trim(TextBox7.Text) & "',pass='" & Trim(TextBox9.Text) & "' where usrname='" & glbl.uname & "';"
                c.cmd = New OleDbCommand(c.sql, c.cn)
                c.cmd.ExecuteNonQuery()
                c.cmd.Dispose()
                c.sql = "update login set passwd='" & Trim(TextBox9.Text) & "' where usrname='" & glbl.uname & "';"

                c.cmd = New OleDbCommand(c.sql, c.cn)
                c.cmd.ExecuteNonQuery()
                c.cmd.Dispose()
                c.disconnect()
                c = Nothing
                MsgBox(" Profile Updated ")


            End If


    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then



            Dim x As Integer
            x = glbl.c_id
            Dim c As Class1
            c = New Class1
            c.sql = "select * from register where usrname='" & glbl.uname & "';"



            c.connect()
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            While c.dr.Read
                TextBox1.Text = c.dr("cname")
                TextBox2.Text = c.dr("address")
                TextBox3.Text = c.dr("city")
                TextBox4.Text = c.dr("lndmrk")
                TextBox5.Text = c.dr("citypin")
                TextBox6.Text = c.dr("mobno")
                TextBox7.Text = c.dr("email")
                'TextBox8.Text=c.dr("

            End While
            c.dr.Close()
            c.cmd.Dispose()
            c.disconnect()
            c = Nothing
        End If

    End Sub
End Class
