using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for ShoppingCart
/// </summary>
public class ShoppingCart
{
    public List<Computer> Items { get; set; }

    public static ShoppingCart Current
    {
        get
        {
            var cart = HttpContext.Current.Session[Constants.CART] as ShoppingCart;
            if(cart  == null)
            {
                cart = new ShoppingCart();
                HttpContext.Current.Session[Constants.CART] = cart;
            }

            return cart;
        }
        

    }
}