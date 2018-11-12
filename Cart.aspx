<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Cart.aspx.cs" Inherits="Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Shopping Cart</title>
    <style>
        .tum {
            position: absolute;
            width: 600px;
            height: 590px;
            top: 0px;
        }

        .divSol {
            position: absolute;
            width: 300px;
        }

        .divSag {
            position: relative;
            left: 400px;
            width: 700px;
            top: 30px;
        }

        .son {
            position: absolute;
            margin-bottom: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div id="tum" runat="server">
        </div>
        <div id="sol" runat="server">
        </div>
        <div id="sag" runat="server">
        </div>
        <div id="son" runat="server">
        </div>

        <br />
        <br />
        <asp:Label ID="lblinfocart" runat="server" Style="font-size: 30px;" Text=""></asp:Label><br />
        <br />
    </form>
</body>
</html>