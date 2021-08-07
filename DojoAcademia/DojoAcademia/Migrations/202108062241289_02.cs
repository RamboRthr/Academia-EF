namespace DojoAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _02 : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "public.Aluno", newName: "Pessoa");
            RenameColumn(table: "public.Pessoa", name: "Turno", newName: "Turno1");
            AddColumn("public.Pessoa", "SalarioHora", c => c.Double());
            AddColumn("public.Pessoa", "Discriminator", c => c.String(nullable: false, maxLength: 128));
            AddColumn("public.Modalidade", "Professor", c => c.String());
            DropTable("public.Professor");
        }
        
        public override void Down()
        {
            CreateTable(
                "public.Professor",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 128),
                        Turno = c.String(),
                        SalarioHora = c.Double(nullable: false),
                        Nome = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.CPF);
            
            DropColumn("public.Modalidade", "Professor");
            DropColumn("public.Pessoa", "Discriminator");
            DropColumn("public.Pessoa", "SalarioHora");
            RenameColumn(table: "public.Pessoa", name: "Turno1", newName: "Turno");
            RenameTable(name: "public.Pessoa", newName: "Aluno");
        }
    }
}
