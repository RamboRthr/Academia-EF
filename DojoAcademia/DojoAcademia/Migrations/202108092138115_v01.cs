namespace DojoAcademia.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class v01 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "public.Pessoa",
                c => new
                    {
                        CPF = c.String(nullable: false, maxLength: 128),
                        Nome = c.String(),
                        Telefone = c.String(),
                        TurnoAluno = c.String(),
                        Modalidade = c.String(),
                        Turno = c.String(),
                        SalarioHora = c.Double(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.CPF);
            
            CreateTable(
                "public.Modalidade",
                c => new
                    {
                        Nome = c.String(nullable: false, maxLength: 128),
                        PrecoHora = c.Double(nullable: false),
                        VezesSemana = c.Int(nullable: false),
                        Professor = c.String(),
                    })
                .PrimaryKey(t => t.Nome);
            
        }
        
        public override void Down()
        {
            DropTable("public.Modalidade");
            DropTable("public.Pessoa");
        }
    }
}
