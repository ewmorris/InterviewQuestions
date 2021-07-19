CREATE TABLE [dbo].[CampsiteAvailable]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [CampsiteId] INT NOT NULL, 
    [Available] DATE NOT NULL, 
    CONSTRAINT [FK_CampsiteAvailable_ToCampsite] FOREIGN KEY (CampsiteId) REFERENCES [CampSite]([Id])
)
