using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using busqueda_todo.Clases;
using busqueda_todo.Models;
using WebMatrix.WebData;


namespace busqueda_todo.Controllers
{
    public class FileUploadCController : Controller
    {
        //
        // GET: /FileUploadC/
        public int todown { get; set; }
        public int todown2 { get; set; }
        
        public string resuel;
        public int num = 0;
        public int num2 = 0;
        public string[] archivos = new string[500];


        public ActionResult view1()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";

            return View();
        }
        public ActionResult SubidaNueva()
        {
            var oTicket2 = new Clases.TicketArchivoAdjunto2();

            HttpPostedFileBase FileUpload1 = Request.Files[0];
            if (FileUpload1 != null && FileUpload1.ContentLength > 0)
            {
                string fileextention = System.IO.Path.GetExtension(FileUpload1.FileName);
                if (fileextention == ".doc" || fileextention == ".docx" || fileextention == ".xls" || fileextention == ".xlsx" || fileextention == ".txt" || fileextention == ".pdf")
                {
                    var nTicket = new Random().Next(100000);
                    
                    var test = (Clases.TicketArchivoAdjunto2.Last1().TicketId)+111;
                    FileUpload1.SaveAs(Server.MapPath("~/UploadBooks/" + test + FileUpload1.FileName.ToString()));
                    oTicket2.Guardar(Convert.ToInt32(test), test + FileUpload1.FileName.ToString());
                }else{return Content("El Archivo debe ser .doc .docx .xls .xlsx .txt .pdf");}
            }
            return Content("Archivos subidos correctamente");
        }
        //archivos[archivos.Count(x => x != null) + 1] = FileUpload1.FileName + "-" + num2;

        public FilePathResult Download(int id)
        {
            var arch = Clases.Adjunto2.ObtenerArchivoAdjunto(id);
            return File(arch.Ruta.Trim(), "application/octet-stream", arch.Archivo.Trim());
        }

        public FilePathResult Download2(int id)
        {
            var arch = Clases.TicketArchivoAdjunto2.ObtenerArchivoAdjunto(id);
            return File(arch.Url.Trim(), "application/octet-stream", arch.Descripcion.Trim());
        }



        public ActionResult Download22(int id)
        {
            List<dynamic> resultRows = new List<dynamic>();
            resultRows.Add(new Clases.Adjunto2 { ID = 1, Ruta = "ruta", Archivo = "arch" });
            resultRows.Add(new Clases.Adjunto2 { ID = 2, Ruta = "ruta2", Archivo = "arch2" });

            List<dynamic> lisdyn = new List<dynamic>();
            lisdyn.Add(new { todown = 1, todown2 = 5 });
            lisdyn.Add(new { todown = 2, todown2 = 4 });
            lisdyn.Add(new { todown = 3, todown2 = 3 });
            lisdyn.Add(new { todown = 4, todown2 = 2 });
            lisdyn.Add(new { todown = 5, todown2 = 1 });

            var a1 = id;
            return Content(a1.ToString());

        }

        public ActionResult Download23(int id)
        {
            var arch = Clases.TicketArchivoAdjunto2.ObtenerArchivoAdjunto2(id);
            var lista = new List<string>();
            foreach (var item in arch)
            {
                var a1 = item.TicketArchivoAdjuntoId.ToString().Trim();
                lista.Add(a1);
            }
             string[] listo = lista.ToArray();
            return null;
        }


        public ActionResult Download24(int id, string id2)
        {

            var arch = Clases.TicketArchivoAdjunto2.ObtenerArchivoAdjunto2(id);
            var lista = new List<string>();
            foreach (var item in arch)
            {
                var a1 = item.TicketArchivoAdjuntoId.ToString().Trim();
                lista.Add(a1);
            }
            string[] listo = lista.ToArray();

            return Json(listo, JsonRequestBehavior.AllowGet);
        }

        public class oModel
        {
            //public string FirstName { get; set; }
            //public string LastName { get; set; }
            public int Id { get; set; }
            public string Archivo { get; set; }
            
        }

        [HttpPost] //maneja correctamente el JSON desde jquery ajax
        public JsonResult Download666(oModel contactInfo)
        {
            var a = contactInfo.Id;
            var b = contactInfo.Archivo;

            var arch = Clases.TicketArchivoAdjunto2.ObtenerArchivoAdjunto2(a);
            var lista = new List<string>();
            foreach (var item in arch)
            {
                var a1 = item.TicketArchivoAdjuntoId.ToString().Trim();
                lista.Add(a1);
            }
            string[] listo = lista.ToArray();

            return Json(listo, JsonRequestBehavior.AllowGet);
        }



       public JsonResult Dow_Aut_Arch_Adj(oModel datos)
        {
            var arch = Clases.TicketArchivoAdjunto2.SelecWhere(datos.Id);
            var lista = new List<string>();
            foreach (var item in arch)
            {
                var a1 = item.TicketArchivoAdjuntoId.ToString().Trim();
                lista.Add(a1);
            }
            return Json(lista, JsonRequestBehavior.AllowGet);
        }




       public JsonResult json1(oModel datos)
       {
           var arch = Clases.result1.ObtenerTodos2a(datos.Archivo);
           var lista = new List<dynamic>();
           lista = arch.ToList();
           return Json(lista, JsonRequestBehavior.AllowGet);
       }
    }
}
