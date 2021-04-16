<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="pedit.aspx.vb" Inherits="Account_pedit" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style2
        {
            width: 847px;
        }
        .style3
        {
            width: 731px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">

<div>
    <table style="width: 34%; position: absolute; top: 194px; left: 97px; right: 530px;" 
        frame="border" title="update your profile">
        <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label1" runat="server" Text=" Name" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>&nbsp;&nbsp;
            </td>
           
        </tr>
       <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label2" runat="server" Text=" Address" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>&nbsp;</td>
           
        </tr>
        <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label3" runat="server" Text="City" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>&nbsp;</td>
           </tr>
         <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label4" runat="server" Text="Landmark" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>&nbsp;
            </td>
           
        </tr>
        <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label5" runat="server" Text="City Pin" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>&nbsp;
            </td>
           
        </tr>
        <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label6" runat="server" Text="Mobile No." Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>&nbsp; </td>
           
        </tr>
        <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label7" runat="server" Text="Email id" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>&nbsp;
            </td>
           
        </tr>
        <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label8" runat="server" Text="Old Password" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox8" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
           
        </tr>
         <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label9" runat="server" Text="New Password" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox9" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
            </td>
           
        </tr>
        <tr>
            <td class="style2" style="background-color: #FFFFFF">
                <asp:Label ID="Label10" runat="server" Text="Conform Password" Font-Bold="True" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black"></asp:Label> &nbsp;
            </td>
            
            <td class="style3">
                &nbsp;&nbsp;&nbsp;
                <asp:TextBox ID="TextBox10" runat="server" TextMode="Password"></asp:TextBox>&nbsp;
            </td>
           
        </tr>
        <tr>
            
            <td class="style2" style="background-color: #FFFFFF">
                &nbsp;&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;<asp:Button ID="Button1" runat="server" Text="Update Profile" BackColor="White" 
                    Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="Large" Height="33px" 
                    Width="164px" />&nbsp;
            </td>
            <td class="style3">
               &nbsp;&nbsp;
                <br />
&nbsp;&nbsp;
               <asp:Button ID="Button2" runat="server" Text="Clear" BackColor="White" 
                    Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="Large" Height="33px" 
                    Width="118px" />&nbsp;
            </td>
            
        </tr>
    </table>
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="X-Large" 
        Text="Update Your profile  "></asp:Label>
    <br />
&nbsp;&nbsp;&nbsp;
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
    </div>


</asp:Content>
