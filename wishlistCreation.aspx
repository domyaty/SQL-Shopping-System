<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wishlistCreation.aspx.cs" Inherits="milestone3.wishlistCreation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            <asp:Label ID="Label2" runat="server" Text="Wish List Name:"></asp:Label>
            
            <br /> <asp:TextBox ID="wishList" runat="server" ></asp:TextBox>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Create Wish List" OnClick="Button1_Click" />
        </p>
    </form>
</body>
</html>
