using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Domain.Interfaces
{
    public interface IAudit
    {
        int AuditId { get; set; }
        DateTime AuditDate { get; set; }
        string AuditAction { get; set; }
        string AuditUserName { get; set; }
        string AuditMachineName { get; set; }
        int AuditUserId { get; set; }
        string JsonChangedData { get; set; }
    }
}
