<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddCreditCard.aspx.cs" Inherits="milestone3.AddCreditCard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Credit Card No:"></asp:Label>
            <asp:TextBox ID="CreditCardNo" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Expiry Date:"></asp:Label>
            <asp:TextBox ID="ExDate" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="CVV:"></asp:Label>
            <asp:TextBox ID="Cvv" runat="server"></asp:TextBox>
            <br />
            <br />
        
            <asp:Button ID="Button1" runat="server" Text="Add"  />
           
        </div>
    </form>
</body>
</html>
