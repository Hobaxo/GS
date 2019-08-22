USE [Users]
GO

IF OBJECT_ID('[dbo].[UserProject]', 'U') IS NULL
BEGIN
	CREATE TABLE [dbo].[Project]
	(
		[Id]			INT			NOT NULL PRIMARY KEY
		,[StartDate]	DATETIME	NOT NULL
		,[EndDate]		DATETIME	NOT NULL
		,[Credits]		INT			NOT NULL
	)
END
GO