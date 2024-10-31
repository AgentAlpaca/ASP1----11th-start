<%@ Page Language="C#" AutoEventWireup="true" CodeFile="hangman.aspx.cs" Inherits="hangman" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Panel ID="Panel1" runat="server" Direction="RightToLeft">
               
                            <asp:Label runat="server" ID="lblLetter" Text="Label" >

                            </asp:Label><asp:Label runat="server" Text="Label" ID="Label1"></asp:Label><asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
                <asp:Table ID="TableChars" runat="server" Dir="rtl" ></asp:Table>          
                </asp:Panel>
             
                
             <asp:Panel ID="Panel2" runat="server">
                  <table>
            <tr>
                        <td>
                            <asp:Button ID="Q" runat="server" Text="Q" OnClick="Q_Click" />
                        </td>
                          <td>
                              <asp:Button ID="W" runat="server" Text="W" OnClick="W_Click" />
  </td>
                          <td>
                              <asp:Button ID="E" runat="server" Text="E" OnClick="E_Click" />
  </td>
                          <td>
                              <asp:Button ID="R" runat="server" Text="R" OnClick="R_Click" />
  </td>
                          <td>
                              <asp:Button ID="T" runat="server" Text="T" OnClick="T_Click" />
  </td>
                          <td>
                              <asp:Button ID="Y" runat="server" Text="Y" OnClick="Y_Click" />
  </td>
                          <td>
                              <asp:Button ID="U" runat="server" Text="U" OnClick="U_Click" />
  </td>
                          <td>
                              <asp:Button ID="I" runat="server" Text="I" OnClick="I_Click" />
  </td>
                          <td>
                              <asp:Button ID="O" runat="server" Text="O" OnClick="O_Click" />
  </td>
                          <td>
                              <asp:Button ID="P" runat="server" Text="P" OnClick="P_Click" />
  </td>
                    </tr>
                    <tr>
                          <td>
      <asp:Button ID="A" runat="server" Text="A" OnClick="A_Click" />
  </td>  <td>
      <asp:Button ID="S" runat="server" Text="S" OnClick="S_Click" />
  </td>  <td>
      <asp:Button ID="D" runat="server" Text="D" OnClick="D_Click" />
  </td>  <td>
      <asp:Button ID="F" runat="server" Text="F" OnClick="F_Click" />
  </td>  <td>
      <asp:Button ID="G" runat="server" Text="G" OnClick="G_Click" />
  </td>  <td>
      <asp:Button ID="H" runat="server" Text="H" OnClick="H_Click" />
  </td>  <td>
      <asp:Button ID="J" runat="server" Text="J" OnClick="J_Click" />
  </td>  <td>
      <asp:Button ID="K" runat="server" Text="K" OnClick="K_Click" />
  </td>  <td>
      <asp:Button ID="L" runat="server" Text="L" OnClick="L_Click" />
  </td>
                    </tr>
                    <tr>
                          <td>
                              <asp:Button ID="Z" runat="server" Text="Z" OnClick="Z_Click1" />
  </td>
                          <td>
                              <asp:Button ID="X" runat="server" Text="X" OnClick="X_Click1" />
  </td>
                          <td>
      <asp:Button ID="C" runat="server" Text="C" OnClick="C_Click" />
  </td>
                          <td>
                              <asp:Button ID="V" runat="server" Text="V" OnClick="V_Click" />
  </td>
                          <td>
      <asp:Button ID="B" runat="server" Text="B" OnClick="B_Click" />
  </td>
                          <td>
                              <asp:Button ID="N" runat="server" Text="N" OnClick="N_Click" />
  </td>
                          <td>
                              <asp:Button ID="M" runat="server" Text="M" OnClick="M_Click" />
  </td>
                    </tr>
                </table>
                 </asp:Panel>
            
        </div>
    </form>
</body>
</html>
