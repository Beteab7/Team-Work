create PROC spGetLog(
	@userID	int)
AS
BEGIN
	SELECT DISTINCT pid as [Project ID], [Name], [Description], BeginDate, EndDate
	FROM Project, ProjectLog
	WHERE (Project.pid = ProjectLog.projectID) OR (ProjectAdmin=@userID)
	ORDER BY [NAME]
END

