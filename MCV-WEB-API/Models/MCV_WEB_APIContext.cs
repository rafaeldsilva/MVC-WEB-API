using System.Data.Entity;

namespace MCV_WEB_API.Models
{
    public class MCV_WEB_APIContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public MCV_WEB_APIContext() : base("" +
            "Data Source=(local);" +
            "Initial Catalog=db_mwapi;" +
            "Persist Security Info=True;" +
            "User ID=sa;" +
            "Password=sql2017"){
        }

        public System.Data.Entity.DbSet<MCV_WEB_API.Models.Usuario> Usuarios { get; set; }
    }
}
