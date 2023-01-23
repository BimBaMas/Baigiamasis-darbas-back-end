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
                .UseSqlServer("Data Source=.;Initial Catalog=BaigiamasisDarbas_Mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .Options;
        UserRepository userRepository;
        UserInfoRepository userInfoRepository;
        UserAddressRepository userAddressRepository;

        User user;
        User user2;
        User user3;
        UserAddressDTO userAddressDTO;
        UserInfoDTO userInfoDTO;

        [OneTimeSetUp]
        public void SetUp()
        {
            DatabaseContext databaseContext = new DatabaseContext(options);
            userRepository = new UserRepository(databaseContext);
            userAddressRepository = new UserAddressRepository(databaseContext);
            userInfoRepository = new UserInfoRepository(databaseContext);
            
            UserDTO userDTO = new UserDTO() { UserName = "TestUser", Password = "TestPassword", Role = "user" };
            user = userRepository.Create(userDTO);
            user2 = userRepository.Create(userDTO);
            user3 = userRepository.Create(userDTO);
            
            userAddressDTO = new UserAddressDTO { UserId = user.Id, Town = "TestTown", Street = "TestStreet", HouseNo = "15Test", FlatNo = "15Test" };
            
            userInfoDTO = new UserInfoDTO() { Name = "TestName", Surname = "TestSurname", PersonalId = "TestPersonalId", PhoneNo = "TestPhoneNo", Email = "TestEmail", Avatar = "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", UserId = user.Id };
            userInfoRepository.Create(userInfoDTO);
            
            userInfoDTO.UserId = user2.Id;
            userInfoRepository.Create(userInfoDTO);
            
            userInfoDTO.UserId = user3.Id;
            userInfoRepository.Create(userInfoDTO);
            
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