namespace A3_EF6_Ext.Models
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class EXTEDMX : DbContext
    {
        // Your context has been configured to use a 'ExtEDMX' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'A3_EF6_Ext.Models.ExtEDMX' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ExtEDMX' 
        // connection string in the application configuration file.
        public EXTEDMX()
            : base("name=EXTEDMX")
        {
        }

        

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

          public virtual DbSet<EmployeeInfo> Employees { get; set; }

          protected override void OnModelCreating(DbModelBuilder modelBuilder)
          {
              modelBuilder.Entity<EmployeeInfo>().MapToStoredProcedures();
          }
    }

     
}