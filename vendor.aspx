<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vendor.aspx.cs" Inherits="milestone3.vendor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
        c<asp:Button ID="Button1" runat="server" Text="Post Product" Height="99px" Width="160px" OnClick="Button1_Click" />
        </p>
        <p>
        <asp:Button ID="Button2" runat="server" Text="View Products" Height="99px" Width="160px" OnClick="Button2_Click" />
        </p>
        <p>
        <asp:Button ID="Button3" runat="server" Text="Edit Products" Height="99px" Width="160px" OnClick="Button3_Click" />
        </p>
        <p>
        <asp:Button ID="Button4" runat="server" Text="Create Offer" Height="99px" Width="160px" OnClick="Button4_Click" />
        </p>
    
    
    </form>
</body>
</html>
