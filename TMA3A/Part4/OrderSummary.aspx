<%@ Page Language="C#" AutoEventWireup="true" CodeFile="OrderSummary.aspx.cs" Inherits="Part3_OrderSummary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Order Summary</title>
    <link rel="stylesheet" type="text/css" href="../main.css" />
    <link rel="stylesheet" type="text/css" href="part3.css" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="banner">
            <a href="StoreHomepage.aspx" id="logo" ><img class="logo" src="../Images/logo.png" /></a>
            <a href="StoreHomepage.aspx">Home</a>
            <a href="Customization.aspx">Customization</a>
            <a href="Feedback.aspx">Feedback</a>
            <a href="Contacts.aspx">Contact</a>
            <div class="cart">
                <a id="active" href="OrderSummary.aspx" style="right:20px; position:absolute;">Cart Order</a>
                <asp:Label ID="CartCount" runat="server" style="right:5px; top:45px; position:absolute;"/>
                <a href="OrderSummary.aspx" style="right:150px; position:absolute;"><img src="../Images/cart.png" /></a>
            </div>
           <asp:Button runat="server" ID="login" PostBackUrl="SignIn.aspx" CssClass="loginBtn" Text="Login" ></asp:Button>
        </div>

        <div class="box">
            <div>
                <div><h1>Order Summary</h1></div>
                <asp:Label ID="ListMsg" runat="server" ></asp:Label>
                <asp:BulletedList ID="ComputerList" runat="server"></asp:BulletedList>
                <div><asp:Label ID="PriceTotal" runat="server"></asp:Label></div>
            </div>
        </div>
        
    </form>
</body>
</html>
