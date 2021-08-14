namespace DojoAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class chaveestrageira : DbMigration
    {
        public override void Up()
        {
            AddColumn("public.Pessoa", "Modalidade_Nome", c => c.String(maxLength: 128));
            CreateIndex("public.Pessoa", "Modalidade_Nome");
            AddForeignKey("public.Pessoa", "Modalidade_Nome", "public.Modalidade", "Nome");
            DropColumn("public.Pessoa", "Modalidade");
        }
        
        public override void Down()
        {
            AddColumn("public.Pessoa", "Modalidade", c => c.String());
            DropForeignKey("public.Pessoa", "Modalidade_Nome", "public.Modalidade");
            DropIndex("public.Pessoa", new[] { "Modalidade_Nome" });
            DropColumn("public.Pessoa", "Modalidade_Nome");
        }
    }
}
