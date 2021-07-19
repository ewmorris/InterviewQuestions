CREATE FUNCTION [dbo].[MostPopularDay]
(
	
)
RETURNS Date
AS
BEGIN
	DECLARE @PopularDay AS DATE
	SELECT TOP 1  @PopularDay = Reserved FROM CampsiteReserved GROUP BY Reserved ORDER BY COUNT(Reserved) DESC 
	RETURN @PopularDay
END
