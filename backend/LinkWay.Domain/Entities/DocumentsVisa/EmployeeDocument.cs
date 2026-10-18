
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.DocumentsVisa;

namespace LinkWay.Domain.Entities.DocumentsVisa;

public class EmployeeDocument : GuidTenantEntity
{
    public Guid EmployeeId { get; set; }
    public EmployeeDocType DocType { get; set; }
    public string? DocNumber { get; set; }
    public DateOnly? IssueDate { get; set; }
    public DateOnly? ExpiryDate { get; set; }
    public int? FileId { get; set; }
    public DocVersionStatus VersionStatus { get; set; }
}
