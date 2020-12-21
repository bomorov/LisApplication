using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    /// <summary>
    /// Справочник областей
    /// </summary>
    public class Region:BaseDictEntity
    {

        public  IList<District> Districts { get; set; }

        public Region()
        {
            Districts=new List<District>();
        }
    }
}
