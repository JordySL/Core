using Core.Models;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Business
{
    public interface IUserLoginBusiness
    {
        IEnumerable<UserLogin> AutenticacionUser(string username, string password);
    }
    public class UserLoginBusiness : IUserLoginBusiness
    {
        private IUnitOfWork _unitofWork;

        public UserLoginBusiness(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public IEnumerable<UserLogin> AutenticacionUser(string username, string password)
        {
            return _unitofWork.userlogin.AutenticacionUser(username,password);
        }
    }
}
