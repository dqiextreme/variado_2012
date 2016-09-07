using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace test_postgresql.clases
{
    class Master_List
    {
        public static string conexion = string.Format("Server=localhost;Port=5432;User Id=Joec;Password=joec2107;Database=Test_Psql1;");
        public NpgsqlConnection conn2 = new NpgsqlConnection(conexion);
        public NpgsqlDataAdapter psqlad;

        //-SELECT---------------------------------------------------------------------------

        public List<System.Data.DataRow> psql_select()
        {
            DataSet ds = new DataSet();
            string tabl = "Test1";
            string query = "SELECT * FROM " + tabl + "";
            psqlad = new NpgsqlDataAdapter(query, conn2);
            psqlad.Fill(ds);
            return ds.Tables[0].AsEnumerable().ToList();
        }
        
        public DataSet psql_select_DS(string tabl)
        {
            DataSet ds = new DataSet();
            string query = "SELECT * FROM " + tabl;
            psqlad = new NpgsqlDataAdapter(query, conn2);
            psqlad.Fill(ds);
            return ds;
        }

        //----------------------------------------------------------------------------


        //-INSERT---------------------------------------------------------------------------

        //string tabl = "Test1";
        //val = "(1,'newval1'),(2,'newval2')"
        public bool psql_insert(string tabl, string val)
        {
            string query = "INSERT INTO " + tabl + " VALUES " + val;
            conn2.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn2);
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn2.Close();
            return true;
        }






        //string tabl = "Test1";
        //string query = "INSERT INTO \"" + tabl + "\" VALUES (1,'newval1'),(2,'newval2')";

        public void psql_query(string query)
        {
            conn2.Open();

            NpgsqlCommand cmd = new NpgsqlCommand(query, conn2);

            cmd.ExecuteNonQuery(); cmd.Dispose(); conn2.Close();
        }

        //----------------------------------------------------------------------------

        

        //----------------------------------------------------------------------------

        public void psql_insert_parametros()
        {
            string tabl = "Test1";
            string query = "INSERT INTO " + tabl + " VALUES (@id,@texto)";

            conn2.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn2; cmd.CommandText = query; cmd.CommandType = CommandType.Text;

            cmd.Parameters.Add(new NpgsqlParameter("@id", 7));
            cmd.Parameters.Add(new NpgsqlParameter("@texto", "newval7"));

            cmd.ExecuteNonQuery(); cmd.Dispose(); conn2.Close();
        }

        //----------------------------------------------------------------------------

        

        public int psql_count(string tabl)
        {
            int a = 0;
            conn2.Open();
            //NpgsqlCommand cmd = new NpgsqlCommand(query, conn2);
            NpgsqlCommand cmd = new NpgsqlCommand("SELECT COUNT(*) FROM "+ tabl, conn2);
            NpgsqlDataReader read1;
            read1 = cmd.ExecuteReader();
            while (read1.Read()){
                a = read1.GetInt16(0);
            }
            read1.Close(); cmd.Dispose(); conn2.Close();
            return a;
        }
    }
}
