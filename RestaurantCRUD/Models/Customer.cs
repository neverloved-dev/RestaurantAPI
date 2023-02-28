using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace RestaurantCRUD.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Required]
        public int Id{ get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }

        public string PhoneNumber { get; set; }
        [Required]
        public string Password { get; set; }
    }
}

