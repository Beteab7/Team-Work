USE [master]
GO
CREATE LOGIN [Production] WITH PASSWORD=N'fj8329jrqettmjm' MUST_CHANGE, DEFAULT_DATABASE=[master], CHECK_EXPIRATION=ON, CHECK_POLICY=ON
GO
ALTER SERVER ROLE [bulkadmin] ADD MEMBER [Production]
GO
ALTER SERVER ROLE [diskadmin] ADD MEMBER [Production]
GO
ALTER SERVER ROLE [processadmin] ADD MEMBER [Production]
GO
ALTER SERVER ROLE [securityadmin] ADD MEMBER [Production]
GO
ALTER SERVER ROLE [serveradmin] ADD MEMBER [Production]
GO
ALTER SERVER ROLE [sysadmin] ADD MEMBER [Production]
GO
USE [Team]
GO
CREATE USER [Production] FOR LOGIN [Production]
GO
USE [Team]
GO
ALTER ROLE [db_accessadmin] ADD MEMBER [Production]
GO
USE [Team]
GO
ALTER ROLE [db_backupoperator] ADD MEMBER [Production]
GO
USE [Team]
GO
ALTER ROLE [db_datareader] ADD MEMBER [Production]
GO
USE [Team]
GO
ALTER ROLE [db_datawriter] ADD MEMBER [Production]
GO
USE [Team]
GO
ALTER ROLE [db_ddladmin] ADD MEMBER [Production]
GO
USE [Team]
GO
ALTER ROLE [db_securityadmin] ADD MEMBER [Production]
GO
