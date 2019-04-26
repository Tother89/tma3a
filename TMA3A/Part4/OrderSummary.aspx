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
            <div class="summary">
                <div><h1>Order Summary</h1></div>
                <asp:Label ID="ListMsg" CssClass="summary" runat="server" ></asp:Label>
                <asp:CheckBoxList ID="ComputerList" runat="server"></asp:CheckBoxList>
                <div><h3>Total: <asp:Label ID="PriceTotal" CssClass="price" runat="server"></asp:Label></h3></div>
            </div>
            <div><asp:Button ID="Delete" CssClass="btn" runat="server" Text="Delete" OnClick="Delete_Click" /><asp:Label ID="DeleteLabel" runat="server" style="color:red;"></asp:Label>
            <asp:Button ID="Upload" CssClass="btn" style="margin-left: 10px;" runat="server" Text="Save" OnClick="Upload_Click" 
                OnClientClick="return alert('Saving order to database');" Visible="false" /><asp:Label ID="UploadLabel" runat="server" style="color:red;"></asp:Label>
            <asp:Button ID="Fetch" CssClass="btn" style="margin-left: 10px;" runat="server" Text="Grab Order" OnClick="Fetch_Click" 
                OnClientClick="return confirm('Remove current order and retrieve saved one?');" Visible="false" /><asp:Label ID="FetchLabel" runat="server" style="color:red;"></asp:Label></div>
            <div>
                <asp:Label ID="Label1" runat="server" Visible="false" Text="Be sure to save your orders for another time."></asp:Label>
            </div>

            <div>
                <p>You can log in with your account to save orders. Whenever you click save the database will be changed to hold only 
                    your current order. If you don't like your current order then go ahead and grab your old one that is saved. Want more
                    than one machine? Go back to the customization screen and add a new item to your cart!
                </p>
            </div>
        
    </form>
</body>
</html>
