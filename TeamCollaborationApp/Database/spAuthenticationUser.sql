create PROCEDURE spAuthenticationUser
@username varchar(50),
@password varchar(50),
@bool varchar(50) output
AS
BEGIN
  SELECT COUNT(*) FROM [USER] 
  WHERE [USER].USERNAME = @USERNAME and [USER].[Password] = @password

  IF (@@ROWCOUNT > 1)
  set @bool = 'true'
  else
  set @bool = 'false'
    
END
