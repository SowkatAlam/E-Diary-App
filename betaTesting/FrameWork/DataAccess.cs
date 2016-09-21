using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace betaTesting.FrameWork
{
    class DataAccess
    {
        
        string connectionString = "Data Source=DESKTOP-DME6Q27;Initial Catalog=mydatabase;Integrated Security=True";
        
        public void Execute(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(connectionString);
            command.Connection = connection;
            connection.Open();
            command.ExecuteNonQuery();
            connection.Close();
        }
        public DataTable Query(SqlCommand query)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            query.Connection = connection;
            SqlDataAdapter da = new SqlDataAdapter(query);
            connection.Open();
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();

            return dt;
        }
    }
}
