﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="editProduct.aspx.cs" Inherits="milestone3.editProduct" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="direction: ltr">

            <asp:Label ID="Label7" runat="server" Text="serial_no"></asp:Label> 
            <br />
            <asp:TextBox ID="serial_number" runat="server" ></asp:TextBox>
              <br />

            <asp:Label ID="Label2" runat="server" Text="Product name"></asp:Label> 
            <br />
             <asp:TextBox ID="productName" runat="server" ></asp:TextBox>
            <br />
            
            <asp:Label ID="Label3" runat="server" Text="Category"></asp:Label> 
            <br />
             <asp:TextBox ID="cat" runat="server" ></asp:TextBox>
            <br />
            
            <asp:Label ID="Label4" runat="server" Text="Product description"></asp:Label> 
            <br />
             <asp:TextBox ID="Produc_desc" runat="server" ></asp:TextBox>
            <br />
            
            <asp:Label ID="Label5" runat="server" Text="Price"></asp:Label> <br />
             <asp:TextBox ID="Pr" runat="server" ></asp:TextBox>
            <br />

            <asp:Label ID="Label6" runat="server" Text="Color"></asp:Label>
            <br />
             <asp:TextBox ID="Cl" runat="server" ></asp:TextBox>
             <br />
             <br />
             <br />

            <asp:Button ID="Button1" runat="server" Text="Edit Product" OnClick="Button1_Click" />

        </div>
    </form>
</body>
</html>
