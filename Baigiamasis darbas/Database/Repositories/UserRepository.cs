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
            throw new NotImplementedException();
        }

        public User Delete(int id)
        {
            throw new NotImplementedException();
        }

        public User Get(UserDTO data)
        {
            throw new NotImplementedException();
        }

        public User Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
