CREATE VIEW [dbo].[AvailableCampsites]
	AS SELECT c.Name as Campsite, ca.Available as [Available Date] FROM [CampsiteAvailable] ca
	   LEFT JOIN 
		[Campsite] c ON
			ca.CampsiteId = c.Id
