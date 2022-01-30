GO
Alter PROC	spInsertProject(
	@userID int,
	@Name varchar(50),
	@Description varchar(200),
	@BeginDate Date,
	@EndDate Date,
	@ProjectID int OUTPUT
)
AS
BEGIN
	INSERT INTO Project
	VALUES (@Name,GETDATE(),@Description,@userID,@BeginDate,@EndDate)

	SELECT @ProjectID = SCOPE_IDENTITY()
END

---------------------------------------------------------

GO
alter PROC spGetProject(
	@userID	int)
AS
BEGIN
	SELECT DISTINCT pid as [Project ID], [Name], [Description], BeginDate, EndDate
	FROM Project, ProjectMember
	WHERE (UserId=@userID AND pid=ProjectId) OR (ProjectAdmin=@userID)
	ORDER BY [NAME]
END

---------------------------------------------------------

GO
alter PROC spDeleteProject(
	@userID int,
	@projectID int)
AS
BEGIN
	DELETE FROM Project
	WHERE pid=@projectID and ProjectAdmin=@userID
END
	--use function
---------------------------------------------------------

GO
alter PROC	spUpdateProject(
	@projectID int,
	@userID int,
	@Name varchar(50),
	@Description varchar(200),
	@BeginDate Date,
	@EndDate Date
)
AS
BEGIN
	UPDATE Project
	SET Name=@Name, Description=@Description, BeginDate=@BeginDate, EndDate=@EndDate
	WHERE ProjectAdmin=@userID AND pid=@projectID
END
---------------------------------------------------------

GO
alter PROC spSearchProject(
	@userID int,
	@Name varchar(50)
)
AS
BEGIN
	SELECT DISTINCT pid as [Project ID], [Name], [Description], BeginDate, EndDate
	FROM Project, ProjectMember
	WHERE ((UserId=@userID AND pid=ProjectId) OR (ProjectAdmin=@userID)) AND [Name] LIKE @Name+'%'
END