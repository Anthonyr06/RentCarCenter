using RentCarCenter.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCarCenter.Models
{
    public class VehicleModel : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [ForeignKey("VehicleType")]
        public int VehicleTypeId { get; set; }
        [ForeignKey("VehicleBrand")]
        public int VehicleBrandId { get; set; }
        [Required]
        public StatusEnum Status { get; set; }

        public virtual VehicleType VehicleType { get; set; }
        public virtual VehicleBrand VehicleBrand { get; set; }
        public virtual ICollection<Vehicle> Vehicle { get; set; }
    }
}
