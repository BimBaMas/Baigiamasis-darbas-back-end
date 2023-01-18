using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Baigiamasis_darbas.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository userRepository;
        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }
        [HttpGet("user")]
        public ActionResult<User> Get([FromQuery] string username)
        {            
            User user = userRepository.Get(username);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpGet]
        public ActionResult<User> Get([FromQuery]string username, [FromQuery] string password)
        {
            UserDTO userDTO = new UserDTO { Password = password, UserName = username};
            User user = userRepository.Get(userDTO);
            return user == null ? NotFound() : Ok(user);
        }
        
        [HttpPost]
        public ActionResult<User> Create([FromBody] UserDTO value)
        {
            User user = userRepository.Create(value);
            return user == null ? NotFound() : Ok(user);
        }
        
        [HttpPut]
        public ActionResult<User> Put([FromQuery]int id, [FromBody] UserDTO value)
        {
            User user = userRepository.Update(id, value);
            return user == null ? NotFound() : Ok(user);
        }
        [HttpPut("Role")]
        public ActionResult<User> Put([FromQuery] int id, [FromQuery] string value)
        {
            User user = userRepository.Update(id, value);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpDelete]
        public ActionResult<User> Delete([FromQuery] int id)
        {
            User user = userRepository.Delete(id);
            return user == null ? NotFound() : Ok(user);
        }
    }
}
