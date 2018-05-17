using Core.Models;
using Core.Repository;
using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace Core.DADapper
{
    public class UserLoginRepository : Repository<UserLogin>, IUserLoginRepository
    {
        public UserLoginRepository(string connectionString) : base(connectionString)
        {
        }

        public IEnumerable<UserLogin> AutenticacionUser(string username, string password)
        {
            var param = new
            {
                username = username,
                password = password
            };
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Query<UserLogin>("dbo.AutenticacionUser", param, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
