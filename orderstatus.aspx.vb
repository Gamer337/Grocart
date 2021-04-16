Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Partial Class orderstatus
    Inherits System.Web.UI.Page
    
    Protected Sub GridView1_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Dim k As String

        Dim row As GridViewRow = GridView1.SelectedRow
        k = Val((row.Cells(1).Text))
        lblst.Text = row.Cells(6).Text
        glbl.supn = row.Cells(4).Text
        glbl.ono = k
        Dim c As Class1
        c = New Class1
        c.connect()

        c.sql = "delete from rec_order;"
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.sql = "insert rec_order select * from order_data where ordno=" & k
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.disconnect()
        c = Nothing
        GridView2.DataBind()

        If Trim(lblst.Text) = "Pending" Or lblst.Text = "processing" Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False

        End If

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Dim c As Class1
            c = New Class1
            c.connect()

            c.sql = "delete from order_status;"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.cmd.ExecuteNonQuery()
            c.cmd.Dispose()
            c.sql = "select ordno,usrname,sname,sum(netamt) from order_data where usrname='" & glbl.uname & "' " _
& " group by ordno,usrname,sname "
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            Dim cmd2, cm3 As OleDbCommand
            Dim dr2 As OleDbDataReader
            While c.dr.Read
                c.sql = "select bdt,ordno,status from sales where ordno=" & c.dr(0) & " group by bdt,ordno,status"
                cmd2 = New OleDbCommand(c.sql, c.cn)
                dr2 = cmd2.ExecuteReader
                While dr2.Read
                    c.sql = "insert into order_status values(" & c.dr(0) & ",'" & Format(dr2(0), "MM/dd/yyyy") & "','" & c.dr(1) & "','" _
                        & c.dr(2) & "'," & c.dr(3) & ",'" & dr2(2) & "');"
                    cm3 = New OleDbCommand(c.sql, c.cn)
                    cm3.ExecuteNonQuery()
                    cm3.Dispose()

                End While

            End While
            c.dr.Close()
            c.cmd.Dispose()
            c.sql = "delete from rec_order;"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.cmd.ExecuteNonQuery()
            c.cmd.Dispose()


            c.disconnect()
            c = Nothing
            GridView1.DataBind()
            GridView2.DataBind()



        End If
    End Sub

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim s As String
        s = MsgBox("Are you sure Cancel This Order ?", MsgBoxStyle.Question + MsgBoxStyle.YesNo)
        If s = MsgBoxResult.Yes Then
            Dim c As Class1
            c = New Class1
            c.connect()
            c.sql = "delete from order_data where ordno=" & glbl.ono
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.cmd.ExecuteNonQuery()
            c.cmd.Dispose()
            c.sql = "delete from sales where ordno=" & glbl.ono
            'MsgBox(c.sql)

            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.cmd.ExecuteNonQuery()
            c.cmd.Dispose()

            c.sql = "select mobno from register where usrname='" & glbl.uname & "';"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            Dim cmob, smob As String
            While c.dr.Read
                cmob = c.dr("mobno")
            End While
            c.dr.Close()
            c.cmd.Dispose()

            c.sql = "select * from supplier where sname='" & glbl.supn & "';"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            While c.dr.Read
                smob = c.dr("mobno")
            End While
            c.dr.Close()
            c.cmd.Dispose()
            c.disconnect()
            c = Nothing

            Dim sURL As String
            Dim objReader As StreamReader
            sURL = "http://apps.smslane.com/vendorsms/pushsms.aspx?user=aditicomforts&password=" _
            & "233257&msisdn=91" & cmob & "&sid=SMSLane&msg=Hi " & glbl.uname & " your Order No :" & glbl.ono & " has been Cancelled Thank you see you in near future ..GROCART" & "&fl=0"
            Dim sResponse As WebRequest
            sResponse = WebRequest.Create(sURL)
            Try
                Dim objStream As Stream
                objStream = sResponse.GetResponse.GetResponseStream()
                objReader = New StreamReader(objStream)
                Response.Write(objReader.ReadToEnd())
                objReader.Close()
                'Response.Redirect("orderstatus.aspx")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            sURL = "http://apps.smslane.com/vendorsms/pushsms.aspx?user=aditicomforts&password=" _
            & "233257&msisdn=91" & smob & "&sid=SMSLane&msg=Hi " & glbl.supn & " The  Order No :" & glbl.ono & " has been Cancelled For your Information ..GROCART" & "&fl=0"


            sResponse = WebRequest.Create(sURL)
            Try
                Dim objStream As Stream
                objStream = sResponse.GetResponse.GetResponseStream()
                objReader = New StreamReader(objStream)
                Response.Write(objReader.ReadToEnd())
                objReader.Close()
                Response.Redirect("orderstatus.aspx")
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try


            Response.Redirect("orderstatus.aspx")


        End If
    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Response.Redirect("default5.aspx")
    End Sub
End Class
