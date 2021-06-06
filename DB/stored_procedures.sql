DROP PROCEDURE IF EXISTS GetSupervisorByUserNameAndPassword;
GO
CREATE PROCEDURE GetSupervisorByUserNameAndPassword @UserName varchar, @Password varchar
AS
SET NOCOUNT ON;

SELECT *
FROM Supervisors 
WHERE username = @UserName AND password = @Password;
GO
GRANT EXECUTE ON GetSupervisorByUserNameAndPassword 
    TO winforms;  
GO  