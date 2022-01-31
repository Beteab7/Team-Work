
--login
CREATE LOGIN [CyberSecurityExpert] WITH PASSWORD=N'5dTubgdQfsvh+1ogI8owVtRVM/7KsflRDb6Li7GV5XM=', DEFAULT_DATABASE=Team, DEFAULT_LANGUAGE=[us_english]

CREATE LOGIN EMPLOYEE WITH PASSWORD=N'5dTubgdQfsvh+1ogI8owVtRVM/7KsflRDb6Li7GV5XM=', DEFAULT_DATABASE=Team, DEFAULT_LANGUAGE=[us_english]

-- User
GO
CREATE USER [Emp] FOR LOGIN EMPLOYEE
GO
ALTER ROLE [db_datareader] ADD MEMBER Emp
Go
ALTER ROLE [db_datawriter] ADD MEMBER Emp



CREATE USER [SecurityPerson] FOR LOGIN CyberSecurityExpert
GO
ALTER AUTHORIZATION ON SCHEMA::[db_accessadmin] TO [SecurityPerson]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_datareader] TO [SecurityPerson]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_datawriter] TO [SecurityPerson]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_ddladmin] TO [SecurityPerson]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_denydatareader] TO [SecurityPerson]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_denydatawriter] TO [SecurityPerson]
GO
ALTER AUTHORIZATION ON SCHEMA::[db_securityadmin] TO [SecurityPerson]


--schema
GO
CREATE SCHEMA [Security] AUTHORIZATION [db_accessadmin]
GO
ALTER AUTHORIZATION ON SCHEMA::[Security] TO [SecurityPerson]

GO
CREATE SCHEMA [Employee] AUTHORIZATION [Emp]