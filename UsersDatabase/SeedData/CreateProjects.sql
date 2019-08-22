﻿INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 1, DATEADD(DAY, DATEDIFF(DAY, 0, GETDATE()), 0), DATEADD(MONTH, 1, DATEDIFF(DAY, 0, GETDATE())), 1
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 1)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 2, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0), DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 31), 2
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 2)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 3, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0), DATEADD(DAY, -1, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())+1, 0))), 3
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 3)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 4, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0), DATEADD(MONTH, DATEDIFF(MONTH, -1, GETDATE())+1, -1), 4
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 4)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 5, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE()), 0), DATEADD(MONTH, DATEDIFF(MONTH, -1, GETDATE()), -1), 5
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 5)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 6, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())-1, 0), DATEADD(MONTH, DATEDIFF(MONTH, -1, GETDATE()), -1), 6
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 6)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 7, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())-1, 0), DATEADD(DAY, -1, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())+1, 0))), 7
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 7)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 8, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())-1, 0), DATEADD(DAY, -1, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())+1, 0))), 8
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 8)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 9, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())-2, 0), DATEADD(DAY, -1, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())-1, 0))), 9
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 9)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 10, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())-1, 0), DATEADD(DAY, -1, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0))), 10
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 10)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 11, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())+1, 0), DATEADD(DAY, -1, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())+1, 0))), 11
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 11)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 12, DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())+1, 0), DATEADD(WEEK,DATEDIFF(WEEK,0,GETDATE()),6), 12
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 12)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 13, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0), DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())-1, 0)-1, 13
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 13)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 14, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())-1, 0), DATEADD(MONTH, 6, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())-1, 0)))-1, 14
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 14)

INSERT INTO [dbo].[Project] (Id, StartDate, EndDate, Credits)
SELECT 15, DATEADD(MONTH, 6, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE())-1, 0))), DATEADD(DAY, -1, DATEADD(YEAR, 0, DATEADD(YEAR, DATEDIFF(YEAR, 0, GETDATE()), 0))), 15
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[Project] WHERE Id = 15)