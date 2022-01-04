


CREATE TABLE [User](
    [uid] AS 'U-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, #), 20) PERSISTED not null primary key,
	# int not null identity(1,1) ,
	Fname varchar(50) not null,
	Lname varchar(50),
	Username varchar(50),
	Phone varchar(20),
	Email varchar(80),
	photo image,
	[Password] varchar(50),
	DepId varchar(22)
)

--------------------------------------------------------------

CREATE TABLE Project(
    pid AS 'P-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, #), 20)  PERSISTED not null primary key,
	# int not null identity(1,1) ,
	[Name] varchar(50),
	dateCreated Date,
	[Description] varchar(200)
)
--------------------------------------------------------------

CREATE TABLE Task(
    tid AS 'T-' + RIGHT(REPLICATE('0', 8) + CONVERT(VARCHAR, #), 20)  PERSISTED not null primary key,
	# int not null identity(1,1),
	[Name] varchar(50),
	[Description] varchar(200),
	[Priority] int,
	Completion bit,
	projectId varchar(22),
	dateCreated Date,
	Deadline Date
)

ALTER TABLE Task
ADD CONSTRAINT FK_Task_Project 
FOREIGN KEY(projectId)
REFERENCES Project(pid);

--------------------------------------------------------------


CREATE TABLE ProjectAdmin(
	ProjectId varchar(22) not null,
	UserId varchar(22) not null
)

ALTER TABLE ProjectAdmin
ADD CONSTRAINT PK_padmin
PRIMARY KEY(ProjectId, UserId)

ALTER TABLE ProjectAdmin
ADD CONSTRAINT FK_PA
FOREIGN KEY(ProjectId)
REFERENCES Project(Pid);

ALTER TABLE ProjectAdmin
ADD CONSTRAINT FK_PA2
FOREIGN KEY(UserId)
REFERENCES [User]([uid]);

--------------------------------------------------------------

CREATE TABLE TaskMember(
	TaskId varchar(22) not null,
	UserId varchar(22) not null,
)

ALTER TABLE TaskMember
ADD CONSTRAINT PK_TASK
PRIMARY KEY(TaskId, UserId)

ALTER TABLE TaskMember
ADD CONSTRAINT FK_TA
FOREIGN KEY(TaskId)
REFERENCES Task(tid);

ALTER TABLE TaskMember
ADD CONSTRAINT FK_TA2
FOREIGN KEY(UserId)
REFERENCES [User]([uid]);


--------------------------------------------------------------

CREATE TABLE ProjectMember(
	ProjectId varchar(22) not null,
	UserId varchar(22) not null
)

ALTER TABLE ProjectMember
ADD CONSTRAINT PK_Project
PRIMARY KEY(ProjectId, UserId)

ALTER TABLE ProjectMember
ADD CONSTRAINT Fk_PM
FOREIGN KEY(ProjectId)
REFERENCES Project(pid)

ALTER TABLE ProjectMember
ADD CONSTRAINT Fk_PM2
FOREIGN KEY(UserId)
REFERENCES [User]([uid])

--------------------------------------------------------------



