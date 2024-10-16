<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ex2.aspx.cs" Inherits="ex2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>

                        <asp:TextBox ID="n1" runat="server"></asp:TextBox>

                    </td>
                    <td>

                        <asp:TextBox ID="n2" runat="server"></asp:TextBox>

                    </td>
                    <td>
                        &nbsp;<td class="auto-style1">=</td>

                    </td>
                    <td>

            <asp:Label ID="result" runat="server" Text="Label"></asp:Label>
                    </td>
                </tr>
            </table>

            <br />
                        <asp:Button ID="Button1" runat="server" Text="+" OnClick="Button1_Click1" />

            <br />
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="-" />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="*" />
            <br />

        </div>
        <p>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="/" />
        </p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
