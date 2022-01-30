CREATE PROC spFetchUserID(
	@userID int OUTPUT)
AS
BEGIN
	SELECT TOP 1 @userID = UserID
	FROM UserLoggedIn
	ORDER BY loginTime DESC
END