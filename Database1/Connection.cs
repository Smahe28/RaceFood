using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Database1
{
    public class Connection
    {
        public SqlConnection MyConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Race; Integrated Security = True");
            return con;
        }
    }
}
