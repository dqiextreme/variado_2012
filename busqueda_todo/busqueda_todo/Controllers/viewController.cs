using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace busqueda_todo.Controllers
{
    public class viewController : Controller
    {
        //
        // GET: /view/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult frm_login()
        {
            return View();
        }

        public ActionResult frm_redireccionar_()
        {
            return View();
        }


    }
}
