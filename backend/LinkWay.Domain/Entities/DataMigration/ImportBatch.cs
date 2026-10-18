
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.DataMigration;

namespace LinkWay.Domain.Entities.DataMigration;

public class ImportBatch : TenantEntity
{
    public int? MigrationProjectId { get; set; }
    public ImportDataType DataType { get; set; }
    public int? FileId { get; set; }
    public int? MappingId { get; set; }
    public DuplicatePolicy DuplicatePolicy { get; set; }
    public ImportBatchStatus Status { get; set; }
    public int TotalRows { get; set; }
    public int ValidRows { get; set; }
    public int InvalidRows { get; set; }
    public int ImportedRows { get; set; }
    public int FailedRows { get; set; }
    public int? ErrorReportFileId { get; set; }
    public DateTime? PreviewApprovedAt { get; set; }
    public Guid? PreviewApprovedBy { get; set; }
    public DateTime? ImportedAt { get; set; }
    public Guid? ImportedBy { get; set; }
    public DateTime? UndoneAt { get; set; }
    public Guid? UndoneBy { get; set; }
    public string? UndoReason { get; set; }
}
