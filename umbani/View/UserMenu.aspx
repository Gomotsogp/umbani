<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserMenu.aspx.cs" Inherits="umbani.View.UserMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel ID="Panel1" runat="server" Height="574px">
        <asp:Panel ID="Panel2" runat="server" BackColor="#3399ff" style="text-align:center">
            Meun<br /> </asp:Panel>
        <asp:Button ID="Button1" runat="server" Text="Add" BackColor="#3399ff" Width="221px"  /><asp:TextBox ID="TextBox1" runat="server" placeholder="Search and filter by company" style="margin-left: 103px" Width="486px"></asp:TextBox>
        <br />
        <br /> 
        <asp:GridView ID="GridView1" runat="server" Height="435px" Width="1455px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoFormat="Professional">
        </asp:GridView>
    </asp:Panel>
</asp:Content>
