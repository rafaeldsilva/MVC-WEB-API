namespace MCV_WEB_API.Migrations
{
    using MCV_WEB_API.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MCV_WEB_API.Models.MCV_WEB_APIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MCV_WEB_API.Models.MCV_WEB_APIContext context)
        {
            //context.Usuarios.AddOrUpdate(p => p.Id,
            //    new Usuario
            //    {
            //        Id = 1,
            //        Nome = "produto 1",
            //        SobreNome = "COD1",
            //        Email = "descrição produto 1",
            //        Senha = 10,
            //        Token = "abc123",
            //        dt_token = Conve
            //    },
            //    new Usuario
            //    {
            //        Id = 2,
            //        nome = "produto 2",
            //        codigo = "COD2",
            //        descricao = "descrição produto 2",
            //        preco = 20
            //    },
            //    new Usuario
            //    {
            //        Id = 3,
            //        nome = "produto 3",
            //        codigo = "COD3",
            //        descricao = "descrição produto 3",
            //        preco = 30
            //    });          
        }
    }
}
