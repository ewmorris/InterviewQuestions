/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/
DELETE CampsiteReserved
DELETE CampsiteAvailable
DELETE Campsite

SET IDENTITY_INSERT Campsite ON
INSERT INTO Campsite (Id, Name) VALUES (1,'Campsite A')
INSERT INTO Campsite (Id, Name) VALUES (2,'Campsite B')
INSERT INTO Campsite (Id, Name) VALUES (3,'Campsite C')
INSERT INTO Campsite (Id, Name) VALUES (4,'Campsite D')
SET IDENTITY_INSERT Campsite OFF

SET IDENTITY_INSERT CampsiteReserved ON
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (1, 1, '9/1/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (2, 2, '9/1/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (3, 2, '9/2/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (4, 3, '9/1/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (5, 3, '9/2/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (6, 3, '9/3/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (7, 4, '9/1/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (8, 4, '9/2/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (9, 4, '9/3/2021')
INSERT INTO CampsiteReserved (Id, CampsiteId, Reserved) VALUES (10, 4, '9/4/2021')
SET IDENTITY_INSERT CampsiteReserved OFF

SET IDENTITY_INSERT CampsiteAvailable ON
INSERT INTO CampsiteAvailable (Id, CampsiteId, Available) VALUES (1,1,'9/2/2021')
INSERT INTO CampsiteAvailable (Id, CampsiteId, Available) VALUES (2,1,'9/3/2021')
INSERT INTO CampsiteAvailable (Id, CampsiteId, Available) VALUES (3,1,'9/4/2021')
INSERT INTO CampsiteAvailable (Id, CampsiteId, Available) VALUES (4,2,'9/3/2021')
INSERT INTO CampsiteAvailable (Id, CampsiteId, Available) VALUES (5,2,'9/4/2021')
INSERT INTO CampsiteAvailable (Id, CampsiteId, Available) VALUES (6,3,'9/4/2021')
SET IDENTITY_INSERT CampsiteAvailable OFF