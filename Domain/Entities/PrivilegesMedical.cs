using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Льготная категория по медицинским показаниям
    /// </summary>
    public class PrivilegesMedical:BaseDictEntity
    {
        public int CoefficentA { get; set; }
        public  int CoefficentB { get; set; }
    }
}
