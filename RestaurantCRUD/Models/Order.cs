﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RestaurantCRUD.Models
{
    [Table("Orders")]
    public class Order
    {
        [Required]
       public Guid guid { get; set; }
        [Required]
       public DateTime ordered_at { get; set; }
        [Required]
       public DateTime delivered_at { get; set; }
        
    }
}
