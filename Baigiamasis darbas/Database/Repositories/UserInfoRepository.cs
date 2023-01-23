using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Baigiamasis_darbas.Database.Repositories
{
    public class UserInfoRepository : IUserInfoRepository
    {
        private readonly DatabaseContext databaseContext;
        public UserInfoRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }
        public List<UserInfo> Get()
        {
            List<UserInfo> userInfo = databaseContext.UserInfo.ToList();
            return userInfo;
        }
        public UserInfo GetById(int id)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.UserId == id);            
            return userInfo;
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
                Avatar = Convert.FromBase64String(data.Avatar),
                UserId = data.UserId
            };
            databaseContext.UserInfo.Add(userInfo);
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdateAvatar(int id, UserInfoDTO data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.UserId == id);
            if (userInfo == null)
                return null;
            userInfo.Avatar = Convert.FromBase64String(data.Avatar);
            databaseContext.SaveChanges();            
            return userInfo;
        }

        public UserInfo UpdateEmail(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.UserId == id);
            if (userInfo == null)
                return null;
            userInfo.Email = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdateName(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.UserId == id);
            if (userInfo == null)
                return null;
            userInfo.Name = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdatePersonalId(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.UserId == id);
            if (userInfo == null)
                return null;
            userInfo.PersonalId = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdatePhoneNo(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.UserId == id);
            if (userInfo == null)
                return null;
            userInfo.PhoneNo = data;
            databaseContext.SaveChanges();
            return userInfo;
        }

        public UserInfo UpdateSurname(int id, string data)
        {
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.UserId == id);
            if (userInfo == null)
                return null;
            userInfo.Surname = data;
            databaseContext.SaveChanges();
            return userInfo;
        }
        public UserInfo Delete(int id)
        { 
            UserInfo userInfo = databaseContext.UserInfo.FirstOrDefault(x => x.UserId == id);
            if (userInfo == null)
                return null;
            databaseContext.UserInfo.Remove(userInfo);
            databaseContext.SaveChanges();
            return userInfo;
        }
    }
}
