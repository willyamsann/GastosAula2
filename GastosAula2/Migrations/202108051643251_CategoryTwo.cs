namespace GastosAula2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CategoryTwo : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Categoria",
                c => new
                    {
                        IdCategory = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.IdCategory);
            
            AddColumn("dbo.Gasto", "CategoriaId", c => c.Int(nullable: false));
            CreateIndex("dbo.Gasto", "CategoriaId");
            AddForeignKey("dbo.Gasto", "CategoriaId", "dbo.Categoria", "IdCategory", cascadeDelete: false);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Gasto", "CategoriaId", "dbo.Categoria");
            DropIndex("dbo.Gasto", new[] { "CategoriaId" });
            DropColumn("dbo.Gasto", "CategoriaId");
            DropTable("dbo.Categoria");
        }
    }
}
