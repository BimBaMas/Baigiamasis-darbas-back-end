using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;

namespace Baigiamasis_darbas.Interfaces
{
    public interface IUserAddressRepository
    {
        public List<UserAddress> Get();
        public UserAddress GetById(int id);
        public UserAddress Create(UserAddressDTO data);
        public UserAddress UpdateTown(int id, string data);
        public UserAddress UpdateStreet(int id, string data);
        public UserAddress UpdateHouseNo(int id, string data);
        public UserAddress UpdateFlatNo(int id, string data);
        public UserAddress Delete(int id);
    }
}
