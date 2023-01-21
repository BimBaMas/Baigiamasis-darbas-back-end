using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;

namespace Baigiamasis_darbas.Interfaces
{
    public interface IUserRepository
    {
        public List<User> Get();
        public User Get(string data);
        public User Get(UserDTO data);
        public User Create(UserDTO data);
        public User Update(int id, string value);
        public User Update(int id, UserDTO value);                
        public User Delete(int id);
    }
}
