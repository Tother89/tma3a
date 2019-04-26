<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CookieTracker.aspx.cs" Inherits="Part1_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookie Tracker</title>
    <link type="text/css" href="../main.css" rel="stylesheet" />
    
</head>
<body>
        <div class="banner">
      <h1>COMP 466: Assignment 3A</h1>

            <a href="../tma3a.aspx">Home</a>
            <a id="active" href="CookieTracker.aspx">Part 1</a>
            <a href="../Part2/Slideshow.aspx">Part 2</a>
            <a href="../Part3/StoreHomepage.aspx">Part 3</a>
            <a href="../Part4/FinalStore.aspx">Part 4</a>
        </div>

    <div class="box">
     <img alt="Cookies" src="../Images/cookies.jpg" />

    <div>
        <h1>Cookie Tracker</h1>
        <p> All browsers keep track of user information like site visits through cookies.</p>
        <p>Hit refresh on this page to see your cookie count
            go up with each new visit to this site.
        </p>
    </div>

    <div>
        <p>Page visits: <asp:Label ID="VisitLabel" runat="server" Text="No page visits"></asp:Label> </p>
        <p>IP Address: <asp:Label ID="IpLabel" runat="server" Text="No IP address found"></asp:Label></p>
        <p>Time Zone: <asp:Label ID="ZoneLabel" runat="server" Text="Unknown Time Zone"></asp:Label></p>
    </div>
        </div>

    <script src="TimeZone.js" type="text/javascript" ></script>
</body>
</html>
