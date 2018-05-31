CREATE TABLE [dbo].[Warehouses] (
    [Id]       UNIQUEIDENTIFIER CONSTRAINT [DF_Warehouses_Id] DEFAULT (newid()) NOT NULL,
    [Name]     VARCHAR (50)     NOT NULL,
    [Location] VARCHAR (50)     NULL,
    CONSTRAINT [PK_Warehouses] PRIMARY KEY CLUSTERED ([Id] ASC)
);

