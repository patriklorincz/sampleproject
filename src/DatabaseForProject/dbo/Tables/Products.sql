CREATE TABLE [dbo].[Products] (
    [Id]         UNIQUEIDENTIFIER CONSTRAINT [DF_Products_Id] DEFAULT (newid()) NOT NULL,
    [Name]       VARCHAR (50)     NOT NULL,
    [CategoryId] UNIQUEIDENTIFIER NOT NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_Products_Categories] FOREIGN KEY ([CategoryId]) REFERENCES [dbo].[Categories] ([Id])
);

