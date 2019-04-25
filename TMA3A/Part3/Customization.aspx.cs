using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part3_Customization : System.Web.UI.Page
{
    Computer CurrentComputer;

    protected void Page_Load(object sender, EventArgs e)
    {
        var count = Session[Constants.CART_COUNT];
        CartCount.Text = count == null ? string.Empty : count.ToString();
        CurrentComputer = Session["Computer"] as Computer;

        if (CurrentComputer != null && !IsPostBack)
        {
            InitializePartsList();
            compLabel.Text = CurrentComputer.Name;
            price.Text = GetCurrentPrice().ToString("C");
            ComputerImg.ImageUrl = CurrentComputer.ImgUrl;
            PopulateComputerList();
        }

        // Determine and set the selected computer's default options
        if (CurrentComputer == null && !IsPostBack)
        {
            SetupSelectedComputer();
            PopulateComputerList();
        }
        
    }

    private void PopulateComputerList()
    {
        computerList.Items.Add(new ListItem("--Select One--"));
        computerList.Items.Add(new ListItem(Constants.DefaultComputers[Constants.MacbookPro].Name) + " - " + Constants.DefaultComputers[Constants.MacbookPro].Price);
        computerList.Items.Add(new ListItem(Constants.DefaultComputers[Constants.HPNotebook].Name) + " - " + Constants.DefaultComputers[Constants.HPNotebook].Price);
        computerList.Items.Add(new ListItem(Constants.DefaultComputers[Constants.SurfacePro].Name) + " - " + Constants.DefaultComputers[Constants.SurfacePro].Price);
    }

    private void SetupSelectedComputer()
    {
        HttpCookie cookie = Response.Cookies[Constants.COMPUTER_COOKIE];
        string compName = cookie?.Value;


        switch (compName) {
            case (Constants.HPNotebook):
                CurrentComputer = Constants.DefaultComputers[Constants.HPNotebook];
                break;
            case Constants.SurfacePro:
                CurrentComputer = Constants.DefaultComputers[Constants.SurfacePro];
                break;
            case Constants.MacbookPro:
                CurrentComputer = Constants.DefaultComputers[Constants.MacbookPro];
                break;
            default:
                CurrentComputer = Constants.DefaultComputers[Constants.HPNotebook];
                break;
        }

        Session["Computer"] = CurrentComputer;

        if (CurrentComputer != null)
        {
            InitializePartsList();
            compLabel.Text = CurrentComputer.Name;
            price.Text = GetCurrentPrice().ToString("C");
            ComputerImg.ImageUrl = CurrentComputer.ImgUrl;
        }

    }

    private double GetCurrentPrice()
    {
        double sum = 0;

        sum += FindListValue(selectCpu.SelectedValue);
        sum += FindListValue(selectDisplay.SelectedValue);
        sum += FindListValue(selectOs.SelectedValue);
        sum += FindListValue(selectHd.SelectedValue);
        sum += FindListValue(selectRam.SelectedValue);

        return sum;
    }

    private double FindListValue(string value)
    {
        return Double.Parse(value);
    }

    private void InitializePartsList()
    {
        SetDropDown(selectCpu, CurrentComputer.CPU, CpuLabel);
        SetDropDown(selectRam, CurrentComputer.RAM, RamLabel);
        SetDropDown(selectDisplay, CurrentComputer.Display, displayLabel);
        SetDropDown(selectHd, CurrentComputer.HardDrive, HdLabel);
        SetDropDown(selectOs, CurrentComputer.OS, OsLabel);
    }

    private void SetDropDown(DropDownList list, Part part, Label label)
    {
        list.ClearSelection();
        list.SelectedIndex = list.Items.IndexOf(list.Items.FindByText(part.Name));
        label.Text = Convert.ToDecimal(list.SelectedValue).ToString("C");
    }

    protected void selectDisplay_SelectedIndexChanged(object sender, EventArgs e)
    {
        if(sender is DropDownList list)
        {
            // Set the new total price
            price.Text = GetCurrentPrice().ToString("C");
            CurrentComputer.Price = GetCurrentPrice();

            // Set new computer part to our current computer object and set the text on the dropdown
            //CurrentComputer = new Computer();
            switch (list.ClientID)
            {
                case Constants.SelectCpu:
                    CurrentComputer.CPU = 
                        new Part(list.SelectedItem.Text, Constants.ImageDictionary[list.SelectedItem.Text], FindListValue(list.SelectedValue));
                    SetDropDown(selectCpu, CurrentComputer.CPU, CpuLabel);
                    break;
                case Constants.SelectDisplay:
                    CurrentComputer.Display =
                        new Part(list.SelectedItem.Text, Constants.ImageDictionary[list.SelectedItem.Text], FindListValue(list.SelectedValue));
                    SetDropDown(selectDisplay, CurrentComputer.Display, displayLabel);
                    break;
                case Constants.SelectHd:
                    CurrentComputer.HardDrive =
                        new Part(list.SelectedItem.Text, Constants.ImageDictionary[list.SelectedItem.Text], FindListValue(list.SelectedValue));
                    SetDropDown(selectHd, CurrentComputer.HardDrive, HdLabel);
                    break;
                case Constants.SelectOs:
                    CurrentComputer.OS =
                        new Part(list.SelectedItem.Text, Constants.ImageDictionary[list.SelectedItem.Text], FindListValue(list.SelectedValue));
                    SetDropDown(selectOs, CurrentComputer.OS, OsLabel);
                    break;
                case Constants.SelectRam:
                    CurrentComputer.RAM =
                        new Part(list.SelectedItem.Text, Constants.ImageDictionary[list.SelectedItem.Text], FindListValue(list.SelectedValue));
                    SetDropDown(selectRam, CurrentComputer.RAM, RamLabel);
                    break;
            }

            Session["Computer"] = CurrentComputer;
        }
    }

    protected void cartBtn_Click(object sender, EventArgs e)
    {
        Computer comp = new Computer()
        {
            Price = CurrentComputer.Price,
            CPU = CurrentComputer.CPU,
            RAM = CurrentComputer.RAM,
            Display = CurrentComputer.Display,
            HardDrive = CurrentComputer.HardDrive,
            ImgUrl = CurrentComputer.ImgUrl,
            Name = CurrentComputer.Name,
            OS = CurrentComputer.OS,
            ID = Guid.NewGuid().ToString()
        };
           
        comp.Price = GetCurrentPrice();

        ShoppingCart cart = ShoppingCart.Current;
        if (cart.Items == null)
            cart.Items = new List<Computer>();
        cart.Items.Add(comp);

        CartCount.Text = cart.Items.Count.ToString();
        Session[Constants.CART_COUNT] = cart.Items.Count;
        Session[Constants.CART] = cart;
      
        Server.Transfer("OrderSummary.aspx", false);
    }

    protected void computerList_SelectedIndexChanged(object sender, EventArgs e)
    {
        if (sender is DropDownList list)
        {
            if (list.SelectedItem.Text.StartsWith(Constants.MacbookPro))
                SetSelectedComputerCookie(Constants.DefaultComputers[Constants.MacbookPro]);
            if (list.SelectedItem.Text.StartsWith(Constants.HPNotebook))
                SetSelectedComputerCookie(Constants.DefaultComputers[Constants.HPNotebook]);
            if (list.SelectedItem.Text.StartsWith(Constants.SurfacePro))
                SetSelectedComputerCookie(Constants.DefaultComputers[Constants.SurfacePro]);
        }

        Response.Redirect("Customization.aspx");
    }

    private void SetSelectedComputerCookie(Computer computer)
    {
        // Create the new computer computer based on the selected default computer
        HttpCookie cookie = Request.Cookies[Constants.COMPUTER_COOKIE] ?? CreateNewComputerCookie();
        cookie.Value = computer.Name;
        Response.Cookies.Add(cookie);
        Session["Computer"] = computer;
    }

    private HttpCookie CreateNewComputerCookie()
    {
        HttpCookie cookie = new HttpCookie(Constants.COMPUTER_COOKIE);
        cookie.Expires = DateTime.Now.AddDays(30);
        cookie.Value = string.Empty;
        Response.Cookies.Add(cookie);

        return cookie;
    }
}