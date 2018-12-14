<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Rates.aspx.cs" Inherits="WebFormsIdentity.View.Rates" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="474px">
    Year :&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <br />
    <br />
    Rate Type :&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp; Rate :&nbsp;&nbsp;
    <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    <br />
    <br />
    Rate Type :<asp:TextBox ID="TextBox5" runat="server" style="margin-left: 22px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp; Rate :
    <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 23px" Width="176px"></asp:TextBox>
    <br />
    <br />
    Rate Type :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox6" runat="server" Height="27px" OnTextChanged="TextBox6_TextChanged" style="margin-left: 0px" Width="145px"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp; Rate :&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="Button1" runat="server" BackColor="#3399FF" Height="58px" style="margin-left: 214px" Text="Save" Width="171px" OnClick="Button1_Click" />
</asp:Panel>
</asp:Content>
