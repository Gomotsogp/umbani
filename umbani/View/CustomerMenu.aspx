<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="CustomerMenu.aspx.cs" Inherits="umbani.View.CustomerMenu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" Height="574px">
        <asp:Panel ID="Panel2" runat="server" BackColor="#3399ff" style="text-align:center">
            Meun<br /> </asp:Panel>
        <asp:Button ID="Button1" runat="server" Text="Add" BackColor="#3399ff" Width="221px" OnClick="Button1_Click"  /><asp:TextBox ID="TextBox1" runat="server" placeholder="Search and filter by company" style="margin-left: 103px" Width="486px"></asp:TextBox>
        <br />
        <br /> 
        
        <asp:GridView ID="GridView1" runat="server" Height="435px" Width="1455px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoFormat="Professional" AllowSorting="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" OnRowDeleting="GridView1_RowDeleting" DataKeyNames="id" OnRowUpdating="GridView1_RowUpdating">
            <Columns>
                <asp:BoundField DataField="id" HeaderText="id" />
                <asp:BoundField DataField="name" HeaderText="Company Name" />
                <asp:BoundField DataField="name1" HeaderText="Contact" />
                <asp:BoundField DataField="phonenumber" HeaderText="Phone" />
                <asp:BoundField DataField="email" HeaderText="Email" />
                <asp:CommandField ShowEditButton="true" />
                <asp:CommandField ShowDeleteButton="true" />
                
                
            </Columns>
            

            <EmptyDataTemplate>
                <asp:DropDownList ID="contactlist" runat="server" DataSourceID="SqlDataSource2" DataTextField="name" DataValueField="id">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:umbani %>" SelectCommand="SELECT [id], [name] FROM [Contact]"></asp:SqlDataSource>
            </EmptyDataTemplate>
            

        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:umbani %>" SelectCommand=" select c.id,c.name ,co.name,co.phonenumber,co.email from company c
  inner join contact co
  on c.contactid = co.id"></asp:SqlDataSource>
    </asp:Panel>
</asp:Content>
