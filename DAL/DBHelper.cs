#region Using Directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
#endregion Using Directives

namespace DAL
{
    public class DBHelper
    {
        const string CONNECTION_STRING = "Data Source=localhost;Initial Catalog=SmartCodingDB;Integrated Security=true;";
        //Select with Parameter
        #region ExecuteParamerizedSelectCommand()
        internal static DataTable ExecuteParamerizedSelectCommand(string commandName,CommandType cmdType,SqlParameter[]param)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandType = cmdType;
                    command.CommandText = commandName;                

                try
                {
                    if (connection.State != ConnectionState.Open)
                    {
                        connection.Open();
                    }
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
                catch
                {
                    throw;
                }
            }
            }
            return table;
        }
        #endregion
        //Insert,Update and Delete
        #region ExecuteNonQuery()
        internal static bool ExecuteNonQuery(string commandName,CommandType cmdType,SqlParameter[]sqlParameters)
        {
            int result = 0;
            using(SqlConnection connection=new SqlConnection(CONNECTION_STRING))
            {
                using(SqlCommand command=connection.CreateCommand())
                {
                    command.CommandType = cmdType;
                    command.CommandText = commandName;
                    command.Parameters.AddRange(sqlParameters);
                    try
                    {
                        if(connection.State!=ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        result=command.ExecuteNonQuery();
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return result > 0;
        }        
        #endregion
        //Select Without parameter
        #region ExecuteSelectCommand()
        internal static DataTable ExecuteSelectCommand(string commandName,CommandType cmdType)
        {
            DataTable dt = null;
            using (SqlConnection connection = new SqlConnection(CONNECTION_STRING))
            {
                using(SqlCommand command=connection.CreateCommand())
                {
                    command.CommandType = cmdType;
                    command.CommandText = commandName;
                    try
                    {
                        if(connection.State!=ConnectionState.Open)
                        {
                            connection.Open();
                        }
                        using(SqlDataAdapter adapter=new SqlDataAdapter(command))
                        {
                            dt = new DataTable();
                            adapter.Fill(dt);
                        }
                    }
                    catch
                    {
                        throw;
                    }
                }
            }
            return dt;
        }
        #endregion
    }
}
