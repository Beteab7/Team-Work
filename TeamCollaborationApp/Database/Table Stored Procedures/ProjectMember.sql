	--ProjectId varchar(22) not null,
	--UserId varchar(22) not null,
	--DateAdded date

	--Project Member Stored Procedures
--------------------------------------------------------------
CREATE PROC spInsertProjectMember(
	@ProjectId varchar(22),
	@UserId varchar(22))
AS
BEGIN
	INSERT INTO ProjectMember
	VALUES (@ProjectId, @UserId, GETDATE())
END

--------------------------------------------------------------

GO
CREATE PROC spDeleteProjectMemeber(
	@ProjectId varchar(22),
	@UserId varchar(22))
AS
BEGIN
	DELETE FROM ProjectMember
	WHERE UserId=@UserId and ProjectId=@ProjectId
END

--------------------------------------------------------------

GO
CREATE PROC spGetRecentProjectMembers(
	@ProjectId varchar(22))
AS
BEGIN
	SELECT dbo.GetFullName(UserID)
	FROM ProjectMember
	WHERE ProjectId = @ProjectId
	ORDER BY DateAdded ASC
END

--------------------------------------------------------------

GO
CREATE PROC spGetOldProjectMembers(
	@ProjectId varchar(22))
AS
BEGIN
	SELECT dbo.GetFullName(UserID)
	FROM ProjectMember
	WHERE ProjectId = @ProjectId
	ORDER BY DateAdded DESC
END

--------------------------------------------------------------

GO
CREATE PROC spSearchProjectMember(
	@ProjectId varchar(22),
	@querry varchar(50))
AS
BEGIN
	SELECT [Full Name]
	FROM ProjectMember, dbo.SearchName(@querry)
	WHERE ProjectId=@ProjectId
END

--------------------------------------------------------------

