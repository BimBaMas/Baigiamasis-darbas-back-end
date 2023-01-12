using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Baigiamasis_darbas.Database.Entities
{
    public class UserInfo
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("User")]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string PersonalId { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public byte[] Avatar { get; set; }        
        [ForeignKey("UserAddress")]
        public int Address { get; set; }
    }
}
