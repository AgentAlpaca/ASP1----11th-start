<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ex3.aspx.cs" Inherits="ex3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="Image2" runat="server" style="width: 300px" ImageUrl="~/Images/pic2.png"/>
            <asp:Image ID="Image3" runat="server" style="width: 300px" ImageUrl="~/Images/pic3.png"/>
            <asp:Image ID="Image1" runat="server" style="height: 70px" ImageUrl="~/Images/pic.png" />
        </div>
        <asp:RadioButtonList ID="RadioButtonList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged">
            <asp:ListItem Value="1">pic1</asp:ListItem>
            <asp:ListItem Value="2">pic2</asp:ListItem>
            <asp:ListItem Value="3">pic3</asp:ListItem>
        </asp:RadioButtonList>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged1">
            <asp:ListItem Value="1">img1</asp:ListItem>
            <asp:ListItem Value="2">img2</asp:ListItem>
            <asp:ListItem Value="3">img3</asp:ListItem>
        </asp:CheckBoxList>
        <br />
    </form>
</body>
</html>
