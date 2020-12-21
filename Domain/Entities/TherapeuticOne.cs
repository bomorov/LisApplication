using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Подгруппы терапевтических диагнозов
    /// </summary>
    public class TherapeuticOne:BaseDictEntity
    {
        public  int TherapeuticGroupId { get; set; }
        public  TherapeuticGroup TherapeuticGroup { get; set; }
        public  IList<TherapeuticTwo> ThreTherapeuticTwos { get; set; }

        public TherapeuticOne()
        {
            ThreTherapeuticTwos=new List<TherapeuticTwo>();
        }
    }
}
