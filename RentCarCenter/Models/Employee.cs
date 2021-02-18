using RentCarCenter.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace RentCarCenter.Models
{
    public class Employee : IBasePerson
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(13)]
        public string Identification { get; set; }
        [Required]
        public EmployeeScheduleEnum Schedule { get; set; }
        [Required]
        public int Commission { get; set; }
        [Required]
        public DateTime EntryDate { get; set; }
        public StatusEnum Status { get; set; }

        public virtual ICollection<RentDetail> RentDetail { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }

    public enum EmployeeScheduleEnum
    {
        Matutina,
        Vespertina
    }
}
