<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Products_acc.aspx.cs" Inherits="milestone3.Products_acc" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Serial No.:"></asp:Label>
         <asp:TextBox ID="Serial1" runat="server"></asp:TextBox>
           
            
            <asp:Label ID="name" runat="server" Text="Wish List Name:"></asp:Label>
            <asp:TextBox ID="Wishlistname" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Add to my Wish List" OnClick="Button1_Click" />
            <br />
            <asp:Label ID="serial" runat="server" Text="Serial No:"></asp:Label>
            
            <asp:TextBox ID="serialNo" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="cart" runat="server" Text="Add to my Cart" OnClick="cart_Click" />
        </div>
    </form>
</body>
</html>
