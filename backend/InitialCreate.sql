IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
CREATE TABLE [Features] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(100) NOT NULL,
    [Name] nvarchar(150) NOT NULL,
    [Description] nvarchar(500) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    CONSTRAINT [PK_Features] PRIMARY KEY ([Id])
);

CREATE TABLE [Plan] (
    [Id] int NOT NULL IDENTITY,
    [Code] nvarchar(50) NOT NULL,
    [Name] nvarchar(150) NOT NULL,
    [Price] decimal(12,2) NOT NULL,
    [Currency] char(3) NOT NULL,
    [BillingCycle] int NOT NULL,
    [MaxUsers] int NOT NULL,
    [MaxEmployees] int NOT NULL,
    [MaxClients] int NOT NULL,
    [TrialDays] int NOT NULL,
    [GraceDays] int NOT NULL,
    [PublishedAt] datetime2 NULL,
    [PublishedBy] uniqueidentifier NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    CONSTRAINT [PK_Plan] PRIMARY KEY ([Id])
);

CREATE TABLE [PlatformSetting] (
    [Id] int NOT NULL IDENTITY,
    [LegalName] nvarchar(200) NOT NULL,
    [TradeName] nvarchar(200) NULL,
    [Trn] nvarchar(50) NULL,
    [Address] nvarchar(500) NULL,
    [Email] nvarchar(200) NULL,
    [Phone] nvarchar(15) NULL,
    [Currency] char(3) NOT NULL,
    [VatRate] decimal(5,2) NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    CONSTRAINT [PK_PlatformSetting] PRIMARY KEY ([Id])
);

CREATE TABLE [Tenants] (
    [Id] uniqueidentifier NOT NULL,
    [Code] nvarchar(50) NOT NULL,
    [LegalName] nvarchar(200) NOT NULL,
    [TradeName] nvarchar(200) NULL,
    [TradeLicenceNo] nvarchar(100) NULL,
    [TradeLicenceExpiry] date NULL,
    [Trn] nvarchar(50) NULL,
    [Email] nvarchar(200) NOT NULL,
    [Phone] nvarchar(20) NULL,
    [Address] nvarchar(500) NULL,
    [LogoFileId] int NULL,
    [Status] int NOT NULL,
    [SignupSource] int NOT NULL,
    [Currency] char(3) NOT NULL,
    [VatRate] decimal(5,2) NOT NULL,
    [LastActivityAt] datetime2 NULL,
    [DeactivatedAt] datetime2 NULL,
    [DeactivatedBy] uniqueidentifier NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    CONSTRAINT [PK_Tenants] PRIMARY KEY ([Id])
);

CREATE TABLE [PlanFeatures] (
    [Id] int NOT NULL IDENTITY,
    [PlanId] int NOT NULL,
    [FeatureId] int NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    CONSTRAINT [PK_PlanFeatures] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_PlanFeatures_Features_FeatureId] FOREIGN KEY ([FeatureId]) REFERENCES [Features] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_PlanFeatures_Plan_PlanId] FOREIGN KEY ([PlanId]) REFERENCES [Plan] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [TenantSettings] (
    [Id] int NOT NULL IDENTITY,
    [Currency] char(3) NOT NULL,
    [VatRate] decimal(5,2) NOT NULL,
    [DateFormat] nvarchar(30) NOT NULL,
    [NormalHoursPerDay] decimal(4,2) NOT NULL,
    [WeeklyOffDay] smallint NOT NULL,
    [MarginThresholdPct] decimal(5,2) NOT NULL,
    [LeaveSalaryTiming] int NOT NULL,
    [MohreEstablishmentId] nvarchar(100) NULL,
    [WpsEmployerId] nvarchar(100) NULL,
    [WpsAgentId] int NULL,
    [WpsEmployerAccount] nvarchar(100) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    [TenantId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TenantSettings] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TenantSettings_Tenants_TenantId] FOREIGN KEY ([TenantId]) REFERENCES [Tenants] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [TenantStatusHistory] (
    [Id] int NOT NULL IDENTITY,
    [FromStatus] int NOT NULL,
    [ToStatus] int NOT NULL,
    [ChangedAt] datetime2 NOT NULL,
    [ChangedBy] uniqueidentifier NULL,
    [Reason] nvarchar(500) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    [TenantId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TenantStatusHistory] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TenantStatusHistory_Tenants_TenantId] FOREIGN KEY ([TenantId]) REFERENCES [Tenants] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [TenantSubscriptions] (
    [Id] uniqueidentifier NOT NULL,
    [PlanId] int NOT NULL,
    [Status] int NOT NULL,
    [StartDate] date NOT NULL,
    [EndDate] date NULL,
    [GraceEndsOn] date NULL,
    [AutoRenew] bit NOT NULL,
    [PlanNameSnapshot] nvarchar(150) NOT NULL,
    [PriceSnapshot] decimal(12,2) NOT NULL,
    [BillingCycleSnapshot] int NOT NULL,
    [MaxUsersSnapshot] int NOT NULL,
    [MaxEmployeesSnapshot] int NOT NULL,
    [MaxClientsSnapshot] int NOT NULL,
    [RenewedFromId] uniqueidentifier NULL,
    [CancelledAt] datetime2 NULL,
    [CancelledBy] uniqueidentifier NULL,
    [CancelReason] nvarchar(500) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    [TenantId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_TenantSubscriptions] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_TenantSubscriptions_Plan_PlanId] FOREIGN KEY ([PlanId]) REFERENCES [Plan] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TenantSubscriptions_TenantSubscriptions_RenewedFromId] FOREIGN KEY ([RenewedFromId]) REFERENCES [TenantSubscriptions] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_TenantSubscriptions_Tenants_TenantId] FOREIGN KEY ([TenantId]) REFERENCES [Tenants] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [SubscriptionInvoices] (
    [Id] uniqueidentifier NOT NULL,
    [SubscriptionId] uniqueidentifier NOT NULL,
    [InvoiceNo] nvarchar(50) NOT NULL,
    [IssueDate] date NOT NULL,
    [DueDate] date NULL,
    [Subtotal] decimal(12,2) NOT NULL,
    [VatAmount] decimal(12,2) NOT NULL,
    [Total] decimal(12,2) NOT NULL,
    [Status] int NOT NULL,
    [IssuedAt] datetime2 NULL,
    [IssuedBy] uniqueidentifier NULL,
    [VoidedAt] datetime2 NULL,
    [VoidedBy] uniqueidentifier NULL,
    [VoidReason] nvarchar(500) NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    [TenantId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_SubscriptionInvoices] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SubscriptionInvoices_TenantSubscriptions_SubscriptionId] FOREIGN KEY ([SubscriptionId]) REFERENCES [TenantSubscriptions] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SubscriptionInvoices_Tenants_TenantId] FOREIGN KEY ([TenantId]) REFERENCES [Tenants] ([Id]) ON DELETE NO ACTION
);

CREATE TABLE [SubscriptionPayments] (
    [Id] uniqueidentifier NOT NULL,
    [SubscriptionInvoiceId] uniqueidentifier NOT NULL,
    [Amount] decimal(18,2) NOT NULL,
    [Method] int NOT NULL,
    [ReferenceNo] nvarchar(100) NULL,
    [PaidOn] date NOT NULL,
    [CreatedAt] datetime2 NOT NULL,
    [CreatedBy] uniqueidentifier NULL,
    [UpdatedAt] datetime2 NULL,
    [UpdatedBy] uniqueidentifier NULL,
    [TenantId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_SubscriptionPayments] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_SubscriptionPayments_SubscriptionInvoices_SubscriptionInvoiceId] FOREIGN KEY ([SubscriptionInvoiceId]) REFERENCES [SubscriptionInvoices] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_SubscriptionPayments_Tenants_TenantId] FOREIGN KEY ([TenantId]) REFERENCES [Tenants] ([Id]) ON DELETE NO ACTION
);

CREATE UNIQUE INDEX [IX_Features_Code] ON [Features] ([Code]);

CREATE UNIQUE INDEX [IX_Plan_Code] ON [Plan] ([Code]);

CREATE INDEX [IX_PlanFeatures_FeatureId] ON [PlanFeatures] ([FeatureId]);

CREATE UNIQUE INDEX [IX_PlanFeatures_PlanId_FeatureId] ON [PlanFeatures] ([PlanId], [FeatureId]);

CREATE INDEX [IX_SubscriptionInvoices_SubscriptionId] ON [SubscriptionInvoices] ([SubscriptionId]);

CREATE UNIQUE INDEX [IX_SubscriptionInvoices_TenantId_InvoiceNo] ON [SubscriptionInvoices] ([TenantId], [InvoiceNo]);

CREATE INDEX [IX_SubscriptionInvoices_TenantId_Status_IssueDate] ON [SubscriptionInvoices] ([TenantId], [Status], [IssueDate]);

CREATE INDEX [IX_SubscriptionPayments_SubscriptionInvoiceId] ON [SubscriptionPayments] ([SubscriptionInvoiceId]);

CREATE INDEX [IX_SubscriptionPayments_TenantId_PaidOn] ON [SubscriptionPayments] ([TenantId], [PaidOn]);

CREATE UNIQUE INDEX [IX_Tenants_Code] ON [Tenants] ([Code]);

CREATE UNIQUE INDEX [IX_TenantSettings_TenantId] ON [TenantSettings] ([TenantId]);

CREATE INDEX [IX_TenantStatusHistory_TenantId_ChangedAt] ON [TenantStatusHistory] ([TenantId], [ChangedAt]);

CREATE INDEX [IX_TenantSubscriptions_PlanId] ON [TenantSubscriptions] ([PlanId]);

CREATE INDEX [IX_TenantSubscriptions_RenewedFromId] ON [TenantSubscriptions] ([RenewedFromId]);

CREATE INDEX [IX_TenantSubscriptions_TenantId_Status] ON [TenantSubscriptions] ([TenantId], [Status]);

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20261023142453_InitialCreate', N'10.0.13');

COMMIT;
GO

