﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mvc_test3.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class test_linqsql1Entities3 : DbContext
    {
        public test_linqsql1Entities3()
            : base("name=test_linqsql1Entities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Employees> Employees { get; set; }
    
        public virtual ObjectResult<SP_Emplo1_Result> SP_Emplo1(Nullable<int> valor)
        {
            var valorParameter = valor.HasValue ?
                new ObjectParameter("valor", valor) :
                new ObjectParameter("valor", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SP_Emplo1_Result>("SP_Emplo1", valorParameter);
        }
    }
}