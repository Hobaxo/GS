INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 1, 1, 1, '2019-08-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 1 AND ProjectId = 1)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 2, 2, 1, '2019-08-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 2 AND ProjectId = 2)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 3, 3, 1, '2019-08-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 3 AND ProjectId = 3)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 1, 4, 0, '2019-09-15'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 1 AND ProjectId = 4)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 2, 5, 0, '2019-09-15'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 2 AND ProjectId = 5)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 3, 6, 0, '2019-09-15'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 3 AND ProjectId = 6)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 1, 7, 1, '2019-01-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 1 AND ProjectId = 7)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 2, 8, 1, '2019-01-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 2 AND ProjectId = 8)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 3, 9, 1, '2019-01-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 3 AND ProjectId = 9)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 1, 10, 0, '2018-06-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 1 AND ProjectId = 10)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 2, 11, 0, '2018-06-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 2 AND ProjectId = 11)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 3, 12, 0, '2018-06-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 3 AND ProjectId = 12)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 1, 13, 1, '2018-09-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 1 AND ProjectId = 13)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 2, 14, 1, '2018-09-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 2 AND ProjectId = 14)

INSERT INTO [dbo].[UserProject] (UserId, ProjectId, IsActive, AssignedDate)
SELECT 3, 15, 1, '2018-09-01'
WHERE NOT EXISTS (SELECT 1 FROM [dbo].[UserProject] WHERE UserId = 3 AND ProjectId = 15)