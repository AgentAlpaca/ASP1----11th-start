<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ex5.aspx.cs" Inherits="ex5" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image1" runat="server" Width="1000px" ImageUrl="~/Images/pic.png" />
        </div>
        <p>
            <asp:Label ID="Label1" runat="server" Text="London"></asp:Label>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Hide pic" />
        </p>
        <p>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Show pic" />
        </p>
        <p>
            <asp:CheckBox ID="Back" runat="server" OnCheckedChanged="Back_CheckedChanged" Text="Background" />
        </p>
        <p>
            <asp:CheckBox ID="Highlights" runat="server" OnCheckedChanged="Highlights_CheckedChanged" Text="Highlights" />
        </p>
        
        <p>
        <asp:Button ID="sendref" runat="server" Text="Send" OnClick="sendref_Click" />
        </p>
        
    </form>
</body>
</html>
