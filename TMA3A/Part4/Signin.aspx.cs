using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part3_Login : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        // Set the login text for the current user
        var loginCookie = Request.Cookies[Constants.LOGIN_COOKIE];
        var user = loginCookie?.Values[Constants.LOGIN_USER];
        bool loggedIn = loginCookie != null && !string.IsNullOrEmpty(user);
        logout.Text = loggedIn ? "Logout" : "";

        DisplayButtons(loggedIn);
        var count = Session[Constants.CART_COUNT];
        CartCount.Text = count == null ? string.Empty : count.ToString();
    }

    private void DisplayButtons(bool state)
    {
        logout.Visible = state;
    }

    protected void logout_Click(object sender, EventArgs e)
    {
        Session.RemoveAll();
        var cookie = Request.Cookies[Constants.LOGIN_COOKIE];
        cookie.Expires = DateTime.Now.AddDays(-1);
    }

    protected void regSubmit_Click(object sender, EventArgs e)
    {

    }

    protected void loginSubmit_Click(object sender, EventArgs e)
    {
        if (ValidateUsernameAndPassword())
        {

        }
    }

    private bool ValidateUsernameAndPassword()
    {
        return true;
    }
}