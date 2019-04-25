using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part3_OrderSummary : System.Web.UI.Page
{
    private ShoppingCart Cart;

    protected void Page_Load(object sender, EventArgs e)
    {
        // Set the login text for the current user
        string user = Session[Constants.LOGIN_USER] as string;
        bool loggedIn = user != null && !string.IsNullOrEmpty(user);
        login.Text = loggedIn ? $"{user}" : "Login";

        var count = Session[Constants.CART_COUNT];
        CartCount.Text = count == null ? string.Empty : count.ToString();

        if (!IsCallback)
        {
            InitializeComputerList();
        }
        
    }

    private void InitializeComputerList()
    {
        Cart = ShoppingCart.Current;
        if (Cart == null || Cart.Items.Count == 0)
        {
            ListMsg.Text = "No items found in cart";
            return;
        }
        double total = 0;
        foreach(Computer comp in Cart.Items)
        {
            ComputerList.Items.Add(new ListItem(comp.Name + " - " + comp.Price.ToString("C")));
            total += comp.Price;
        }

        PriceTotal.Text = total.ToString("C");
    }


}