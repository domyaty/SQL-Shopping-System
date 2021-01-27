<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createOffer.aspx.cs" Inherits="milestone3.createOffer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Offer amount"></asp:Label> 
            <br />
            <asp:TextBox ID="offer_A" runat="server" ></asp:TextBox>
              <br />

            <asp:Label ID="Label2" runat="server" Text="expiry date"></asp:Label> 
            <br />
             <asp:TextBox ID="Expiry_Date" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="ADD_OFFER" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="offerid"></asp:Label> 
            <br />
             <asp:TextBox ID="offer_ID" runat="server" ></asp:TextBox>
            <br />
            
            <asp:Label ID="Label5" runat="server" Text="Serial_ID_of_product"></asp:Label> <br />
             <asp:TextBox ID="serial_id" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="Button2" runat="server" Text="APPLY_OFFER" OnClick="Button2_Click" />
             <br />
            <br />
            <br />
            
             <asp:Label ID="Label3" runat="server" Text="Offer_ID"></asp:Label> <br />
             <asp:TextBox ID="OFFERID" runat="server" ></asp:TextBox>
            <br />
            <asp:Button ID="Button3" runat="server" Text="REMOVE_OFFER" OnClick="Button3_Click" />
        </div>
    </form>
</body>
</html>
