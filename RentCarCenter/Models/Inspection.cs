using RentCarCenter.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentCarCenter.Models
{
    public class Inspection : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public bool IsGrated { get; set; }
        [Required]
        public string FuelQuantity { get; set; }
        [Required]
        public bool HasHydraulicCat { get; set; }
        [Required]
        public bool HasSpareTire { get; set; }
        [Required]
        public bool HasBrokenMirror { get; set; }
        public DateTime Date { get; set; }
        public StatusEnum Status { get; set; }

        public int RentDetailId { get; set; }
        public virtual RentDetail RentDetail { get; set; }
    }
}
