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

        ShowFieldsWhenLoggedIn(loggedIn);

        var count = Session[Constants.CART_COUNT];
        CartCount.Text = count == null ? string.Empty : count.ToString();

        if (!IsPostBack && !IsCallback)
        {
            InitializeComputerList();
        }

        
    }

    private void ShowFieldsWhenLoggedIn(bool state)
    {
        Upload.Visible = state;
        UploadLabel.Visible = state;
        Fetch.Visible = state;
        FetchLabel.Visible = state;
    }

    private void InitializeComputerList()
    {
        Cart = ShoppingCart.Current;
        if (Cart == null)
        {
            Upload.Visible = false;
            UploadLabel.Visible = false;
            ListMsg.Text = "No items found in cart";
            return;
        }
        
        if (Cart.Items?.Count == 0 || Cart.Items == null)
        {
            Upload.Visible = false;
            UploadLabel.Visible = false;
            ListMsg.Text = "No items found in cart";
            return;
        }

        double total = 0;
        int count = 1;
        foreach (Computer comp in Cart.Items)
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

        ComputerList.Items.Cast<ListItem>().Where(li => li.Selected).ToList().Clear();

        foreach (string id in selectedIds)
        {
            Cart.Items.RemoveAll(c => c.ID == id);
        }

        Session[Constants.CART] = Cart;
        Session[Constants.CART_COUNT] = Cart.Items.Count;

        Server.Transfer("OrderSummary.aspx");
    }

    protected void Upload_Click(object sender, EventArgs e)
    {
        string customerId = Session[Constants.CUSTOMER_ID] as string;
        if (string.IsNullOrEmpty(customerId))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Invalid Customer Id", "alert('Could not find a valid customer id.');", true);
            return;
        }
        SqlHandler.RemoveExistingOrders(customerId);

        foreach(ListItem item in ComputerList.Items)
        {
            string[] price = item.Text.Split('$');
            SqlHandler.UploadCustomerOrder(item.Text, price[price.Length-1], customerId);
        }
        Server.Transfer("OrderSummary.aspx");

        ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Upload successful');", true);
        
    }

    protected void Fetch_Click(object sender, EventArgs e)
    {
        double result = 0;
        if (string.IsNullOrEmpty(PriceTotal.Text))
        {
            Double.TryParse(PriceTotal.Text, out result);
        }
        string user = Session[Constants.LOGIN_USER] as string;
        if (string.IsNullOrEmpty(user))
        {
            ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('No user account found at this time.');", true);
            return;
        }

        var list = SqlHandler.FetchCustomerOrders(user);
        if(list != null)
        {
            ComputerList.Items.Clear();
            ShoppingCart cart = ShoppingCart.Current;
            cart.Items = new List<Computer>();

            double total = 0;
            foreach(var item in list)
            {
                double value;
                string[] price = item.Item1.Split('$');
                string priceVal = price[price.Length - 1];
                Double.TryParse(priceVal, out value);
                string name = price[0].Substring(3, price[0].IndexOf('-') - 3);

                Computer comp = new Computer()
                {
                    Price = value,
                    Name = name,
                    ID = item.Item2
                };
                cart.Items.Add(comp);

                total += value;
            }

            CartCount.Text = cart.Items.Count.ToString();
            Session[Constants.CART_COUNT] = cart.Items.Count;
            Session[Constants.CART] = cart;

            PriceTotal.Text = total.ToString("C");
        }
        else
        {
            ClientScript.RegisterStartupScript(this.GetType(), "Empty Order List", "alert('There are no orders available');", true);
        }
        Server.Transfer("OrderSummary.aspx");
    }
}