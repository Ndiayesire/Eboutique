namespace EBoutique.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EBoutique.Models.bdBoutiqueContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled =true;
            AutomaticMigrationDataLossAllowed =false;
        }

        protected override void Seed(EBoutique.Models.bdBoutiqueContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
