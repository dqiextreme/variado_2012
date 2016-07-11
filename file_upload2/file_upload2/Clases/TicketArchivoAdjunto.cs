using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Transactions;
using file_upload2.Models;
                                
using System.Web.Mvc;

namespace file_upload2.Clases
{
    public class TicketArchivoAdjunto2
    {
        public decimal TicketArchivoAdjuntoId { get; set; }
        public int TicketId { get; set; }
        public string Descripcion { get; set; }
        public string Url { get; set; }

        public TicketArchivoAdjunto2()
        {
        }

        //agregar referencia "System.Data.Linq" en agregar refencia al proyecto para pode rusar sqlmethods
        //Requerido para cualquier funcion que retorne algun valor
        private TicketArchivoAdjunto2(Models.TicketArchivoAdjunto pTicket)//pasar
        {
            TicketArchivoAdjuntoId = pTicket.TicketArchivoAdjuntoId;
            TicketId = pTicket.TicketId;
            Descripcion = pTicket.Descripcion;
            Url = pTicket.Url;
        }
        
        //INSER INTO
        public void Guardar(int Tid, string Tdesc)//pasar
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                using (var oTransactionScope = new TransactionScope())
                {
                    var oTicket = new Models.TicketArchivoAdjunto
                    {
                        TicketId = Tid,
                        Descripcion = Tdesc,
                        Url = "~/UploadBooks/Attachments/" + Tdesc
                    };
                    oBdSdcEntidades.TicketArchivoAdjunto.Add(oTicket);
                    oBdSdcEntidades.SaveChanges();
                    oTransactionScope.Complete();
                }
            }
        }

        //SELECT OBTENER UN SOLO VALOR "CAMPO"
        public static int contar()
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var oTicket = oBdSdcEntidades.TicketArchivoAdjunto.Count(x => x.TicketArchivoAdjuntoId >= 1);
                return oTicket;
            }
        }

        ////entidad publica
        //public static test_linqsql1Entities prueba1()
        //{
        //    test_linqsql1Entities ent2 = new test_linqsql1Entities();
        //    return ent2;
        //}

        //public datos para busquedas
        public static IList<TicketArchivoAdjunto> prueba2()
        {
            test_linqsql1Entities ent2 = new test_linqsql1Entities();
            var a = ent2.TicketArchivoAdjunto.ToList();
            return a;
        }

     
        //SELECT * FROM WHERE
        public static IEnumerable<TicketArchivoAdjunto2> SelecWhere(int val)//pasar//contar2
        {
            ////clase generica.cs
            //var test1 = Clases.generica.Gen_ticket1();
            //var res3 = test1.ToList();
            //var res4 = res3.Where(x => x.TicketArchivoAdjuntoId > val).ToList().Select(x => new TicketArchivoAdjunto2(x)).ToList();

            ////llamo la funcion interna prueba2
            //var res2 = prueba2().Where(x => x.TicketArchivoAdjuntoId > val).ToList().Select(x => new TicketArchivoAdjunto2(x)).ToList();
            
            //elimino el uso del using entities(){}
            test_linqsql1Entities ent = new test_linqsql1Entities();
            var res = ent.TicketArchivoAdjunto.Where(x => x.TicketArchivoAdjuntoId > val).ToList().Select(x => new TicketArchivoAdjunto2(x)).ToList();
            
            return res;
            //using (var oBdSdcEntidades = new test_linqsql1Entities())
            //{
            //    var res = oBdSdcEntidades.TicketArchivoAdjunto.Where(x => x.TicketArchivoAdjuntoId > val).ToList().
            //            Select(x => new TicketArchivoAdjunto2(x)).ToList();
            //    return res;
            //}
        }

        //SELECT * FROM all
        public static IEnumerable<TicketArchivoAdjunto2> SelecA()
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                //con este obtengo todos los registros
                //entity.table.ToList().Select(x => new nombre_clase(x)).ToList();
                var res = oBdSdcEntidades.TicketArchivoAdjunto.ToList().Select(x => new TicketArchivoAdjunto2(x)).ToList();
                return res;
            }
        }

        //SELECT TOP 1 * FROM WHERE DESC
        public static TicketArchivoAdjunto2 Sel_1_Whe_Desc(int pTicketId)//pasar
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var oTicket =
                    oBdSdcEntidades.TicketArchivoAdjunto.OrderByDescending(x => x.TicketArchivoAdjuntoId).Take(1).SingleOrDefault(x => x.TicketId == pTicketId);
                return oTicket != null ? new TicketArchivoAdjunto2(oTicket) : null;
            }
        }

        //SELECT TOP 1 * DESC 
        public static TicketArchivoAdjunto2 Last1()//pasar
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var oTicket = oBdSdcEntidades.TicketArchivoAdjunto.OrderByDescending(x => x.TicketArchivoAdjuntoId).Take(1).SingleOrDefault();
                if (oTicket == null)//en caso de que sea null le envio uno en blanco de esta forma
                {
                    oTicket = new Models.TicketArchivoAdjunto
                    {
                        Descripcion = "",
                        TicketArchivoAdjuntoId = 0,
                        TicketId = 0,
                        Url = ""
                    }; 
                }
                return oTicket != null ? new TicketArchivoAdjunto2(oTicket) : null;
            }
        }


        public static TicketArchivoAdjunto2 ObtenerArchivoAdjunto(int pArchivoId)//pasar
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var oArchivoAdjunto = oBdSdcEntidades.TicketArchivoAdjunto.SingleOrDefault(x => x.TicketArchivoAdjuntoId == pArchivoId);
                return oArchivoAdjunto != null ? new TicketArchivoAdjunto2(oArchivoAdjunto) : null;
            }
        }

        //SELECT * FROM WHERE
        public static IEnumerable<TicketArchivoAdjunto2> ObtenerArchivoAdjunto2(int val)//pasar//contar2
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var res = oBdSdcEntidades.TicketArchivoAdjunto.Where(x => x.TicketId == val).ToList().
                        Select(x => new TicketArchivoAdjunto2(x)).ToList();
                return res;
            }
        }
        
        public static bool contien()
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var oTicket = oBdSdcEntidades.TicketArchivoAdjunto.Select(x=>x.Descripcion.Contains("111"));
                return true;
            }
        }
    }
}

