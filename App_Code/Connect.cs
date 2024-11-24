using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.OleDb;

/// <summary>
/// Summary description for Connect
/// </summary>
public class Connect
{
    const string FILE_NAME = "zooo.mdb";
    public static string GetConnectionString()
    {
        string location = HttpContext.Current.Server.MapPath("~/App_Data/" + FILE_NAME);
        string connectionString = @"Provider=Microsoft.Ace.OLEDB.12.0; data source=" + location;
        return connectionString;
    }
}