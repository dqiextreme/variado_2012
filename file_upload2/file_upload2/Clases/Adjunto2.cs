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
public class Adjunto2
{
    public int ID { get; set; }
    public string Archivo { get; set; }
    public string Ruta { get; set; }
        
    public Adjunto2()
    {
            
    }

        //agregar referencia "System.Data.Linq" en agregar refencia al proyecto para pode rusar sqlmethods
        //Requerido para cualquier funcion que retorne algun valor
        private Adjunto2(Models.Adjunto pTicket)
        {
            ID = pTicket.ID;
            Ruta = pTicket.Ruta;
            Archivo = pTicket.Archivo;
        }

        //INSER INTO
        public void Guardar(string Varch)
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                using (var oTransactionScope = new TransactionScope())
                {
                    var oTicket = new Models.Adjunto
                    {
                        Archivo = Varch,
                        Ruta = "~/UploadBooks/Attachments/" + Varch
                    };
                    oBdSdcEntidades.Adjunto.Add(oTicket);
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
                var oTicket = oBdSdcEntidades.Adjunto.Count(x => x.Archivo == "nuevo-1.docx");
                return oTicket;
            }
        }
      
        //SELECT SOLO UN REGISTRO COMPLETO
        public static Adjunto2 Selec()
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var oTicket = oBdSdcEntidades.Adjunto.First(x => x.ID == 4);
                return oTicket != null ? new Adjunto2(oTicket) : null;
            }
        }

        //SELECT MULTIPLES REGISTROS
        public static IEnumerable<Adjunto2> ObtenerTodos(int val)
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var res = oBdSdcEntidades.Adjunto.Where(x => x.ID >= val).ToList().
                    Select(x => new Adjunto2(x)).ToList();
                return res;
            }
        }

        //obtener todos los registro a partir de un id
        public static IEnumerable<Adjunto2> contar2(int id)
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                var res = oBdSdcEntidades.Adjunto.Where(x => x.ID >= id).ToList().
                    Select(x => new Adjunto2(x)).ToList();
                return res;
            }
        }

        //SELECT OBTENER UN SOLO VALOR "CAMPO"
        public static int contarlike()
        {
            using (var oBdSdcEntidades = new test_linqsql1Entities())
            {
                //var query2 = Program.db_all.view_test_4.Where(result => SqlMethods.Like(result.nombre, "%"+za+"%"));
                var oTicket = oBdSdcEntidades.Adjunto.Count(x => x.Ruta.Contains("nuevo"));
                return oTicket;
            }
        }


        public static Adjunto2 ObtenerArchivoAdjunto(int pArchivoId)
        {
            ////clase generica.cs
            var test1 = Clases.generica.Gen_ticket2();
            //var res3 = test1.ToList();
            //var res4 = res3.Where(x => x.TicketArchivoAdjuntoId > val).ToList().Select(x => new TicketArchivoAdjunto2(x)).ToList();
            var gen = test1.ToList();
            var oArchivoAdjunto = gen.SingleOrDefault(x => x.ID == pArchivoId);
            var oArchivoAdjunto2 = test1.SingleOrDefault(x => x.ID == pArchivoId);
            return oArchivoAdjunto != null ? new Adjunto2(oArchivoAdjunto) : null;
            
            
            //using (var oBdSdcEntidades = new test_linqsql1Entities())
            //{
            //    var oArchivoAdjunto = oBdSdcEntidades.Adjunto.SingleOrDefault(x => x.ID == pArchivoId); 
            //    return oArchivoAdjunto != null ? new Adjunto2(oArchivoAdjunto) : null;
            //}
        }




        //public static FilePathResult ObtenerArchivo(int pArchivoId)
        //{
        //    var oArchivoAdjunto = Clases.ArchivoAdjunto.ObtenerArchivoAdjunto(pArchivoId);
        //    return new FilePathResult(oArchivoAdjunto.Url, oArchivoAdjunto.Tipo);
        //}

        //public static ArchivoAdjunto ObtenerArchivoAdjunto(int pArchivoId)
        //{
        //    using (var oBdSdcEntidades = new BdSdcEntidades())
        //    {
        //        var oArchivoAdjunto =
        //            oBdSdcEntidades.ArchivoAdjunto.SingleOrDefault(x => x.ArchivoId == pArchivoId);
        //        return oArchivoAdjunto != null ? new ArchivoAdjunto(oArchivoAdjunto) : null;
        //    }
        //}

    }
}

