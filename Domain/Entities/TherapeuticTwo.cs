using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Категории терапевтических диагнозов
    /// </summary>
    public class TherapeuticTwo:BaseDictEntity
    {
        public  int TherapeuticOneId { get; set; }
        public  TherapeuticOne TherapeuticOne { get; set; }
        public  IList<TherapeuticThree> TherapeuticThrees { get; set; }

        public TherapeuticTwo()
        {
            TherapeuticThrees=new List<TherapeuticThree>();
        }
    }
}
