CREATE TABLE [dbo].[Table]
(
	[DinnerID] INT NOT NULL IDENTITY, 
    [Title] NVARCHAR(50) NOT NULL, 
    [EventDate] DATETIME NOT NULL, 
    [Description] NVARCHAR(MAX) NOT NULL, 
    [HostedBy] NVARCHAR(50) NOT NULL, 
    [ContactPhone] NVARCHAR(50) NOT NULL, 
    [Address] NVARCHAR(50) NOT NULL, 
    [Country] NCHAR(10) NOT NULL, 
    [Latitude] FLOAT NOT NULL, 
    [Logitude] FLOAT NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([DinnerID]) 
)
