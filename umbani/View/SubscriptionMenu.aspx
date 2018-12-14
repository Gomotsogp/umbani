<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="SubscriptionMenu.aspx.cs" Inherits="umbani.View.SubscriptionMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <asp:Panel ID="Panel1" runat="server" Height="574px">
        <asp:Panel ID="Panel2" runat="server" BackColor="#3399ff" style="text-align:center">
            Meun<br /> </asp:Panel>
        <asp:Button ID="Button1" runat="server" Text="Add" BackColor="#3399ff" Width="221px" OnClick="Button1_Click"  /><asp:TextBox ID="TextBox1" runat="server" placeholder="Search and filter by company" style="margin-left: 103px" Width="486px"></asp:TextBox>
        <br />
        <br /> 
        <asp:GridView ID="GridView1" runat="server" Height="435px" Width="1455px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoFormat="Professional" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="id" OnRowUpdating="GridView1_RowUpdating" >
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" />
                <asp:BoundField DataField="name" HeaderText="Company" SortExpression="name" />
                <asp:BoundField DataField="name1" HeaderText="Contact" SortExpression="name1" />
                <asp:BoundField DataField="name2" HeaderText="Product" SortExpression="name2" />
                <asp:BoundField DataField="numberofUsers" HeaderText="No Of Users" SortExpression="numberofUsers" />
                <asp:BoundField DataField="subscriptionstartdate" HeaderText="Subscription End" SortExpression="subscriptionstartdate" />
                <asp:CommandField ShowEditButton="true" />
                <asp:CommandField ShowDeleteButton="true" />
            </Columns>
        </asp:GridView>
           <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:umbani %>" SelectCommand=" select s.id,co.name,c.name,p.name,s.numberofUsers,s.subscriptionstartdate from subscription s
  inner join company co
  on s.companyid = co.id
  inner join contact c
  on s.contactid = c.id
  inner join product p
  on s.productid = p.id"></asp:SqlDataSource>
    </asp:Panel>
</asp:Content>
