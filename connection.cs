using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
/// <summary>
/// Summary description for connection
/// </summary>
public class connection
{
    SqlConnection cn;
    SqlCommand cm;
    SqlDataReader dr;
    public connection()
    {
        cn = new SqlConnection();
        string ss;
        ss = AppDomain.CurrentDomain.BaseDirectory;
        cn.ConnectionString = "Data Source=.\\SQLEXPRESS;AttachDbFilename=" + ss + "productdata.mdf;Integrated Security=True;Connect Timeout=30;User Instance=True";
        cn.Open();
    }
    public void insert(String s)
    {

        cn.Close();
        cn.Open();
        cm = new SqlCommand(s, cn);
        cm.ExecuteNonQuery();

    }
    public SqlDataReader disp(String s)
    {
        cn.Close();
        cn.Open();
        cm = new SqlCommand(s, cn);
        dr = cm.ExecuteReader();
        return (dr);
    }
}