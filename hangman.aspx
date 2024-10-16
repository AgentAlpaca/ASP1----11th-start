<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hangman.aspx.cs" Inherits="hangman" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         
            <asp:Panel ID="Panel1" runat="server">
                
                            <asp:Label runat="server" ID="lblLetter" Text="Label" ></asp:Label>
                               <asp:Label runat="server" ID="Label1" Text="Label" ></asp:Label>
              
                </asp:Panel>
             <asp:Panel ID="Panel2" runat="server">
                  <table>
            <tr>
                        <td>
                            <asp:Button ID="Q" runat="server" Text="Q" />
                        </td>
                          <td>
      <asp:Button ID="W" runat="server" Text="W" />
  </td>
                          <td>
      <asp:Button ID="E" runat="server" Text="E" />
  </td>
                          <td>
      <asp:Button ID="R" runat="server" Text="R" />
  </td>
                          <td>
      <asp:Button ID="T" runat="server" Text="T" />
  </td>
                          <td>
      <asp:Button ID="Y" runat="server" Text="Y" />
  </td>
                          <td>
      <asp:Button ID="U" runat="server" Text="U" />
  </td>
                          <td>
      <asp:Button ID="I" runat="server" Text="I" />
  </td>
                          <td>
      <asp:Button ID="O" runat="server" Text="O" />
  </td>
                          <td>
      <asp:Button ID="P" runat="server" Text="P" />
  </td>
                    </tr>
                    <tr>
                          <td>
      <asp:Button ID="A" runat="server" Text="A" OnClick="A_Click" />
  </td>  <td>
      <asp:Button ID="S" runat="server" Text="S" />
  </td>  <td>
      <asp:Button ID="D" runat="server" Text="D" />
  </td>  <td>
      <asp:Button ID="F" runat="server" Text="F" />
  </td>  <td>
      <asp:Button ID="G" runat="server" Text="G" />
  </td>  <td>
      <asp:Button ID="H" runat="server" Text="H" />
  </td>  <td>
      <asp:Button ID="J" runat="server" Text="J" />
  </td>  <td>
      <asp:Button ID="K" runat="server" Text="K" />
  </td>  <td>
      <asp:Button ID="L" runat="server" Text="L" />
  </td>
                    </tr>
                    <tr>
                          <td>
      <asp:Button ID="Z" runat="server" Text="Z" />
  </td>
                          <td>
      <asp:Button ID="X" runat="server" Text="X" />
  </td>
                          <td>
      <asp:Button ID="C" runat="server" Text="C" OnClick="C_Click" />
  </td>
                          <td>
      <asp:Button ID="V" runat="server" Text="V" />
  </td>
                          <td>
      <asp:Button ID="B" runat="server" Text="B" OnClick="B_Click" />
  </td>
                          <td>
      <asp:Button ID="N" runat="server" Text="N" />
  </td>
                          <td>
      <asp:Button ID="M" runat="server" Text="M" />
  </td>
                    </tr>
                </table>
                 </asp:Panel>
            
        </div>
    </form>
</body>
</html>
