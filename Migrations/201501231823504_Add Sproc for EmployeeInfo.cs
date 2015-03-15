namespace A3_EF6_Ext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddSprocforEmployeeInfo : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.EmployeeInfo_Insert",
                p => new
                    {
                        EmpName = p.String(),
                        Salary = p.Decimal(precision: 18, scale: 2),
                        DeptName = p.String(),
                        Designation = p.String(),
                    },
                body:
                    @"INSERT [dbo].[EmployeeInfoes]([EmpName], [Salary], [DeptName], [Designation])
                      VALUES (@EmpName, @Salary, @DeptName, @Designation)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[EmployeeInfoes]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[EmployeeInfoes] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.EmployeeInfo_Update",
                p => new
                    {
                        Id = p.Int(),
                        EmpName = p.String(),
                        Salary = p.Decimal(precision: 18, scale: 2),
                        DeptName = p.String(),
                        Designation = p.String(),
                    },
                body:
                    @"UPDATE [dbo].[EmployeeInfoes]
                      SET [EmpName] = @EmpName, [Salary] = @Salary, [DeptName] = @DeptName, [Designation] = @Designation
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.EmployeeInfo_Delete",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[EmployeeInfoes]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.EmployeeInfo_Delete");
            DropStoredProcedure("dbo.EmployeeInfo_Update");
            DropStoredProcedure("dbo.EmployeeInfo_Insert");
        }
    }
}
