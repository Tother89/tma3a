using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Part
/// </summary>
public class Part
{
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public double Price { get; set; }

    public Part(string name, string url, double price)
    {
        Name = name;
        ImgUrl = url;
        Price = price;
    }
}