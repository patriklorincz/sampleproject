CREATE TABLE [dbo].[Providers] (
    [Id]      UNIQUEIDENTIFIER CONSTRAINT [DF_Providers_Id] DEFAULT (newid()) NOT NULL,
    [Name]    VARCHAR (50)     NOT NULL,
    [Address] VARCHAR (50)     NULL,
    CONSTRAINT [PK_Providers] PRIMARY KEY CLUSTERED ([Id] ASC)
);

