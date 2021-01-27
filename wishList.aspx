<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wishList.aspx.cs" Inherits="milestone3.wishList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label3" runat="server" Text="Wish List Name:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="View" OnClick="Button2_Click" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Wish List Name:"></asp:Label>
            <asp:TextBox ID="name" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="Serial No.:"></asp:Label>
            <asp:TextBox ID="serial" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Remove" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
