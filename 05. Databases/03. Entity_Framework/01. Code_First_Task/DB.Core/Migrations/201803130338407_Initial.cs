namespace DB.Core.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        AddressText = c.String(),
                        TownID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Towns", t => t.TownID)
                .Index(t => t.TownID);
            
            CreateTable(
                "dbo.Towns",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ManagerID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.ManagerID)
                .Index(t => t.ManagerID);
            
            CreateTable(
                "dbo.Employees",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                        JobTitle = c.String(),
                        Salary = c.Decimal(precision: 18, scale: 2),
                        AddressID = c.Int(),
                        DepartmentID = c.Int(),
                        ManagerID = c.Int(),
                        HireDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)  
                .ForeignKey("dbo.Addresses", t => t.AddressID)
                .ForeignKey("dbo.Departments", t => t.DepartmentID)
                .ForeignKey("dbo.Employees", t => t.ManagerID)
                .Index(t => t.AddressID)
                .Index(t => t.DepartmentID)
                .Index(t => t.ManagerID);
            
            CreateTable(
                "dbo.EmployeesProjects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        EmployeeID = c.Int(),
                        ProjectID = c.Int(),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.EmployeeID)
                .ForeignKey("dbo.Projects", t => t.ProjectID)
                .Index(t => t.EmployeeID)
                .Index(t => t.ProjectID);
            
            CreateTable(
                "dbo.Projects",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.EmployeesProjects", "ProjectID", "dbo.Projects");
            DropForeignKey("dbo.EmployeesProjects", "EmployeeID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "ManagerID", "dbo.Employees");
            DropForeignKey("dbo.Employees", "DepartmentID", "dbo.Departments");
            DropForeignKey("dbo.Employees", "AddressID", "dbo.Addresses");
            DropForeignKey("dbo.Addresses", "TownID", "dbo.Towns");
            DropIndex("dbo.EmployeesProjects", new[] { "ProjectID" });
            DropIndex("dbo.EmployeesProjects", new[] { "EmployeeID" });
            DropIndex("dbo.Employees", new[] { "ManagerID" });
            DropIndex("dbo.Employees", new[] { "DepartmentID" });
            DropIndex("dbo.Employees", new[] { "AddressID" });
            DropIndex("dbo.Addresses", new[] { "TownID" });
            DropTable("dbo.Projects");
            DropTable("dbo.EmployeesProjects");
            DropTable("dbo.Employees");
            DropTable("dbo.Departments");
            DropTable("dbo.Towns");
            DropTable("dbo.Addresses");
        }
    }
}
