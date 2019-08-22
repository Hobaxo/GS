/*
--------------------------------------------------------------------------------------
HUB - This script inserts the default users into the User table. - Aug 21, 2019
--------------------------------------------------------------------------------------
*/

INSERT INTO [dbo].[User] (Id, FirstName, LastName)
SELECT 1, N'Herberth', N'Urena'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[User] WHERE Id = 1)

INSERT INTO [dbo].[User] (Id, FirstName, LastName)
SELECT 2, N'Alex', N'Ujueta'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[User] WHERE Id = 2)

INSERT INTO [dbo].[User] (Id, FirstName, LastName)
SELECT 3, N'Carlos', N'Mendez'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[User] WHERE Id = 3)