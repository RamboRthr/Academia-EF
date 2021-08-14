namespace DojoAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v05 : DbMigration
    {
        public override void Up()
        {
            DropTable("public.Turno");
        }
        
        public override void Down()
        {
            CreateTable(
                "public.Turno",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
    }
}
