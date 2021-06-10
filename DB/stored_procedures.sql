--GetSupervisorByUserNameAndPassword
DROP PROCEDURE IF EXISTS GetSupervisorByUserNameAndPassword;
GO
CREATE PROCEDURE GetSupervisorByUserNameAndPassword @UserName varchar(45), @Password varchar(45)
AS
SET NOCOUNT ON;

SELECT p.personnel_id, p.first_name, p.last_name
FROM Supervisors s
	INNER JOIN Personnel p ON (p.personnel_id = s.personnel_id)
WHERE s.username = @UserName COLLATE Latin1_General_CS_AS 
	AND s.password = HASHBYTES('SHA2_512', @Password+CAST(username AS NVARCHAR(36)));
GO
GRANT EXECUTE ON GetSupervisorByUserNameAndPassword 
    TO winforms;  
GO 


--GetInvestigatorByUserNameAndPassword
DROP PROCEDURE IF EXISTS GetInvestigatorByUserNameAndPassword;
GO
CREATE PROCEDURE GetInvestigatorByUserNameAndPassword @UserName varchar(45), @Password varchar(45)
AS
SET NOCOUNT ON;

SELECT p.personnel_id, p.first_name, p.last_name
FROM Investigators s
	INNER JOIN Personnel p ON (p.personnel_id = s.personnel_id)
WHERE s.username = @UserName COLLATE Latin1_General_CS_AS 
	AND s.password = HASHBYTES('SHA2_512', @Password+CAST(username AS NVARCHAR(36)));
GO
GRANT EXECUTE ON GetInvestigatorByUserNameAndPassword 
    TO winforms;  
GO 


--GetAdministratorByUserNameAndPassword
DROP PROCEDURE IF EXISTS GetAdministratorByUserNameAndPassword;
GO
CREATE PROCEDURE GetAdministratorByUserNameAndPassword @UserName varchar(45), @Password varchar(45)
AS
SET NOCOUNT ON;

SELECT p.personnel_id, p.first_name, p.last_name
FROM Administrators s
	INNER JOIN Personnel p ON (p.personnel_id = s.personnel_id)
WHERE s.username = @UserName COLLATE Latin1_General_CS_AS 
	AND s.password = HASHBYTES('SHA2_512', @Password+CAST(username AS NVARCHAR(36)));
GO
GRANT EXECUTE ON GetAdministratorByUserNameAndPassword 
    TO winforms;  
GO 


--GetAllOfficersForComboBox
DROP PROCEDURE IF EXISTS GetAllOfficersForComboBox;
GO
CREATE PROCEDURE GetAllOfficersForComboBox
AS
SET NOCOUNT ON;

    SELECT p.last_name, p.first_name, p.personnel_id
	FROM Officers o, Personnel p
	WHERE o.personnel_id = p.personnel_id
	ORDER BY p.last_name;
GO
GRANT EXECUTE ON
GetAllOfficersForComboBox
TO winforms;
GO


--AddCitizen
DROP PROCEDURE IF EXISTS AddCitizen;
GO
CREATE PROCEDURE AddCitizen 
	@first_name varchar(45), 
	@last_name varchar(45), 
	@address1 varchar(45), 
	@address2 varchar(45), 
	@city varchar(45), 
	@state char(2), 
	@zipcode varchar(10), 
	@phone varchar(12), 
	@email varchar(45)
AS
SET NOCOUNT ON;
INSERT Citizens (first_name, last_name, address1, address2, city, state, zipcode, phone, email)
VALUES (@first_name, @last_name, @address1, @address2, @city, @state, @zipcode, @phone, @email)
GO
GRANT EXECUTE ON AddCitizen 
    TO winforms;  
GO 

--Get Last CitizenID
DROP PROCEDURE IF EXISTS GetLastCitizenID;
GO
CREATE PROCEDURE GetLastCitizenID
AS
SET NOCOUNT ON;
SELECT TOP 1 citizen_id FROM Citizens ORDER BY citizen_id DESC
GO
GRANT EXECUTE ON GetLastCitizenID 
    TO winforms;  
GO 


--Add Complaint
DROP PROCEDURE IF EXISTS AddComplaint;
GO
CREATE PROCEDURE AddComplaint 
	@citizen_id int,
	@officers_personnel_id int, 
	@supervisors_personnel_id int, 
	@investigators_personnel_id int, 
	@administrators_pesonnel_id int, 
	@date_created datetime, 
	@allegation_type varchar(45), 
	@complaint_notes text, 
	@dispostion varchar(25), 
	@disposition_date date, 
	@discipline varchar(45)
AS
SET NOCOUNT ON;
INSERT Complaints	(
						citizen_id, 
						officers_personnel_id, 
						supervisors_personnel_id, 
						investigators_personnel_id, 
						administrators_personnel_id, 
						date_created, 
						allegation_type, 
						complaint_notes, 
						disposition, 
						disposition_date, 
						discipline
					)
VALUES (
			@citizen_id,
			@officers_personnel_id, 
			@supervisors_personnel_id, 
			@investigators_personnel_id, 
			@administrators_pesonnel_id, 
			@date_created, 
			@allegation_type, 
			@complaint_notes, 
			@dispostion, 
			@disposition_date, 
			@discipline
		)
GO
GRANT EXECUTE ON AddComplaint 
    TO winforms;  
GO 
