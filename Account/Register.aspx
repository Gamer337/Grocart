<%@ Page Title="Register" Language="VB" MasterPageFile="~/Site.Master" AutoEventWireup="false"
    CodeFile="Register.aspx.vb" Inherits="Account_Register" %>

<asp:Content ID="HeaderContent" runat="server" ContentPlaceHolderID="HeadContent">
    <style type="text/css">
        .textEntry
        {}
    </style>
</asp:Content>
<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    
                    <h2>
                        Create a New Account
                    </h2>
                   <br />

                        Passwords are required to be a minimum of <%= Membership.MinRequiredPasswordLength %> characters in length.
                    </p>
                      <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />
                         <br />   <br />   <br />   <br />
                       <br />   <br />   <br />   <br />   <br />   <br />   <br />   <br />
                          <br />   <br />   <br />   
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />
                    <br />   <br />
                    <div style="position: absolute; left: 25%; top: 190px; height: 1036px; width: 611px;">
                        <fieldset class="register">
                        <legends>Account infomation</legends>
                         
                                <br />
                         
                                <asp:Label ID="Label6" runat="server" ForeColor="#000099">Mobile No:</asp:Label><br />
                                <asp:TextBox ID="TextBox6" runat="server" CssClass="textEntry" Height="25px" 
                                     Width="180px" BackColor="#FFFF99" BorderColor="Maroon"></asp:TextBox>
                                 <asp:Label ID="L9" runat="server" Text="* Field Required" 
                                     ForeColor="Red" Visible="False"></asp:Label> 
                                                      
                                <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName" 
                                     ForeColor="#000066">User Name:</asp:Label>
                                <asp:TextBox ID="UserName" runat="server" CssClass="textEntry" Width="180px" 
                                     Height="25px" BackColor="#FFFF99" BorderColor="Maroon"></asp:TextBox><asp:Label
                                    ID="L5" runat="server" Text="* Field Required"  ForeColor="Red" 
                                    Visible="False"></asp:Label>
                                
                           
                        
                                <asp:Label ID="EmailLabel" runat="server" AssociatedControlID="Email" 
                                    ForeColor="#000066">E-mail:</asp:Label>
                                <asp:TextBox ID="Email" runat="server" CssClass="textEntry" Width="180px" 
                                    Height="25px" BackColor="#FFFF99" BorderColor="Maroon"></asp:TextBox><asp:Label
                                    ID="L6" runat="server" Text="* Field Required"  ForeColor="Red" 
                                    Visible="False"></asp:Label>
                          
                          
                                <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password" 
                                    ForeColor="#000066">Password:</asp:Label>
                                <asp:TextBox ID="Password" runat="server" CssClass="passwordEntry" 
                                    TextMode="Password" Width="180px" Height="25px" BackColor="#FFFF99" 
                                    BorderColor="Maroon"></asp:TextBox><asp:Label
                                    ID="L7" runat="server" Text="* Field Required" ForeColor="Red" 
                                    Visible="False"></asp:Label>
                           
                                <asp:Label ID="ConfirmPasswordLabel" runat="server" 
                                    AssociatedControlID="ConfirmPassword" ForeColor="#000066">Confirm Password:</asp:Label>
                                <asp:TextBox ID="ConfirmPassword" runat="server" CssClass="passwordEntry" 
                                    TextMode="Password" Width="180px" Height="25px" BackColor="#FFFF99" 
                                    BorderColor="Maroon"></asp:TextBox><asp:Label
                                    ID="L8" runat="server" Text="* Field Required" ForeColor="Red" 
                                    Visible="False"></asp:Label></br>

                               
                           
                            <asp:Label ID="Label5" runat="server" Visible="False" ForeColor="#000066">Customer ID:</asp:Label>
                                <br />
                                <asp:TextBox ID="TextBox5" runat="server" Visible="False" Height="32px" 
                                style="margin-left: 13px" Width="180px" BackColor="#FFFF99" 
                                BorderColor="Maroon" ></asp:TextBox>
                           </br>

                                <asp:Label ID="Label1" runat="server" ForeColor="#000066">Name:</asp:Label><br />
                                <asp:TextBox ID="TextBox1" runat="server" CssClass="textEntry" Width="180px" 
                                     Height="25px" BackColor="#FFFF99" BorderColor="Maroon"></asp:TextBox><asp:Label
                                    ID="L1" runat="server" Text="* Field Required"  ForeColor="Red" 
                                     Visible="False"></asp:Label>
                                
                           </br>

                                 <asp:Label ID="Label2" runat="server" ForeColor="#000066">Address:</asp:Label><br />
                                <asp:TextBox ID="TextBox2" runat="server" CssClass="textEntry" Height="30px" 
                                     Width="180px" TextMode="MultiLine" BackColor="#FFFF99" 
                                     BorderColor="Maroon"></asp:TextBox>
                                 <asp:Label
                                    ID="L2" runat="server" Text="* Field Required" 
                                     ForeColor="Red" Visible="False"></asp:Label>
                           </br>

                                <asp:Label ID="Label3" runat="server" ForeColor="#000066">City:</asp:Label><br />
                                <asp:TextBox ID="TextBox3" runat="server" CssClass="textEntry" Height="25px" 
                                     Width="180px" BackColor="#FFFF99" BorderColor="Maroon"></asp:TextBox>
                                 <asp:Label
                                    ID="L3" runat="server" Text="* Field Required" 
                                     ForeColor="Red" Visible="False"></asp:Label>
                              
                           </br>
                                <asp:Label ID="Label4" runat="server" ForeColor="#000066">Landmark:</asp:Label><br />
                                <asp:TextBox ID="TextBox4" runat="server" CssClass="textEntry" Height="25px" 
                                     Width="180px" BackColor="#FFFF99" BorderColor="Maroon"></asp:TextBox><asp:Label
                                    ID="L4" runat="server" Text="* Field Required"  ForeColor="Red" 
                                     Visible="False"></asp:Label>
                               
                            </br>
                                <asp:Label ID="Label7" runat="server" ForeColor="#000066">City Pin:</asp:Label><br />
                                <asp:TextBox ID="TextBox7" runat="server" CssClass="textEntry" Width="180px" 
                                    Height="25px" BackColor="#FFFF99" BorderColor="Maroon"></asp:TextBox>
                                 <asp:Label ID="L10" runat="server" Text="* Field Required" 
                                     ForeColor="Red" Visible="False"></asp:Label> 
                                                      
                         
                            <br />
                            <br />
                            <br />
                            <br />
                                                      
                         
                            <asp:Button ID="Button2" runat="server" Text="Create User" Height="41px" 
                                Width="100px" />
                                                      
                         
                            <asp:Button ID="Button3" runat="server" Text="Cancel" Height="41px" 
                                Width="100px" />
                                                      
                         
                            <br />
                                                      
                         
                        </fieldset>
                        </div>        
                   
</asp:Content>