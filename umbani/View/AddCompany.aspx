<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddCompany.aspx.cs" Inherits="umbani.View.AddCompany" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="533px">
    Company Name:&nbsp;
    <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    <br />
    Contact Name:&nbsp;
    <asp:DropDownList ID="ddlContact" runat="server" Height="16px" Width="176px" OnSelectedIndexChanged="ddlContact_SelectedIndexChanged" AutoPostBack="True">
    </asp:DropDownList>
    <br />
    Contact Phone:&nbsp;
    <asp:TextBox ID="txtContactPhone" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    Contact Email :&nbsp;
    <asp:TextBox ID="txtContactEMail" runat="server" ReadOnly="True"></asp:TextBox>
    <br />
    <asp:Button ID="Button1" runat="server" BackColor="#3399FF" Height="53px" OnClick="Button1_Click" style="margin-left: 133px" Text="Save" Width="99px" />
    <br />
</asp:Panel>
</asp:Content>
