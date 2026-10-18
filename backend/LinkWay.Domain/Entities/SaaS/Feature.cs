
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.SaaS;

public class Feature : AuditableEntity
{
    public string Code { get; set; }
    public string Name { get; set; }
    public string? Description { get; set; }
}
