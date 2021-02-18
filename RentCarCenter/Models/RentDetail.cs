using RentCarCenter.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentCarCenter.Models
{
    public class RentDetail : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime RentDate { get; set; }
        [Required, DataType(DataType.Currency)]
        public double PriceByDay { get; set; }
        [Required]
        public int RentDays { get; set; }
        [Required, MaxLength(500)]
        public string Comment { get; set; }
        public bool HasBeenReturned { get; set; }
        public StatusEnum Status { get; set; }

        public int CustomerId { get; set; }
        public virtual Customer Customer { get; set; }
        public int VehicleId { get; set; }
        public virtual Vehicle Vehicle { get; set; } 
        public int EmployeeId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }
}
