	--ProjectId varchar(22) not null,
	--UserId varchar(22) not null,
	--DateAdded date

	--Project Member Stored Procedures
--------------------------------------------------------------
alter PROC spInsertProjectMember(
	@ProjectId int,
	@UserId int)
AS
BEGIN
	INSERT INTO ProjectMember
	VALUES (@ProjectId, @UserId, GETDATE())
END

--------------------------------------------------------------

GO
alter PROC spDeleteProjectMember(
	@ProjectId int,
	@UserId int)
AS
BEGIN
	DELETE FROM ProjectMember
	WHERE UserId=@UserId and ProjectId=@ProjectId
END

--------------------------------------------------------------

GO
alter PROC spGetRecentProjectMembers(
	@ProjectId int)
AS
BEGIN
	SELECT UserID, dbo.GetFullName(UserID) as [Full Name]
	FROM ProjectMember
	WHERE ProjectId = @ProjectId
	ORDER BY DateAdded DESC
END

--------------------------------------------------------------

GO
alter PROC spGetOldProjectMembers(
	@ProjectId int)
AS
BEGIN
	SELECT UserID, dbo.GetFullName(UserID) as [Full Name]
	FROM ProjectMember
	WHERE ProjectId = @ProjectId
	ORDER BY DateAdded ASC
END

--------------------------------------------------------------

GO
alter PROC spSearchProjectMember(
	@ProjectId int,
	@query varchar(50))
AS
BEGIN
	SELECT DISTINCT [uid], [Full Name]
	FROM ProjectMember, dbo.SearchName(@query)
	WHERE ProjectId=@ProjectId
END

--------------------------------------------------------------

