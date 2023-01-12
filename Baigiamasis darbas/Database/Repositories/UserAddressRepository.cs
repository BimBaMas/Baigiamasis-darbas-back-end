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

        public string UpdateFlatNo(int id, string data)
        {
            throw new NotImplementedException();
        }

        public string UpdateHouseNo(int id, string data)
        {
            throw new NotImplementedException();
        }

        public string UpdateStreet(int id, string data)
        {
            throw new NotImplementedException();
        }

        public string UpdateTown(int id, string data)
        {
            throw new NotImplementedException();
        }
    }
}
