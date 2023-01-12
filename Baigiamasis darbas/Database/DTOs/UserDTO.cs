namespace Baigiamasis_darbas.Database.DTOs
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public UserDTO(string userName, string password)
        {
            UserName = userName;
            Password = password;
        }
    }
}
