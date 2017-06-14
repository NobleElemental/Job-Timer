CREATE TABLE [dbo].JobTimer
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [jobNumber] INT NOT NULL, 
    [Description] NVARCHAR(MAX) NULL, 
    [Time] INT NULL
)
