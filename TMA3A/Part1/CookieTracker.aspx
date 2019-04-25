﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CookieTracker.aspx.cs" Inherits="Part1_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cookie Tracker</title>
    <link type="text/css" href="../main.css" rel="stylesheet" />
    
</head>
<body>
      <h1>COMP 466: Assignment 3A</h1>
        <div>
            <a href="../tma3a.aspx">Home</a>
            <a id="active" href="CookieTracker.aspx">Part 1</a>
            <a href="../Part2/Slideshow.aspx">Part 2</a>
            <a href="../Part3/StoreHomepage.aspx">Part 3</a>
            <a href="../Part4/FinalStore.aspx">Part 4</a>
        </div>
     <img alt="Cookies" src="../Images/cookies.jpg" />

    <div>
        <h1>Cookie Tracker</h1>
    </div>

    <div>
        <p>Page visits: <asp:Label ID="VisitLabel" runat="server" Text="No page visits"></asp:Label> </p>
        <p>IP Address: <asp:Label ID="IpLabel" runat="server" Text="No IP address found"></asp:Label></p>
        <p>Time Zone: <asp:Label ID="ZoneLabel" runat="server" Text="Unknown Time Zone"></asp:Label></p>
    </div>
</body>
</html>