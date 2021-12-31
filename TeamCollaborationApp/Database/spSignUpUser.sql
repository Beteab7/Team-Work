
create PROCEDURE spSignUpUser
@Fullname varchar(50),
@Email varchar(50),
@username varchar(50),
@password varchar(50)
AS
BEGIN
 DECLARE @FIRSTNAME VARCHAR(40)
 DECLARE @LASTNAME VARCHAR(40)
 --Calling the Spliter Procudure
 EXEC spSplitFullname @FULLNAME , @FIRSTNAME OUTPUT , @LASTNAME OUTPUT

  insert into [User]
  values (@FIRSTNAME,@LASTNAME,@username,NULL,@Email,null,@password) 
END

