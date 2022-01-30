alter PROCEDURE spUserInfoRetrival
@username varchar(50),
@userid int output,
@firstname varchar(100) output,
@lastname varchar(50) output,
@phone varchar(20) output,
@email varchar(30) output,
@photo image output,
@password varchar(30) output
AS
BEGIN
  SELECT @userid = [Uid],
         @firstname = fname,
		 @lastname= Lname, 
		 @phone = Phone,
		 @email = Email,
		 @photo = photo,
		 @password = [Password]
  from [User] 
  where Username = @username
   
END


