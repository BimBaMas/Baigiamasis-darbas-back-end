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
            UserInfo userInfo = new UserInfo
            { 
                Name = data.Name,
                Surname = data.Surname,
                PersonalId = data.PersonalId,
                PhoneNo = data.PhoneNo,
                Email = data.Email,
                Avatar = data.Avatar
            };
            databaseContext.UserInfo.Add(userInfo);
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo GetById(int id)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.Id == id);
            if (userInfo == null)
                return null;
            return userInfo;
        }

        public UserInfo UpdateAvatar(int id, byte[] data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.Id == id);
            if (userInfo == null)
                return null;
            userInfo.Avatar = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdateEmail(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.Id == id);
            if (userInfo == null)
                return null;
            userInfo.Email = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdateName(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.Id == id);
            if (userInfo == null)
                return null;
            userInfo.Name = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdatePersonalId(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.Id == id);
            if (userInfo == null)
                return null;
            userInfo.PersonalId = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdatePhoneNo(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.Id == id);
            if (userInfo == null)
                return null;
            userInfo.PhoneNo = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdateSurname(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.Id == id);
            if (userInfo == null)
                return null;
            userInfo.Surname = data;
            databaseContext.SaveChanges();
            return userInfo;
        }
    }
}
