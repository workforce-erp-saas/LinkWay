
using LinkWay.Domain.Entities.Common;
using LinkWay.Domain.Enums.DataMigration;

namespace LinkWay.Domain.Entities.DataMigration;

public class ImportColumnMapping : TenantEntity
{
    public string Name { get; set; }
    public ImportDataType DataType { get; set; }
    public string? ColumnMap { get; set; }
    public string? DefaultValues { get; set; }
    public string? Transformations { get; set; }
}
