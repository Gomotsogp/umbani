<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="WebFormsIdentity.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <asp:Panel ID="Panel1" runat="server" Height="166px" Width="375px">
            <asp:Label ID="Label1" runat="server" Text="Name :"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Email :"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Save" BackColor="#3399FF"/>
           
            <asp:Button ID="Button2" runat="server" Text="Change Password"  BackColor="#3399FF" style="margin-left: 28px" OnClick="Button2_Click"/>
                    </asp:Panel>
</asp:Content>
