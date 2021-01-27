<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="specifyAmount.aspx.cs" Inherits="milestone3.specifyAmount" %>

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

    <p>
        <asp:Label ID="Label2" runat="server" Text="Amount of Cash:"></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
    </p>

    <p>
        <asp:Label ID="Label3" runat="server" Text="Amount of Credit:"></asp:Label><br />
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox> 
    </p>

        <br /><asp:Button ID="Button1" runat="server" Text="Pay" OnClick="Button1_Click" Height="36px" Width="70px" />

    </form>
</body>
</html>
