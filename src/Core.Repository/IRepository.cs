using System.Collections.Generic;

namespace Core.Repository
{
    public interface IRepository<Datos> where Datos : class
        {
            int Insert(Datos entity);
            int Update(Datos entity);
            int Delete(Datos entity);
            IEnumerable<Datos> GetList();
            Datos GetById(int id);
        }
}
