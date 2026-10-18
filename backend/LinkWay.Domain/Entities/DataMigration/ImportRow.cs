
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.DataMigration;

namespace LinkWay.Domain.Entities.DataMigration;

public class ImportRow : TenantEntity
{
    public int BatchId { get; set; }
    public int RowNumber { get; set; }
    public string? RawData { get; set; }
    public ImportRowStatus Status { get; set; }
    public string? Errors { get; set; }
}
