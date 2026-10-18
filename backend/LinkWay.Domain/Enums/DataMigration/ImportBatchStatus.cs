namespace LinkWay.Domain.Enums.DataMigration;

public enum ImportBatchStatus
{
    Uploaded,
    Validated,
    PreviewApproved,
    Imported,
    PartiallyImported,
    Undone,
    Failed
}
