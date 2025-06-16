<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="LeaveReoprt.aspx.cs" Inherits="Leave_management.LeaveReoprt" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        Leave Report</p>
    <p>
        Enter Email
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>
    <p>
&nbsp;<asp:Button ID="Button1" runat="server" Text=" leave report" OnClick="Button1_Click" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </p>
    <p>
        <asp:GridView ID="GvLeaveReport" runat="server">
        </asp:GridView>
    </p>
</asp:Content>
