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
        if (Cart == null)
        {
            ListMsg.Text = "No items found in cart";
            return;
        }
        
        if (Cart.Items?.Count == 0 || Cart.Items == null)
        {
            ListMsg.Text = "No items found in cart";
            return;
        }

        double total = 0;
        int count = 1;
        foreach(Computer comp in Cart.Items)
        {
            ComputerList.Items.Add(new ListItem(count + ". "+ comp.Name + " - " + comp.Price.ToString("C"), comp.ID));
            total += comp.Price;
            count++;
        }

        PriceTotal.Text = total.ToString("C");
    }



    protected void Delete_Click(object sender, EventArgs e)
    {
        List<string> selectedIds = ComputerList.Items.Cast<ListItem>()
           .Where(li => li.Selected)
           .Select(li => li.Value)
           .ToList();

        Cart = ShoppingCart.Current;
        if(Cart == null || Cart.Items == null)
        {
            DeleteLabel.Text = "No items selected";
            return;
        }

        if ( selectedIds.Count == 0)
        {
            DeleteLabel.Text = "No items selected";
            return;
        }

        foreach (string id in selectedIds)
        {
            Cart.Items.RemoveAll(c => c.ID == id);
        }

        Session[Constants.CART] = Cart;
        Session[Constants.CART_COUNT] = Cart.Items.Count;

        Server.Transfer("OrderSummary.aspx");
    }
}