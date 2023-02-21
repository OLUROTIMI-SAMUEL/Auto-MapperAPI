using AutoMaper_API.Entities;

namespace AutoMaper_API.Services
{
    public class UserRepository : IUserRepository
    {
        public static List<User> users = new List<User>()
        {
            new User{Id = new Guid("45408c64-1af9-4ea4-a9e0"),
            Email = "test@test.com", FirstName = "Jane", LastName = "David", Password = "testPassword"},

            new User{Id = new Guid("4540c645-1lf9-4ea4-a9e0"),
            Email = "test@test.com", FirstName = "Samuel", LastName = "Olurotimi", Password = "testPassword2"},

            new User{Id = new Guid("45488c64-1af9-42a4-a9e0"),
            Email = "test@test.com", FirstName = "Kenny", LastName = "John", Password = "testPassword3"}
        };
        public User CreateUser(User user)
        {
            user.Id = Guid.NewGuid();
            users.Add(user);
            return user;
        }

        public List<User> GetAllUser()
        {
            return users;
        }

        //public List <User> GetAllUsers()
        //{
        //    return users;
        //}

        public User GetUserById(Guid guid)
        {
            var user = users.FirstOrDefault(u => u.Id == guid);
            return user;
        }
    }
}
