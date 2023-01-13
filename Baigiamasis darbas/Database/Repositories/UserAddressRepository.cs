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
            throw new NotImplementedException();
        }

        public UserAddress GetById(int id)
        {
            throw new NotImplementedException();
        }

        public UserAddress UpdateFlatNo(int id, string data)
        {
            throw new NotImplementedException();
        }

        public UserAddress UpdateHouseNo(int id, string data)
        {
            throw new NotImplementedException();
        }

        public UserAddress UpdateStreet(int id, string data)
        {
            throw new NotImplementedException();
        }

        public UserAddress UpdateTown(int id, string data)
        {
            throw new NotImplementedException();
        }
    }
}
