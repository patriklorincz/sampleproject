CREATE TABLE [dbo].[ProviderSupply] (
    [IdProvider] UNIQUEIDENTIFIER NOT NULL,
    [IdProduct]  UNIQUEIDENTIFIER NOT NULL,
    [Price]      REAL             NOT NULL,
    CONSTRAINT [PriceGreaterThanZero] CHECK ([Price]>(0)),
    CONSTRAINT [FK_ProviderSupply_Products] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_ProviderSupply_Providers] FOREIGN KEY ([IdProvider]) REFERENCES [dbo].[Providers] ([Id])
);

