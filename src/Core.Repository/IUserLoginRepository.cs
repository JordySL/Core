using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Repository
{
    public interface IUserLoginRepository : IRepository<UserLogin>
    {
        IEnumerable<UserLogin> AutenticacionUser(string username,string password);
    }
}
