ALTER PROCEDURE spSplitFullname
@Fullname varchar(50),
@FIRSTNAME VARCHAR(40) OUTPUT,
@LASTNAME VARCHAR(40) OUTPUT

As
BEGIN
  
  SELECT @FIRSTNAME = FIRSTNAME, @LASTNAME = lastname FROM dbo.splitfullname(@Fullname) 
          
  
END


