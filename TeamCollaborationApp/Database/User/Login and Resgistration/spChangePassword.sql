create PROCEDURE spChangePassword
@Id varchar(22),
@password varchar(50)
AS
BEGIN

update [User]
set [Password] = @password
where
   [uid] = @id
END