using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Manegment_System
{
    public class MainClass
    {
        public SqlConnection connec()
        {
            SqlConnection conn = new SqlConnection("Data Source=MUDASIR;initial Catalog=library_system_managments;integrated Security=True;");
            conn.Open();
            return conn;
        }
    }
}
