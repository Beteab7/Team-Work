GO
CREATE TRIGGER DeleteProject
ON Project
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @pid int
	
	SELECT @PID = deleted.pid
	FROM deleted

	DELETE FROM ProjectMember
	WHERE @pid = ProjectId
	
	DELETE FROM Project
	WHERE @pid = [pid]
END

--------------------------------------------------

GO
CREATE TRIGGER DeleteTask
ON Task
INSTEAD OF DELETE
AS
BEGIN
	DECLARE @tid int
	
	SELECT @tid = deleted.tid
	FROM deleted

	DELETE FROM TaskMember
	WHERE @tid = TaskId
	
	DELETE FROM Task
	WHERE @tid = [tid]
END

--------------------------------------------------

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
CREATE TRIGGER trgUpdateProject
ON Project
FOR UPDATE
AS
BEGIN
	DECLARE @actionPerformed VARCHAR(100), @projectID int
	
	SELECT @projectID = [pid]
	FROM inserted
	
	SELECT @actionPerformed = dbo. getProjectLog(@projectID)
	FROM inserted

	INSERT INTO ProjectLog
	VALUES (@projectID, @actionPerformed, GETDATE())
END

select * from Project
select * from TaskMember