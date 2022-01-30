ALTER PROCEDURE spAuthenticationUser
@username varchar(50),
@password varchar(50)
AS
BEGIN
	SELECT COUNT(*) FROM [USER] 
	WHERE [USER].USERNAME = @USERNAME and [USER].[Password] = @password
  
	DECLARE @userID int

	SELECT @userID=[uid]
	FROM [User]
	WHERE username=@username

	IF @@ROWCOUNT != 0
		INSERT INTO UserLoggedIn VALUES
		(@userID, GETDATE())
   
END

   
