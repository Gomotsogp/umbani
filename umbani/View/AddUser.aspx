<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddUser.aspx.cs" Inherits="umbani.View.AddUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="538px">
    <asp:Label ID="Label1" runat="server" Text="Full Name :"></asp:Label>
    &nbsp;&nbsp;
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    Email :&nbsp;&nbsp;
    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
    <br />
        Login Name :&nbsp;&nbsp;
    <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
    <br />
    Password :&nbsp;&nbsp;
    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
    <br />
    Confirm Password :&nbsp;&nbsp;
    <asp:TextBox ID="txtConfirmPas" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnSave" runat="server" BackColor="#3399FF" Height="56px" Text="Save" Width="144px" OnClick="btnSave_Click"  />
</asp:Panel>
</asp:Content>
