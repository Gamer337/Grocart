<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default8.aspx.vb" Inherits="Default8" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .style1
        {
            width: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div>
    <br />
    <br />
</div>
<div style="background-color: #FFFF66">
    <table>
        
        <tr>
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Image ID="Image1" runat="server" Height="200px" Width="337px" />&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        <td>
            <asp:Label ID="Label2" runat="server" Font-Bold="True" 
                Font-Names="Comic Sans MS" Font-Size="Large"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
            
        <td>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Text="Quantity" Font-Bold="True"></asp:Label>&nbsp;&nbsp;
            <asp:TextBox ID="TextBox2" runat="server" Width="33px"></asp:TextBox>&nbsp;
        </td>
        <td class="style1">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </td>
        </tr>
    </table>
</div>
<br />&nbsp;&nbsp; <asp:Button ID="button2" runat="server" Text="Add to Cart" 
        BackColor="#DAC09E" Font-Bold="True" Font-Names="Comic Sans MS" 
        Font-Size="Medium" ForeColor="Black" ></asp:Button>
    <asp:Button ID="button3" runat="server" Text="Look for More" 
        Width="150px" BackColor="#DAC09E" Font-Bold="True" 
        Font-Names="Comic Sans MS" Font-Size="Medium" ForeColor="Black" ></asp:Button>
    <asp:Button ID="button4" runat="server" Text="Check OUT" Width="100px" 
        BackColor="#DAC09E" Font-Bold="True" Font-Names="Comic Sans MS" 
        Font-Size="Medium" ForeColor="Black" ></asp:Button>
    <br />
    &nbsp;&nbsp;<br />
&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label3" runat="server" 
        Text="Your Cart" Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="Large"></asp:Label>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        CellPadding="2" DataSourceID="SqlDataSource1" ForeColor="Black" 
        GridLines="None" Width="1062px" Height="200px" 
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <Columns>
            <asp:BoundField DataField="slno" HeaderText="Serial no." 
                SortExpression="slno" />
            <asp:BoundField DataField="pid" HeaderText="Product id" SortExpression="pid" />
            <asp:BoundField DataField="brand" HeaderText="Brand" SortExpression="brand" />
            <asp:BoundField DataField="pname" HeaderText="Product" SortExpression="pname" />
            <asp:BoundField DataField="qty" HeaderText="Qty" SortExpression="qty" />
            <asp:BoundField DataField="weight" HeaderText="Weight" 
                SortExpression="weight" />
            <asp:BoundField DataField="unit" HeaderText="Unit" SortExpression="unit" />
            <asp:BoundField DataField="mrp" HeaderText="Price" SortExpression="mrp" />
            <asp:BoundField DataField="taxp" HeaderText="Tax%" SortExpression="taxp" />
            <asp:BoundField DataField="sname" HeaderText="Supplied by" 
                SortExpression="sname" />
            <asp:BoundField DataField="netamt" HeaderText="Net Amount" 
                SortExpression="netamt" />
        </Columns>
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
            HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:vgdbConnectionString %>" 
        SelectCommand="SELECT [slno], [pid], [brand], [pname], [qty], [unit], [weight], [mrp], [taxp], [sname], [netamt] FROM [order_tmp]">
    </asp:SqlDataSource>
&nbsp;&nbsp;&nbsp;
    <p>
<br />
    </p>
</asp:Content>

