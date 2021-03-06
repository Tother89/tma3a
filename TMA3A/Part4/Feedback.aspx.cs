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
        string user = Session[Constants.LOGIN_USER] as string;
        bool loggedIn = user != null && !string.IsNullOrEmpty(user);
        login.Text = loggedIn ? $"{user}" : "Login";

        var count = Session[Constants.CART_COUNT];
        CartCount.Text = count == null ? string.Empty : count.ToString();
    }

    protected void CartImg_Clicked(object sender, ImageClickEventArgs e)
    {
        Response.Redirect("OrderSummary.aspx");
    }

    protected void login_Click(object sender, EventArgs e)
    {
        Response.Redirect("Signin.aspx");
    }
}