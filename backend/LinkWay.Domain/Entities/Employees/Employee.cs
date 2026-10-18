
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Employees;

namespace LinkWay.Domain.Entities.Employees;

public class Employee : GuidTenantEntity
{
    public string EmployeeCode { get; set; }
    public string FullName { get; set; }
    public string? Nationality { get; set; }
    public string? Phone { get; set; }
    public DateOnly? DateOfBirth { get; set; }
    public DateOnly? HireDate { get; set; }
    public int? DesignationId { get; set; }
    public string? PassportNo { get; set; }
    public DateOnly? PassportExpiry { get; set; }
    public int? PassportFileId { get; set; }
    public string? Trade { get; set; }
    public decimal? ExperienceYears { get; set; }
    public EmployeeStatus Status { get; set; }
    public DateOnly? TerminationDate { get; set; }
    public DateTime? TerminatedAt { get; set; }
    public Guid? TerminatedBy { get; set; }
    public string? TerminationReason { get; set; }
}
