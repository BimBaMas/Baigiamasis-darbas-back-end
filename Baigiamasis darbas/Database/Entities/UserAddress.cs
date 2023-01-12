using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Baigiamasis_darbas.Database.Entities
{
    public class UserAddress
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [ForeignKey("UserInfo")]
        public int UserInfoId { get; set; }
        public string Town { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string? FlatNo { get; set; }
    }
}
