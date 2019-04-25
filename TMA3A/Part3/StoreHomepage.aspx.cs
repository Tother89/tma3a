using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part3_StoreHomepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        var count = Session[Constants.CART_COUNT];
        CartCount.Text = count == null ? string.Empty : count.ToString();
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
        SetSelectedComputerCookie(Constants.DefaultComputers[Constants.MacbookPro]);
        Server.Transfer("Customization.aspx", false);
    }

    protected void hp_Click(object sender, ImageClickEventArgs e)
    {
        SetSelectedComputerCookie(Constants.DefaultComputers[Constants.HPNotebook]);
        Server.Transfer("Customization.aspx", false);
    }

    protected void surfacepro_Click(object sender, ImageClickEventArgs e)
    {
        SetSelectedComputerCookie(Constants.DefaultComputers[Constants.SurfacePro]);
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