alter PROCEDURE spAuthenticationUser
@username varchar(50),
@password varchar(50)
AS
BEGIN
  SELECT COUNT(*) FROM [USER] 
  WHERE [USER].USERNAME = @USERNAME and [USER].[Password] = @password
   
END

   
