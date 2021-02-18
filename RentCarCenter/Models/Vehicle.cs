using RentCarCenter.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentCarCenter.Models
{
    public class Vehicle : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(200)]
        public string Description { get; set; }
        [Required, MaxLength(20)]
        public string NoChassis { get; set; }
        [Required, MaxLength(20)]
        public string NoMotor { get; set; }
        [Required, MaxLength(20)]
        public string NoLicensePlate { get; set; }
        public StatusEnum Status { get; set; }

        public int FuelTypeId { get; set; }
        public FuelType FuelType { get; set; }
        public int VehicleModelId { get; set; }
        public VehicleModel VehicleModel { get; set; }
        public virtual ICollection<RentDetail> RentDetail { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }
}
