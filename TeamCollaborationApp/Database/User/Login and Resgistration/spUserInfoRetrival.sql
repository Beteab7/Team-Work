alter PROCEDURE spUserInfoRetrival
@username varchar(50),
@userid varchar(22) output,
@firstname varchar(100) output,
@lastname varchar(50) output,
@phone varchar(20) output,
@email varchar(30) output,
@password varchar(30) output
AS
BEGIN
  SELECT @userid = [Uid],
         @firstname = fname,
		 @lastname= Lname, 
		 @phone = Phone,
		 @email = Email,
		 @password = [Password]
  from [User] 
  where Username = @username
   
END


