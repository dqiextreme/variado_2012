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
    
    public partial class Valija
    {
        public Valija()
        {
            this.DetalleValija = new HashSet<DetalleValija>();
        }
    
        public int ValijaId { get; set; }
        public int UsuarioIdDe { get; set; }
        public int UsuarioIdPara { get; set; }
        public Nullable<System.DateTime> FechaEnviada { get; set; }
        public Nullable<System.DateTime> FechaRecibida { get; set; }
        public bool Recibida { get; set; }
        public bool Enviada { get; set; }
    
        public virtual ICollection<DetalleValija> DetalleValija { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual Usuario Usuario1 { get; set; }
    }
}