namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDepartmentTabletoRelationShipEmployee : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "DepartmentId", c => c.Int(nullable: true));
            CreateIndex("dbo.Employees", "DepartmentId");
            AddForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments", "ID", cascadeDelete: true);
            DropColumn("dbo.Employees", "section");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "section", c => c.String());
            DropForeignKey("dbo.Employees", "DepartmentId", "dbo.Departments");
            DropIndex("dbo.Employees", new[] { "DepartmentId" });
            DropColumn("dbo.Employees", "DepartmentId");
        }
    }
}
