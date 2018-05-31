CREATE TABLE [dbo].[Stocks] (
    [IdWarehouse] UNIQUEIDENTIFIER NOT NULL,
    [IdProduct]   UNIQUEIDENTIFIER NOT NULL,
    [Price]       REAL             NOT NULL,
    [Quantity]    INT              CONSTRAINT [DF_Stocks_Quantity] DEFAULT ((0)) NOT NULL,
    CONSTRAINT [QuantityGreaterThanZero] CHECK ([Quantity]>=(0)),
    CONSTRAINT [StockPriceGreaterThanZero] CHECK ([Price]>(0)),
    CONSTRAINT [FK_Stocks_Products] FOREIGN KEY ([IdProduct]) REFERENCES [dbo].[Products] ([Id]),
    CONSTRAINT [FK_Stocks_Warehouses] FOREIGN KEY ([IdWarehouse]) REFERENCES [dbo].[Warehouses] ([Id])
);

