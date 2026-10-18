
using LinkWay.Domain.Entities.Common;

namespace LinkWay.Domain.Entities.FilesStorage;

public class File : TenantEntity
{
    public string StorageKey { get; set; }
    public string OriginalName { get; set; }
    public string MimeType { get; set; }
    public long SizeBytes { get; set; }
    public string Sha256 { get; set; }
}
