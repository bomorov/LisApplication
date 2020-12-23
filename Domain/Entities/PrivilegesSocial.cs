using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Социальная льготная категория
    /// </summary>
    public class PrivilegesSocial:BaseDictEntity
    {
        public int CoefficentA { get; set; }
        public int CoefficentB { get; set; }
    }
}
