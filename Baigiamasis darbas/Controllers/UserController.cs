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
        
        [HttpGet]
        public ActionResult<User> Get([FromBody]UserDTO value)
        {
            User user = userRepository.Get(value);
            return user == null ? NotFound() : Ok(user);
        }
        
        [HttpPost]
        public ActionResult<User> Post([FromBody] UserDTO value)
        {
            User user = userRepository.Create(value);
            return user == null ? NotFound() : Ok(user);
        }
        
        [HttpPut("{id}")]
        public ActionResult<User> Put(int id, [FromBody] UserDTO value)
        {
            User user = userRepository.Update(id, value);
            return user == null ? NotFound() : Ok(user);
        }

        [HttpDelete("{id}")]
        public ActionResult<User> Delete(int id)
        {
            User user = userRepository.Delete(id);
            return user == null ? NotFound() : Ok(user);
        }
    }
}
