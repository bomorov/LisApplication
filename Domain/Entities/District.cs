using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Справочник районов
    /// </summary>
    public class District:BaseDictEntity
    {
        public int RegionId { get; set; }
        public  Region Region { get; set; }
        public IList<Hospital> Hospitals { get; set; }

        public District()
        {
            Hospitals = new List<Hospital>();
        }
    }
}
