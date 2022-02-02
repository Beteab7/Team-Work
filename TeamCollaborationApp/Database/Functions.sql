
alter FUNCTION GetFullName(
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




GO
ALTER function splitFullname
(@fullname varchar(80)
 )
 returns @temp table 
 (firstname varchar(40),
  lastname varchar(40)
 )
 as
 begin
  DECLARE @LEN INT
  DECLARE @firstname varchar(40), @lastname varchar(40)
  SET @LEN = LEN(@FULLNAME)

  SET @FIRSTNAME =  SUBSTRING(@FULLNAME , 1, CHARINDEX(' ',@FULLNAME))
  SET @LASTNAME = SUBSTRING(@FULLNAME,CHARINDEX(' ',@Fullname)+1, LEN(@FULLNAME))
   insert into @temp 
   values( @FIRSTNAME, @LASTNAME)
   RETURN  
  end