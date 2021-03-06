namespace DojoAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class turno1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Turno",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
        
        public override void Down()
        {
            DropTable("public.Turno");
        }
    }
}
