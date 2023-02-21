using AutoMaper_API.Entities;

namespace AutoMaper_API.Services
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        List<User> GetAllUser();
        User GetUserById(Guid guid);
    }
}
