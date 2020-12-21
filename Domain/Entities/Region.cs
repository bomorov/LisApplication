using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    public class Region:AuditableEntity
    {
        public  string Name { get; set; }
        public  string Code { get; set; }
        public  IList<Area> Areas { get; set; }

        public Region()
        {
            Areas=new List<Area>();
        }
    }
}
