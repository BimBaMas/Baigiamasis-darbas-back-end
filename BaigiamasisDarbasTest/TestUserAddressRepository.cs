using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Baigiamasis_darbas.Database;
using Baigiamasis_darbas.Interfaces;

namespace BaigiamasisDarbasTest
{
    public class TestUserAddressRepository
    {
        DbContextOptions<DatabaseContext> options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer("Data Source=.;Initial Catalog=BaigiamasisDarbas;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .Options;
        UserRepository userRepository;
        UserAddressRepository userAddressRepository;
        User user;
        User user2;
        User user3;
        UserAddressDTO userAddressDTO;


        [OneTimeSetUp]
        public void SetUp()
        {
            DatabaseContext databaseContext = new DatabaseContext(options);
            userRepository = new UserRepository(databaseContext);
            userAddressRepository = new UserAddressRepository(databaseContext);
            UserDTO userDTO = new UserDTO() { UserName = "TestUser", Password = "TestPassword", Role = "user" };
            user = userRepository.Create(userDTO);
            user2 = userRepository.Create(userDTO);
            user3 = userRepository.Create(userDTO);
            userAddressDTO = new UserAddressDTO { UserId = user.Id, Town = "TestTown", Street = "TestStreet", HouseNo = "15Test", FlatNo = "15Test" };
            userAddressRepository.Create(userAddressDTO);
            userAddressDTO.UserId = user3.Id;
            userAddressRepository.Create(userAddressDTO);
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            userRepository.Delete(user.Id);
            userRepository.Delete(user2.Id);
            userRepository.Delete(user3.Id);
        }        
        [Test]
        public void TestGetByIdResultNotNull()
        {            
            UserAddress userAddress = userAddressRepository.GetById(user.Id);
            Assert.NotNull(userAddress);            
        }
        [Test]
        public void CreateNewUserAddressAndTestIfItsInDatabase()
        {
            UserAddressDTO userAddressDTO2 = new UserAddressDTO { UserId = user2.Id, Town = "TestTown2", Street = "TestStreet", HouseNo = "15Test", FlatNo = "15Test" };
            UserAddress userAddress = userAddressRepository.Create(userAddressDTO2);
            Assert.NotNull(userAddress);
        }
        [Test]
        public void TestUpdateTownTownAfterUpdateEqualsUpdated()
        {
            userAddressRepository.UpdateTown(user.Id, "Updated");
            UserAddress userAddress = userAddressRepository.GetById(user.Id);
            Assert.AreEqual(userAddress.Town, "Updated");
        }
        [Test]
        public void TestUpdateStreetStreetAfterUpdateEqualsUpdated()
        {
            userAddressRepository.UpdateStreet(user.Id, "Updated");
            UserAddress userAddress = userAddressRepository.GetById(user.Id);
            Assert.AreEqual(userAddress.Street, "Updated");
        }
        [Test]
        public void TestUpdateFlatNoFlatNoAfterUpdateEqualsUpdated()
        {
            userAddressRepository.UpdateFlatNo(user.Id, "Updated");
            UserAddress userAddress = userAddressRepository.GetById(user.Id);
            Assert.AreEqual(userAddress.FlatNo, "Updated");
        }
        [Test]
        public void TestUpdateHouseNoHouseNoAfterUpdateEqualsUpdated()
        {
            userAddressRepository.UpdateHouseNo(user.Id, "Updated");
            UserAddress userAddress = userAddressRepository.GetById(user.Id);
            Assert.AreEqual(userAddress.HouseNo, "Updated");
        }
        [Test]
        public void TestDeleteDeletesOneRecord()
        {
            int countbefore = userAddressRepository.Get().Count;
            userAddressRepository.Delete(user3.Id);
            int countafter = userAddressRepository.Get().Count;
            Assert.AreEqual(countbefore, countafter + 1);
        }
    }
}