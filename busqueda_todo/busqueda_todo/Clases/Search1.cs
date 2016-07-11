using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Transactions;
using busqueda_todo.Models;

using System.Web.Mvc;

namespace busqueda_todo.Clases
{
public class Search1
{
    public string TABLE_NAME { get; set; }
    public string COLUMN_NAME { get; set; }
    public string DATA_TYPE { get; set; }
    public Nullable<int> ORDINAL_POSITION { get; set; }
        
    public Search1()
    {
            
    }

        
        //SELECT OBTENER UN SOLO VALOR "CAMPO"
        public static int contar(string vTab, string vCam, string vVal)
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var oTicket = oBdSdcEntidades.STEP_search(vTab, vCam, vVal);
                return oTicket;
            }
        }

        //SELECT MULTIPLES REGISTROS
        //public static IEnumerable<Search1> ObtenerTodos(string vTab, string vCam, string vVal)
        public static void ObtenerTodos(string vTab, string vCam, string vVal)
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var res = oBdSdcEntidades.STEP_search(vTab, vCam, vVal);
                //return res;
            }
        }

        ////obtener todos los registro a partir de un id
        //public static IEnumerable<Search1> contar2(int id)
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var res = oBdSdcEntidades.Adjunto.Where(x => x.ID >= id).ToList().
        //            Select(x => new Search1(x)).ToList();
        //        return res;
        //    }
        //}

        ////SELECT OBTENER UN SOLO VALOR "CAMPO"
        //public static int contarlike()
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        //var query2 = Program.db_all.view_test_4.Where(result => SqlMethods.Like(result.nombre, "%"+za+"%"));
        //        var oTicket = oBdSdcEntidades.Adjunto.Count(x => x.Ruta.Contains("nuevo"));
        //        return oTicket;
        //    }
        //}


        //public static Search1 ObtenerArchivoAdjunto(int pArchivoId)
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var oArchivoAdjunto = oBdSdcEntidades.Adjunto.SingleOrDefault(x => x.ID == pArchivoId); 
        //        return oArchivoAdjunto != null ? new Search1(oArchivoAdjunto) : null;
        //    }
        //}
    }
}

