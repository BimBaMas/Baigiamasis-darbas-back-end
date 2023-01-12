using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;

namespace Baigiamasis_darbas.Interfaces
{
    public interface IUserAddressRepository
    {
        public UserAddress GetById(int id);
        public UserAddress Create(UserAddressDTO data);
        public string UpdateTown(int id, string data);
        public string UpdateStreet(int id, string data);
        public string UpdateHouseNo(int id, string data);
        public string UpdateFlatNo(int id, string data);
    }
}
