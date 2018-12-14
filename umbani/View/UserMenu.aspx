<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UserMenu.aspx.cs" Inherits="umbani.View.UserMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:Panel ID="Panel1" runat="server" Height="574px">
        <asp:Panel ID="Panel2" runat="server" BackColor="#3399ff" style="text-align:center">
            Meun<br /> </asp:Panel>
        <asp:Button ID="Button1" runat="server" Text="Add" BackColor="#3399ff" Width="221px" OnClick="Button1_Click"  /><asp:TextBox ID="TextBox1" runat="server" placeholder="Search and filter by company" style="margin-left: 103px" Width="486px"></asp:TextBox>
        <br />
        <br /> 
        <asp:GridView ID="GridView1" runat="server" Height="435px" Width="1455px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoFormat="Professional" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="fullName" HeaderText="fullName" SortExpression="fullName" />
                <asp:BoundField DataField="email" HeaderText="email" SortExpression="email" />
                <asp:BoundField DataField="username" HeaderText="username" SortExpression="username" />
                <asp:CommandField ShowEditButton="true" />
                <asp:CommandField ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
         <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:umbani %>" SelectCommand="SELECT [id], [fullName], [email], [username] FROM [User]"></asp:SqlDataSource>
    </asp:Panel>
</asp:Content>
