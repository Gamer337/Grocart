Imports System.Data.OleDb
Imports System
Imports System.IO
Imports System.Net
Imports System.Text
Partial Class ordersummary
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim c As Class1
        c = New Class1
        c.sql = "delete from sales_tmp;"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.sql = "insert sales_tmp select * from sales where sid=" & glbl.sid & " and ordno=" & Val(DropDownList1.SelectedItem.Value)
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        GridView1.DataBind()
        c.disconnect()


    End Sub

    Protected Sub Button2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As Class1
        c = New Class1
        c.sql = "update sales set status='" & Trim(DropDownList2.SelectedItem.Value) & "' where sid=" & glbl.sid & " and ordno=" & Val(DropDownList1.SelectedItem.Value)
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()

        c.sql = "delete from sales_tmp;"
        c.connect()
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        c.sql = "insert sales_tmp select * from sales where sid=" & glbl.sid & " and ordno=" & Val(DropDownList1.SelectedItem.Value)
        c.cmd = New OleDbCommand(c.sql, c.cn)
        c.cmd.ExecuteNonQuery()
        c.cmd.Dispose()
        GridView1.DataBind()

        If Trim(DropDownList2.Text) = "out for delivery" Then
            c.sql = "select * from order_data where orderno=(select distinct(ordno) from sales_tmp);"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            Dim un As String
            While c.dr.Read
                un = c.dr("usrname")
            End While
            c.dr.Close()
            c.cmd.Dispose()
            c.sql = "select mobno from register where usrname='" & un & "';"
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            Dim cmob As String
            While c.dr.Read
                cmob = c.dr("mobno")
            End While
            c.dr.Close()
            c.cmd.Dispose()
            Dim sURL As String
            Dim objReader As StreamReader
            sURL = "http://apps.smslane.com/vendorsms/pushsms.aspx?user=aditicomforts&password=" _
            & "233257&msisdn=91" & cmob & "&sid=SMSLane&msg=Hi " & un & " your Order No :" & DropDownList1.Text & " is OUT for delivery Pls. Keep exact change for the order amount..GROCART" & "&fl=0"

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



        End If
        c.disconnect()
    End Sub

    Protected Sub Button3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button3.Click
        Response.Redirect("sreports.aspx")

    End Sub

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'hide menu
        Dim nmx As Menu
        nmx = CType(Master.FindControl("NavigationMenu"), Menu)
        nmx.Visible = False
        'end hide
    End Sub

    Protected Sub Button4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Button4.Click
        Response.Redirect("supplieroption.aspx")
    End Sub
End Class
