<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Part3_Contacts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Contact</title>
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
            <a id="active" href="Contact.aspx">Contact</a>
            <div class="cart">
                <a href="OrderSummary.aspx" style="right:20px; position:absolute;">Cart Order</a>
                <asp:Label ID="CartCount" runat="server" style="right:5px; top:45px; position:absolute;"/>
                <a href="OrderSummary.aspx" style="right:150px; position:absolute;"><img src="../Images/cart.png" /></a>
            </div>
        </div>
    </form>

    <div class="content">
        <h2>Having Trouble?</h2>
        <p>Gives us a call at: <b><em>(780) 555-1234</em></b> </p>
        <p>E-mail support: <a href="mailto:support@computermaker.com?Subject=Computer%Maker%Problems" target="_top"><b>support@computermaker.com</b></a></p>
    </div>

</body>
</html>
