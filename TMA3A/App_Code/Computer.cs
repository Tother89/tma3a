using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Computer
/// </summary>
public class Computer : Parts
{
    public string Name { get; set; }
    public string ImgUrl { get; set; }
    public double Price { get; set; }
    public string ID { get; set; }

    public int CpuId { get; set; }
    public int DriveId { get; set; }
    public int DisplayId { get; set; }
    public int RamId { get; set; }
    public int OsId { get; set; }

    public Computer()

    {
    

    }
}