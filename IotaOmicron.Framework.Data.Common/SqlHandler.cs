using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using IotaOmicron.Framework.Data.Common.Interfaces;
using Dapper;
using System.Data.SqlClient;

namespace IotaOmicron.Framework.Data.Common
{
    public class SqlHandler : ISqlHandler
    {
        public SqlHandler()
        {

        }

        public async Task<IEnumerable<T>> QueryAsync<T>(string connectionString, string command, CommandType commandType, object parameters) where T : class
        {
            if (string.IsNullOrEmpty(command) || string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException($"The argument {nameof(command)} is either empty, null or a white space.");
            }

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return await connection.QueryAsync<T>(command, parameters, commandType: commandType);
        }

        public async Task<int> ExecuteAsync(string connectionString, string command, CommandType commandType, object parameters)
        {
            if (string.IsNullOrEmpty(command) || string.IsNullOrWhiteSpace(command))
            {
                throw new ArgumentException($"The argument {nameof(command)} is either empty, null or a white space.");
            }

            using SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            return await connection.ExecuteAsync(command, parameters, commandType: commandType);
        }
    }
}
