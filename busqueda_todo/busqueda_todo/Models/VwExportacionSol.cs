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
    
    public partial class VwExportacionSol
    {
        public byte Estado { get; set; }
        public string Administrador { get; set; }
        public string Cliente { get; set; }
        public int SolicitudId { get; set; }
        public string Asunto { get; set; }
        public string Prioridad { get; set; }
        public Nullable<decimal> TiempoMaximoSolucion { get; set; }
        public Nullable<decimal> MinsTransAten { get; set; }
        public Nullable<decimal> MinsTransSol { get; set; }
        public string Solicitante { get; set; }
        public string Explicacion { get; set; }
        public System.DateTime Fecha { get; set; }
        public Nullable<decimal> MinutosPausado { get; set; }
        public Nullable<int> AdministradorId { get; set; }
        public Nullable<System.DateTime> FechaCerrado { get; set; }
        public Nullable<int> PrioridadId { get; set; }
        public int ClienteId { get; set; }
        public string Descripcion { get; set; }
        public string Asignador { get; set; }
    }
}