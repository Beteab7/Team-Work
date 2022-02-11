
GO
ALTER TRIGGER trgdeleteTask
ON Task
FOR DELETE
AS
BEGIN
	DECLARE @actionPerformed VARCHAR(100), @projectID int
	
	SELECT @actionPerformed = dbo.getTaskName(deleted.tid, deleted.projectId)
	FROM deleted

	SET @actionPerformed += 'Deleted'

	SELECT @projectID = projectId
	FROM deleted

	INSERT INTO ProjectLog
	VALUES (@projectID, @actionPerformed, GETDATE())
END

--------------------------------------------------

GO
CREATE TRIGGER trgInsertTask
ON Task
FOR INSERT
AS
BEGIN
	DECLARE @actionPerformed VARCHAR(100), @projectID int
	
	SELECT @actionPerformed = dbo.getTaskName(inserted.tid, inserted.projectId)
	FROM inserted

	SET @actionPerformed += 'Inserted'

	SELECT @projectID = projectId
	FROM inserted

	INSERT INTO ProjectLog
	VALUES (@projectID, @actionPerformed, GETDATE())
END

--------------------------------------------------

GO
alter TRIGGER trgUpdateProject
ON Project
FOR UPDATE
AS
BEGIN
	DECLARE @actionPerformed VARCHAR(100), @projectID int
	
	SELECT @projectID = [pid]
	FROM inserted
	
	SELECT @actionPerformed = dbo.getProjectLog(@projectID)+ ' Updated'
	FROM inserted

	INSERT INTO ProjectLog
	VALUES (@projectID, @actionPerformed, GETDATE())
END

--------------------------------------------------

GO
CREATE TRIGGER trgDeleteProject
ON Project
FOR Delete
AS
BEGIN
	DECLARE @actionPerformed VARCHAR(100), @projectID int
	
	SELECT @projectID = [pid]
	FROM inserted
	
	SELECT @actionPerformed = dbo. getProjectLog(@projectID)+ ' Deleted'
	FROM inserted

	INSERT INTO ProjectLog
	VALUES (@projectID, @actionPerformed, GETDATE())
END

--------------------------------------------------

GO
CREATE TRIGGER trgInsertProject
ON Project
FOR INSERT
AS
BEGIN
	DECLARE @actionPerformed VARCHAR(100), @projectID int
	
	SELECT @projectID = [pid]
	FROM inserted
	
	SELECT @actionPerformed = dbo. getProjectLog(@projectID)+ 'Insert'
	FROM inserted

	INSERT INTO ProjectLog
	VALUES (@projectID, @actionPerformed, GETDATE())
END