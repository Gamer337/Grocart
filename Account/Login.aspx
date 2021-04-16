<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Login.aspx.vb" Inherits="Account_Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    
    
    
   <div class="login" style="right: 40%; width: 314px; top:200px; height: 171px;">
       <br />
       <br />

       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;

       
       <asp:Label ID="Label4" runat="server" Text=" LOGIN HERE " 
           Font-Names="Comic Sans MS" Font-Size="X-Large"></asp:Label>
       <br />

       <br />

       
       <table style="width: 100%;">
           <tr>
               <td>
                   &nbsp;<asp:Label ID="Label1" runat="server" Text="Username" Font-Bold="True" 
                       Font-Names="Comic Sans MS" Font-Size="Large"></asp:Label>
               </td>
               <td>
                   &nbsp; <asp:TextBox ID="TextBox1" runat="server" CssClass="textEntry" Width="170px" 
                Height="33px"></asp:TextBox>
               </td>
               
           </tr>
           <tr>
               <td>
                   &nbsp;<asp:Label ID="Label2" runat="server" Text="Password" Font-Bold="True" 
                       Font-Names="Comic Sans MS" Font-Size="Large"></asp:Label>
               </td>
               <td>
                   &nbsp; <asp:TextBox ID="TextBox2" runat="server" CssClass="passwordEntry" 
                 TextMode="Password" Width="170px" Height="33px"></asp:TextBox>
               </td>
              
           </tr>
           <tr>
               <td>
                   <br />
&nbsp;
                   &nbsp;<asp:Button ID="Button1" runat="server" Text="Log In" Width="95px" 
                Height="31px" BackColor="White" Font-Bold="True" Font-Names="Comic Sans MS" 
                       Font-Size="Large" />  
               &nbsp;&nbsp;&nbsp;  
               </td> 
               <td>
                   &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Button ID="Button2" runat="server" 
                       Text="Cancel" Width="95px" 
                Height="31px" BackColor="White" Font-Bold="True" Font-Names="Comic Sans MS" 
                       Font-Size="Large" />
                   &nbsp;</td>
           </tr>

           
            
           
       </table>
       
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       
           <a href="~/resetpass.aspx">
            <asp:Label ID="Label3" runat="server" Text="Forgot Password ?"></asp:Label>
            </a>       
    
           
       </div>
        <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
       <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
       <br />
           
   <div style="position: absolute; left: 394px; top: 166px; width: 394px; height: 251px;">     
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                <asp:ScriptManager ID="ScriptManager1" runat="server"> </asp:ScriptManager>
                <asp:Image ID="Image1" runat="server" ImageUrl="~/grocartimg/download (1).jpg" 
                    Width="314px" />
                <asp:Timer ID="Timer1" runat="server" Interval="3000"></asp:Timer>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
</asp:Content>

