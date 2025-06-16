<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LeaveRequest.aspx.cs" Inherits="Leave_management.LeaveRequest" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Leave request</p>
    <p>
        email
        <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
    </p>
    <p>
        Leave type&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
        Start Date
        <asp:TextBox ID="TextBox2" TextMode="Date" runat="server"   ></asp:TextBox>
    </p>
    <p>
        End Date
        <asp:TextBox ID="TextBox3"  TextMode="Date" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <asp:Button ID="Button1" runat="server" Text="apply" OnClick="Button1_Click" />
    <p>
        &nbsp;</p>
</asp:Content>
