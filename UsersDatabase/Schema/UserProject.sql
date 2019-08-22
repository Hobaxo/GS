USE [Users]
GO

IF OBJECT_ID('[dbo].[UserProject]', 'U') IS NULL
BEGIN
	CREATE TABLE [dbo].[UserProject]
	(
		[UserId]		INT			NOT NULL
		,[ProjectId]	INT			NOT NULL
		,[IsActive]		BIT			NOT NULL
		,[AssignedDate]	DATETIME	NOT NULL

		,CONSTRAINT FK_UserProject_UserId FOREIGN KEY(UserId) REFERENCES [dbo].[User](Id)
		,CONSTRAINT FK_UserProject_ProjectId FOREIGN KEY(ProjectId) REFERENCES [dbo].[Project](Id)
	)
END
GO