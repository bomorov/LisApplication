using Domain.Common;
using System.Collections.Generic;

namespace Domain.Entities
{
    /// <summary>
    /// Подгруппы хирургических операций
    /// </summary>
    public class SurgicalOne : BaseDictEntity
    {

        public int SurgicalGroupId { get; set; }
        public SurgicalGroup SurgicalGroup { get; set; }
        public IList<SurgicalTwo> SurgicalTwos { get; set; }
        public SurgicalOne()
        {
            SurgicalTwos = new List<SurgicalTwo>();
        }
    }
}