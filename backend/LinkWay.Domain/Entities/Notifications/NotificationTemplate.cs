
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Notifications;

namespace LinkWay.Domain.Entities.Notifications;

public class NotificationTemplate : TenantEntity
{
    public string Code { get; set; }
    public NotifChannel Channel { get; set; }
    public string Language { get; set; }
    public string Subject { get; set; }
    public string Body { get; set; }
}
