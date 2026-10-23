
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.SaaS;

public class Feature : AuditableEntity
{
    public string Code { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string? Description { get; set; }
}
