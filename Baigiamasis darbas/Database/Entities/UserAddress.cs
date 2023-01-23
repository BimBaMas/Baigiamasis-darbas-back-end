using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Baigiamasis_darbas.Database.Entities
{
    public class UserAddress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string? FlatNo { get; set; }
        [ForeignKey("UserInfo.UserId")]
        public int UserId { get; set; }
        public virtual UserInfo UserInfo { get; set; }
    }
}
