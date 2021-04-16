Imports System.Data.OleDb
Partial Class Default2
    Inherits System.Web.UI.Page
    Dim fn As String
    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        fn = (Image1.ImageUrl)

        If Trim(fn) = "" Then
            MsgBox(" Image not found ... cannot insert ")
            Exit Sub
        End If
        Dim c As Class1
        c = New Class1

        c.sql = "select max(pid) from products;"
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
            L1.Visible = True
            TextBox2.Focus()
            Exit Sub
        Else
            L1.Visible = False
        End If
        If Trim(TextBox3.Text) = "" Then
            L2.Visible = True
            TextBox3.Focus()
            Exit Sub
        Else
            L2.Visible = False
        End If
        If Trim(TextBox4.Text) = "" Then
            L3.Visible = True
            TextBox4.Focus()
            Exit Sub
        Else
            L3.Visible = False
        End If
        If (IsNumeric(TextBox5.Text)) = False Then
            L4.Visible = True
            TextBox5.Focus()
            Exit Sub
        Else
            L4.Visible = False
        End If
        If (IsNumeric(TextBox6.Text)) = False Then
            L5.Visible = True
            TextBox6.Focus()
            Exit Sub
        Else
            L5.Visible = False
        End If
        If IsNumeric(TextBox7.Text) = False Then
            L6.Visible = True
            TextBox7.Focus()
            Exit Sub
        Else
            L6.Visible = False
        End If
        If Trim(TextBox9.Text) = "" Then
            L7.Visible = True
            TextBox9.Focus()
            Exit Sub
        Else
            L7.Visible = False
        End If
        If IsNumeric(TextBox10.Text) = False Then
            L8.Visible = True
            TextBox10.Focus()
            Exit Sub
        Else
            L8.Visible = False
        End If
        c.sql = "Insert into products values(" & Val(TextBox1.Text) & "," & glbl.sid & ",'" & glbl.sname & "','" & Trim(TextBox2.Text) & "','" & Trim(TextBox3.Text) & "','" & Trim(TextBox4.Text) & "'," & Val(TextBox5.Text) & "," & Val(TextBox6.Text) & "," & Val(TextBox7.Text) & " ,'" & Trim(TextBox9.Text) & "'," & Val(TextBox10.Text) & ");"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()

        c.sql = "insert into pimages (id,pimg)SELECT " & Val(TextBox1.Text) & ",BulkColumn " & " FROM Openrowset( Bulk '" & fn & "', Single_Blob) as img "
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.disconnect()
        MsgBox(" ... product registered ...")
        TextBox1.Text = ""
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        If FileUpload1.HasFile Then
            Image1.ImageUrl = FileUpload1.PostedFile.FileName
            ' MsgBox(FileUpload1.PostedFile.FileName)
            ' Image1.ImageUrl = "~/images/ashirwad10kg.jpg"
            Try
                Dim img1 As System.Drawing.Image = System.Drawing.Image.FromFile(Image1.ImageUrl)
            Catch ex As Exception
                MsgBox(ex.Message)
                MsgBox(" Not an image")
                Exit Sub
            End Try

            fn = (FileUpload1.PostedFile.FileName)

        End If
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Response.Redirect("~/default5.aspx")
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        Image1.ImageUrl = ""
        TextBox2.Focus()
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim s1 As String
            s1 = "SELECT DISTINCT [pid], [s_id], [sname], [pgroup], [pname], [mrp] FROM [products] where [s_id]=" _
               & glbl.sid & " ORDER BY [pid] DESC, [s_id] DESC"
            SqlDataSource2.SelectCommand = s1
            SqlDataSource2.DataBind()

            GridView1.DataBind()

        End If
    End Sub

    Protected Sub Button5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim c As Class1
        c = New Class1
        Dim s2 As String
        s2 = "select [pid] from [products];"
        c.connect()
        c.cmd = New OleDbCommand(s2, c.cn)
        c.dr = c.cmd.ExecuteReader
        Dim pno As Int16

        While c.dr.Read
            pno = c.dr("pid")
        End While
        c.dr.Close()
        c.cmd.Dispose()

        If Val(TextBox8.Text) = pno Then
            c.sql = "delete from products where [pid]=" & Val(TextBox8.Text) & ";"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.cmd.ExecuteNonQuery()
            c.cmd.Dispose()
            c.disconnect()
            MsgBox("selected product deleted successfully")
        End If


    End Sub

    Protected Sub Button6_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button6.Click
        Response.Redirect("~/supplieroption.aspx")
    End Sub
End Class
