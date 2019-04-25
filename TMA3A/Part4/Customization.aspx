<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Customization.aspx.cs" Inherits="Part3_Customization" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Computer Customization</title>
    <link rel="stylesheet" type="text/css" href="../main.css" />
    <link rel="stylesheet" type="text/css" href="part3.css" />
</head>
<body>
    <form id="form1" runat="server">
      <div class="banner">
            <a href="StoreHomepage.aspx" id="logo" ><img class="logo" src="../Images/logo.png" /></a>
            <a href="StoreHomepage.aspx">Home</a>
            <a id="active" href="Customization.aspx">Customization</a>
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
            <div>
                <div><h1>My Computer Customization</h1></div>
            </div>
            <div><asp:Label runat="server" CssClass="compLabel" ID="compLabel"></asp:Label></div>
            <div><asp:Label runat="server" CssClass="price" ID="price"></asp:Label></div>
            <div><asp:Image ID="ComputerImg" runat="server" /></div>
            <div class="price-container" style="display:flex;width:100%;">
                <asp:Button ID="cartBtn" runat="server" Text="Add to cart" CssClass="btn" OnClick="cartBtn_Click" />
            </div>
            <div class ="partOptions">
                <div class="main">
                    <div><asp:Label ID="Label1" runat="server" Text="CPU: "></asp:Label></div>
                    <div><asp:DropDownList ID="selectCpu" runat="server" AutoPostBack="true" onselectedindexchanged="selectDisplay_SelectedIndexChanged">
                       
                    </asp:DropDownList> </div>
                    <div><asp:Label ID="CpuLabel" runat="server" ></asp:Label></div>
                </div>
                 <div class="main">
                     <div><asp:Label ID="Label2" runat="server" Text="Display: "></asp:Label></div>
                     <div><asp:DropDownList ID="selectDisplay" runat="server" AutoPostBack="true" onselectedindexchanged="selectDisplay_SelectedIndexChanged">
                        
                    </asp:DropDownList></div>
                     <div><asp:Label ID="displayLabel" runat="server"></asp:Label></div>
                     <br />
                </div>
                 <div class="main">
                     <div><asp:Label ID="Label3" runat="server" Text="Hard Drive: "></asp:Label></div>
                    <div><asp:DropDownList ID="selectHd" runat="server" AutoPostBack="true" onselectedindexchanged="selectDisplay_SelectedIndexChanged">
                       
                    </asp:DropDownList></div>
                     <div><asp:Label ID="HdLabel" runat="server" ></asp:Label></div>
                </div>
                 <div class="main">
                     <div><asp:Label ID="Label4" runat="server" Text="RAM: "></asp:Label></div>
                    <div><asp:DropDownList ID="selectRam" runat="server" AutoPostBack="true" onselectedindexchanged="selectDisplay_SelectedIndexChanged">
                       
                    </asp:DropDownList></div>
                     <div><asp:Label ID="RamLabel" runat="server"></asp:Label></div>
                </div>
                 <div class="main">
                     <div><asp:Label ID="Label5" runat="server" Text="Operating System"></asp:Label></div>
                     <div><asp:DropDownList ID="selectOs" runat="server" AutoPostBack="true" onselectedindexchanged="selectDisplay_SelectedIndexChanged">
                       
                    </asp:DropDownList></div>
                     <div><asp:Label ID="OsLabel" runat="server" ></asp:Label></div>
                </div>
                <div class="main">
                    <div><asp:Label ID="Label6" runat="server" Text="Default Computer"></asp:Label></div>
                    <div><asp:DropDownList ID="computerList" runat="server" AutoPostBack="true" OnSelectedIndexChanged="computerList_SelectedIndexChanged"/></div>
                </div>
            </div>
        </div>

    </form>
</body>
</html>
