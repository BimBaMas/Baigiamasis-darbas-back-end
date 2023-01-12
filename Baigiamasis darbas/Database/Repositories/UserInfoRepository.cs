using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Interfaces;

namespace Baigiamasis_darbas.Database.Repositories
{
    public class UserInfoRepository : IUserInfoRepository
    {
        private readonly DatabaseContext databaseContext;
        public UserInfoRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public UserInfo Create(UserInfoDTO data)
        {
            throw new NotImplementedException();
        }

        public UserInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public byte[] UpdateAvatar(byte[] data)
        {
            throw new NotImplementedException();
        }

        public string UpdateEmail(string data)
        {
            throw new NotImplementedException();
        }

        public string UpdateName(string data)
        {
            throw new NotImplementedException();
        }

        public string UpdatePersonalId(string data)
        {
            throw new NotImplementedException();
        }

        public string UpdatePhoneNo(string data)
        {
            throw new NotImplementedException();
        }

        public string UpdateSurname(string data)
        {
            throw new NotImplementedException();
        }
    }
}
