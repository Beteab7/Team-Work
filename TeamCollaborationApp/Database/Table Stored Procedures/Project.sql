GO
CREATE PROC	spInsertProject(
	@userID varchar(22),
	@Name varchar(50),
	@Description varchar(200)
)
AS
BEGIN
	INSERT INTO Project
	VALUES (@Name,GETDATE(),@Description)

	INSERT INTO ProjectAdmin
	VALUES (Scope_Identity(),@userID)
END

---------------------------------------------------------
GO
CREATE PROC spGetProject(
	@userID varchar(22))
AS
BEGIN
	SELECT [NAME], [Description], dateCreated
	FROM Project, ProjectMember [PM], ProjectAdmin[PA]
	WHERE PM.UserId=@userID OR PA.UserId=@userID
END

---------------------------------------------------------

GO
CREATE PROC spDeleteProject(
	@userID varchar(22),
	@projectID varchar(22))
AS
BEGIN
DELETE FROM
END
	--use function
---------------------------------------------------------
