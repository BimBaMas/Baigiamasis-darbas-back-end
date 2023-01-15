using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Interfaces;

namespace Baigiamasis_darbas.Database.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DatabaseContext databaseContext;
        public UserRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public User Create(UserDTO data)
        {
            User user = new User
            {
                Username = data.UserName,
                Password = data.Password,
                Role = "user"
            };
            databaseContext.Users.Add(user);
            databaseContext.SaveChanges();
            return user;
        }

        public User Delete(int id)
        {
            User user = databaseContext.Users.FirstOrDefault(x => x.Id == id);
            if (user == null)
                return null;
            databaseContext.Users.Remove(user);
            databaseContext.SaveChanges();
            return user;
        }

        public User Get(UserDTO data)
        {
            User user = databaseContext.Users.FirstOrDefault(x => (x.Username == data.UserName && x.Password == data.Password));
            if (user == null)
                return null;
            return user;
        }

        public User Update(int id, UserDTO value)
        {
            User user = databaseContext.Users.FirstOrDefault(x => x.UserInfoId == id);
            if (user == null)
                return null;
            user.Password = value.Password;
            databaseContext.SaveChanges();
            return user;
        }
    }
}
