//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace busqueda_todo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ServicioPorProblema
    {
        public int DetalleId { get; set; }
        public int ProblemaId { get; set; }
        public int ServicioPorClienteId { get; set; }
    
        public virtual Problema Problema { get; set; }
        public virtual ServicioPorCliente ServicioPorCliente { get; set; }
    }
}
