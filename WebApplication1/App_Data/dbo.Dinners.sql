CREATE TABLE [dbo].[Dinners] (
    [DinnerID]     INT            IDENTITY (1, 1) NOT NULL,
    [Title]        NVARCHAR (50)  NOT NULL,
    [EventDate]    DATETIME       NOT NULL,
    [Description]  NVARCHAR (256) NOT NULL,
    [HostedBy]     NVARCHAR (20)  NOT NULL,
    [ContactPhone] NVARCHAR (20)  NOT NULL,
    [Address]      NVARCHAR (50)  NOT NULL,
    [Country]      NCHAR (30)     NOT NULL,
    [Latitude]     FLOAT (53)     NULL,
    [Logitude]     FLOAT (53)     NULL, 
    CONSTRAINT [PK_Dinners] PRIMARY KEY ([DinnerID])
);

