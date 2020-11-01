namespace G3.CLASS.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class nueva : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nombre_Apellido = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Horarios",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DiaHora = c.DateTime(nullable: false),
                        PeluqueroId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Peluqueros", t => t.PeluqueroId, cascadeDelete: true)
                .Index(t => t.PeluqueroId);
            
            CreateTable(
                "dbo.Peluqueros",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Nombre = c.String(nullable: false),
                        Espejo = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Productos",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Stock = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tareas",
                c => new
                    {
                        Id = c.Int(nullable: false),
                        Descripcion = c.String(nullable: false),
                        Tiempo = c.String(nullable: false),
                        Valor = c.Int(nullable: false),
                        ProductoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Productos", t => t.ProductoId, cascadeDelete: true)
                .Index(t => t.ProductoId);
            
            CreateTable(
                "dbo.Turnos",
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
                .ForeignKey("dbo.Peluqueros", t => t.PeluqueroId, cascadeDelete: true)
                .ForeignKey("dbo.Tareas", t => t.TareaId, cascadeDelete: true)
                .Index(t => t.TareaId)
                .Index(t => t.ClienteId)
                .Index(t => t.PeluqueroId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Turnos", "TareaId", "dbo.Tareas");
            DropForeignKey("dbo.Turnos", "PeluqueroId", "dbo.Peluqueros");
            DropForeignKey("dbo.Turnos", "ClienteId", "dbo.Clientes");
            DropForeignKey("dbo.Tareas", "ProductoId", "dbo.Productos");
            DropForeignKey("dbo.Horarios", "PeluqueroId", "dbo.Peluqueros");
            DropIndex("dbo.Turnos", new[] { "PeluqueroId" });
            DropIndex("dbo.Turnos", new[] { "ClienteId" });
            DropIndex("dbo.Turnos", new[] { "TareaId" });
            DropIndex("dbo.Tareas", new[] { "ProductoId" });
            DropIndex("dbo.Horarios", new[] { "PeluqueroId" });
            DropTable("dbo.Turnos");
            DropTable("dbo.Tareas");
            DropTable("dbo.Productos");
            DropTable("dbo.Peluqueros");
            DropTable("dbo.Horarios");
            DropTable("dbo.Clientes");
        }
    }
}
