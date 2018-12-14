<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddProduct.aspx.cs" Inherits="umbani.View.AddProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="445px">
    Product Name:&nbsp;
    <asp:TextBox ID="txtName" runat="server" style="margin-left: 49px"></asp:TextBox>
    <br />
    Annual Cost:&nbsp;
    <asp:TextBox ID="txtAnnualCost" runat="server" style="margin-left: 68px"></asp:TextBox>
    <br />
    Monthly Cost:&nbsp;
    <asp:TextBox ID="txtMonthly" runat="server" style="margin-left: 56px"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" BackColor="#3399FF" Height="53px" Text="Save" Width="125px" OnClick="Button1_Click" />
</asp:Panel>
</asp:Content>
