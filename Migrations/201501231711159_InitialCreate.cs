namespace A3_EF6_Ext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EmployeeInfoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        EmpName = c.String(),
                        Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DeptName = c.String(),
                        Designation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EmployeeInfoes");
        }
    }
}
