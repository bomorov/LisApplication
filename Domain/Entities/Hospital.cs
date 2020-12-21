using Domain.Common;
using Domain.Enums;
using System.Collections.Generic;

namespace Domain.Entities
{
    /// <summary>
    /// Справочник стационаров
    /// </summary>
    public class Hospital : BaseDictEntity
    {
        public HospitalType Type { get; set; }
        public string Adress { get; set; }
        public string FullName { get; set; }
        public string Boss { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }
        public IList<Branch> Branches { get; set; }

        public Hospital()
        {
            Branches = new List<Branch>();
        }
    }
}