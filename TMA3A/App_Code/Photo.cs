using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Photo
/// </summary>
public class Photo
{
    public int Id { get; set; }
    public string Url { get; set; }
    public string Description { get; set; }

    public Photo(int id, string url, string description)
    {
        Id = id;
        Url = url;
        Description = description;
    }
}