<%@ Page Language="C#" AutoEventWireup="true"  MasterPageFile="~/MasterPage.Master" CodeBehind="RenewSub.aspx.cs" Inherits="WebFormsIdentity.Home" %>

<asp:Content ID="C1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <asp:Panel ID="Panel1" runat="server" Height="659px">
        Quote Sent
        <asp:CheckBox ID="CheckBox1" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp; Order Received
        <asp:CheckBox ID="CheckBox2" runat="server" />
        <br />
        <br />
        <br />
        Invoice Sent
        <asp:CheckBox ID="CheckBox3" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp; New Key
        <asp:CheckBox ID="CheckBox4" runat="server" />
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" BackColor="#3399FF" Height="60px" style="margin-left: 189px" Text="Save" Width="214px" />
    </asp:Panel>
    
</asp:Content>
 