using System;
using System.Collections.Generic;
using System.Text;
using Domain.Common;
using Domain.Enums;

namespace Domain.Entities
{
    public  class Hospital:AuditableEntity
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public  HospitalType Type { get; set; }
        public  string Adress { get; set; }
        public  string FullName { get; set; }
        public  string Boss { get; set; }
    }
}
