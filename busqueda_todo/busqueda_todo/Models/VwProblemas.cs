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
    
    public partial class VwProblemas
    {
        public int ProblemaId { get; set; }
        public int ClienteId { get; set; }
        public int UsuarioId { get; set; }
        public int CategoriaId { get; set; }
        public int SubcategoriaId { get; set; }
        public int PrioridadSubcategoriaId { get; set; }
        public int FrecuenciaId { get; set; }
        public int ImpactoId { get; set; }
        public string Cliente { get; set; }
        public string Usuario { get; set; }
        public string Categoria { get; set; }
        public string Subcategoria { get; set; }
        public string Prioridad { get; set; }
        public string ColorRgb { get; set; }
        public string Frecuencia { get; set; }
        public string Impacto { get; set; }
        public string Titulo { get; set; }
        public System.DateTime FechaRegistro { get; set; }
        public System.DateTime FechaEsperadaSolucion { get; set; }
        public Nullable<System.DateTime> FechaRealSolucion { get; set; }
        public string Solucion { get; set; }
    }
}
