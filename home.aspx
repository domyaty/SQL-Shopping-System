<%@ Page Language="C#" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="milestone3.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="Button1" runat="server" Height="60px" Text="login" Width="160px" OnClick="Button1_Click" /><br /><br />

            <asp:Button ID="Button3" runat="server" Height="60px" Text="register as a vendor" Width="160px" OnClick="Button3_Click" /><br /><br />

            <asp:Button ID="Button4" runat="server" Height="60px" Text="register as a customer" Width="160px" OnClick="Button4_Click" /><br /><br />
        </div>
    </form>
</body>
</html>
