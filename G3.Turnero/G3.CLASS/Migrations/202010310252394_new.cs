namespace G3.CLASS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _new : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre_Apellido = c.String(nullable: false),
                        Peluquero_Pref = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Peluqueroes", t => t.Peluquero_Pref, cascadeDelete: true)
                .Index(t => t.Peluquero_Pref);
            
            CreateTable(
                "dbo.Peluqueroes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false),
                        EspejoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Espejoes", t => t.EspejoId, cascadeDelete: true)
                .Index(t => t.EspejoId);
            
            CreateTable(
                "dbo.Espejoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Dia = c.String(nullable: false),
                        Hora = c.String(nullable: false),
                        PeluqueroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Peluqueroes", t => t.PeluqueroId, cascadeDelete: true)
                .Index(t => t.PeluqueroId);
            
            CreateTable(
                "dbo.Productoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tareas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false),
                        Tiempo = c.String(nullable: false),
                        Valor = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productoes", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Turnoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DateTime = c.DateTime(nullable: false),
                        TareaId = c.Int(nullable: false),
                        ClienteId = c.Int(nullable: false),
                        PeluqueroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Clientes", t => t.ClienteId, cascadeDelete: true)
                .ForeignKey("dbo.Peluqueroes", t => t.PeluqueroId, cascadeDelete: false)
                .ForeignKey("dbo.Tareas", t => t.TareaId, cascadeDelete: true)
                .Index(t => t.TareaId)
                .Index(t => t.ClienteId)
                .Index(t => t.PeluqueroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnoes", "TareaId", "dbo.Tareas");
            DropForeignKey("dbo.Turnoes", "PeluqueroId", "dbo.Peluqueroes");
            DropForeignKey("dbo.Turnoes", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Tareas", "ProductoId", "dbo.Productoes");
            DropForeignKey("dbo.Horarios", "PeluqueroId", "dbo.Peluqueroes");
            DropForeignKey("dbo.Clientes", "Peluquero_Pref", "dbo.Peluqueroes");
            DropForeignKey("dbo.Peluqueroes", "EspejoId", "dbo.Espejoes");
            DropIndex("dbo.Turnoes", new[] { "PeluqueroId" });
            DropIndex("dbo.Turnoes", new[] { "ClienteId" });
            DropIndex("dbo.Turnoes", new[] { "TareaId" });
            DropIndex("dbo.Tareas", new[] { "ProductoId" });
            DropIndex("dbo.Horarios", new[] { "PeluqueroId" });
            DropIndex("dbo.Peluqueroes", new[] { "EspejoId" });
            DropIndex("dbo.Clientes", new[] { "Peluquero_Pref" });
            DropTable("dbo.Turnoes");
            DropTable("dbo.Tareas");
            DropTable("dbo.Productoes");
            DropTable("dbo.Horarios");
            DropTable("dbo.Espejoes");
            DropTable("dbo.Peluqueroes");
            DropTable("dbo.Clientes");
        }
    }
}
