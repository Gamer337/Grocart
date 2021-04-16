Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Data.OleDb
Partial Class cart

    Inherits System.Web.UI.Page
    Public cnt As Integer
    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        'MsgBox(" you selected ")
        cnt += 1
        If (cnt Mod 2) = 0 Then
            Dim row As GridViewRow = GridView1.SelectedRow
            Dim s As String
            Dim k As Int16
            s = MsgBox("Are you Sure Delete this item From Cart ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
            If s = MsgBoxResult.Yes Then
                k = Val((row.Cells(1).Text))
                Dim c1 As Class1
                c1 = New Class1

                c1.connect()
                c1.sql = "delete from order_tmp where slno=" & k
                c1.cmd = New OleDbCommand(c1.sql, c1.cn)
                c1.cmd.ExecuteNonQuery()
                c1.cmd.Dispose()

                Dim n As Int16
                n = 1
                c1.sql = "select * from order_tmp order by slno;"
                c1.cmd = New OleDbCommand(c1.sql, c1.cn)
                c1.dr = c1.cmd.ExecuteReader
                Dim cmd2 As OleDbCommand

                While c1.dr.Read
                    c1.sql = "Update order_tmp set slno=" & n & " where slno=" & c1.dr("slno")
                    cmd2 = New OleDbCommand(c1.sql, c1.cn)
                    cmd2.ExecuteNonQuery()
                    cmd2.Dispose()
                    n += 1

                End While
                c1.disconnect()
                GridView1.DataBind()

                Dim c As Class1
                c = New Class1
                c.connect()

                c.sql = "select sum(weight),sum(netamt) from order_tmp;"
                c.cmd = New OleDbCommand(c.sql, c.cn)
                c.dr = c.cmd.ExecuteReader
                Dim w, sc As Double

                While c.dr.Read
                    If IsDBNull(c.dr(0)) Then
                        Label4.Text = "0"
                        Label6.Text = "0"
                        Label8.Text = "0"
                        Label10.Text = "0"
                    Else
                        Label4.Text = FormatNumber(c.dr(0), 2) & " Kgs"
                        Label6.Text = "" & FormatNumber(c.dr(1), 2) & ""
                        w = FormatNumber(c.dr(0), 2)
                        If (w < 5) Then
                            sc = 40
                        Else
                            If (w < 10) Then
                                sc = 80
                            Else
                                If (w < 50) Then
                                    sc = 150
                                Else
                                    sc = 300
                                End If
                            End If
                        End If
                        Label8.Text = FormatNumber(sc, 2)
                        Label10.Text = Val(Label6.Text) + Val(Label8.Text)
                    End If

                End While
                c.dr.Close()
                c.cmd.Dispose()
                c.disconnect()
            End If
        End If
    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            cnt = 1
            Dim c As Class1
            c = New Class1
            c.connect()
            Label13.Text = glbl.uname

            c.sql = "select unit,sum(weight),sum(netamt) from order_tmp group by unit;"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            Dim w, sc As Double

            While c.dr.Read
                If IsDBNull(c.dr(0)) Then
                    Label4.Text = "0"
                    Label6.Text = "0"
                    Label8.Text = "0"
                    Label10.Text = "0"
                Else

                    If c.dr(0) = "kg" Then
                        w = w + c.dr(1)
                    Else
                        w = w + (c.dr(1) / 1000)

                    End If
                    Label4.Text = FormatNumber(w, 3) & " Kgs"

                    Label6.Text = "" & c.dr(2) & ""

                   

                End If

            End While
            If (w < 5) Then
                sc = 40
            Else
                If (w < 10) Then
                    sc = 80
                Else
                    If (w < 50) Then
                        sc = 150
                    Else
                        sc = 300
                    End If
                End If
            End If
            Label8.Text = sc
            Label10.Text = Val(Label6.Text) + Val(Label8.Text)
            c.dr.Close()
            c.cmd.Dispose()
            c.disconnect()

        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As Class1
        c = New Class1
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
        c.disconnect()
        Dim c1 As Class1
        c1 = New Class1
        Dim cmd2 As OleDbCommand
        Dim cmd3 As OleDbCommand
        Dim cmd4 As OleDbCommand
        c1.sql = "select * from order_tmp"
        c1.connect()
        c1.cmd = New OleDbCommand(c1.sql, c1.cn)
        c1.dr = c1.cmd.ExecuteReader       
        Dim dr1 As OleDbDataReader
        While c1.dr.Read
            c1.sql = "insert into order_data values(" & max & ",'" & c1.dr("usrname") & "'," & c1.dr("pid") & ",'" & c1.dr("pname") & "'," & c1.dr("mrp") & "," & c1.dr("taxp") & ",'" & c1.dr("sname") & "'," & c1.dr("qty") & "," & c1.dr("netamt") & ");"
            cmd2 = New OleDbCommand(c1.sql, c1.cn)
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()

        End While

        c1.sql = "select * from order_data;"
        cmd3 = New OleDbCommand(c1.sql, c1.cn)
        dr1 = cmd3.ExecuteReader
        While dr1.Read
            c1.sql = "insert into sales values(" & max & "," & dr1("ordno") & "," & glbl.sid & "," & dr1("pid") & "," & dr1("mrp") & ",'" & Format(System.DateTime.Now, "MM/dd/yyyy") & "'," & dr1("mrp") & ",'" & ("Pending") & "');"
            cmd4 = New OleDbCommand(c1.sql, c1.cn)
            cmd4.ExecuteNonQuery()
            cmd4.Dispose()
        End While

        dr1.Close()
        cmd3.Dispose()

        c1.dr.Close()
        c1.cmd.Dispose()
        'c1.sql = "delete from order_tmp;"
        'c1.cmd = New OleDbCommand(c1.sql, c1.cn)
        'c1.cmd.ExecuteNonQuery()
        'c1.cmd.Dispose()
        GridView1.DataBind()
        ' Response.Redirect("ordersummary.aspx")
        ' MsgBox("Order Summary Page  ?")
        Button2.Enabled = True
        Button1.Enabled = False

        c.connect()

        c.sql = "select mobno from register where usrname='" & glbl.uname & "';"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        Dim cmob As String
        While c.dr.Read
            cmob = c.dr("mobno")
        End While
        c.dr.Close()
        c.cmd.Dispose()

        c1.disconnect()

        Dim sURL As String
        Dim objReader As StreamReader
        sURL = "http://apps.smslane.com/vendorsms/pushsms.aspx?user=aditicomforts&password=" _
        & "233257&msisdn=91" & cmob & "&sid=SMSLane&msg=Hi " & glbl.uname & " your order for amount Rs" & Trim(Label10.Text) & " has been Placed Successfully. Further status shall be intimated you shortly GROCART&fl=0"

        Dim sResponse As WebRequest
        sResponse = WebRequest.Create(sURL)
        Try
            Dim objStream As Stream
            objStream = sResponse.GetResponse.GetResponseStream()
            objReader = New StreamReader(objStream)
            Response.Write(objReader.ReadToEnd())
            objReader.Close()
            Response.Redirect("cart.aspx")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As Class1
        c = New Class1
        c.sql = "delete from order_prn;"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()

        c.sql = "select * from order_tmp order by slno;"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.dr = c.cmd.ExecuteReader
        Dim cmd2 As OleDbCommand
        Dim s As String

        While c.dr.Read
            s = "insert into order_prn values('" & c.dr(0) & "'," & c.dr(1) & "," & c.dr(2) & ",'" & c.dr(3) & "','" & c.dr(4) _
                & "'," & c.dr(5) & "," & c.dr(6) & ",'" & c.dr(7) & "'," & c.dr(8) & "," & c.dr(9) & ",'" & c.dr(10) & "'," & c.dr(11) & "," & Val(Label8.Text) & "," & Val(Label10.Text) & ");"
            cmd2 = New OleDbCommand(s, c.cn)
            cmd2.ExecuteNonQuery()
            cmd2.Dispose()


        End While
        c.dr.Close()
        c.cmd.Dispose()
        c.disconnect()
        c = Nothing


        Response.Redirect("orderprint.aspx")

    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim sURL As String
        Dim objReader As StreamReader
        sURL = "http://apps.smslane.com/vendorsms/pushsms.aspx?user=aditicomforts&password=" _
        & "233257&msisdn=919590557424,919242127823&sid=SMSLane&msg=Test SMS From SMSLane&fl=0"

        Dim sResponse As WebRequest
        sResponse = WebRequest.Create(sURL)
        Try
            Dim objStream As Stream
            objStream = sResponse.GetResponse.GetResponseStream()
            objReader = New StreamReader(objStream)
            Response.Write(objReader.ReadToEnd())
            objReader.Close()
            Response.Redirect("cart.aspx")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class
