<%@ Page Language="C#" AutoEventWireup="true" CodeFile="StoreHomepage.aspx.cs" Inherits="Part3_StoreHomepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Computer Maker</title>
    <link rel="stylesheet" type="text/css" href="../main.css" />
    <link rel="stylesheet" type="text/css" href="part3.css" />
</head>
<body>
    <form id="form1" runat="server">
       <div class="banner">
            <a href="StoreHomepage.aspx" id="logo" ><img class="logo" src="../Images/logo.png" /></a>
            <a href="../tma3a.aspx">TMA3A Home</a>
            <a href="Customization.aspx">Customization</a>
            <a href="Feedback.aspx">Feedback</a>
            <a href="Contact.aspx">Contact</a>
            <div class="cart">
                <a href="OrderSummary.aspx" style="right:20px; position:absolute;">Cart Order</a>
                <asp:Label ID="CartCount" runat="server" style="right:5px; top:45px; position:absolute;"/>
                <a href="OrderSummary.aspx" style="right:150px; position:absolute;"><img src="../Images/cart.png" /></a>
            </div>
           <asp:Button runat="server" ID="login" PostBackUrl="SignIn.aspx" CssClass="loginBtn" Text="Login" ></asp:Button>
        </div>

            <div class="box">
                <h2>Computer Maker</h2>
                <p>
                    Welcome to computer maker where you can select a default computer and customize its parts to your needs.<br />
                    Please be sure to leave <a href="Feedback.aspx">feedback</a> about your experience here.<br />
                    If you have any questions see our <a href="Contact.aspx">Contacts</a> page.
                </p>
                <p>Make sure to <a href="Signin.aspx">sign in</a> and submit your orders. Otherwise you'll just be seen as a guest. </p>
            
                <h2>Select One</h2>
                <h4>Start off your computer maker experience by choosing a basic starting point</h4>
            </div>
            <div class="defaultComputers">
                <div class="comp">
                    <asp:ImageButton CssClass="imgComputers" ID="hp" 
                        runat="server" ImageUrl="../Images/Computers/hp.png" OnClick="hp_Click" />
                    <div><label>HP Notebook</label></div>
                </div>
                <div class="comp">
                    <asp:ImageButton CssClass="imgComputers" ID="mac"
                        runat="server" ImageUrl="../Images/Computers/macbook.png" OnClick="mac_Click" />
                    <div><label>Macbook Pro</label></div>
                </div>
                <div class="comp">
                    <asp:ImageButton CssClass="imgComputers" ID="surfacepro" 
                    runat="server" ImageUrl="../Images/Computers/surfacepro.png" OnClick="surfacepro_Click" />
                   <div><label>Surface Pro</label></div> 
                </div>
                        
            </div>
                 
    </form>
</body>
</html>
