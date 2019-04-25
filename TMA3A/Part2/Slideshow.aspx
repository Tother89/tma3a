<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Slideshow.aspx.cs" Inherits="Part2_Slideshow" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Slideshow</title>
    <link type="text/css" rel="stylesheet" href="../main.css" />
    <link type="text/css" rel="stylesheet" href="part2.css" />
</head>
<body>
    <form id="form1" runat="server">
         <h1>COMP 466: Assignment 3A</h1>
        <div>
            <a href="../tma3a.aspx">Home</a>
            <a href="../Part1/CookieTracker.aspx">Part 1</a>
            <a id="active" href="Slideshow.aspx">Part 2</a>
            <a href="../Part3/StoreHomepage.aspx">Part 3</a>
            <a href="../Part4/FinalStore.aspx">Part 4</a>
        </div>
        <div class="Content">
       

            <div class="slideShowButtons">
                <asp:ImageButton ID="BackButton" runat="server" ImageUrl="../Images/backward.png" OnClick="BackButton_Click"/>
                <asp:ImageButton ID="PlayButton" runat="server" ImageUrl="../Images/play.png" OnClick="PlayButton_Click"/>
                <asp:ImageButton ID="ShuffleButton" runat="server" ImageUrl="../Images/shuffle.png" OnClick="ShuffleButton_Click" />
                <asp:ImageButton ID="ForwardButton" runat="server" ImageUrl="../Images/forward.png" OnClick="ForwardButton_Click" />
            </div>
             <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel runat="server">
                <ContentTemplate>
                    <asp:Timer ID="Timer" runat="server" Interval="3000" OnTick="Timer_Tick"></asp:Timer>
                    <div class="gallery"><asp:Image ID="Image" class="ssImg" runat="server" ImageUrl="../Images/Part2/banffhotsprings.jpg" /></div>
                    <asp:Label ID="CaptionLabel" runat="server" Text="1. Cave at Banff Hot Springs"></asp:Label>
                        <asp:HiddenField ID="ShuffleOn" runat="server" Value="false"></asp:HiddenField>
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
</body>
</html>
