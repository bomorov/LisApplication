using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Справочник отделений
    /// </summary>
    public class Branch:BaseDictEntity
    {
        public int CountBed { get; set; }
        public  int HospitalId { get; set; }
        public  Hospital Hospital { get; set; }

    }
}
