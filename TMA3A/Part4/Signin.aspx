<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Signin.aspx.cs" Inherits="Part3_Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Log In</title>
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
            <a href="Contact.aspx">Contact</a>
            <div class="cart">
                <a href="OrderSummary.aspx" style="right:20px; position:absolute;">Cart Order</a>
                <asp:Label ID="CartCount" runat="server" style="right:5px; top:45px; position:absolute;"/>
                <a href="OrderSummary.aspx" style="right:150px; position:absolute;"><img src="../Images/cart.png" /></a>
            </div>
           <asp:Button runat="server" ID="logout" PostBackUrl="StoreHomepage.aspx" CssClass="loginBtn" Text="Logout" OnClick="logout_Click" ></asp:Button>
        </div>
        <div class="container">
            <div class="login">
		    	 <div class="loginTitle">
                     <img src="../Images/login.png" alt="User"/>
				     <p>Register</p>
				 </div>

                <div >
                        <asp:Label ID="Label2" runat="server" Text="Username: "></asp:Label>
                        <asp:TextBox ID="rusername" runat="server" ></asp:TextBox>
                        </div>
                <div>
                    <asp:Label ID="rpasswordLabel" runat="server" Text="Password: "></asp:Label>
                    <asp:TextBox ID="rpassword" runat="server" TextMode="Password"></asp:TextBox>
				     </div>

                <div>
                    <asp:Label ID="rPass2Label" runat="server" Text="Password: "></asp:Label>
                    <asp:TextBox ID="rPass2" runat="server" TextMode="Password" ></asp:TextBox>
				</div>
				
                <div>
				      <asp:Button runat="server" cssclass="btn" id="regSubmit" Text="Register" OnClick="regSubmit_Click"></asp:Button>
				    </div>
				      <asp:Label ID="registerMsg" runat="server" style="color:red;"></asp:Label></asp:Label>

            </div>
            

            <div class="login">
					<div class="loginTitle">
                        <img src="../Images/login.png" alt="User"/>
                        <p>Login</p>
				    </div>

				    <div >
                        <asp:Label ID="userLabel" runat="server" Text="Username: "></asp:Label>
                        <asp:TextBox ID="username" runat="server" ></asp:TextBox>
                        </div>
                <div>
                    <asp:Label ID="passwordLabel" runat="server" Text="Password: "></asp:Label>
                    <asp:TextBox ID="loginPass" runat="server" TextMode="Password" ></asp:TextBox>
				     </div>   
                <div>
				      <asp:Button runat="server" ID="login" CssClass="btn" Text="Login" OnClick="loginSubmit_Click"></asp:Button>
				    </div>
                    <asp:Label ID="loginMsg" runat="server" style="color:red;"></asp:Label>

            </div>
            </div>
        </form>
    </body>
</html>

