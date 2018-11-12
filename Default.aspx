<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Main Page</title>
</head>
<body>
     <form id="form1" runat="server">
        <div id="leftside" runat="server" style="position: absolute; top: 21px; left: 10px; height: 130px; width: 157px; background-color: yellow;">
            <asp:Label ID="lblname" runat="server"></asp:Label>
            <asp:HyperLink ID="linkButton" runat="server" Text="here" NavigateUrl="Login.aspx"></asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="btnshoppingcart" runat="server" NavigateUrl="~/Cart.aspx">Display Shopping Cart</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="btnlogout" runat="server" Height="26px" OnClick="btnlogout_Click" Text="Log out" />
        </div>
        <asp:Panel id="rightside" runat="server" style="position: relative; width: 700px; top: 10px; left: 210px; height: 297px;">
            <asp:Label ID="linkbelow" runat="server" Text="Click on a link below:"></asp:Label><br /><br />

            <asp:HyperLink ID="book1" runat="server" Text="ASP.NET 3.5 Unleashed"></asp:HyperLink><br /><br />
            <asp:HyperLink ID="book2" runat="server" Text="ASP.NET Evolution"></asp:HyperLink><br /><br />
            <asp:HyperLink ID="book3" runat="server" Text="Mastering Web Development with Microsoft Visual Studio 2005"></asp:HyperLink><br /><br />
            <asp:HyperLink ID="book4" runat="server" Text="Beginning ASP.NET 2.0"></asp:HyperLink><br /><br />
            <asp:HyperLink ID="book5" runat="server" Text="Beginning ASP.NET 3.5 in C# 2008: From Novice to Professional, Second Edition"></asp:HyperLink><br /><br />
        </asp:Panel>
    </form>
</body>
</html>
