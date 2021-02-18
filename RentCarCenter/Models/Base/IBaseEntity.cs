using System;
using System.Collections.Generic;
using System.Text;

namespace RentCarCenter.Models.Base
{
    public interface IBaseEntity
    {
        int Id { get; set; }
        StatusEnum Status { get; set; }
    }

    public enum StatusEnum
    {
        Activado,
        Eliminado
    }
}
