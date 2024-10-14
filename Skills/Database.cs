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
        private DataTable _dt;
        private SqlDataAdapter _dap;
        private SqlCommand _command;

        public Database()
        {
            // Assign connection string to this variable
            _connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\data\sqlfiles\DB_Skills_CS.mdf;Integrated Security=True;Connect Timeout=30;";
            _connection = new SqlConnection(_connectionString);
            _command = new SqlCommand();
            _command.Connection = _connection;
        }

        public int SetData(String query)
        {
            int cnt;
            if(_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
            _command.CommandText = query;
            cnt = _command.ExecuteNonQuery();
            _connection.Close();
            return cnt;
        }
        public DataTable GetData(String query)
        {
            _dt = new DataTable();
            _dap = new SqlDataAdapter(query, _connectionString);
            _dap.Fill(_dt);
            return _dt;
        }
    }

}
