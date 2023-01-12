using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;

namespace Baigiamasis_darbas.Interfaces
{
    public interface IUserInfoRepository
    {
        public UserInfo Create(UserInfoDTO data);
        public UserInfo GetById(int id);
        public string UpdateName(string data);
        public string UpdateSurname(string data);
        public string UpdatePersonalId(string data);
        public string UpdatePhoneNo(string data);
        public string UpdateEmail(string data);
        public byte[] UpdateAvatar(byte[] data);
    }
}
