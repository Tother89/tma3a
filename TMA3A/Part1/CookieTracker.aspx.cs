using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Part1_Default : System.Web.UI.Page
{
    private const string VisitCookie = "visits";
    private HttpCookie Cookie = new HttpCookie("Cookie")
    {
        Expires = DateTime.MaxValue
    };
    private static int VisitCounter = 0;

    protected void Page_Load(object sender, EventArgs e)
    {
        //Page has been loaded so increase the visit count
        ReadCookie();
        IncreaseVisitCounter();

        //Set the ip address
        SetIpAddress();

        //Find and set the time zone
        SetTimeZone();
    }

    public void IncreaseVisitCounter()
    {
        VisitCounter++;
        Cookie.Values.Add(VisitCookie, VisitCounter.ToString());
        VisitLabel.Text = VisitCounter.ToString();
    }

    public int ReadCookie()
    {
        if(Cookie == null)
        {
            return 0;
        }

        if (!string.IsNullOrEmpty(Cookie.Values["visits"]))
        {
            int result;
            Int32.TryParse(Cookie.Values["visits"], out result);

            VisitCounter = result;
            return result;
        }

        return 0;
    }

    //https://www.c-sharpcorner.com/article/get-ip-address-in-Asp-Net/
    private void SetIpAddress()
    {
        string userip = Request.UserHostAddress;
        if (Request.UserHostAddress != null)
        {
            Int64 macinfo = new Int64();
            string macSrc = macinfo.ToString("X");
            if (macSrc == "0")
            {
                if (userip == "127.0.0.1")
                {
                    Response.Write("visited Localhost!");
                }
                else
                {
                    IpLabel.Text = userip;
                }
            }
        }
    }

    private void SetTimeZone()
    {
        TimeZone zone = TimeZone.CurrentTimeZone;

        ZoneLabel.Text = zone.StandardName;
    }
}