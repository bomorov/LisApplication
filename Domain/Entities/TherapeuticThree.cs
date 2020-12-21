using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Подгруппы терапевтических диагнозов
    /// </summary>
    public class TherapeuticThree:BaseDictEntity
    {
        public  int TherapeuticTwoId { get; set; }
        public  TherapeuticTwo TherapeuticTwo { get; set; }
    }
}
