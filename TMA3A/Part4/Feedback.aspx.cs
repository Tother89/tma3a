﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part3_Feedback : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Set the login text for the current user
        var loginCookie = Request.Cookies[Constants.LOGIN_COOKIE];
        var user = loginCookie?.Values[Constants.LOGIN_USER];
        bool loggedIn = loginCookie != null && !string.IsNullOrEmpty(user);
        login.Text = loggedIn ? $"{user}" : "Login";


        var count = Session[Constants.CART_COUNT];
        CartCount.Text = count == null ? string.Empty : count.ToString();
    }

    protected void CartImg_Clicked(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("OrderSummary.aspx");
    }
}