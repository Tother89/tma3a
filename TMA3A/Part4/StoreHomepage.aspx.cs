using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part3_StoreHomepage : System.Web.UI.Page
{
    List<Computer> compList;

    protected void Page_Load(object sender, EventArgs e)
    {
        string user = Session[Constants.LOGIN_USER] as string;
        bool loggedIn = user != null && !string.IsNullOrEmpty(user);
        login.Text = loggedIn ? $"{user}" : "Login";

        var count = Session[Constants.CART_COUNT];
        CartCount.Text = count == null ? string.Empty : count.ToString();

        compList = SqlHandler.FetchDefaultComputers();
    }

    private HttpCookie CreateNewComputerCookie()
    {
        HttpCookie cookie = new HttpCookie(Constants.COMPUTER_COOKIE);
        cookie.Expires = DateTime.Now.AddDays(30);
        cookie.Value = string.Empty;
        Response.Cookies.Add(cookie);

        return cookie;
    }

    protected void mac_Click(object sender, ImageClickEventArgs e)
    {
        SetSelectedComputerCookie(compList.FirstOrDefault(x=> x.Name == Constants.MacbookPro));
        Server.Transfer("Customization.aspx", false);
    }

    protected void hp_Click(object sender, ImageClickEventArgs e)
    {
        SetSelectedComputerCookie(compList.FirstOrDefault(x => x.Name == Constants.HPNotebook));
        Server.Transfer("Customization.aspx", false);
    }

    protected void surfacepro_Click(object sender, ImageClickEventArgs e)
    {
        SetSelectedComputerCookie(compList.FirstOrDefault(x => x.Name == Constants.SurfacePro));
        Server.Transfer("Customization.aspx", false);
    }

    private void SetSelectedComputerCookie(Computer computer)
    {
        // Create the new computer computer based on the selected default computer
        HttpCookie cookie = Request.Cookies[Constants.COMPUTER_COOKIE] ?? CreateNewComputerCookie();
        cookie.Value = computer.Name;
        Response.Cookies.Add(cookie);
        Session["Computer"] = computer;
    }
}