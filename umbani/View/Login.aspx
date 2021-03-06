﻿<%@ Page Language="C#" AutoEventWireup="true"   CodeBehind="Login.aspx.cs" Inherits="umbani.View.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="font-family: Arial,Helvetica,sans-serif;font-size:small">
    <form id="form1" runat="server">
        <div>
            <h4 style="font-size: medium">LOGIN</h4>
         <hr />
         <asp:PlaceHolder runat="server" ID="LoginStatus" Visible="false">
            <p>
               <asp:Literal runat="server" ID="StatusText" />
            </p>
         </asp:PlaceHolder>
            <div style="margin-bottom: 10px">
               <asp:Label runat="server" AssociatedControlID="txtUserName">User name</asp:Label>
               <div>
                  <asp:TextBox runat="server" ID="txtUserName" />
               </div>
            </div>
            <div style="margin-bottom: 10px">
               <asp:Label runat="server" AssociatedControlID="txtPassword">Password</asp:Label>
               <div>
                  <asp:TextBox runat="server" ID="txtPassword" TextMode="Password" Height="25px" Width="168px" />
               </div>
            </div>
            <div style="margin-bottom: 10px">
               <div>
                  <asp:Button runat="server" OnClick="SignIn" Text="Log in" BackColor="#3399FF" />
               </div>
            </div>
            <div>
               <div>
                  <asp:Button runat="server" OnClick="SignOut" Text="Log out"  BackColor="#3399FF" />
               </div>
            </div>

        </div>

        <asp:Panel ID="Panel1" runat="server" BackColor="#3399FF" style="text-align:center; margin-top: 1px;">
            Developed by Umbani Software cc</asp:Panel>

    </form>
</body>
</html>
