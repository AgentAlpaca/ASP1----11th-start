<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ex8.aspx.cs" Inherits="ex7" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem Value="1">Manager</asp:ListItem>
                <asp:ListItem Value="2">Tester</asp:ListItem>
                <asp:ListItem Value="3">Engineer</asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

            <asp:Button ID="Button1" runat="server" Text="Button" />

        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
