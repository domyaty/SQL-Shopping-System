<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="customer.aspx.cs" Inherits="milestone3.customer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <p>
        <asp:Button ID="Button6" runat="server" Height="65px" Text="AddCreditCard" Width="180px" OnClick="Button6_Click" />
        </p>

        <p>
        <asp:Button ID="Button7" runat="server" Height="65px" Text="View My Cart" Width="180px" OnClick="Button7_Click" />
        </p>

        <p>
        <asp:Button ID="Button8" runat="server" Height="65px" Text="View Products" Width="180px" OnClick="Button8_Click" />

        </p>
        <p>
                <asp:Button ID="Button9" runat="server" Height="65px" Text="View WishList" Width="180px" OnClick="Button9_Click" />
        
        </p>

        <p>
        <asp:Button ID="Button1" runat="server" Height="65px" Text="make an order" Width="180px" OnClick="Button1_Click" />
        </p>

        <p>
            <asp:Button ID="Button2" runat="server" Height="65px" Text="Specify Amount of payment" Width="180px" OnClick="Button2_Click" />
        </p>

        <p>
            <asp:Button ID="Button3" runat="server" Height="65px" Text="Choose Credit Card to pay" Width="180px" OnClick="Button3_Click" />
        </p>

        <p>
            <asp:Button ID="Button4" runat="server" Height="65px" Text="Cancel Order" Width="180px" OnClick="Button4_Click" />
        </p>
        <br />
    
        <p>
        <asp:Label ID="Label1" runat="server" Text="Mobile Number:"></asp:Label><br />
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox> 
        </p>
        <asp:Button ID="Button5" runat="server" Text="Add" OnClick="AddTelephone" />

    </form>
</body>
</html>
