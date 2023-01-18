using Baigiamasis_darbas.Database.DTOs;
using Baigiamasis_darbas.Database.Entities;
using Baigiamasis_darbas.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Baigiamasis_darbas.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserInfoController : ControllerBase
    {
        IUserInfoRepository userInfoRepository;
        public UserInfoController(IUserInfoRepository userInfoRepository)
        {
            this.userInfoRepository = userInfoRepository;
        }
        [HttpGet]
        public ActionResult<List<UserInfo>> Get()
        {
            List<UserInfo> userInfo = userInfoRepository.Get();
            return userInfo == null ? NotFound() : Ok(userInfo);
        }
        [HttpGet("id")]
        public ActionResult<UserInfo> Get([FromQuery] int id)
        {
            UserInfo userInfo = userInfoRepository.GetById(id);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }

        [HttpPost]
        public ActionResult<UserInfo> Post([FromBody] UserInfoDTO value)
        {
            UserInfo userInfo = userInfoRepository.Create(value);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }

        [HttpPut("Name")]
        public ActionResult<UserInfo> PutName([FromQuery]int id, [FromQuery]string value)
        {
            UserInfo userInfo = userInfoRepository.UpdateName(id, value);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }

        [HttpPut("Surname")]
        public ActionResult<UserInfo> PutSurname([FromQuery] int id, [FromQuery] string value)
        {
            UserInfo userInfo = userInfoRepository.UpdateSurname(id, value);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }

        [HttpPut("PersonalId")]
        public ActionResult<UserInfo> PutPersonalId([FromQuery] int id, [FromQuery] string value)
        {
            UserInfo userInfo = userInfoRepository.UpdatePersonalId(id, value);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }

        [HttpPut("PhoneNo")]
        public ActionResult<UserInfo> PutPhoneNo([FromQuery] int id, [FromQuery] string value)
        {
            UserInfo userInfo = userInfoRepository.UpdatePhoneNo(id, value);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }

        [HttpPut("Email")]
        public ActionResult<UserInfo> PutEmail([FromQuery] int id, [FromQuery] string value)
        {
            UserInfo userInfo = userInfoRepository.UpdateEmail(id, value);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }
        [HttpPut("Avatar")]
        public ActionResult<UserInfo> PutAvatar([FromQuery] int id, [FromQuery]byte[] value)
        {
            UserInfo userInfo = userInfoRepository.UpdateAvatar(id, value);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }
        [HttpDelete]
        public ActionResult<UserInfo> Delete([FromQuery] int id)
        {
            UserInfo userInfo = userInfoRepository.Delete(id);
            return userInfo == null ? NotFound() : Ok(userInfo);
        }
    }
}
