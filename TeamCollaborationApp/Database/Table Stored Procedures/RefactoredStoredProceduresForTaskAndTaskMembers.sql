/*********************************************************************************
 _________________________________________________________________________________
					STORED PROCEDURES FOR TASK TABLE
 _________________________________________________________________________________
 *********************************************************************************/

----------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR INSERT OPERATIONS             */
----------------------------------------------------------------------------------


GO
/*
	A stored procedure to insert values
	into the task table takes all the necessary
	values and performs an insert statement.
*/
create PROC spInsertTask
	(
	-- [!!] id is omitted since it's an auto incrementing property.
	@name VARCHAR(50),
	@description VARCHAR(200),
	@priority INT,
	@completion BIT,
	@projectId INT,
	@deadline DATETIME
	)
AS
BEGIN
INSERT INTO TASK 
VALUES
	(
	@name,
	@description,
	@priority,
	@completion,
	@projectId,
	GETDATE(),
	@deadline
	)
END

----------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR READ OPERATIONS               */
----------------------------------------------------------------------------------

GO
/*
	A stored procedure to fetch all the datas
	from the database. 
	Performs select all statement.
*/
create PROC spFetchTasks
AS
BEGIN
	SELECT * FROM Task;
END

-----------------------------------------------------

GO
-- Fetch all the tasks ordered by their priority
create PROC spFetchTasksOrderedByPriority
AS
BEGIN
	SELECT * FROM TASK ORDER BY TASK.Priority;
END

-----------------------------------------------------

GO
create PROC spFetchTasksOrderedByName
AS
BEGIN
--	Fetch all the tasks ordered by their name.
	SELECT * FROM TASK ORDER BY TASK.Name;
END

-----------------------------------------------------

GO
create PROC spFetchSingleTaskById
 @taskId INT
AS
BEGIN
	SELECT * FROM TASK 
	WHERE TASK.TID = @taskId

END;

-----------------------------------------------------

GO
create PROC spFetchTasksByProject
(@projectID INT)
AS
BEGIN
  SELECT *
  FROM Task
  WHERE projectId=@projectID;
END


----------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR UPDATE OPERATIONS               */
----------------------------------------------------------------------------------
GO
CREATE PROC spUpdateTaskDeadLine
	(@taskId INT, @deadline DATETIME2)
AS
BEGIN
	UPDATE Task
	SET Task.Deadline = @deadline
	WHERE Task.[tid] = @taskId;
END
select * from task;
GO
create PROC spUpdateTaskName
	(@taskId INT, @name VARCHAR(50))
AS
BEGIN
	UPDATE Task
	SET Task.[Name] = @name
	WHERE Task.[tid] = @taskId;
END

-----------------------------------------------------
GO
create PROC spUpdateTaskDescription
	(@taskId INT, @description VARCHAR(200))
AS
BEGIN
	UPDATE Task
	SET Task.[Description] = @description
	WHERE Task.[tid] = @taskId;
END
-----------------------------------------------------
GO
create PROC spUpdateTaskPriority
	(@taskId INT, @priority int)
AS
BEGIN
	UPDATE Task
	SET Task.[Priority] = @priority
	WHERE Task.[tid] = @taskId;
END

----------------------------------------------------
GO
create PROC spUpdateTaskCompletion
	(@taskId INT, @completion bit)
AS
BEGIN
	UPDATE Task
	SET Task.Completion = @completion
	WHERE Task.[tid] = @taskId;
END

-----------------------------------------------------
GO
create PROC spUpdateTask
	(
	@id INT,
	@name VARCHAR(50),
	@description VARCHAR(200),
	@priority INT,
	@completion BIT,
	@projectId INT,
	@deadline DATETIME2
	)
AS
BEGIN
	UPDATE Task
	SET 
			Task.[name] = @name,
			Task.[description] = @description,
			Task.[priority] = @priority,
			Task.[completion] = @completion,
			Task.[projectId] = @projectId,
			Task.[deadline] =  @deadline
	WHERE Task.[tid] = @id;

END

----------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR DELETE OPERATIONS             */
----------------------------------------------------------------------------------
GO
create PROC spDeleteTask
	(@taskId INT)
AS
BEGIN
	DELETE FROM TASK
	WHERE Task.tid = @taskId;
END



/*********************************************************************************
 _________________________________________________________________________________
					STORED PROCEDURES FOR TASK MEMBER TABLE
 _________________________________________________________________________________
 *********************************************************************************/

--------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR INSERT OPERATIONS              */
--------------------------------------------------------------------------------

GO
create PROC spInsertTaskAndMember 
	(@TaskId INT, @UserId INT)
AS
BEGIN
	INSERT INTO TaskMember 
	VALUES
		(@TaskId, @UserId)
END

 -------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR READ OPERATIONS              */
--------------------------------------------------------------------------------

 GO
/*
	This SP fetches all the registered tasks with their user
	including their id and the user id plus other informations
	like full user name and task properties

	it works by joining the user, task and taskMember tables

	It will first join the user table with the taskMember table
	based on the userID and taskMember.userId rows. Then it'll
	join it with the task table to fetch the remaining rows
	from the task table based on the task.tid row and taskMember.userId
	row.
*/

create PROC spFetchTasksAndUsers
AS
BEGIN
	SELECT 
		TaskId as [Task Id],
		[uid] as [User Id],
		Fname + ' ' + Lname as [Full User Name],
		[name] as [Task Name],
		[Priority] as [Task Priority],
		[Completion] as [TaskCompletion],
		[dateCreated] as [Date Created]
	FROM
		[USER]
	JOIN
		TaskMember
	ON
		-- Joining the tables base on their ids.	
		[USER].[uid] = TaskMember.UserId
	JOIN
		TASK
	ON
		-- Again joining the task table based on thier ids.
		Task.tid = TaskMember.TaskId
END

-----------------------------------------------------

GO
/*
	This procedure works almost exactly like the
	spFetchTasksAndUsers but it's used to select
	a single task base on a given task id or
	user id
*/
create PROC spFetchTaskAndUserById
 (@id INT)
AS
BEGIN
SELECT 
		TaskId as [Task Id],
		[uid] as [User Id],
		Fname + ' ' + Lname as [Full User Name],
		[name] as [Task Name],
		[Priority] as [Task Priority],
		[Completion] as [TaskCompletion],
		[dateCreated] as [Date Created]
	FROM
		[USER]
	JOIN
		TaskMember
	ON
		-- Joining the tables base on their ids.	
		[USER].[uid] = TaskMember.UserId
	JOIN
		TASK
	ON
		-- Again joining the task table based on thier ids.
		Task.tid = TaskMember.TaskId
	/*
		This where clause selects only one task based on the
		given parameter to the procedure.
	*/
	WHERE
		[TaskId] = @id

END


 -------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR UPDATE OPERATIONS           */
--------------------------------------------------------------------------------

GO
create PROC spUpdateUserTask
	@userId INT, @taskId INT
AS
BEGIN
	UPDATE TaskMember
	SET TaskId = @taskId
	WHERE UserId = @userId
END

-------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR DELETE OPERATIONS           */
--------------------------------------------------------------------------------

GO
create PROC spDeleteTaskMemberUser
	@userId INT
AS
BEGIN
	DELETE TaskMember
	WHERE UserId = @userId
END

------------------------------------------

GO
create PROC spDeleteTaskMemberTask
	@taskId INT
AS
BEGIN
	DELETE TaskMember
	WHERE TaskId = @taskId
END


GO
create proc spFetchAllProjectMembers
		@projectId int
as
begin
	select Fname + ' ' +Lname as [Full Name] from [User]
	Join
	ProjectMember
	ON
	[USER].[UID] = ProjectMember.UserId
	WHERE
	ProjectMember.ProjectId = @projectId
end

go
create proc spSelectUserId
	(@fname varchar(50))
as
begin
	select [uid] from [User] 
	where [User].Fname like '%' + @fname
end
