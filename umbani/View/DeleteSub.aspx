<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="DeleteSub.aspx.cs" Inherits="umbani.View.DeleteSub" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="302px">
        Comments :
        <asp:TextBox ID="TextBox1" runat="server" Height="100px" Width="270px"></asp:TextBox>
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" BackColor="#3399FF" Height="54px" Text="Save" Width="143px" OnClick="Button1_Click" />
    </asp:Panel>
</asp:Content>
