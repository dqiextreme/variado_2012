using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.SqlClient;
using System.Transactions;
using busqueda_todo.Models;

using System.Web.Mvc;
using System.Data;





namespace busqueda_todo.Clases
{
public class test21
{
    public string TABLE_NAME { get; set; }
    public string COLUMN_NAME { get; set; }
    public string DATA_TYPE { get; set; }
    public Nullable<Int32> ORDINAL_POSITION { get; set; }
    
        
    public test21()
    {
            
    }

        private test21(Models.STEP_1_Result pTicket)
        {
            TABLE_NAME = pTicket.TABLE_NAME;
            COLUMN_NAME = pTicket.COLUMN_NAME;
            DATA_TYPE = pTicket.DATA_TYPE;
            ORDINAL_POSITION = pTicket.ORDINAL_POSITION;
        }

        public static IList<Models.Ticket> prueba1()
        {
            using (var oBdSdcEntidades = new SCIBDEntities())
            {
                var test = oBdSdcEntidades.Ticket.ToList();
                return test;
            }
        }
        
        public static IList<int> prueba2()
        {
            using (var oBdSdcEntidades = new SCIBDEntities())
            {
                var test = oBdSdcEntidades.Ticket.Select(x => x.UsuarioId).ToList();
                return test;
            }
        }

        public static string prueba3()
        {

            using (var oBdSdcEntidades = new SCIBDEntities())
            {
                var test2 = "";
                if (oBdSdcEntidades.Ticket.Select(x => x.UsuarioId).ToList().Contains(58))
                {
                    test2 = oBdSdcEntidades.Ticket.Count(x => x.UsuarioId == 58).ToString();
                }  
                return test2;
            }
        }

    }
}

