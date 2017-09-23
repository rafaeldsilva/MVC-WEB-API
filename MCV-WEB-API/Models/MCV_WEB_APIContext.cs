using System.Data.Entity;

namespace MCV_WEB_API.Models
{
    public class MCV_WEB_APIContext : DbContext
    {
        public MCV_WEB_APIContext() : base("" +
            "Data Source=(local);" + //servidor hostname.
            "Initial Catalog=db_mwapi;" + // Banco de dados.
            "Persist Security Info=True;" + // armazenar senha na string de conexao.
            "User ID=sa;" + //Usuario "sa".
            "Password=sql2017"){ //Senha do banco.
        }
        public System.Data.Entity.DbSet<MCV_WEB_API.Models.Usuario> Usuarios { get; set; }
    }
}
