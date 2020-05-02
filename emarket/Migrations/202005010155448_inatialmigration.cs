namespace emarket.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inatialmigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.categories",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(),
                        number_of_products = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.products",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        discription = c.String(nullable: false, maxLength: 500),
                        image = c.String(),
                        price = c.Int(nullable: false),
                       
                        Category_id = c.Int(),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.categories", t => t.Category_id)
                .Index(t => t.Category_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.products", "Category_id", "dbo.categories");
            DropIndex("dbo.products", new[] { "Category_id" });
            DropTable("dbo.products");
            DropTable("dbo.categories");
        }
    }
}
