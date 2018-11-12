<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblfname" runat="server" Text="First Name: "></asp:Label>
            <asp:TextBox ID="txtfname" runat="server" Width="181px"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="lblLname" runat="server" Text="Last Name: "></asp:Label>
            <asp:TextBox ID="txtlname" runat="server" Width="181px"></asp:TextBox>
            <br />
            <br />

            <asp:Button ID="btnlogin" runat="server" Height="26px" Style="margin-left:215px" OnClick="btnlogin_Click" Text="Login" />
        </div>
    </form>
</body>
</html>
