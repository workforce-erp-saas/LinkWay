
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.DataMigration;

namespace LinkWay.Domain.Entities.DataMigration;

public class ImportDocumentFile : TenantEntity
{
    public int BatchId { get; set; }
    public int FileId { get; set; }
    public string? MatchKey { get; set; }
    public int? MatchedEmployeeId { get; set; }
    public int? MatchedDocumentId { get; set; }
    public ImportRowStatus Status { get; set; }
}
