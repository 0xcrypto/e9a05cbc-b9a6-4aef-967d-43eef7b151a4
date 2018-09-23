using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Parking.Interfaces;

namespace Parking.Database
{
    /// <summary>
    /// SqlDataAccess is being used for accessing MSSQL database quickly and easily. 
    /// Requires a connection string that is named MsSql defined on web.config file. This connection string is used as default. 
    /// For using different connection strings you should pass the name of the connection string as a parameter with methods.
    /// </summary>
    public class SqlDataAccess : ISqlDataAccess
    {
        // Default connection string. a connection named MsSql should be defined in web.config file.
        public const string ConnectionStringName = "MsSql";

        //This returns the connection string  
        private static string DefaultConnectionString = "Data Source=DESKTOP-0PGDO2C\\SQLEXPRESS;Initial Catalog=db_Parking;User ID=sa;Password=p@ssw0rd";

        public SqlCommand GetCommand(string sql)
        {
            var conn = new SqlConnection(ConnectionString);
            var sqlCmd = new SqlCommand(sql, conn);
            return sqlCmd;
        }

        public DataTable Execute(string sql)
        {
            DataTable dt = new DataTable();
            SqlCommand cmd = GetCommand(sql);
            cmd.Connection.Open();
            dt.Load(cmd.ExecuteReader());
            cmd.Connection.Close();
            return dt;
        }

        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            //command.ExecuteNonQuery();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }

        public int ExecuteNonQuery(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        public int ExecuteNonQuery(SqlCommand command)
        {
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        public int ExecuteStoredProcedure(string spName)
        {
            SqlCommand cmd = GetCommand(spName);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection.Open();
            int result = cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            return result;
        }

        public int ExecuteStoredProcedure(SqlCommand command)
        {
            command.CommandType = CommandType.StoredProcedure;
            command.Connection.Open();
            int result = command.ExecuteNonQuery();
            command.Connection.Close();
            return result;
        }

        public string ConnectionString
        {
            get
            {
                if (DefaultConnectionString == string.Empty)
                {
                    DefaultConnectionString = ConfigurationManager.ConnectionStrings[ConnectionStringName].ConnectionString;
                }
                return DefaultConnectionString;
            }
            set { }
        }
    }
}