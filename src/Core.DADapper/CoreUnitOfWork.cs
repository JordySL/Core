using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Repository;

namespace Core.DADapper
{
    public class CoreUnitOfWork : IUnitOfWork
    {
        public CoreUnitOfWork(string connectionString)
        {
            usersprofile = new UserProfileRepository(connectionString);
            userlogin = new UserLoginRepository(connectionString);
        }
        public IUserLoginRepository userlogin {get; private set;}

        public IUserProfileRepository usersprofile {get; private set;}
    }
}
