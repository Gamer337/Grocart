<%@ Page Title="" Language="VB" MasterPageFile="~/Site.master" AutoEventWireup="false" CodeFile="Default5.aspx.vb" Inherits="Default5" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="MainContent" Runat="Server">
    <div style="width: 1012px">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
        </asp:ScriptManager>
        <asp:UpdatePanel ID="UpdatePanel1" runat="server">
            <ContentTemplate>
                &nbsp;
                <asp:Label ID="Label1" runat="server" BackColor="#CC99FF" BorderColor="White" 
                    Font-Names="Comic Sans MS" Font-Size="Large" ForeColor="Black" 
                    Text="Product Category"></asp:Label>
                <br />
                <asp:ListBox ID="ListBox1" runat="server" Height="345px" Width="211px" 
                    AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" 
                    BackColor="#9933FF" Font-Names="Comic Sans MS" Font-Size="Medium">
                </asp:ListBox>
                <br />
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
                <br />
                <br />
            </ContentTemplate>
          <Triggers>
            <asp:AsyncPostbackTrigger ControlID="ListBox1" EventName="SelectedIndexChanged" />
             
          </Triggers>
        </asp:UpdatePanel>
    </div>
   <div style="position:absolute; left:356px; top:150px; width: 480px; height: 64px;">
       &nbsp;&nbsp;&nbsp;
       
       <asp:UpdatePanel ID="UpdatePanel2" runat="server">
        <ContentTemplate>
            <asp:Table ID="tab2" runat="server" Width="183px">
            </asp:Table>
        </ContentTemplate>
       </asp:UpdatePanel>
   </div>
    <br />
    <br />
</asp:Content>

