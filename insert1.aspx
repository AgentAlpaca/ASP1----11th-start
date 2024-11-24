<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="insert1.aspx.cs" Inherits="insert1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <label>name:</label><asp:TextBox ID="TextBox1" runat="server"></asp:TextBox><br />
   <label>family:</label> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><br />
    <label>age</label><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><br />
    <label>picture</label><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><br />
    <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
</asp:Content>

