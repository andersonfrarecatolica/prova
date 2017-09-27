namespace Prova.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class insertAluno : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Alunoes (Nome, Cpf, Faixa_Id, TipoDeAssociacao_Id) VALUES ('Martim Castro Ribeiro', '158.778.735-04', 8, 1), ('Lucas Alves Melo', '916.749.332-74', 11, 3), ('Breno Castro Carvalho', '454.019.800-94', 9, 2), ('Laura Cardoso Rocha', '361.089.665-56', 13, 4)");
        }
        
        public override void Down()
        {
        }
    }
}
