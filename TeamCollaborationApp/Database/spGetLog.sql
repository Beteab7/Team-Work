ALTER PROC spGetLog(
	@userID	int)
AS
BEGIN
	SELECT DISTINCT pid as [Project ID], [Name], actionPerformed as [Action Performed], timePerformed as [Time Performed]
	FROM Project, ProjectLog
	WHERE (Project.pid = ProjectLog.projectID) OR (ProjectAdmin=@userID)
	ORDER BY [NAME]
END
