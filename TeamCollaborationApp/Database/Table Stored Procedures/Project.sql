GO
Alter PROC	spInsertProject(
	@userID varchar(22),
	@Name varchar(50),
	@Description varchar(200),
	@BeginDate Date,
	@EndDate Date,
	@ProjectID varchar(22) OUTPUT
)
AS
BEGIN
	INSERT INTO Project
	VALUES (@Name,GETDATE(),@Description,@userID,@BeginDate,@EndDate)
	select @ProjectID = SCOPE_IDENTITY()
END

---------------------------------------------------------

GO
CREATE PROC spGetProject(
	@userID varchar(22))
AS
BEGIN
	SELECT DISTINCT pid as [Project ID], [Name], [Description], BeginDate, EndDate
	FROM Project, ProjectMember
	WHERE (UserId=@userID AND pid=ProjectId) OR (ProjectAdmin=@userID)
END

---------------------------------------------------------

GO
CREATE PROC spDeleteProject(
	@userID varchar(22),
	@projectID varchar(22))
AS
BEGIN
	DELETE FROM Project
	WHERE pid=@projectID and ProjectAdmin=@userID
END
	--use function
---------------------------------------------------------

GO
CREATE PROC	spUpdateProject(
	@projectID varchar(22),
	@userID varchar(22),
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
CREATE PROC spSearchProject(
	@userID varchar(22),
	@Name varchar(50)
)
AS
BEGIN
	SELECT DISTINCT pid as [Project ID], [Name], [Description], BeginDate, EndDate
	FROM Project, ProjectMember
	WHERE ((UserId=@userID AND pid=ProjectId) OR (ProjectAdmin=@userID)) AND [Name] LIKE @Name+'%'
END