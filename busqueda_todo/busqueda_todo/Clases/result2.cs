using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Transactions;
using busqueda_todo.Models;

using System.Web.Mvc;
using System.Data;

using MySql.Data.MySqlClient;
using MySql;



namespace busqueda_todo.Clases
{
public class result2
{
    public string TABLE_NAME { get; set; }
    public string COLUMN_NAME { get; set; }
    public string DATA_TYPE { get; set; }
    public Nullable<int> ORDINAL_POSITION { get; set; }
    
        
    public result2()
    {
            
    }

    public static string DB2 = "SCIBD";

    public static string SV2 = "192.168.1.42";

    public static string SE2 = "User ID=AppBDSDC;Password=AppBDSDC**;";


        private result2(Models.STEP_1_Result pTicket)
        {
            TABLE_NAME = pTicket.TABLE_NAME;
            COLUMN_NAME = pTicket.COLUMN_NAME;
            DATA_TYPE = pTicket.DATA_TYPE;
            ORDINAL_POSITION = pTicket.ORDINAL_POSITION;
        }

        //public static IList<dynamic> ObtenerTodos2a(string vVal)
        //{
        //    var lista = ObtenerTodosSqlExt();
        //    var lista2 = new List<dynamic>();
        //    foreach (var item in lista)
        //    {
        //        string a = GetUniversities21(item.TABLE_NAME.ToString(), item.COLUMN_NAME.ToString(), vVal);
        //        if (a != null)
        //        {
        //            lista2.Add(GetUniversities21(item.TABLE_NAME.ToString(), item.COLUMN_NAME.ToString(), vVal));
        //        }
        //    }
        //    return lista2;
        //}


        //public static IEnumerable<dynamic> ObtenerTodos2(string vVal)
        //{
        //    var lista = ObtenerTodosSqlExt();
        //    var lista2 = new List<string>();
        //    foreach (var item in lista)
        //    {
        //        string a = GetUniversities21(item.TABLE_NAME.ToString(), item.COLUMN_NAME.ToString(), vVal);
        //        if (a != null)
        //        {
        //            lista2.Add(GetUniversities21(item.TABLE_NAME.ToString(), item.COLUMN_NAME.ToString(), vVal));
        //        }
        //    }
        //    return lista2;
        //}

        ////SELECT MULTIPLES REGISTROS WITH SQL DIRECT
        public static IEnumerable<result2> ObtenerTodosSql()
        {
            var lista3 = new List<result2>();
            string srtQry = "SELECT DISTINCT(TABLE_NAME) FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_SCHEMA = 'sunahipdb'";
            string connString = @"Server=200.11.150.3;Database=sunahipdb;Uid=snlyf;Pwd=joec@2107;";
            //<add name="BdSdcSecurity" connectionString="server=192.168.1.42;database=SCIBD;User ID=AppBDSDC;Password=AppBDSDC**;" providerName="System.Data.SqlClient" />
            //SqlConnection conn = new SqlConnection(connString);
            MySqlConnection conn = new MySqlConnection(connString);
            try
            {
                conn.Open();
                //SqlCommand command = new SqlCommand(srtQry, conn);
                //SqlDataReader reader = (command.ExecuteReader());

                MySqlCommand command = new MySqlCommand(srtQry, conn);
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    lista3.Add(new result2
                    {
                        TABLE_NAME = reader.GetString(0),
                        COLUMN_NAME = reader.GetString(1),
                        DATA_TYPE = reader.GetString(2),
                        ORDINAL_POSITION = reader.GetInt32(3),
                    });
                }
                conn.Close();
            }
            catch (Exception)
            {

            }
            
            
            return lista3;
        }

        ////SELECT MULTIPLES REGISTROS WITH SQL DIRECT
        //public static IEnumerable<result2> ObtenerTodosSqlExt()
        //{
        //    var lista3 = new List<result2>();
        //    string srtQry = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, ORDINAL_POSITION FROM " + DB2 + ".INFORMATION_SCHEMA.COLUMNS ORDER BY TABLE_NAME, ORDINAL_POSITION";
        //    string connString = @"Data Source=" + SV2 + ";Initial Catalog=" + DB2 + ";" + SE2;
        //    SqlConnection conn = new SqlConnection(connString);
        //    conn.Open();
        //    SqlCommand command = new SqlCommand(srtQry, conn);
        //    SqlDataReader reader = (command.ExecuteReader());
        //    while (reader.Read())
        //    {
        //        lista3.Add(new result2
        //        {
        //            TABLE_NAME = reader.GetString(0),
        //            COLUMN_NAME = reader.GetString(1),
        //            DATA_TYPE = reader.GetString(2),
        //            ORDINAL_POSITION = reader.GetInt32(3),
        //        });
        //    }
        //    conn.Close();
        //    return lista3;
        //}

        //public static string GetUniversities2(string vTab, string vCam, string vVal)
        //{
        //    dynamic a = null;

        //    string srtQry = "Select count(*) From " + vTab + " Where CAST(" + vCam + " as nvarchar) = CAST('" + vVal + "' as nvarchar)";
        //    string connString = @"Data Source=(localdb)\PRUEBAS;Initial Catalog=test_linqsql1;Integrated Security=True";
        //    SqlConnection conn = new SqlConnection(connString);
        //    conn.Open();
        //    SqlCommand command = new SqlCommand(srtQry, conn);
        //    SqlDataReader reader = (command.ExecuteReader());
        //    while (reader.Read()) { a = reader.GetInt32(0); }
        //    if (a == 0)
        //    {
        //        a = null;
        //    }
        //    else
        //    {
        //        a = srtQry;
        //    }
        //    conn.Close();
        //    return a;
        //}

        //public static string GetUniversities21(string vTab, string vCam, string vVal)
        //{
        //    dynamic a = null;

        //    string srtQry = "Select count(*) From [" + DB2 + "].[dbo].[" + vTab + "] Where CAST([" + DB2 + "].[dbo].[" + vTab + "].[" + vCam + "] as nvarchar) = CAST('" + vVal + "' as nvarchar)";
        //    string connString = @"Data Source=" + SV2 + ";Initial Catalog=" + DB2 + ";"+SE2;
        //    SqlConnection conn = new SqlConnection(connString);
        //    conn.Open();
        //    SqlCommand command = new SqlCommand(srtQry, conn);
        //    try
        //    {
        //        SqlDataReader reader = (command.ExecuteReader());
        //        while (reader.Read()) { a = reader.GetInt32(0); }
        //        if (a == 0)
        //        {
        //            a = null;
        //        }
        //        else
        //        {
        //            a = "Select * From [" + DB2 + "].[dbo].[" + vTab + "] Where CAST([" + DB2 + "].[dbo].[" + vTab + "].[" + vCam + "] as nvarchar) = CAST('" + vVal + "' as nvarchar)"; ;
        //        }
        //    }
        //    catch (Exception)
        //    {

        //    }
            
        //    conn.Close();
        //    return a;
        //}

    
    }
}

