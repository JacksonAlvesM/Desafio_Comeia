namespace Desafio.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Empresas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CNPJ = c.String(),
                        Nome_Fantasia = c.String(),
                        Telefone = c.String(),
                        Email = c.String(),
                        Data_Do_Cadastro = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Empresas");
        }
    }
}
