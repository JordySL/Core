using Core.Models;
using Core.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Business
{
    public interface IUserProfileBusiness
    {
        IEnumerable<UserProfile> GetUserProfiles();
        int InsertUserProfile(UserProfile usersprofile);
        int UpdateUserProfile(UserProfile usersprofile);
        int DeleteUserProfile(UserProfile usersprofile);
        UserProfile GetUserProfile(int id);

    }
    public class UserProfileBusiness : IUserProfileBusiness
    {
        private IUnitOfWork _unitofWork;

        public UserProfileBusiness(IUnitOfWork unitofWork)
        {
            _unitofWork = unitofWork;
        }

        public int DeleteUserProfile(UserProfile usersprofile)
        {
            return _unitofWork.usersprofile.Delete(usersprofile);
        }

        public UserProfile GetUserProfile(int id)
        {
            return _unitofWork.usersprofile.GetById(id);
        }

        public IEnumerable<UserProfile> GetUserProfiles()
        {
            return _unitofWork.usersprofile.GetList();
        }

        public int InsertUserProfile(UserProfile usersprofile)
        {
            return _unitofWork.usersprofile.Insert(usersprofile);
        }

        public int UpdateUserProfile(UserProfile usersprofile)
        {
            return _unitofWork.usersprofile.Update(usersprofile);
        }
    }
}
