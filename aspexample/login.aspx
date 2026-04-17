<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="aspexample.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">

                 <tr>
     <td>
     enter name <asp:TextBox ID="txtname" runat="server"  ></asp:TextBox>
     </td>
 </tr>
                
                 <tr>
     <td>
     enter  EMAIL<asp:TextBox ID="txtemail"  runat="server"  ></asp:TextBox>
     </td>
 </tr>

     <tr>
    <td>
      select movie name<asp:RadioButtonList ID="radiomv" runat="server">
          <asp:ListItem  Value="Dacott">Dacott</asp:ListItem>
          <asp:ListItem Value ="Kalki">kalki</asp:ListItem>
          <asp:ListItem Value="Rajasab">Rajasab</asp:ListItem>

       </asp:RadioButtonList>
    </td>
</tr>
                     <tr>
    <td>
      select show time<asp:RadioButtonList ID="radioshow" runat="server">
          <asp:ListItem  Value="11am">11am</asp:ListItem>
          <asp:ListItem Value ="2pm">2pm</asp:ListItem>
          <asp:ListItem Value="6pm">6pm</asp:ListItem>
          <asp:ListItem Value="9pm">9pm</asp:ListItem>
       </asp:RadioButtonList>
    </td>
</tr>
     <tr>
    <td>
      add ons<asp:CheckBoxList ID="checkadd" runat="server">
          <asp:ListItem  Value="softdrink">softdrinks</asp:ListItem>
          <asp:ListItem  Value="snacks">Snacks</asp:ListItem>
          <asp:ListItem value="3dglass">3dglass</asp:ListItem>
             </asp:CheckBoxList>
    </td>
</tr>

                <tr>
                    <td>
          <asp:CheckBox ID="chkm" runat="server" Text="movie" />
                    </td>
                </tr>
                 <tr>


                <tr>
                    <td>
                 <asp:Button ID="btnbook" runat="server" Text="Book" OnClick="btnbook_Click" />
                    </td>
                </tr>
                 <tr>
     <td>
<asp:Label ID="lblmsg" runat="server"></asp:Label>
     </td>
 </tr>

                
            </table>
        </div>
    </form>
</body>
</html>
