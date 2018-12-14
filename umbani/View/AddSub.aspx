<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="AddSub.aspx.cs" Inherits="umbani.View.AddSub" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="445px" Width="1313px">
        Company :<asp:DropDownList ID="ddlCompany" runat="server" Height="59px" style="margin-left: 115px" Width="349px" DataSourceID="SqlDataSource1" DataTextField="name" DataValueField="id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:umbani %>" SelectCommand="SELECT [id], [name] FROM [Company]"></asp:SqlDataSource>
        <br />
        Contact :
        <asp:DropDownList ID="ddlContact" runat="server" Height="59px" style="margin-left: 126px" Width="348px" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:umbani %>" SelectCommand="SELECT [name], [id] FROM [Contact]"></asp:SqlDataSource>
        <br />
        product :
        <asp:DropDownList ID="ddlProduct" runat="server" Height="34px" style="margin-left: 125px" Width="348px" DataSourceID="SqlDataSource3" DataTextField="name" DataValueField="id">
        </asp:DropDownList>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:umbani %>" SelectCommand="SELECT [id], [name] FROM [Product]"></asp:SqlDataSource>
        <br />
        Number of Users:
        <asp:TextBox ID="txtUsers" runat="server" Height="26px" style="margin-left: 44px" Width="350px"></asp:TextBox>
        <br />
        Subscription start :<asp:Calendar ID="Calendar1" runat="server" Height="164px" Width="303px"></asp:Calendar>
        <br />
        Annual :
        <asp:CheckBox ID="chkAnnual" runat="server" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Monthly:
        <asp:CheckBox ID="chkMonthly" runat="server" />
        <br />
        Cost : <asp:TextBox ID="txtCost" runat="server" Height="28px" style="margin-left: 150px" Width="350px"></asp:TextBox>
        <br />
        Sales Rep :
        <asp:DropDownList ID="ddlSalesRep" runat="server" Height="26px" style="margin-left: 118px" Width="342px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnSave" runat="server" BackColor="#3399FF" Height="50px" style="margin-left: 126px" Text="Save" Width="144px" OnClick="Button1_Click" />
    </asp:Panel>
    <p>
        <br />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
