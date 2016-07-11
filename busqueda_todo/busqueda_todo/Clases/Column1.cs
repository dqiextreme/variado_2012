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
public class Column1
{
    public string COLUMN_NAME { get; set; }
    public string DATA_TYPE { get; set; }
    public Nullable<int> ORDINAL_POSITION { get; set; }
        
    public Column1()
    {
            
    }

        //agregar referencia "System.Data.Linq" en agregar refencia al proyecto para pode rusar sqlmethods
        //Requerido para cualquier funcion que retorne algun valor
        //private Column1(Models.Adjunto pTicket)
        private Column1(Models.STEP_COLUMN_Result pTicket)
        {
            COLUMN_NAME = pTicket.COLUMN_NAME;
            DATA_TYPE = pTicket.DATA_TYPE;
            ORDINAL_POSITION = pTicket.ORDINAL_POSITION;
        }

        //SELECT OBTENER UN SOLO VALOR "CAMPO"
        public static int contar(string col1)
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var oTicket = oBdSdcEntidades.STEP_COLUMN(col1).Count();
                return oTicket;
            }
        }

        //SELECT SOLO UN REGISTRO COMPLETO
        public static Column1 Selec(string col1)
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                //var oTicket = oBdSdcEntidades.Adjunto.First(x => x.ID == 4);
                var oTicket = oBdSdcEntidades.STEP_COLUMN(col1).First();
                return oTicket != null ? new Column1(oTicket) : null;
            }
        }

        ////SELECT MULTIPLES REGISTROS
        //public static IEnumerable<Column1> ObtenerTodos(int val)
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var res = oBdSdcEntidades.Adjunto.Where(x => x.ID >= val).ToList().
        //            Select(x => new Column1(x)).ToList();
        //        return res;
        //    }
        //}

        ////obtener todos los registro a partir de un id
        //public static IEnumerable<Column1> contar2(int id)
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var res = oBdSdcEntidades.Adjunto.Where(x => x.ID >= id).ToList().
        //            Select(x => new Column1(x)).ToList();
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


        //public static Column1 ObtenerArchivoAdjunto(int pArchivoId)
        //{
        //    using (var oBdSdcEntidades = new test_linqsql1Entities())
        //    {
        //        var oArchivoAdjunto = oBdSdcEntidades.Adjunto.SingleOrDefault(x => x.ID == pArchivoId); 
        //        return oArchivoAdjunto != null ? new Column1(oArchivoAdjunto) : null;
        //    }
        //}
    }
}

