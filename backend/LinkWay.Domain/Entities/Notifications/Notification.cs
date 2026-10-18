
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Notifications;

namespace LinkWay.Domain.Entities.Notifications;

public class Notification : TenantEntity
{
    public Guid? UserId { get; set; }
    public string? RecipientEmail { get; set; }
    public NotifChannel Channel { get; set; }
    public string? TemplateCode { get; set; }
    public string Language { get; set; }
    public string? Subject { get; set; }
    public string Body { get; set; }
    public string? RelatedTable { get; set; }
    public int? RelatedId { get; set; }
    public NotifStatus Status { get; set; }
    public DateTime? SentAt { get; set; }
    public string? FailureReason { get; set; }
    public DateTime? ReadAt { get; set; }
}
