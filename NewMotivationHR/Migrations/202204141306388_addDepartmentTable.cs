namespace NewMotivationHR.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addDepartmentTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Departments",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        ParentId = c.Int(nullable: false),
                        IsMain = c.Boolean(nullable: false),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Departments");
        }
    }
}
