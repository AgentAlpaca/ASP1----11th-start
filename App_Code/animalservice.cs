using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography.X509Certificates;
using System.Xml.Linq;

/// <summary>
/// Summary description for animalservice
/// </summary>
public class animalservice
{
    protected OleDbConnection myconnection;
    public animalservice()
    {//יצירת עצם של חיבור
        string connectionstring = Connect.GetConnectionString();
        myconnection = new OleDbConnection(connectionstring);
    }
    public DataSet getAnimals()
    {   //select * from animals equivalent  
        OleDbCommand myCmd = new OleDbCommand("select1", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;

        OleDbDataAdapter adapter = new OleDbDataAdapter();
        adapter.SelectCommand = myCmd;
        DataSet dataset = new DataSet();

        try
        {
            myconnection.Open();
            adapter.Fill(dataset, "Animals");
            dataset.Tables["Animals"].PrimaryKey = new DataColumn[] { dataset.Tables["Animals"].Columns["num"] };
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            myconnection.Close();
        }
        return dataset;
    }
    public void addAnimals(string name, string family)
    {
        OleDbCommand myCmd = new OleDbCommand("insert1", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter objParam;
        objParam = myCmd.Parameters.Add("@name", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = name;
        objParam = myCmd.Parameters.Add("@family", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = family;

       try
        {
            myconnection.Open();
            int n = myCmd.ExecuteNonQuery();
        }
        catch(Exception ex)
        {
            throw ex;
        }
        finally
        {
            myconnection.Close();
        }

    }
    public void deleteAnimals(int num)
    {
        OleDbCommand myCmd = new OleDbCommand("delete1", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter objParam;
        objParam = myCmd.Parameters.Add("@num", OleDbType.Integer);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = num;

       try
        {
            myconnection.Open();
            int n = myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            myconnection.Close();
        }
        
    }
    public void addAnimals(string name, string family, int age, string picture)
    {
        OleDbCommand myCmd = new OleDbCommand("insert1", myconnection);
        myCmd.CommandType = CommandType.StoredProcedure;

        OleDbParameter objParam;
        objParam = myCmd.Parameters.Add("@name", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = name;
        objParam = myCmd.Parameters.Add("@family", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = family;
        objParam = myCmd.Parameters.Add("@age", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = age;
        objParam = myCmd.Parameters.Add("@picture", OleDbType.BSTR);
        objParam.Direction = ParameterDirection.Input;
        objParam.Value = picture;
        try
        {
            myconnection.Open();
            int n = myCmd.ExecuteNonQuery();
        }
        catch (Exception ex)
        {
            throw ex;
        }
        finally
        {
            myconnection.Close();
        }
    }
}