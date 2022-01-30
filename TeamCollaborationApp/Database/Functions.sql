
CREATE FUNCTION GetFullName(
@userID VARCHAR(22))
RETURNS VARCHAR(100)
AS
BEGIN
	DECLARE @FullName VARCHAR(100)
	
	SELECT @FullName=Fname+' '+Lname
	FROM [User]
	WHERE [uid]=@userID

	RETURN @FullName
END

---------------------------------------------------------

GO
ALTER FUNCTION SearchName(
@querry VARCHAR(50))
RETURNS TABLE
AS
RETURN 
	SELECT [uid], dbo.GetFullName([uid]) as [Full Name]
	FROM [User]
	WHERE Fname like @querry+'%' or Lname like @querry+'%' 