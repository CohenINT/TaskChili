using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

public class DataAcces
{
    private string connectionString = ConfigurationManager.ConnectionStrings["SITE_DB"].ToString();
    private string commandText { get; set; }
    private CommandType commandType { get; set; }
    private SqlParameter[] sqlParameters { get; set; }
    private Enums.ExecuteType executeType { get; set; }

    public DataSet ResultDataSet = new DataSet();
    public DataTable ResultDataTable = new DataTable();
    public string ResultScalar = string.Empty;

    public DataAcces(string _commandText, CommandType _commandType, SqlParameter[] _sqlParameters, Enums.ExecuteType _executeType)
    {
        commandText = _commandText;
        commandType = _commandType;
        sqlParameters = _sqlParameters;
        executeType = _executeType;
        ExecuteSql();// on creation of this object, it execute the sql procuedure with given parameters
    }

    private void ExecuteSql()
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            connection.Open();
            using (SqlCommand cmd = new SqlCommand(commandText, connection))
            {
                cmd.CommandTimeout = 0;
                cmd.CommandType = commandType;
                if (sqlParameters != null && sqlParameters.Count() > 0)
                    cmd.Parameters.AddRange(sqlParameters);

                switch (executeType)
                {
                    case Enums.ExecuteType.DataSet:
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(ResultDataSet);
                        break;

                    case Enums.ExecuteType.DataTable:
                        using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                            da.Fill(ResultDataTable);
                        break;

                    case Enums.ExecuteType.Scalar:
                        ResultScalar = cmd.ExecuteScalar().ToString();
                        break;

                    case Enums.ExecuteType.NonQuery:
                    default:
                        cmd.ExecuteNonQuery();
                        break;
                }
            }
            connection.Close();
        }
    }
}