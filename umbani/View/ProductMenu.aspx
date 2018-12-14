<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="ProductMenu.aspx.cs" Inherits="umbani.View.ProductMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="574px">
        <asp:Panel ID="Panel2" runat="server" BackColor="#3399ff" style="text-align:center">
            Meun<br /> </asp:Panel>
        <asp:Button ID="Button1" runat="server" Text="Add" BackColor="#3399ff" Width="221px"  /><asp:TextBox ID="TextBox1" runat="server" placeholder="Search and filter by company" style="margin-left: 103px" Width="486px"></asp:TextBox>
        <br />
        <br /> 
        <asp:GridView ID="GridView1" runat="server" Height="435px" Width="1455px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoFormat="Professional" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" OnRowDeleting="GridView1_RowDeleting" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
                <asp:BoundField DataField="name" HeaderText="name" SortExpression="name" />
                <asp:BoundField DataField="annualCost" HeaderText="annualCost" SortExpression="annualCost" />
                <asp:BoundField DataField="monthlyCost" HeaderText="monthlyCost" SortExpression="monthlyCost" />
                <asp:CommandField ShowEditButton="true" />
                <asp:CommandField ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:umbani %>" SelectCommand="SELECT [id], [name], [annualCost], [monthlyCost] FROM [Product]"></asp:SqlDataSource>
    </asp:Panel>
</asp:Content>
