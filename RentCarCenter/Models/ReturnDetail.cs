using RentCarCenter.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace RentCarCenter.Models
{
    public class ReturnDetail : IBaseEntity
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "date")]
        public DateTime Date { get; set; }
        [Required]
        [MaxLength(200)]
        public string Comment { get; set; }
        [Required]
        public StatusEnum Status { get; set; }

        [Required]
        [ForeignKey("RentDetail")] 
        public int RentDetailId { get; set; }
        public virtual RentDetail RentDetail { get; set; }
    }
}
