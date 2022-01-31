
create PROCEDURE spSaveUser
@Id varchar(22),
@Firstname varchar(50),
@Lastname varchar(50),
@Email varchar(50),
@Username varchar(50),
@Phone varchar(50) 
AS
BEGIN
 --Calling the Spliter Procudure
update [User]
set Fname = @Firstname,
    Lname = @LASTNAME,
	Username = @username,
	Phone = @phone,
	email = @Email
	
where
   uid = @id
END