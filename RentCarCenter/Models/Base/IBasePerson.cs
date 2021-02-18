using System;
using System.Collections.Generic;
using System.Text;

namespace RentCarCenter.Models.Base
{
    public interface IBasePerson : IBaseEntity
    {
        string Name { get; set; }
        string Identification { get; set; }
    }
}
