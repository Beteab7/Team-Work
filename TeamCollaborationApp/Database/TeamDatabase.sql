
CREATE TABLE [User](
    [uid] int not null identity(1,1)  primary key,
	Fname varchar(50) not null,
	Lname varchar(50),
	Username varchar(50),
	Phone varchar(20),
	Email varchar(80),
	photo image,
	[Password] varchar(50)
)
--------------------------------------------------------------

CREATE TABLE Project(
    pid int not null identity(1,1)  primary key,
	[Name] varchar(50),
	dateCreated Date,
	[Description] varchar(200),
	ProjectAdmin int,
	BeginDate Date,
	EndDate Date
)

ALTER TABLE Project
ADD CONSTRAINT FK_ProjectAdmin 
FOREIGN KEY(ProjectAdmin)
REFERENCES [User]([uid]);
--------------------------------------------------------------

CREATE TABLE Task(
    tid int not null identity(1,1)  primary key,
	[Name] varchar(50),
	[Description] varchar(200),
	[Priority] int,
	Completion bit,
	projectId int,
	dateCreated Date,
	Deadline Date
)

ALTER TABLE Task
ADD CONSTRAINT FK_Task_Project 
FOREIGN KEY(projectId)
REFERENCES Project(pid);

--------------------------------------------------------------

CREATE TABLE TaskMember(
	TaskId int not null,
	UserId int not null
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
	ProjectId int not null,
	UserId int not null,
	DateAdded date
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



