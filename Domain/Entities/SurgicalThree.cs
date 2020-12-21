using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Подкатегории хирургических операций
    /// </summary>
    public class SurgicalThree:BaseDictEntity
    {
        public  int SurgicalTwoId { get; set; }
        public  SurgicalTwo SurgicalTwo { get; set; }
    }
}
