namespace DojoAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Aluno",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 128),
                        Turno = c.String(),
                        Modalidade = c.String(),
                        Nome = c.String(),
                        Telefone = c.String(),
                    })
                .PrimaryKey(t => t.CPF);
            
            CreateTable(
                "public.Modalidade",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 128),
                        PrecoHora = c.Double(nullable: false),
                        VezesSemana = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Nome);
            
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
            
        }
        
        public override void Down()
        {
            DropTable("public.Professor");
            DropTable("public.Modalidade");
            DropTable("public.Aluno");
        }
    }
}
