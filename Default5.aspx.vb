Imports System.Data.OleDb
Imports System.IO

Partial Class Default5
    Inherits System.Web.UI.Page
    Public cnt As Integer
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim c As Class1
            c = New Class1
            c.sql = "select distinct(pgroup) from products order by pgroup;"
            c.connect()
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            While c.dr.Read
                ListBox1.Items.Add(c.dr(0))
            End While
            c.dr.Close()
            c.cmd.Dispose()
            c.disconnect()
            cnt = 1
        End If
    End Sub
    Protected Sub ListBox1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        cnt += 1
        If (cnt Mod 2) = 0 Then   ' block twice execuion
            Dim c As Class1
            c = New Class1
            c.sql = "select * from products where pgroup='" & ListBox1.Text & "';"
            ' MsgBox(c.sql)

            c.connect()
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            'ListBox2.Items.Clear()
            Dim tr As TableRow
            Dim tc As TableCell

            Dim cmd2 As OleDbCommand
            Dim dr2 As OleDbDataReader

            Dim BYTES1() As Byte
            Dim STRFN As String
            Dim path As String = "d:\ddd\"
            If Directory.Exists(path) Then
                For Each filepath As String In Directory.GetFiles(path)


                    File.Delete(filepath)
                Next
            End If
            Dim ppid As Int16


            While c.dr.Read
                tc = New TableCell
                tc.Text = " PID" & c.dr("pid")
                tr = New TableRow
                tr.Cells.Add(tc)
                c.sql = "select pimg from pimages where id=" & c.dr("pid")
                cmd2 = New OleDbCommand(c.sql, c.cn)
                dr2 = cmd2.ExecuteReader
                dr2.Read()
                BYTES1 = dr2(0)
                STRFN = "d:\ddd\" & Convert.ToString(DateTime.Now.ToFileTime())
                Dim fs As FileStream
                dr2.Close()
                cmd2.Dispose()
                fs = New FileStream(STRFN, FileMode.Create, FileAccess.Write)
                fs.Write(BYTES1, 0, BYTES1.Length)
                fs.Flush()
                fs.Close()
                tc = New TableCell
                ' add image like this
                ppid = c.dr("pid")
                tc.Text = "<center><a href='default8.aspx?pid=" & ppid & "&fn=" & STRFN & "'><img src=" + STRFN + " height=100px width=100px /></a><center>"
                tr.Cells.Add(tc)
                tc = New TableCell
                tc.ForeColor = Drawing.Color.Blue
                tc.Text = "<font face='Times New Roman size=6 color='Blue'> Brand :</font> " & c.dr("brand") & "<br>"
                tc.ForeColor = Drawing.Color.Red
                tc.Text = tc.Text & " Product :" & c.dr("pgroup") & "<br> MRP:" & c.dr("mrp") & "<br> Supplied By :" & c.dr("sname")
                tr.Cells.Add(tc)
                tc = New TableCell
                tc.Text = "   "
                tr.Cells.Add(tc)


                ' On Error Resume Next

                'second set begin
                If c.dr.Read Then



                    tc = New TableCell
                    tc.Text = " PID" & c.dr("pid")
                    ' tr = New TableRow
                    tr.Cells.Add(tc)
                    c.sql = "select pimg from pimages where id=" & c.dr("pid")
                    cmd2 = New OleDbCommand(c.sql, c.cn)
                    dr2 = cmd2.ExecuteReader
                    dr2.Read()
                    BYTES1 = dr2(0)
                    STRFN = "d:\ddd\" & Convert.ToString(DateTime.Now.ToFileTime())
                    ' Dim fs As FileStream
                    dr2.Close()
                    cmd2.Dispose()
                    fs = New FileStream(STRFN, FileMode.Create, FileAccess.Write)
                    fs.Write(BYTES1, 0, BYTES1.Length)
                    fs.Flush()
                    fs.Close()
                    tc = New TableCell
                    ' add image like this
                    ppid = c.dr("pid")
                    tc.Text = "<center><a href='default8.aspx?pid=" & ppid & "&fn=" & STRFN & "'><img src=" + STRFN + " height=100px width=100px /></a><center>"
                    tr.Cells.Add(tc)
                    tc = New TableCell
                    tc.ForeColor = Drawing.Color.Blue
                    tc.Text = "<font face='Times New Roman size=10 color='Blue'> Brand :</font> " & c.dr("brand") & "<br>"
                    tc.ForeColor = Drawing.Color.Red
                    tc.Text = tc.Text & " Product :" & c.dr("pgroup") & "<br> MRP:" & c.dr("mrp") & "<br> Supplied By :" & c.dr("sname")
                    tr.Cells.Add(tc)
                    tc = New TableCell
                    tc.Text = "   "
                    tr.Cells.Add(tc)
                End If
                'end set

                tab2.Rows.Add(tr)

            End While
            ' pictureBox1.Image=Image.FromFile(strfn);

            c.dr.Close()
            c.cmd.Dispose()
            c.disconnect()
        End If
    End Sub

    
End Class
