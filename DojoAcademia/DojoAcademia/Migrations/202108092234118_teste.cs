namespace DojoAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class teste : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Pessoa", "Turno_Nome", c => c.String(maxLength: 128));
            CreateIndex("public.Pessoa", "Turno_Nome");
            AddForeignKey("public.Pessoa", "Turno_Nome", "public.Turno", "Nome");
            DropColumn("public.Pessoa", "Turno");
        }
        
        public override void Down()
        {
            AddColumn("public.Pessoa", "Turno", c => c.String());
            DropForeignKey("public.Pessoa", "Turno_Nome", "public.Turno");
            DropIndex("public.Pessoa", new[] { "Turno_Nome" });
            DropColumn("public.Pessoa", "Turno_Nome");
        }
    }
}
