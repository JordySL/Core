using Core.Repository;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Core.DADapper
{
    public class Repository<Datos> : IRepository<Datos> where Datos : class
    {
        protected readonly string _connectionString;
        public Repository(string connectionString)
        {
            SqlMapperExtensions.TableNameMapper = (type) =>
            {
                return $"{type.Name}";
            };
            _connectionString = connectionString;
        }
        public int Delete(Datos entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Delete(entity) ? 1 : 0;
            }
        }
        public int Insert(Datos entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return (int)connection.Insert(entity);
            }
        }
        public int Update(Datos entity)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Update(entity) ? 1 : 0;
            }
        }
        public Datos GetById(int id)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.Get<Datos>(id);
            }
        }
        public IEnumerable<Datos> GetList()
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                return connection.GetAll<Datos>();
            }
        }

    }
}
