namespace XCompanyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Permisos",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NombreEmpleado = c.String(nullable: false, maxLength: 500),
                        ApellidosEmpleado = c.String(nullable: false, maxLength: 500),
                        FechaPermiso = c.DateTime(nullable: false),
                        TipoPermisoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TipoPermisoes", t => t.TipoPermisoId, cascadeDelete: true)
                .Index(t => t.TipoPermisoId);
            
            CreateTable(
                "dbo.TipoPermisoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 500),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Permisos", "TipoPermisoId", "dbo.TipoPermisoes");
            DropIndex("dbo.Permisos", new[] { "TipoPermisoId" });
            DropTable("dbo.TipoPermisoes");
            DropTable("dbo.Permisos");
        }
    }
}
