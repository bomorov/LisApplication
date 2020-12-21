using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Категории хирургических операций
    /// </summary>
    public class SurgicalTwo:BaseDictEntity
    {
        public  int SurgicalOneId { get; set; }
        public  SurgicalOne SurgicalOne { get; set; }
        public IList<SurgicalThree> SurgicalThrees { get; set; }
        public SurgicalTwo()
        {
            SurgicalThrees = new List<SurgicalThree>();
        }
    }
}
