﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ex1.aspx.cs" Inherits="ex1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </table>
        </div>

        <asp:TextBox ID="fnname" runat="server"></asp:TextBox>
        <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hello" />
        </p>
        <p>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
    </form>
</body>
</html>
