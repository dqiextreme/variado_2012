using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Transactions;
using busqueda_todo.Models;

using System.Web.Mvc;
using System.Data;
using System.Threading.Tasks;

namespace busqueda_todo.Clases
{
public class result1
{
    public string TABLE_NAME { get; set; }
    public string COLUMN_NAME { get; set; }
    public string DATA_TYPE { get; set; }
    public Nullable<Int32> ORDINAL_POSITION { get; set; }
    
        
    public result1()
    {
            
    }
    //base de datos  @"Data Source=;Initial Catalog=;
    
    //public static string DB2 = "SCIBD";
    //public static string SV2 = @"(localdb)\PRUEBAS";
    //public static string SE2 = "Integrated Security=True";

    //public static string DB2 = "SCIBD";
    //public static string SV2 = "192.168.1.42";
    //public static string SE2 = "User ID=AppBDSDC;Password=AppBDSDC**;";

    public static string DB2 = "T3";
    public static string SV2 = "192.168.2.5";
    public static string SE2 = "User ID=devn;Password=cronssat300**;";

    public static int van1 = 0;
    


        private result1(Models.STEP_1_Result pTicket)
        {
            TABLE_NAME = pTicket.TABLE_NAME;
            COLUMN_NAME = pTicket.COLUMN_NAME;
            DATA_TYPE = pTicket.DATA_TYPE;
            ORDINAL_POSITION = pTicket.ORDINAL_POSITION;
        }

        ////SELECT OBTENER UN SOLO VALOR "CAMPO"
        //public static int contar()
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var oTicket = oBdSdcEntidades.STEP_1().Count();
        //        return oTicket;
        //    }
        //}

        ////SELECT SOLO UN REGISTRO COMPLETO
        //public static result1 Selec()
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        //var oTicket = oBdSdcEntidades.Adjunto.First(x => x.ID == 4);
        //        var oTicket = oBdSdcEntidades.STEP_1().First();
        //        return oTicket != null ? new result1(oTicket) : null;
        //    }
        //}

        ////SELECT MULTIPLES REGISTROS
        //public static IEnumerable<result1> ObtenerTodos(string val)
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var res = oBdSdcEntidades.STEP_1().Where(x => x.TABLE_NAME == val).ToList().
        //            Select(x => new result1(x)).ToList();
        //        return res;
        //    }
        //}

        //public static string gener()
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var res = oBdSdcEntidades.STEP_search("Adjunto", "ID", "1").GetType();
        //        return "hola";
        //    }
        //}

        //public static List<DataRow> GetUniversities()
        //{
        //    List<DataRow> list = null;
        //    string srtQry = "Select count(*) From TicketArchivoAdjunto Where TicketArchivoAdjuntoId = 1";
        //    //string srtQry = "if not exists(SELECT * FROM TicketArchivoAdjunto WHERE TicketArchivoAdjuntoId = 1) begin print('nahh'); end else begin print('SELECT * FROM Adjunto'); end";
        //    string connString = @"Data Source=(localdb)\PRUEBAS;Initial Catalog=test_linqsql1;Integrated Security=True";
        //    using (SqlConnection conn = new SqlConnection(connString))
        //    {
        //        //string strQry = "";
        //        using (SqlCommand objCommand = new SqlCommand(srtQry, conn))
        //        {
        //            objCommand.CommandType = CommandType.Text;
        //            DataTable dt = new DataTable();
        //            SqlDataAdapter adp = new SqlDataAdapter(objCommand);
        //            conn.Open();
        //            adp.Fill(dt);
        //            if (dt != null)
        //            {
        //                list = dt.AsEnumerable().ToList();
        //            }
        //        }
        //    }
        //    return list;
        //}

        ////SELECT MULTIPLES REGISTROS
        //public static IEnumerable<result1> ObtenerTodos3()
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var res = oBdSdcEntidades.STEP_1().ToList().
        //            Select(x => new result1(x)).ToList();
        //        return res;
        //    }
        //}

        public static IList<dynamic> ObtenerTodos2a(string vVal)
        {
            var lista = ObtenerTodosSqlExt().ToList();

                var lista2 = new List<dynamic>();
                var lista23 = new List<dynamic>();
                
                lista.ForEach(x => lista23.Add(GetUniversities21(x.TABLE_NAME.ToString(), x.COLUMN_NAME.ToString(), vVal)));
                lista23.RemoveAll(item => item == null);

            //foreach (var item in lista)
            //{
            //    string a = GetUniversities21(item.TABLE_NAME.ToString(), item.COLUMN_NAME.ToString(), vVal);
            //    if (a != null)
            //    {
            //        lista2.Add(GetUniversities21(item.TABLE_NAME.ToString(), item.COLUMN_NAME.ToString(), vVal));
            //    }
            //}

           return lista23;
        }


        public static IEnumerable<dynamic> ObtenerTodos2(string vVal)
        {
            var lista = ObtenerTodosSqlExt();
            var lista2 = new List<string>();
            foreach (var item in lista)
            {
                string a = GetUniversities21(item.TABLE_NAME.ToString(), item.COLUMN_NAME.ToString(), vVal);
                if (a != null)
                {
                    lista2.Add(GetUniversities21(item.TABLE_NAME.ToString(), item.COLUMN_NAME.ToString(), vVal));
                }
            }
            return lista2;
        }

        //SELECT MULTIPLES REGISTROS WITH SQL DIRECT
        public static IEnumerable<result1> ObtenerTodosSql()
        {
            var lista3 = new List<result1>();
            string srtQry = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, ORDINAL_POSITION FROM test_linqsql1.INFORMATION_SCHEMA.COLUMNS ORDER BY TABLE_NAME, ORDINAL_POSITION";
            string connString = @"Data Source=(localdb)\PRUEBAS;Initial Catalog=test_linqsql1;Integrated Security=True";
            //<add name="BdSdcSecurity" connectionString="server=192.168.1.42;database=SCIBD;User ID=AppBDSDC;Password=AppBDSDC**;" providerName="System.Data.SqlClient" />
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand(srtQry, conn);
            SqlDataReader reader = (command.ExecuteReader());
            while (reader.Read())
            {
                lista3.Add(new result1
                {
                    TABLE_NAME = reader.GetString(0),
                    COLUMN_NAME = reader.GetString(1),
                    DATA_TYPE = reader.GetString(2),
                    ORDINAL_POSITION = reader.GetInt32(3),
                });
            }
            conn.Close();
            return lista3;
        }

        //SELECT MULTIPLES REGISTROS WITH SQL DIRECT
        public static IEnumerable<result1> ObtenerTodosSqlExt()
        {//
            var lista3 = new List<result1>();
            //string srtQry = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, ORDINAL_POSITION FROM " + DB2 + ".INFORMATION_SCHEMA.COLUMNS ORDER BY TABLE_NAME, ORDINAL_POSITION";
            string srtQry = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, ORDINAL_POSITION FROM " + DB2 + ".INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME LIKE 'T%' ORDER BY TABLE_NAME, ORDINAL_POSITION";
            string connString = @"Data Source=" + SV2 + ";Initial Catalog=" + DB2 + ";" + SE2;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand(srtQry, conn);
            SqlDataReader reader = (command.ExecuteReader());
            van1++;
            while ((reader.Read() && (van1 <= 100) ))
            {
                van1++;
                lista3.Add(new result1
                {
                    TABLE_NAME = reader.GetString(0),
                    COLUMN_NAME = reader.GetString(1),
                    //DATA_TYPE = reader.GetString(2),
                    //ORDINAL_POSITION = reader.GetInt32(3),
                });
            }
            conn.Close();
            return lista3;
        }

        public static string GetUniversities2(string vTab, string vCam, string vVal)
        {
            dynamic a = null;

            string srtQry = "Select count(*) From " + vTab + " Where CAST(" + vCam + " as nvarchar) = CAST('" + vVal + "' as nvarchar)";
            string connString = @"Data Source=(localdb)\PRUEBAS;Initial Catalog=test_linqsql1;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand(srtQry, conn);
            SqlDataReader reader = (command.ExecuteReader());
            while (reader.Read()) { a = reader.GetInt32(0); }
            if (a == 0)
            {
                a = null;
            }
            else
            {
                a = srtQry;
            }
            conn.Close();
            return a;
        }

        public static string GetUniversities21(string vTab, string vCam, string vVal)
        {
            dynamic a = null;

            string srtQry = "Select count(*) From [" + DB2 + "].[dbo].[" + vTab + "] Where CAST([" + DB2 + "].[dbo].[" + vTab + "].[" + vCam + "] as nvarchar) = CAST('" + vVal + "' as nvarchar)";
            string connString = @"Data Source=" + SV2 + ";Initial Catalog=" + DB2 + ";"+SE2;
            SqlConnection conn = new SqlConnection(connString);
            conn.Open();
            SqlCommand command = new SqlCommand(srtQry, conn);
            try
            {
                SqlDataReader reader = (command.ExecuteReader());
                while (reader.Read()) { a = reader.GetInt32(0); }
                if (a == 0)
                {
                    a = null;
                }
                else
                {
                    a = "Select * From " + vTab + " Where CAST(" + vCam + " as nvarchar) = CAST('" + vVal + "' as nvarchar)"; ;
                }
            }
            catch (Exception)
            {

            }
            
            conn.Close();
            return a;
        }

    
    }
}

