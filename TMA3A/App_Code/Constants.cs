using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Keep track of useful strings
/// </summary>
public static class Constants
{
    public static string LOGIN_COOKIE = "LoginCookie";
    public static string LOGIN_USER = "User";

    public static string COMPUTER_COOKIE = "CompCookie";
    public static string COMPUTER_NAME = "Computer";

    public static string CART_COOKIE = "CartCookie";
    public static string CART = "Cart";
    public static string CART_COUNT = "Cart_Count";

    public const string SurfacePro = "Surface Pro";
    public const string MacbookPro = "Macbook Pro";
    public const string HPNotebook = "HP Notebook";

    public const string Display = "Display";
    public const string Drive = "Drive";
    public const string RAM = "RAM";
    public const string CPU = "CPU";
    public const string OS = "OS";

    public const string SelectCpu = "selectCpu";
    public const string SelectRam = "selectRam";
    public const string SelectOs = "selectOs";
    public const string SelectHd = "selectHd";
    public const string SelectDisplay = "selectDisplay";

    public const string SurfaceProUrl = "../Images/Computers/surfacepro.png";
    public const string MacbookProUrl = "../Images/Computers/macbook.png";
    public const string HPNotebookUrl = "../Images/Computers/hp.png";

    public static Dictionary<string, Computer> DefaultComputers = new Dictionary<string, Computer>()
    {
        { SurfacePro, new Computer {Name = SurfacePro, ImgUrl = SurfaceProUrl, Price = 628.67,
            CPU = new Part("Intel i5", "../Images/Parts/amd7.png", 259.99),
            Display = new Part("Acer 27 in. 75Hz", "../Images/Parts/acer27.png", 189.99),
            HardDrive = new Part("HDD 2TB","../Images/Parts/hdd2tb.png", 84.99),
            OS = new Part("Windows 10 Home", "../Images/Parts/win10.png", 38.71),
            RAM = new Part("8 GB", "../Images/Parts/ram8gb.png", 54.99)}
        },
        { MacbookPro, new Computer {Name = MacbookPro, ImgUrl = MacbookProUrl, Price = 1252.95,
            CPU = new Part("Intel i7", "../Images/Parts/i7.png", 479.99),
            Display = new Part("BenQ 24 in. 144 Hz", "../Images/Parts/benq24.png", 189.99),
            HardDrive = new Part("SSD 1TB","../Images/Parts/ssd1tb.png", 199.99),
            OS = new Part("Mac OS X 10.6 Snow Leopard", "../Images/Parts/macos.png", 38.71),
            RAM = new Part("32 GB", "../Images/Parts/ram32gb.png", 284.99)}
        },
        { HPNotebook, new Computer {Name = HPNotebook, ImgUrl = HPNotebookUrl, Price = 534.32,
            CPU = new Part("AMD Ryzen 3", "../Images/Parts/i7.png", 259.99),
            Display = new Part("Dell 24 in. 60 Hz", "../Images/Parts/dell24.png", 189.99),
            HardDrive = new Part("SSD 500GB","../Images/Parts/ssd500gb.png", 129.99),
            OS = new Part("Windows 7 Home Premium", "../Images/Parts/win7.png", 19.36),
            RAM = new Part("16 GB", "../Images/Parts/ram16gb.png", 119.99)}
        }
    };

    public static Dictionary<string, string> ImageDictionary = new Dictionary<string, string>()
    {
        { "Acer 27 in. 75Hz",  "../Images/Parts/acer27.png" },
        { "BenQ 24 in. 144 Hz" , "../Images/Parts/benq24.png"} ,
        { "Dell 24 in. 60 Hz", "../Images/Parts/dell24.png" },
        { "HDD 500GB", "../Images/Parts/hdd500gb.png" },
        { "HDD 1TB", "../Images/Parts/hdd1tb.png" },
        { "HDD 2TB", "../Images/Parts/hdd2tb.png" },
        { "SSD 256GB", "../Images/Parts/ssd256gb.png" },
        { "SSD 500GB", "../Images/Parts/ssd500gb.png" },
        { "SSD 1TB", "../Images/Parts/ssd1tb.png" },
        { "4 GB", "../Images/Parts/ram4gb.png" },
        { "8 GB", "../Images/Parts/ram8gb.png" },
        { "16 GB", "../Images/Parts/ram16.png" },
        { "32 GB", "../Images/Parts/ram32.png" },
        { "AMD Ryzen 3", "../Images/Parts/amd3.png" },
        { "AMD Ryzen 5", "../Images/Parts/amd5.png" },
        { "AMD Ryzen 7", "../Images/Parts/amd7.png" },
        { "Intel i3", "../Images/Parts/i3.png" },
        { "Intel i5", "../Images/Parts/i5.png" },
        { "Intel i7", "../Images/Parts/i7.png" },
        { "Windows 7 Home Premium", "../Images/Parts/win7.png" },
        { "Mac OS X 10.6 Snow Leopard", "../Images/Parts/macOS.png" },
        { "Windows 10 Home", "..Images/Parts/win10.png" },
    };
}