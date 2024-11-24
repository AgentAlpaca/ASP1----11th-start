<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="select1.aspx.cs" Inherits="select1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



    
    <asp:GridView ID="GridVie" runat="server"></asp:GridView>
    <br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
    



</asp:Content>

