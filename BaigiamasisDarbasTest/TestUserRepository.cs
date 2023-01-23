using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Database.Repositories;
using Microsoft.EntityFrameworkCore;
using Baigiamasis_darbas.Database;

namespace BaigiamasisDarbasTest
{
    public class TestUserRepository
    {
        DbContextOptions<DatabaseContext> options = new DbContextOptionsBuilder<DatabaseContext>()
                .UseSqlServer("Data Source=.;Initial Catalog=BaigiamasisDarbas_Mock;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
                .Options;

        UserRepository userRepository;
        UserDTO userDTO;
        User createdUser;
        int id;

        [OneTimeSetUp]
        public void SetUp()
        {
            DatabaseContext databaseContext = new DatabaseContext(options);
            userRepository = new UserRepository(databaseContext);            
        }
        [SetUp]
        public void Setups()
        {
            userDTO = new UserDTO { UserName = "TestUser", Password = "TestPassword", Role = "user" };
            createdUser = userRepository.Create(userDTO);
        }

        [TearDown]
        public void TearDown()
        {
            userRepository.Delete(createdUser.Id);
        }
        
        [Test]
        public void CreateNewUserAndCheckIfUserByUsernameMatchesDb()
        {            
            User userActual = userRepository.Get(userDTO.UserName);
            Assert.AreEqual(userActual.Username, createdUser.Username);            
        }
        [Test]
        public void GetUserByUsernameAndPassMustBeNotNull()
        {            
            User userActual = userRepository.Get(userDTO);
            Assert.NotNull(userActual);            
        }
        [Test]
        public void DeleteUserCreatesUserThenRemovesFromDbResultNull()
        {            
            userRepository.Delete(createdUser.Id);
            User userActual = userRepository.Get(userDTO);
            Assert.IsNull(userActual);      
        }
        [Test]
        public void UpdateUserPasswordCreeatesUserChangesPasswordPasswordsMach()
        {           
            userDTO.Password = "TestPassword2";
            User userActual = userRepository.Update(createdUser.Id, userDTO);
            Assert.AreEqual(createdUser.Password, userActual.Password);            
        }
        [Test]
        public void UpdateUserRoleCreeatesUserChangesRoleRolesDoNotMach()
        {
            userRepository.Update(createdUser.Id, "admin");
            Assert.AreEqual(createdUser.Role, "admin");
        }
    }
}