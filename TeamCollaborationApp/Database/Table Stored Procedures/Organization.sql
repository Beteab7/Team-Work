GO
CREATE PROC	spGetOrganization(
	@userID varchar(20)
)
AS
BEGIN
	SELECT *
	FROM Organization [O], OrganizationUser [OU]
	WHERE OU.UserId=@userID
END
-----------------------------------------

GO
CREATE PROC spInsertOrganization(
	@Name varchar(80),
	@Address varchar(100),
	@Phone varchar(20),
	@Fax varchar(20),
	@Email varchar(80),
	@Website varchar(100),
	@UserId varchar(22),
	@Description varchar(200)
)
AS
BEGIN
	INSERT INTO Organization
	VALUES (@Name, @Address, @Phone, @Fax, @Email, @Website, @UserId, @Description)
END
-----------------------------------------

GO
CREATE PROC spDeleteOrganization(
@Oid varchar(20))
AS
BEGIN
--ProjectMember
--TaskMember
--Task
--Project

DELETE FROM ProjectMember WHERE 
END