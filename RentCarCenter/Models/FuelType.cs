using RentCarCenter.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCarCenter.Models
{
    public class FuelType : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        public StatusEnum Status { get; set; }

        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
