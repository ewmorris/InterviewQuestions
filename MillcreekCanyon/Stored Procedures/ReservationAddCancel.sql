CREATE PROCEDURE [dbo].[ReservationAddCancel]
	@crud varchar(1),
	@reservationId int,
	@reserved datetime,
	@campsiteId int
	

AS
BEGIN
DECLARE @available AS INT;
SET @available = 0;

	IF @crud = 'D'
		BEGIN
		    
			DELETE CampsiteReserved WHERE Id = @reservationId;
			INSERT INTO CampsiteAvailable (CampsiteId, Available) VALUES (@campsiteId, @reserved);
		END
	ELSE
		BEGIN	
		    
			SELECT @available = COUNT(Id)  FROM CampsiteAvailable WHERE CampsiteId = @campsiteId AND Available = @reserved

			IF @available >= 1
			BEGIN
				INSERT INTO CampsiteReserved (CampsiteId, Reserved) VALUES (@campsiteId, @reserved);
				DELETE CampsiteAvailable WHERE CampsiteId = @campsiteId AND Available = @reserved;
			END
		END		
END