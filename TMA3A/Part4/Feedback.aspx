<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Feedback.aspx.cs" Inherits="Part3_Feedback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Feedback</title>
    <link rel="stylesheet" type="text/css" href="../main.css" />
    <link rel="stylesheet" type="text/css" href="part3.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div class="banner">
            <a href="StoreHomepage.aspx" id="logo" ><img class="logo" src="../Images/logo.png" /></a>
            <a href="StoreHomepage.aspx">Home</a>
            <a href="Customization.aspx">Customization</a>
            <a id="active" href="Feedback.aspx">Feedback</a>
            <a href="Contact.aspx">Contact</a>
            <div class="cart">
                <a href="OrderSummary.aspx" style="right:20px; position:absolute;">Cart Order</a>
                <asp:Label ID="CartCount" runat="server" style="right:5px; top:45px; position:absolute;"/>
                <a href="OrderSummary.aspx" style="right:150px; position:absolute;"><img src="../Images/cart.png" /></a>
            </div>
            <asp:Button runat="server" ID="login" PostBackUrl="SignIn.aspx" CssClass="loginBtn" Text="Login" ></asp:Button>
        </div>

        <div class="content">
            <div class="feedback">
                <asp:Label runat="server" CssClass="error" ID="nameError"></asp:Label>
                <div class="formElement"><label>Name: </label><input type="text" id="name" placeholder="Enter Full Name" required="required"/><br /></div>

                 <asp:Label runat="server" CssClass="error" ID="emailError"></asp:Label>
                <div class="formElement"><label>Email: </label><input id="Text1" type="email" required="required" /></div>

                 
                <h4>Do you feel that Computer Maker delivered on its services for you?</h4>
                <asp:RadioButtonList required="required" ID="RadioButtonList3" runat="server">
                    <asp:ListItem>Yes</asp:ListItem>
                    <asp:ListItem>Somewhat</asp:ListItem>
                    <asp:ListItem>No</asp:ListItem>
                </asp:RadioButtonList>
                
                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator2" Display="Dynamic"
                    ControlToValidate="RadioButtonList3" CssClass="error" >*Please choose one</asp:RequiredFieldValidator>

                <h4>How likely are you to recommend this website to a friend?</h4>
                <asp:RadioButtonList required="required" ID="RecommendationList" runat="server">
                    <asp:ListItem>Very likely</asp:ListItem>
                    <asp:ListItem>Likely</asp:ListItem>
                    <asp:ListItem>Maybe</asp:ListItem>
                    <asp:ListItem>Not Likely</asp:ListItem>
                    <asp:ListItem>Never</asp:ListItem>
                </asp:RadioButtonList>
                
                <asp:RequiredFieldValidator runat="server" ID="RequiredFieldValidator1" Display="Dynamic"
                    ControlToValidate="RecommendationList" CssClass="error" >*Please choose one</asp:RequiredFieldValidator>

                <h4>Overall statisfaction</h4>
                <asp:RadioButtonList required="required" ID="SatisfactionList" runat="server">
                    <asp:ListItem >Excellent</asp:ListItem>
                    <asp:ListItem>Good</asp:ListItem>
                    <asp:ListItem>Not Bad</asp:ListItem>
                    <asp:ListItem>Bad</asp:ListItem>
                    <asp:ListItem>Terrible</asp:ListItem>
                </asp:RadioButtonList>

                <asp:RequiredFieldValidator runat="server" ID="satisfactionReq" Display="Dynamic"
                    ControlToValidate="SatisfactionList" CssClass="error" >*Please choose one</asp:RequiredFieldValidator>

                <div><h4>Comments</h4><textarea id="TextArea" cols="75" rows="10"></textarea></div>

                <input type="submit" value="Submit" formaction="StoreHomepage.aspx"/>

            </div>
        </div>
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.1/jquery.min.js"></script>

    </form>
</body>
</html>
