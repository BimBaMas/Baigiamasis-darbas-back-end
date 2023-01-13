using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;

namespace Baigiamasis_darbas.Interfaces
{
    public interface IUserInfoRepository
    {
        public UserInfo Create(UserInfoDTO data);
        public UserInfo GetById(int id);
        public UserInfo UpdateName(int id, string data);
        public UserInfo UpdateSurname(int id, string data);
        public UserInfo UpdatePersonalId(int id, string data);
        public UserInfo UpdatePhoneNo(int id, string data);
        public UserInfo UpdateEmail(int id, string data);
        public UserInfo UpdateAvatar(int id, byte[] data);
    }
}
