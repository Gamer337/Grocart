 <%@ Page Title="Home Page" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Default.aspx.vb" Inherits="_Default" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <div style="position: absolute; width: 728px; height: 287px; top: 123px; left: 20px;" 
        id=" ">
       
               <object data="movie/homepageclip2.swf" 
                   style="height: 287px; width: 728px; margin-right: 0px;">
        <embed src="movie/homepageclip2.swf" 
        type="application/x-shockwave-flash">

     
        </embed>

        </object>
    
    </div>
    <div style=" position:absolute; width: 335px; left:752px; top: 119px; height: 129px; background-color: #FFFFFF;">
       &nbsp; &nbsp;&nbsp;  
        <asp:Label ID="Label1" runat="server" Text="Registered Customer " 
            ForeColor="#000099"></asp:Label>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;  
            <asp:Label ID="Label2" runat="server" Text="Supplier" 
            ForeColor="#000099"></asp:Label>
        <br />
 &nbsp; &nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:ImageButton ID="ImageButton1" runat="server" Height="33px" 
            ImageUrl="~/grocartimg/loginimg.jpg" Width="104px" />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
        <asp:ImageButton ID="ImageButton2" runat="server" Height="31px" 
            ImageUrl="~/grocartimg/loginimg.jpg" Width="114px" 
            style="margin-top: 0px" />

 &nbsp; &nbsp;&nbsp;    &nbsp; &nbsp;&nbsp;   &nbsp; 

  <asp:Label ID="Label3" runat="server" Text="New to GrowCart ?" 
            ForeColor="#FF3300"></asp:Label>
             &nbsp; &nbsp;&nbsp;    &nbsp; &nbsp;&nbsp;   &nbsp;  &nbsp; &nbsp;&nbsp; &nbsp;  &nbsp; &nbsp;&nbsp;   
            <asp:Label ID="Label5" runat="server" Text="Seller  ? " 
            ForeColor="#FF3300"></asp:Label>
            <br />
            &nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  
             <a href="account/Register.aspx">
             <asp:Label ID="Label4" runat="server" Text="Registered Here" 
            ForeColor="#000099"></asp:Label></a>
            &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;   &nbsp; &nbsp;&nbsp; &nbsp;&nbsp; &nbsp;&nbsp; 
 
           
            <a href="default4.aspx">
           <asp:Label ID="Label6" runat="server" Text="Registered Here" 
            ForeColor="#000099"></asp:Label></a>
             <br />
    </div>


    <div style=" position:absolute; width: 335px; left:752px; top: 237px; height: 170px; background-color: #FFFFFF;">
       &nbsp; &nbsp;&nbsp;  
        <table>
        <tr>
        <td>   &nbsp;&nbsp;&nbsp;   <asp:Label ID="Label7" runat="server" 
                Text="* Hygienic and Preciously selected Products " ForeColor="#000099"></asp:Label>
            <br />
            <asp:Label ID="Label10" runat="server" Text="."></asp:Label>
        </td>
            
        </tr>
         <tr>
        <td>   &nbsp;&nbsp;&nbsp;   <asp:Label ID="Label8" runat="server" Text="*   Best Pricing all the Times" 
                ForeColor="Maroon"></asp:Label>
            <br />
            <asp:Label ID="Label11" runat="server" Text="."></asp:Label>
        </td>
            
        </tr>
         <tr>
        <td>   &nbsp;&nbsp;&nbsp;   <asp:Label ID="Label9" runat="server" 
                Text=" *   Easy Cash On Dilivary Option" ForeColor="#000066"></asp:Label>
            <br />
            <asp:Label ID="Label12" runat="server" Text="."></asp:Label>
        </td>
            
        </tr>
        </table>
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
    <div style="height: 145px">
      
        <asp:Image ID="Image1" runat="server" Height="168px" Width="152px" />
        <asp:Image ID="Image2" runat="server" Height="168px" Width="152px" />
        <asp:Image ID="Image3" runat="server" Height="168px" Width="152px" />
        <asp:Image ID="Image4" runat="server" Height="168px" Width="152px" />
        <asp:Image ID="Image5" runat="server" Height="168px" Width="152px" />
        <asp:Image ID="Image6" runat="server" Height="168px" Width="152px" />
        <asp:Image ID="Image7" runat="server" Height="168px" Width="152px" />
    </div>
    <br />
    <br />
    <br />
    </asp:Content>
