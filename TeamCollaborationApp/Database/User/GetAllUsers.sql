CREATE PROC spGetUsers
AS
BEGIN
	SELECT [uid], dbo.GetFullName(uid) [Full Name]
	FROM [User]
	ORDER BY Fname ASC
END
