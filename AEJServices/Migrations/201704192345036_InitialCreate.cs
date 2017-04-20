namespace AEJServices.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        Company_Name = c.String(),
                        Contact_Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                    })
                .PrimaryKey(t => t.CustomerId);
            
            CreateTable(
                "dbo.Order",
                c => new
                    {
                        OrderId = c.Int(nullable: false, identity: true),
                        Employee_Id = c.Int(nullable: false),
                        Product_Id = c.Int(nullable: false),
                        PO_Number = c.Int(nullable: false),
                        Quantity = c.Int(nullable: false),
                        Customer_CustomerId = c.Int(),
                        Employee_EmployeeId = c.Int(),
                    })
                .PrimaryKey(t => t.OrderId)
                .ForeignKey("dbo.Customer", t => t.Customer_CustomerId)
                .ForeignKey("dbo.Employee", t => t.Employee_EmployeeId)
                .Index(t => t.Customer_CustomerId)
                .Index(t => t.Employee_EmployeeId);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        First_Name = c.String(),
                        Last_Name = c.String(),
                        Email = c.String(),
                        Phone = c.String(),
                        PTO = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
            CreateTable(
                "dbo.Product",
                c => new
                    {
                        ProductId = c.Int(nullable: false),
                        Description = c.String(),
                        Available = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ProductId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Order", "Employee_EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.Order", "Customer_CustomerId", "dbo.Customer");
            DropIndex("dbo.Order", new[] { "Employee_EmployeeId" });
            DropIndex("dbo.Order", new[] { "Customer_CustomerId" });
            DropTable("dbo.Product");
            DropTable("dbo.Employee");
            DropTable("dbo.Order");
            DropTable("dbo.Customer");
        }
    }
}
