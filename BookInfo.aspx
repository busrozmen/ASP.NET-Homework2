<%@ Page Language="C#" AutoEventWireup="true" CodeFile="BookInfo.aspx.cs" Inherits="BookInfo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Book Info</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="position: absolute; width: 300px;">
            <asp:Image ID="bookImage" Style="width: 350px; height: 500px;" runat="server" />
        </div>
        <div style="position: relative; left: 400px; width: 700px; top: 30px;">
            <asp:Label ID="lbltitle" Style="font-size: 24px;" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:Label ID="lblauthor" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:Label ID="lblpublisher" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:Label ID="lblpages" runat="server" Text=""></asp:Label><br />
            <br />
            <asp:Button ID="btnaddtocart" runat="server" Text="Add to Cart" OnClick="btnaddtocart_Click" /><asp:Label ID="lblbookaddedinfo" runat="server"></asp:Label><br />
            <br />
            <asp:HyperLink ID="displayshoppingcart" runat="server" NavigateUrl="Cart.aspx">Display Shopping Cart</asp:HyperLink><br />
            <br />
            <asp:HyperLink ID="returnmainpage" runat="server" NavigateUrl="Default.aspx">Return to Main Page</asp:HyperLink><br />
            <br />
        </div>
    </form>
</body>
</html>
