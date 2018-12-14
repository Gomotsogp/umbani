<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LogOutScreen.aspx.cs" Inherits="umbani.View.LogOutScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Panel ID="Panel1" runat="server" Height="1123px" Width="1368px">
           <b> <asp:Image ID="Image1" runat="server" ImageUrl="~/image/Logo_White_Wide-01.png" Width="100%" /></b>
            <asp:Label ID="Label1" runat="server" Text="Logged out" Height="38px" style="margin-left: 674px" Width="85%"></asp:Label>
        &nbsp;<br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Panel ID="Panel2" runat="server" BackColor="#3399FF" Height="45px" Width="1359px" style="text-align:center">
                <asp:Label runat="server" Text="Developed by Umbani Software cc" /> </asp:Panel>
        </asp:Panel>
    </form>
</body>
</html>
