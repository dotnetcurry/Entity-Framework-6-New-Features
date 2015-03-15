namespace A3_EF6_Ext.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<A3_EF6_Ext.Models.EXTEDMX>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "A3_EF6_Ext.Models.EXTEDMX";
        }

        protected override void Seed(A3_EF6_Ext.Models.EXTEDMX context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
