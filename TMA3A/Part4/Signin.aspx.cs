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
        string user = Session[Constants.LOGIN_USER] as string;
        bool loggedIn = user != null && !string.IsNullOrEmpty(user);
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

    private void ClearAllFields()
    {
        username.Text = string.Empty;
        rusername.Text = string.Empty;
        loginPass.Text = string.Empty;
        rPass2.Text = string.Empty;
        rpassword.Text = string.Empty;
    }

    protected void regSubmit_Click(object sender, EventArgs e)
    {
        if (ValidateRegister())
        {
            
            if (SqlHandler.DoesCustomerExist(rusername.Text))
            {
                registerMsg.Text = "User already exists. Please login or create a new account.";
            }
            else
            {
                SqlHandler.CreateNewCustomer(rusername.Text, rpassword.Text);
                registerMsg.Text = "New user created successfully!";
            }

            ClearAllFields();
        }

        loginMsg.Text = string.Empty;
    }

    protected void loginSubmit_Click(object sender, EventArgs e)
    {
        if (ValidateUsernameAndPassword())
        {
            if (SqlHandler.DoesCustomerExist(username.Text))
            {

                if (SqlHandler.ValidateCredentials(username.Text, loginPass.Text))
                {
                    HttpCookie loginCookie = Request.Cookies[Constants.LOGIN_COOKIE];

                    if (loginCookie == null)
                        loginCookie = new HttpCookie(Constants.LOGIN_COOKIE);
                    loginCookie.Values.Add(Constants.LOGIN_USER, username.Text);
                    loginCookie.Expires = DateTime.Now.AddMonths(1);
                    loginCookie.Values[Constants.LOGIN_USER] = username.Text;
                    logout.Visible = true;
                    logout.Text = "Logout";
                    loginMsg.Text = "User signed in.";
                }
                else
                {
                    loginMsg.Text = "Invalid username or password";
                }
                
            }
            else
            {
                // User does not exist
                loginMsg.Text = "User does not exist. Please register first before logging in.";
            }
        }
        else
        {
            loginMsg.Text = "Invalid credentials";
        }

        ClearAllFields();
        registerMsg.Text = string.Empty;
    }

    private bool ValidateUsernameAndPassword()
    {
        if (loginPass.Text == null || loginPass.Text == string.Empty)
            return false;

        if(username.Text == null || username.Text == string.Empty)
        {
            return false;
        }

        return true;
    }

    private bool ValidateRegister()
    {
        return true;
    }
}