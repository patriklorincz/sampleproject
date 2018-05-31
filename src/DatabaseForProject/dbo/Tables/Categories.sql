CREATE TABLE [dbo].[Categories] (
    [Id]   UNIQUEIDENTIFIER CONSTRAINT [DF_Categories_Id] DEFAULT (newid()) NOT NULL,
    [Name] VARCHAR (50)     NOT NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY CLUSTERED ([Id] ASC)
);

