using System;
using System.Collections.Generic;
using System.Linq;
using EjercitoPractica1.Models;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;



namespace EjercitoPractica1.DAL
{

    public class EjercitoContext: DbContext
    {

        public EjercitoContext() : base("")
        {
        }

        public DbSet<Artilleria> artilleros { get; set; }
       

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}