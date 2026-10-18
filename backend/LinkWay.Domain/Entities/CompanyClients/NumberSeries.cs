
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.BillingFinance;

namespace LinkWay.Domain.Entities.CompanyClients;

public class NumberSeries : TenantEntity
{
    public DocNumberType DocType { get; set; }
    public string Prefix { get; set; }
    public short FiscalYear { get; set; }
    public long LastNumber { get; set; }
}
