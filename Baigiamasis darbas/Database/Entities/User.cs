using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baigiamasis_darbas.Database.Entities
{
    public class User
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }        
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }        
        public virtual UserInfo UserInfo { get; set; }
        public virtual UserAddress UserAddress { get; set; }
        
    }
}
