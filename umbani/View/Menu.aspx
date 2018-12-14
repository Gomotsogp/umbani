<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.Master" CodeBehind="Menu.aspx.cs" Inherits="WebFormsIdentity.DashBoard" %>

<%@ Register assembly="DevExpress.Web.Bootstrap.v18.1, Version=18.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.Bootstrap" tagprefix="dx" %>
<%@ Register assembly="DevExpress.Web.v18.1, Version=18.1.5.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web" tagprefix="dx" %>

<asp:Content ID="C1" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
    
    <asp:Panel ID="Panel1" runat="server" Height="560px">
        <asp:Panel ID="Panel2" runat="server" BackColor="#3399FF" Height="34px" Width="1310px" style="text-align:center">MENU</asp:Panel>
        <br />

        <div>
            <asp:Panel runat="server" style="float:left; display:inline; margin-right:20px; margin-bottom:20px" Width="50%" Height="242px" BackColor="Blue">
                <asp:Panel ID="Panel3" runat="server" BackColor="#3399FF" style="text-align:center">
                    GRAPH 1</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" style="float:left; display:inline; margin-right:20px; margin-bottom:20px" Width="47%" Height="244px" BackColor="Red">
                <asp:Panel ID="Panel4" runat="server" BackColor="#3399FF" Width="618px" style="text-align:center">
                    GRAPH 2</asp:Panel>
            </asp:Panel>
            <br />
            <asp:Panel runat="server" style="float:left; display:inline; margin-right:20px; margin-bottom:20px" Width="50%" Height="256px" BackColor="Blue">
                <asp:Panel ID="Panel5" runat="server" BackColor="#3399FF" style="text-align:center">
                    GRAPH 3</asp:Panel>
            </asp:Panel>
            <asp:Panel runat="server" style="float:left; display:inline; margin-right:20px; margin-bottom:20px" Width="47%" Height="254px" BackColor="Red">
                <asp:Panel ID="Panel6" runat="server" BackColor="#3399FF" style="text-align:center">
                    GRAPH 4</asp:Panel>
            </asp:Panel>
        </div>
    </asp:Panel>
    
</asp:Content>


