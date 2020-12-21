using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Группы хирургических операций
    /// </summary>
    public class SurgicalGroup:BaseDictEntity
    {
        public double WeightChild { get; set; }
        public  double WeightAdult { get; set; }
        public IList<SurgicalOne> SurgicalOnes { get; set; }

        public SurgicalGroup()
        {
            SurgicalOnes=new List<SurgicalOne>();
        }
    }
}
