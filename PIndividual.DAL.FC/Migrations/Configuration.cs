namespace PIndividual.DAL.FC.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<PIndividual.DAL.FC.DBContextCF>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false; // esto lo que hace es que no valida cada que inicia el sistema que está migrando 
            ContextKey = "PIndividual.DAL.FC.DBContextCF";
        }

        protected override void Seed(PIndividual.DAL.FC.DBContextCF context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
