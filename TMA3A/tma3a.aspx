<%@ Page Language="C#" AutoEventWireup="true" CodeFile="tma3a.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>COMP 466 Assignment 3A</title>
    <link rel="stylesheet" type="text/css" href="main.css" />
</head>
<body>
    <div class="banner">
        <h1>COMP 466: Assignment 3A</h1>
        <a id="active" href="tma3a.aspx">Home</a>
        <a href="Part1/CookieTracker.aspx">Part 1: Cookie Tracker</a>
        <a href="Part2/Slideshow.aspx">Part 2: Slideshow</a>
        <a href="Part3/StoreHomepage.aspx">Part 3: Computer Maker</a>
        <a href="Part4/StoreHomepage.aspx">Part 4: Computer Maker</a>
    </div>

    <div>
        <h2>ASP.NET in C#</h2>
    </div>

    <div class="box">
        <h3>Summary</h3>
        <p>This assignment is comprised of four different parts</p>
        <ol>
            <li>Cookie Tracker
                <p>In this application we track how many times the user (you) visit that current page. If you hit refresh you
                    will see the number increase with each visit. Also your external IP address and time zone are displayed.
                </p>
            </li>
            <li>
                Slideshow
                <p>A slideshow similar to assignment 1 part 3 is included in this project. It displays several photos of my trip to 
                    Vancouver and throughout Alberta last summer. You can turn it on to automatically display each photo in a 
                    sequential or random order. You can also flip through them yourself. If you are on shuffle mode you cannot use the 
                    next buttons.
                </p>
            </li>
            <li>
                Computer Maker
                <p>
                    This section is the meat of the assignment. Here we are replciating the functionality of an online webstore for 
                    computers. A lot of  my research came from sites like <a href="https://www.bestbuy.ca/">Best Buy</a> and 
                    <a href="https://www.memoryexpress.com/">Memory Express</a>. With these basic ideas in mind I setup my store. You are 
                    able to create a default computer by clicking on one of the three options and then you are taken to a customization screen.
                    Here you will be able to change several components of the machine including the operating system, display, CPU, hard drive, 
                    and RAM. These will give you a total and you are given an option of adding that custom build machine to your cart. 
                </p>
                <p>
                    From the cart you can see your order summary and remove any unwanted items from it. As well as this major part of the 
                    store you can leave feedback in a form and see the contact page for any assistance you might need.
                </p>
            </li>
            <li>
                Computer Maker Final
                <p>
                    The last part of this assignment is just making the Computer Maker section more robust. It includes handling of the orders
                    by placing them in a database for processing. As well as that it has a log in system which validates users and makes 
                    sure you log in while using this product. The basic flow of the site remains the same but some small things are different.
                </p>
            </li>
        </ol>

        <h3>Remarks</h3>
        <p>This site is to be used for COMP 466 purposes only. Please do not treat this as a real web store as many things like 
            actual product purchases have not been included in its design. 
        </p>

        <div class="information">
				<p>Name: Dallin Toth<br>
				Date Start: April 20, 2019<br>
				Date Completed: April 25, 2019<br>
				Estimated Time: 36 hours</p>
			</div>
    </div>
</body>
</html>
