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
    
    public partial class Problema
    {
        public Problema()
        {
            this.AccionPorProblema = new HashSet<AccionPorProblema>();
            this.ArchivoAccion = new HashSet<ArchivoAccion>();
            this.ArchivoCausa = new HashSet<ArchivoCausa>();
            this.CausaPorProblema = new HashSet<CausaPorProblema>();
            this.RecursoPorProblema = new HashSet<RecursoPorProblema>();
            this.ServicioPorProblema = new HashSet<ServicioPorProblema>();
        }
    
        public int ProblemaId { get; set; }
        public string Titulo { get; set; }
        public int UsuarioId { get; set; }
        public int SubcategoriaId { get; set; }
        public int ImpactoId { get; set; }
        public int FrecuenciaId { get; set; }
        public int PrioridadSubcategoriaId { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public System.DateTime FechaEsperadaSolucion { get; set; }
        public string Solucion { get; set; }
        public Nullable<System.DateTime> FechaRealSolucion { get; set; }
    
        public virtual ICollection<AccionPorProblema> AccionPorProblema { get; set; }
        public virtual ICollection<ArchivoAccion> ArchivoAccion { get; set; }
        public virtual ICollection<ArchivoCausa> ArchivoCausa { get; set; }
        public virtual ICollection<CausaPorProblema> CausaPorProblema { get; set; }
        public virtual Frecuencia Frecuencia { get; set; }
        public virtual Impacto Impacto { get; set; }
        public virtual PrioridadPorSubcategoria PrioridadPorSubcategoria { get; set; }
        public virtual Subcategoria Subcategoria { get; set; }
        public virtual Usuario Usuario { get; set; }
        public virtual ICollection<RecursoPorProblema> RecursoPorProblema { get; set; }
        public virtual ICollection<ServicioPorProblema> ServicioPorProblema { get; set; }
    }
}
