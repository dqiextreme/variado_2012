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
    
    public partial class Cliente
    {
        public Cliente()
        {
            this.CategoriaPorCliente = new HashSet<CategoriaPorCliente>();
            this.DetalleGrupoEmpresa = new HashSet<DetalleGrupoEmpresa>();
            this.FormatoPorCliente = new HashSet<FormatoPorCliente>();
            this.ServicioPorCliente = new HashSet<ServicioPorCliente>();
            this.Usuario = new HashSet<Usuario>();
        }
    
        public int ClienteId { get; set; }
        public string Descripcion { get; set; }
    
        public virtual ICollection<CategoriaPorCliente> CategoriaPorCliente { get; set; }
        public virtual ICollection<DetalleGrupoEmpresa> DetalleGrupoEmpresa { get; set; }
        public virtual ICollection<FormatoPorCliente> FormatoPorCliente { get; set; }
        public virtual ICollection<ServicioPorCliente> ServicioPorCliente { get; set; }
        public virtual ICollection<Usuario> Usuario { get; set; }
    }
}
