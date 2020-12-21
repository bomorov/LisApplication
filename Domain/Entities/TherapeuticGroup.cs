using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Группы терапевтических диагнозов
    /// </summary>
    public class TherapeuticGroup:BaseDictEntity
    {
        public double WeightChild { get; set; }
        public double WeightAdult { get; set; }
        public IList<TherapeuticOne> TherapeuticOnes { get; set; }

        public TherapeuticGroup()
        {
            TherapeuticOnes = new List<TherapeuticOne>();
        }
    }
}
