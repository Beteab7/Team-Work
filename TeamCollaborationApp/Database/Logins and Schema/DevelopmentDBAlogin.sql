USE [master]
GO
CREATE LOGIN [DevelopmentDBA] FROM WINDOWS WITH DEFAULT_DATABASE=[master]
GO
ALTER SERVER ROLE [bulkadmin] ADD MEMBER [Development]
GO
ALTER SERVER ROLE [dbcreator] ADD MEMBER [Development]
GO
ALTER SERVER ROLE [diskadmin] ADD MEMBER [Development]
GO
ALTER SERVER ROLE [processadmin] ADD MEMBER [Development]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [Development]
GO
ALTER SERVER ROLE [serveradmin] ADD MEMBER [Development]
GO
ALTER SERVER ROLE [setupadmin] ADD MEMBER [Development]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Development]
GO
use [Team];
GO
use [master];
GO
USE [Team]
GO
CREATE USER [Development] FOR LOGIN [Development]
GO
USE [Team]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Development]
GO
USE [Team]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Development]
GO
USE [Team]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Development]
GO
USE [Team]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Development]
GO
USE [Team]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Development]
GO
USE [Team]
GO
ALTER ROLE [db_owner] ADD MEMBER [Development]
GO
USE [Team]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Development]
GO
