using Core.Repository;

namespace Core.UnitOfWork
{
    public interface IUnitOfWork
    {
        IUserProfileRepository usersprofile { get; }
    }
}
