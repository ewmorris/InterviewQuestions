CREATE TABLE [dbo].[CampsiteReserved]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CampsiteId] INT NOT NULL, 
    [Reserved] DATE NOT NULL, 
    CONSTRAINT [FK_CampsiteReserved_Campsite] FOREIGN KEY ([CampsiteId]) REFERENCES [Campsite]([Id])
)
