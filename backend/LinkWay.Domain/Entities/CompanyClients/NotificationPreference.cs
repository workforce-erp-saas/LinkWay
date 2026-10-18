
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.Notifications;

namespace LinkWay.Domain.Entities.CompanyClients;

public class NotificationPreference : TenantEntity
{
    public NotifChannel Channel { get; set; }
    public string Language { get; set; }
    public bool IsEnabled { get; set; }
}
