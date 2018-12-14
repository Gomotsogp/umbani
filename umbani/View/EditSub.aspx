<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="EditSub.aspx.cs" Inherits="umbani.View.Edit" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="339px">
        Editable fields:
        <asp:TextBox ID="TextBox1" runat="server" Width="364px"></asp:TextBox>
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox2" runat="server" style="margin-left: 8px" Width="361px"></asp:TextBox>
        <br />
        <br />
        <br />
        &nbsp;<asp:Button ID="Button1" runat="server" BackColor="#3399FF" Height="64px" style="margin-left: 186px" Text="Save" Width="160px" OnClick="Button1_Click" />
    </asp:Panel>
</asp:Content>
