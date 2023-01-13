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

        public UserInfo UpdateAvatar(int id, byte[] data)
        {
            throw new NotImplementedException();
        }

        public UserInfo UpdateEmail(int id, string data)
        {
            throw new NotImplementedException();
        }

        public UserInfo UpdateName(int id, string data)
        {
            throw new NotImplementedException();
        }

        public UserInfo UpdatePersonalId(int id, string data)
        {
            throw new NotImplementedException();
        }

        public UserInfo UpdatePhoneNo(int id, string data)
        {
            throw new NotImplementedException();
        }

        public UserInfo UpdateSurname(int id, string data)
        {
            throw new NotImplementedException();
        }
    }
}
