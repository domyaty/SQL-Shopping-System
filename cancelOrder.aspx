<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="cancelOrder.aspx.cs" Inherits="milestone3.cancelOrder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    
    <p>
        <asp:Label ID="Label1" runat="server" Text="Order ID:"></asp:Label><br />
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    </p>

    <br /><asp:Button ID="Button1" runat="server" Text="Cancel" OnClick="Button1_Click" Height="36px" Width="70px" />
    
    </form>
</body>
</html>
