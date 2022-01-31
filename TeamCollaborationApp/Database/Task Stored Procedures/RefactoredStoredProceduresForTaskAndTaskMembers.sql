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
CREATE PROC spInsertTask
	(
	-- [!!] id is omitted since it's an auto incrementing property.
	@name VARCHAR(50),
	@description VARCHAR(200),
	@priority INT,
	@completion BIT,
	@projectId VARCHAR(22),
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
CREATE PROC spFetchTasks
AS
BEGIN
	SELECT * FROM Task;
END

-----------------------------------------------------

GO
-- Fetch all the tasks ordered by their priority
CREATE PROC spFetchTasksOrderedByPriority
AS
BEGIN
	SELECT * FROM TASK ORDER BY TASK.Priority;
END

-----------------------------------------------------

GO
CREATE PROC spFetchTasksOrderedByName
AS
BEGIN
--	Fetch all the tasks ordered by their name.
	SELECT * FROM TASK ORDER BY TASK.Name;
END

-----------------------------------------------------

GO
CREATE PROC spFetchSingleTaskById
 @taskId varchar(22)
AS
BEGIN
	SELECT * FROM TASK 
	WHERE TASK.TID = @taskId

END;


----------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR UPDATE OPERATIONS               */
----------------------------------------------------------------------------------

CREATE PROC spUpdateTaskName
	(@taskId varchar(22), @name VARCHAR(50))
AS
BEGIN
	UPDATE Task
	SET Task.[Name] = @name
	WHERE Task.[tid] = @taskId;
END

-----------------------------------------------------

CREATE PROC spUpdateTaskDescription
	(@taskId varchar(22), @description VARCHAR(200))
AS
BEGIN
	UPDATE Task
	SET Task.[Description] = @description
	WHERE Task.[tid] = @taskId;
END
-----------------------------------------------------

CREATE PROC spUpdateTaskPriority
	(@taskId varchar(22), @priority int)
AS
BEGIN
	UPDATE Task
	SET Task.[Priority] = @priority
	WHERE Task.[tid] = @taskId;
END

----------------------------------------------------

CREATE PROC spUpdateTaskCompletion
	(@taskId varchar(22), @completion bit)
AS
BEGIN
	UPDATE Task
	SET Task.Completion = @completion
	WHERE Task.[tid] = @taskId;
END

-----------------------------------------------------

CREATE PROC spUpdateTask
	(
	@id varchar(22),
	@name VARCHAR(50),
	@description VARCHAR(200),
	@priority INT,
	@completion BIT,
	@projectId VARCHAR(22),
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
CREATE PROC spDeleteTask
	(@taskId varchar(22))
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
CREATE PROC spInsertTaskAndMember 
	(@TaskId VARCHAR(22), @UserId varchar(22))
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

CREATE PROC spFetchTasksAndUsers
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
CREATE PROC spFetchTaskAndUserById
 (@id varchar(22))
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
	OR
		[uid] = @id
END


 -------------------------------------------------------------------------------
/*                BELOW ARE STORED PROCEDURES FOR UPDATE OPERATIONS           */
--------------------------------------------------------------------------------

GO
CREATE PROC spUpdateUserTask
	@userId varchar(22), @taskId varchar(22)
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
CREATE PROC spDeleteTaskMemberUser
	@userId varchar(22)
AS
BEGIN
	DELETE TaskMember
	WHERE UserId = @userId
END

------------------------------------------

GO
CREATE PROC spDeleteTaskMemberTask
	@taskId varchar(22)
AS
BEGIN
	DELETE TaskMember
	WHERE TaskId = @taskId
END