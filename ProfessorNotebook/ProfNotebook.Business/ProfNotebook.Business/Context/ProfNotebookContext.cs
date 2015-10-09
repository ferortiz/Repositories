using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Devtalk.EF.CodeFirst;
using ProfNotebook.Business.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace ProfNotebook.Business.Context
{
    public class ProfNotebookContext : DbContext
    {
        public ProfNotebookContext()
            : base("ProfNotebookContext")
        {
        }

        public DbSet<Proffesor> Proffesor {get; set;}

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configure Code First to ignore PluralizingTableName convention 
            // If you keep this convention then the generated tables will have pluralized names. 
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}