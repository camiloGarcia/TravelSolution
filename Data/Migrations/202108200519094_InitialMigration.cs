namespace Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.autor",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombres = c.String(maxLength: 50, unicode: false),
                        apellidos = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.autor_has_libro",
                c => new
                    {
                        autor_id = c.Int(nullable: false),
                        isbn_libro = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.autor_id, t.isbn_libro });
            
            CreateTable(
                "dbo.editorial",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        nombre = c.String(maxLength: 50, unicode: false),
                        sede = c.String(maxLength: 50, unicode: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.libro",
                c => new
                    {
                        isbn = c.Int(nullable: false),
                        editorial_id = c.Int(),
                        titulo = c.String(maxLength: 50, unicode: false),
                        sinopsis = c.String(unicode: false, storeType: "text"),
                        n_paginas = c.Int(),
                    })
                .PrimaryKey(t => t.isbn)
                .ForeignKey("dbo.editorial", t => t.editorial_id)
                .Index(t => t.editorial_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.libro", "editorial_id", "dbo.editorial");
            DropIndex("dbo.libro", new[] { "editorial_id" });
            DropTable("dbo.libro");
            DropTable("dbo.editorial");
            DropTable("dbo.autor_has_libro");
            DropTable("dbo.autor");
        }
    }
}
