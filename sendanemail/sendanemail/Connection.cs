using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace sendanemail
{
    internal class Connection
    {
        private static string stringConnection = @" Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=""C:\Users\Trong Khanh\Downloads\sendanemail\sendanemail\sendanemail\Database1.mdf"";Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(stringConnection);
        }
    }
}
