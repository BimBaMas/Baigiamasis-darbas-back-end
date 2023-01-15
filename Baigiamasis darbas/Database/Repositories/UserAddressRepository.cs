using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace Baigiamasis_darbas.Database.Repositories
{
    public class UserAddressRepository : IUserAddressRepository
    {
        private readonly DatabaseContext databaseContext;
        public UserAddressRepository(DatabaseContext databaseContext)
        {
            this.databaseContext = databaseContext;
        }

        public UserAddress Create(UserAddressDTO data)
        {
            UserAddress userAddress = new UserAddress
            {
                Town = data.Town,
                HouseNo = data.HouseNo,
                FlatNo = data.FlatNo,
                Street = data.Street

            };
            databaseContext.Addresses.Add(userAddress);
            databaseContext.SaveChanges();
            return userAddress;
        }

        public UserAddress GetById(int id)
        {
            UserAddress userAddress = databaseContext.Addresses.FirstOrDefault(a => a.Id == id);
            return userAddress;
        }

        public UserAddress UpdateFlatNo(int id, string data)
        {
            UserAddress userAddress = databaseContext.Addresses.FirstOrDefault(a => a.Id == id);
            if (userAddress == null)
                return null;
            userAddress.FlatNo = data;
            databaseContext.SaveChanges();
            return userAddress;
        }

        public UserAddress UpdateHouseNo(int id, string data)
        {
            UserAddress userAddress = databaseContext.Addresses.FirstOrDefault(a => a.Id == id);
            if (userAddress == null)
                return null;
            userAddress.HouseNo = data;
            databaseContext.SaveChanges();
            return userAddress;
        }

        public UserAddress UpdateStreet(int id, string data)
        {
            UserAddress userAddress = databaseContext.Addresses.FirstOrDefault(a => a.Id == id);
            if (userAddress == null)
                return null;
            userAddress.Street = data;
            databaseContext.SaveChanges();
            return userAddress;
        }

        public UserAddress UpdateTown(int id, string data)
        {
            UserAddress userAddress = databaseContext.Addresses.FirstOrDefault(a => a.Id == id);
            if (userAddress == null)
                return null;
            userAddress.Town = data;
            databaseContext.SaveChanges();
            return userAddress;
        }
    }
}
