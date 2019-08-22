USE [Users]
GO

IF OBJECT_ID('[dbo].[UserProject]', 'U') IS NULL
BEGIN
	CREATE TABLE [dbo].[User]
	(
		[Id]			INT				NOT NULL PRIMARY KEY
		,[FirstName]	NVARCHAR(50)	NOT NULL
		,[LastName]		NVARCHAR(50)	NOT NULL
	)
END
GO