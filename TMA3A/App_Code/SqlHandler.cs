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

    public static bool DoesCustomerExist(string user)
    {
        try
        {
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var query = "SELECT ID FROM accounts WHERE Username = @user";
                           

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    using (var reader = cmd.ExecuteReader())
                        return reader.Read();
                }
            }
        }
        catch (MySqlException e)
        {
            throw new Exception("Unable to connect to SQL database");
        }
        catch (Exception e)
        {
            throw new Exception("Unsuccessful query for customer in SQL database.");
        }
    }

    public static bool ValidateCredentials(string user, string password)
    {
        try
        {
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var query = "SELECT * FROM accounts WHERE Username = @user AND Password = @password";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@password", password);
                    using (var reader = cmd.ExecuteReader())
                        return reader.Read();
                }
            }
        }
        catch (MySqlException e)
        {
            throw new Exception("Unable to connect to SQL database");
        }
        catch (Exception e)
        {
            throw new Exception("Unsuccessful query for customer in SQL database.");
        }
    }

    public SqlHandler()
    {
        
    }

    public static void CreateNewCustomer(string user, string password)
    {
        try
        {
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var query = "INSERT INTO accounts (Username, Password) VALUES(@user, @password)";

                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@password", password);

                    var reader = cmd.ExecuteNonQuery();
                    if (reader != 1)
                        throw new Exception();
                }
            }
        }
        catch (MySqlException e)
        {
            throw new Exception("Unable to connect to SQL database");
        }
        catch (Exception e)
        {
            throw new Exception("Unsuccessful query to create User in SQL database.");
        }
    }

    public static List<Computer> FetchDefaultComputers()
    {
        try
        {
            var computers = new List<Computer>();
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var query = "SELECT * FROM computers";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Computer newComp = new Computer()
                        {
                            Name = reader.GetString("Title"),
                            ImgUrl = reader.GetString("ImageUrl"),
                            Price = reader.GetDouble("Price"),
                            CpuId = reader.GetInt32("CpuId"),
                            DriveId = reader.GetInt32("DriveId"),
                            DisplayId = reader.GetInt32("DisplayId"),
                            RamId = reader.GetInt32("RamId"),
                            OsId = reader.GetInt32("OsId")
                        };

                        computers.Add(newComp);
                    }
                }
            }
            return computers;
        }
        catch (MySqlException e)
        {
            throw new Exception("Unable to connect to SQL database");
        }
        catch (Exception e)
        {
            throw new Exception("Unsuccessful query for customer in SQL database.");
        }
    }


    public static List<Part> FetchPartsList()
    {
        try
        {
            var parts = new List<Part>();
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var query = "SELECT * FROM parts";
                using (var cmd = new MySqlCommand(query, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        Part newPart = new Part(reader.GetString("Name"), reader.GetString("ImageUrl"), reader.GetDouble("Price"))
                        {
                            Id = reader.GetInt32("Id"),
                            Category = reader.GetString("PartType")
                        };

                        parts.Add(newPart);
                    }
                }
            }
            return parts;
        }
        catch (MySqlException e)
        {
            throw new Exception("Unable to connect to SQL database");
        }
        catch (Exception e)
        {
            throw new Exception("Unsuccessful query for customer in SQL database.");
        }
    }

    public static string FetchPartImage(string name)
    {
        try
        {
            var parts = new List<Part>();
            using (var conn = new MySqlConnection(ConnStr))
            {
                conn.Open();
                var query = "SELECT ImageUrl FROM parts WHERE Name = @name";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@name", name);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader.GetString("ImageUrl");
                        }
                    }
                }
            }
            return string.Empty;
        }
        catch (MySqlException e)
        {
            throw new Exception("Unable to connect to SQL database");
        }
        catch (Exception e)
        {
            throw new Exception("Unsuccessful query for customer in SQL database.");
        }
    }
}