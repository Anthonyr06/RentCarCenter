using RentCarCenter.Models.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentCarCenter.Models
{
    public class Customer : IBasePerson
    {
        [Key]
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Name { get; set; }
        [Required, MaxLength(13)]
        public string Identification { get; set; }
        [Required, MaxLength(19)]
        public string CreditCard { get; set; }
        public int CreditLimit { get; set; }
        public PersonTypeEnum PersonType { get; set; }
        public StatusEnum Status { get; set; }

        public virtual ICollection<RentDetail> RentDetail { get; set; }
        public virtual ICollection<Inspection> Inspection { get; set; }
    }

    public enum PersonTypeEnum
    {
        Fisica,
        Juridica
    }
}
