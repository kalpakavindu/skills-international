using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skills
{
    internal class Database
    {
        private SqlConnection _connection;
        private String _connectionString;

        public Database()
        {
            // Assign connection string to this variable
            _connectionString = @"Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\data\\sqlfiles\\DB_Skills_CS.mdf;Integrated Security=True;Connect Timeout=30";
            _connection = new SqlConnection(_connectionString);
        }

        public int Set(String query)
        {
            SqlCommand _command = new SqlCommand(query, _connection);

            _command.Connection.Open();
            int r = _command.ExecuteNonQuery();
            _command.Connection.Close();

            return r;
        }
        public DataTable Get(String query)
        {
            DataTable dt = new DataTable();
            SqlCommand _command = new SqlCommand(query, _connection);

            _command.CommandType = System.Data.CommandType.StoredProcedure;
            _command.Connection.Open();
            using (SqlDataReader reader = _command.ExecuteReader())
            {
                dt.Load(reader);
            }

            return dt;
        }
    }

}
