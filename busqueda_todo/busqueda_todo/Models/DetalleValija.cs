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
    
    public partial class DetalleValija
    {
        public int DetalleId { get; set; }
        public int ValijaId { get; set; }
        public string Descripcion { get; set; }
        public bool Recibido { get; set; }
    
        public virtual Valija Valija { get; set; }
    }
}
