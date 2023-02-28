using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prueba.Sql
{
    internal class Builder
    {
        private readonly SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
        public void Build(string user, string password)
        {
            builder.DataSource = "DESKTOP - S8V6F3S\\SQLEXPRESS";
            builder.InitialCatalog = "DB_MAPR";
            builder.PersistSecurityInfo = true;
            builder.UserID = user;
            builder.Password = password;
            Properties.Settings.Default.connection = new SqlConnection(builder.ConnectionString);
        }
    }
}
