using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Справочник гражданств
    /// </summary>
    public class Citizenship:BaseDictEntity
    {
        public  string Name { get; set; }
        public  string Code { get; set; }
    }
}
