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
    public class generica
    {
        //public datos para busquedas
        public static IList<TicketArchivoAdjunto> Gen_ticket1()
        {
            test_linqsql1Entities ent2 = new test_linqsql1Entities();
            var a = ent2.TicketArchivoAdjunto.ToList();
            return a;
        }

        //public datos para busquedas
        public static IList<Adjunto> Gen_ticket2()
        {
            test_linqsql1Entities ent2 = new test_linqsql1Entities();
            var a = ent2.Adjunto.ToList();
            return a;
        }

     
    }
}

