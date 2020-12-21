using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;

namespace Domain.Entities
{
    public class Area:AuditableEntity
    {
        public  string Name { get; set; }
        public  string Code { get; set; }
        public int RegionId { get; set; }
        public  Region Region { get; set; }
    }
}
