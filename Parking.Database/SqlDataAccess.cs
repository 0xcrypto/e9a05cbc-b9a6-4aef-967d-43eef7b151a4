using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Parking.Common;
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
        private static string DefaultConnectionString = ConstructConnectionStringWithServerDetails();
        public SqlCommand GetCommand(string sql)
        {
            var conn = new SqlConnection(ConnectionString);
            var sqlCmd = new SqlCommand(sql, conn);
            return sqlCmd;
        }

        public DataTable Execute(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                SqlCommand cmd = GetCommand(sql);
                cmd.Connection.Open();
                dt.Load(cmd.ExecuteReader());
                cmd.Connection.Close();
                return dt;
            }
            catch (System.Exception e)
            {
                FileLogger.Log($"Sql Data Access error (Unable to execute Sql) : {e.Message}");
                throw;
            }           
        }

        public DataTable Execute(SqlCommand command)
        {
            try
            {
                DataTable dt = new DataTable();
                command.Connection.Open();
                //command.ExecuteNonQuery();
                dt.Load(command.ExecuteReader());
                command.Connection.Close();
                return dt;
            }
            catch (System.Exception e)
            {
                FileLogger.Log($"Sql Data Access error (Unable to execute Sql Command) : {e.Message}");
                throw;
            }
        }

        public int ExecuteNonQuery(string sql)
        {
            try
            {
                SqlCommand cmd = GetCommand(sql);
                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return result;
            }
            catch (System.Exception e)
            {
                FileLogger.Log($"Sql Data Access error (Unable to execute Sql NonQuery) : {e.Message}");
                throw;
            }
        }

        public int ExecuteNonQuery(SqlCommand command)
        {
            try
            {
                command.Connection.Open();
                int result = command.ExecuteNonQuery();
                command.Connection.Close();
                return result;
            }
            catch (System.Exception e)
            {
                FileLogger.Log($"Sql Data Access error (Unable to execute SqlCommand NonQuery) : {e.Message}");
                throw;
            }
        }

        public int ExecuteStoredProcedure(string spName)
        {
            try
            {

                SqlCommand cmd = GetCommand(spName);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection.Open();
                int result = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return result;
            }
            catch (System.Exception e)
            {
                FileLogger.Log($"Sql Data Access error (Unable to execute Stored Proceddure) : {e.Message}");
                throw;
            }
        }

        public int ExecuteStoredProcedure(SqlCommand command)
        {
            try
            {
                command.CommandType = CommandType.StoredProcedure;
                command.Connection.Open();
                int result = command.ExecuteNonQuery();
                command.Connection.Close();
                return result;
            }
            catch (System.Exception e)
            {
                FileLogger.Log($"Sql Data Access error (Unable to execute SqlCommand Stored Procedure) : {e.Message}");
                throw;
            }
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

        private static string ConstructConnectionStringWithServerDetails()
        {
            var tdSetting = ConfigurationReader.GetConfigurationSettings();
            var connectionString = $"Data Source = {tdSetting.TdServerIPAddress},{tdSetting.TdServerPort}; Network Library = DBMSSOCN; Initial Catalog = db_Parking; User ID = {tdSetting.TdServerUsername}; Password = {tdSetting.TdServerPassword};";

            return connectionString;
        }
    }
}