namespace ECommerce_Fabrics.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initDb : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Name = c.String(),
                        Description = c.String(),
                        category_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Categories", t => t.category_Id)
                .Index(t => t.category_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Products", "category_Id", "dbo.Categories");
            DropIndex("dbo.Products", new[] { "category_Id" });
            DropTable("dbo.Products");
            DropTable("dbo.Categories");
        }
    }
}
