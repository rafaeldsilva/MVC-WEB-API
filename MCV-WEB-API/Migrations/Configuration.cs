namespace MCV_WEB_API.Migrations
{
    using MCV_WEB_API.Models;
    using System;
    using System.Data.Entity.Migrations;

    internal sealed class Configuration : DbMigrationsConfiguration<MCV_WEB_API.Models.MCV_WEB_APIContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MCV_WEB_API.Models.MCV_WEB_APIContext context)
        {
            context.Usuarios.AddOrUpdate(p => p.Id,
                new Usuario
                {
                    Id = 1,
                    Nome = "Rafael",
                    SobreNome = "Silva",
                    Email = "rafael.silva@gmail.com",
                    Senha = "rafael123",
                    Token = "abc123",
                    dt_token = Convert.ToDateTime("23/09/2017"),
                    dt_timestamp = Convert.ToDateTime("23/09/2017")
                }
            #region Para inserir mais registros, no momento da persistência.
                //new Usuario
                //{
                   
                //},
                //new Usuario
                //{
                  
                //}
                #endregion

                );
        }
    }
}
