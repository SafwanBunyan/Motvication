namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Add_Transportation_table : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transportations",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Employee_id = c.Int(nullable: false),
                        MonthOfAcount = c.Int(nullable: false),
                        EarningWork = c.Int(nullable: false),
                        AbsenceDays = c.Int(nullable: false),
                        Discount = c.Int(nullable: false),
                        NetSalary = c.Int(nullable: false),
                        DateOfEnteriy = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Employees", t => t.Employee_id, cascadeDelete: true)
                .Index(t => t.Employee_id);
            
            AddColumn("dbo.Employees", "section", c => c.String());
            AddColumn("dbo.Employees", "Transportation", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Transportations", "Employee_id", "dbo.Employees");
            DropIndex("dbo.Transportations", new[] { "Employee_id" });
            DropColumn("dbo.Employees", "Transportation");
            DropColumn("dbo.Employees", "section");
            DropTable("dbo.Transportations");
        }
    }
}
