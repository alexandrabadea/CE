using System.ComponentModel.DataAnnotations;

namespace ProiectMaster.Models.DTOs.VM
{
    public class ShippingAddressVM
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string PersonName { get; set; }

        [Required]
        [MaxLength(10)]
        [Phone]
        public string Phone { get; set; }

        [Required]
        [MaxLength(255)]
        public string Address { get; set; }
    }
}
