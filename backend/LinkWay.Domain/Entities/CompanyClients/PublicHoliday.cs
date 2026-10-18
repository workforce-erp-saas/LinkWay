
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.CompanyClients;

public class PublicHoliday : TenantEntity
{
    public DateOnly HolidayDate { get; set; }
    public string Name { get; set; }
}
