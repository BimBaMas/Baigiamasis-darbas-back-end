using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;

namespace Baigiamasis_darbas.Interfaces
{
    public interface IUserRepository
    {        
        public User Create(UserDTO data);
        public User Update(int id);
        public User Delete(int id);
        public User Get(UserDTO data);
    }
}
