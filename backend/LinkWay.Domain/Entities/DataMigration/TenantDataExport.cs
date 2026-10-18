
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.DataMigration;

namespace LinkWay.Domain.Entities.DataMigration;

public class TenantDataExport : TenantEntity
{
    public ExportStatus Status { get; set; }
    public int? FileId { get; set; }
    public DateTime RequestedAt { get; set; }
    public Guid? RequestedBy { get; set; }
    public DateTime? GeneratedAt { get; set; }
    public DateTime? DownloadedAt { get; set; }
    public Guid? DownloadedBy { get; set; }
    public DateTime? ExpiresAt { get; set; }
}
