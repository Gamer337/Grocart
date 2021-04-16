<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default2.aspx.vb" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
    <style type="text/css">
        .product
        {
            width: 442px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <h1>
    Use the below form to Register the product&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;    <asp:Button ID="Button6" 
                 runat="server" Text="Back" BackColor="#1C5E55" Font-Bold="True" 
                 Font-Names="Comic Sans MS" Font-Size="Medium" ForeColor="White" 
            Width="84px" />
</h1>
    <div style="position: absolute; left: 507px; top: 207px; width: 462px; height: 285px;">
        <fieldset><legend>Product Image(do not use space in filename)</legend><br />
        <asp:FileUpload ID="FileUpload1" runat="server" CssClass="textEntry" 
                Height="30px" BackColor="White" /><br />
        <asp:Image ID="Image1" runat="server" Height="108px" Width="211px" 
                ImageUrl="~/images/Untitled.jpg" /><br />
        <asp:Button ID="Button1" runat="server" Text="Upload Image" BackColor="#1C5E55" 
                Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="Medium" 
                ForeColor="White" /><br />
        </fieldset>
    </div>
<div class="product">
    <fieldset>
        <legend>Product Details</legend>
         <p>
             <asp:Label ID="Label1" runat="server" Text="Product Id" Width="100px" 
                 Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox1" runat="server" CssClass="textEntry" Visible="False" 
                 Height="28px" Width="130px"></asp:TextBox>
         </p>
         <p>
             <asp:Label ID="Label2" runat="server" Text="Product Brand" Width="100px" Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox2" runat="server" CssClass="textEntry" Height="28px" 
                 Width="130px"></asp:TextBox>
             <asp:Label ID="L1" runat="server" Text="* Field Required"  ForeColor="Red" 
                 Visible="False" Height="28px"></asp:Label>
         </p>
         <p>
             <asp:Label ID="Label3" runat="server" Text="Product Group" Width="100px" Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox3" runat="server" CssClass="textEntry" Height="28px" 
                 Width="130px"></asp:TextBox>
              <asp:Label ID="L2" runat="server" Text="* Field Required"  ForeColor="Red" 
                 Visible="False" Height="28px"></asp:Label>
         </p>
         <p>
             <asp:Label ID="Label4" runat="server" Text="Product Name" Width="100px" Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox4" runat="server" CssClass="textEntry" Height="28px" 
                 Width="130px"></asp:TextBox>
              <asp:Label ID="L3" runat="server" Text="* Field Required"  ForeColor="Red" 
                 Visible="False" Height="28px"></asp:Label>
         </p>
         <p>
             <asp:Label ID="Label5" runat="server" Text="Max. Retail Price" Width="100px" Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox5" runat="server" CssClass="textEntry" Height="28px" 
                 Width="130px"></asp:TextBox>
              <asp:Label ID="L4" runat="server" Text="* Field Required"  ForeColor="Red" 
                 Visible="False" Height="28px"></asp:Label>
         </p>
         <p>
             <asp:Label ID="Label6" runat="server" Text="Product Offer" Width="100px" Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox6" runat="server" CssClass="textEntry" Height="28px" 
                 Width="130px"></asp:TextBox>
              <asp:Label ID="L5" runat="server" Text="* Field Required"  ForeColor="Red" 
                 Visible="False" Height="28px"></asp:Label>
         </p>
         
         <p>
             <asp:Label ID="Label7" runat="server" Text="Tax" Width="100px" Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox7" runat="server" CssClass="textEntry" Height="28px" 
                 Width="130px"></asp:TextBox>
              <asp:Label ID="L6" runat="server" Text="* Field Required"  ForeColor="Red" 
                 Visible="False" Height="28px"></asp:Label>
         </p>
          <p>
             <asp:Label ID="Label8" runat="server" Text="Unit " Width="100px" Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox9" runat="server" CssClass="textEntry" Height="28px" 
                 Width="130px"></asp:TextBox>
              <asp:Label ID="L7" runat="server" Text="* Field Required"  ForeColor="Red" 
                 Visible="False" Height="28px"></asp:Label>
         </p>
         <p>
             <asp:Label ID="Label9" runat="server" Text="weight" Width="100px" Height="30px"></asp:Label>
             <asp:TextBox ID="TextBox10" runat="server" CssClass="textEntry" Height="28px" 
                 Width="130px"></asp:TextBox>
              <asp:Label ID="L8" runat="server" Text="* Field Required"  ForeColor="Red" 
                 Visible="False" Height="28px"></asp:Label>
         </p>
         <p>
             <asp:Button ID="Button2" runat="server" Text="Register" CssClass="submitButton" 
                 BackColor="#1C5E55" Font-Bold="True" Font-Names="Comic Sans MS" 
                 Font-Size="Medium" ForeColor="White" />    <asp:Button ID="Button3" 
                 runat="server" Text="Return" BackColor="#1C5E55" Font-Bold="True" 
                 Font-Names="Comic Sans MS" Font-Size="Medium" ForeColor="White" />
             <asp:Button ID="Button4" runat="server" Text="Reset" BackColor="#1C5E55" 
                 Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="Medium" 
                 ForeColor="White" Width="185px" />
         </p>
    </fieldset>
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
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
<br />
<br /><br />

<div>
    <asp:ScriptManager ID="ScriptManager1" runat="server">
    </asp:ScriptManager>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource3" Height="198px" Width="602px" 
        BackColor="#1C5E55" CellPadding="4" ForeColor="#333333" GridLines="None">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="pid" HeaderText="Product Id" SortExpression="pid" />
            <asp:BoundField DataField="s_id" HeaderText="Supplier Id" 
                SortExpression="s_id" />
            <asp:BoundField DataField="sname" HeaderText="Supplier Name" 
                SortExpression="sname" />
            <asp:BoundField DataField="pgroup" HeaderText="Product Group" 
                SortExpression="pgroup" />
            <asp:BoundField DataField="pname" HeaderText="Product Name" 
                SortExpression="pname" />
            <asp:BoundField DataField="mrp" HeaderText="Rate" SortExpression="mrp" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource2" runat="server" 
        ConnectionString="<%$ ConnectionStrings:vgdbConnectionString %>" 
        SelectCommand="SELECT DISTINCT [pid], [s_id], [sname], [pgroup], [pname], [mrp] FROM [products] ORDER BY [pid] DESC, [s_id] DESC">
    </asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:vgdbConnectionString %>" 
        SelectCommand="SELECT DISTINCT [s_id], [pid], [pname], [sname], [pgroup], [mrp] FROM [products] ORDER BY [pid] DESC">
    </asp:SqlDataSource>
</div><br />
<p>
<h2>
Use this to delete the Registered Product
</h2>
</p>
<div>
    &nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label10" runat="server" Text="Enter the product id to delete: "></asp:Label>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox8" runat="server" Width="81px"></asp:TextBox>&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button5" runat="server" Text="Delete" BackColor="#1C5E55" 
        Font-Bold="True" Font-Names="Comic Sans MS" Font-Size="Medium" 
        ForeColor="White" />
</div>
    <br />
    <br />
    <br />
    <br />
    
</asp:Content>

