<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default7.aspx.vb" Inherits="Default7" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
 
<div style="height: 541px; top: 200px; width: 1115px;" >
    &nbsp;<fieldset>
        <legend>Supplier Login</legend>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Username" Width="100px"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server" CssClass="textEntry" Height="25px" 
                Width="130px"></asp:TextBox>
                <asp:Label ID="L1" runat="server" Text="* Field Required"  ForeColor="Red" Visible="False"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Password" Width="100px"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server" CssClass="passwordEntry" 
                TextMode="Password" Height="25px" Width="130px"></asp:TextBox> 
                <asp:Label ID="L2" runat="server" Text="* Field Required"  ForeColor="Red" Visible="False"></asp:Label>       
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Login" style="height: 26px" />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </p>
    </fieldset>
    </div>
<br />
<br />
<br />

</asp:Content>

