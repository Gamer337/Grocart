Imports System.Data.OleDb
Imports System.IO
Partial Class _Default
    Inherits System.Web.UI.Page
    Dim BYTES1() As Byte
    Dim STRFN As String
    'Dim rand As Random
    'Dim x As Int16
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'hide menu
        Dim nmx As Menu
        nmx = CType(Master.FindControl("NavigationMenu"), Menu)
        nmx.Visible = False
        'end hide
     

        Dim c As Class1
        c = New Class1
        
        If Not IsPostBack Then
            glbl.c_id = 0
            glbl.sid = 0
            c.sql = "select pimg from pimages;"
            c.connect()
            c.cmd = New OleDbCommand(c.sql, c.cn)
            c.dr = c.cmd.ExecuteReader
            c.dr.Read()
            Dim n As Integer
            n = 1
            While (c.dr.Read)
                ' rand = New Random()
                'x = rand.Next(1, 4)

                BYTES1 = c.dr(0)
                STRFN = "F:\ddd\" & n & ".jpg"              'Convert.ToString(DateTime.Now.ToFileTime())
                Dim fs As FileStream
                fs = New FileStream(STRFN, FileMode.Create, FileAccess.Write)
                fs.Write(BYTES1, 0, BYTES1.Length)
                fs.Flush()
                fs.Close()
                n = n + 1
                'c.dr.Read()
                ' Image1.ImageUrl = STRFN
                ' Image2.ImageUrl = STRFN
            End While
            c.dr.Close()
            c.cmd.Dispose()
            c.disconnect()
            'For n = 1 To 7


            Image1.ImageUrl = "C:\Users\Vijay\Desktop\mygrossory\product image\1.jpg"
            Image2.ImageUrl = "C:\Users\Vijay\Desktop\mygrossory\product image\2.jpg"
            Image3.ImageUrl = "C:\Users\Vijay\Desktop\mygrossory\product image\3.jpg"
            Image4.ImageUrl = "C:\Users\Vijay\Desktop\mygrossory\product image\4.jpg"
            Image5.ImageUrl = "C:\Users\Vijay\Desktop\mygrossory\product image\5.jpg"
            Image6.ImageUrl = "C:\Users\Vijay\Desktop\mygrossory\product image\6.jpg"
            Image7.ImageUrl = "C:\Users\Vijay\Desktop\mygrossory\product image\7.jpg"



            'Next
        End If

    End Sub

   
    Protected Sub ImageButton1_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        Response.Redirect("~/Account/Login.aspx")
    End Sub

    Protected Sub ImageButton2_Click(ByVal sender As Object, ByVal e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        Response.Redirect("~/Default7.aspx")
    End Sub

   
End Class
