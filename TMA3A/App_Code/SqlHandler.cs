using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for SqlHandler
/// </summary>
public class SqlHandler
{
    private const string ConnStr = "Database=tma3a; Data Source =tma3a-dtoth.mysql.database.azure.com; User Id = dtoth@tma3a-dtoth; Password=Servertma3a";

    public static List<Photo> GetPhotosFromDb()
    {
        try
        {
            var photos = new List<Photo>();
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var query = "SELECT * FROM slideshow";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                        photos.Add(new Photo(reader.GetInt32("ID"), reader.GetString("Url"),
                            reader.GetString("Description")));

                }
            }
            return photos;
        }
        catch (MySqlException e)
        {
            throw new Exception("Unable to connect to SQL database");
        }
        catch (Exception e)
        {
            throw new Exception("Unsuccessful query for photos in SQL database.");
        }
    }

    public SqlHandler()
    {
        
    }

}