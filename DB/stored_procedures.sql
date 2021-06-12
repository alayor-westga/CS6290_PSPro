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
	
	@allegation_type varchar(45), 
	@complaint_notes text 
	
	
AS
SET NOCOUNT ON;
INSERT Complaints(citizen_id, officers_personnel_id, supervisors_personnel_id, date_created, allegation_type, complaint_notes)
VALUES (@citizen_id,@officers_personnel_id, @supervisors_personnel_id, CURRENT_TIMESTAMP,@allegation_type, @complaint_notes)
GO
GRANT EXECUTE ON AddComplaint 
    TO winforms;  
GO 

--AddSupervisor
DROP PROCEDURE IF EXISTS AddSupervisor;
GO
CREATE PROCEDURE AddSupervisor
	@user_name varchar(45), 
	@password varchar(200), 
	@first_name varchar(45), 
	@last_name varchar(45), 
	@gender char(1), 
	@hire_date date, 
	@birthdate date, 
	@assignment varchar(45)
AS
SET NOCOUNT ON;
	DECLARE @ID table (ID int)
    DECLARE @personnel_id INT;

    INSERT INTO Personnel
	OUTPUT INSERTED.personnel_id into @ID
	VALUES (
		@first_name,
		@last_name,
		@gender,
		@hire_date,
		@birthdate,
		@assignment
	)
	SELECT @personnel_id = ID FROM @ID
	INSERT INTO Supervisors
	VALUES (
		@personnel_id,
		@user_name, 
		HASHBYTES('SHA2_512', @password+CAST(@user_name AS NVARCHAR(36)))
	)
GO
GRANT EXECUTE ON
AddSupervisor
TO winforms;
GO

--AddInvestigator
DROP PROCEDURE IF EXISTS AddInvestigator;
GO
CREATE PROCEDURE AddInvestigator
	@user_name varchar(45), 
	@password varchar(200), 
	@first_name varchar(45), 
	@last_name varchar(45), 
	@gender char(1), 
	@hire_date date, 
	@birthdate date, 
	@assignment varchar(45)
AS
SET NOCOUNT ON;
	DECLARE @ID table (ID int)
    DECLARE @personnel_id INT;

    INSERT INTO Personnel
	OUTPUT INSERTED.personnel_id into @ID
	VALUES (
		@first_name,
		@last_name,
		@gender,
		@hire_date,
		@birthdate,
		@assignment
	)
	SELECT @personnel_id = ID FROM @ID
	INSERT INTO Investigators
	VALUES (
		@personnel_id,
		@user_name, 
		HASHBYTES('SHA2_512', @password+CAST(@user_name AS NVARCHAR(36)))
	)
GO
GRANT EXECUTE ON
AddInvestigator
TO winforms;
GO

--AddAdministrator
DROP PROCEDURE IF EXISTS AddAdministrator;
GO
CREATE PROCEDURE AddAdministrator
	@user_name varchar(45), 
	@password varchar(200), 
	@first_name varchar(45), 
	@last_name varchar(45), 
	@gender char(1), 
	@hire_date date, 
	@birthdate date, 
	@assignment varchar(45)
AS
SET NOCOUNT ON;
	DECLARE @ID table (ID int)
    DECLARE @personnel_id INT;

    INSERT INTO Personnel
	OUTPUT INSERTED.personnel_id into @ID
	VALUES (
		@first_name,
		@last_name,
		@gender,
		@hire_date,
		@birthdate,
		@assignment
	)
	SELECT @personnel_id = ID FROM @ID
	INSERT INTO Administrators
	VALUES (
		@personnel_id,
		@user_name, 
		HASHBYTES('SHA2_512', @password+CAST(@user_name AS NVARCHAR(36)))
	)
GO
GRANT EXECUTE ON
AddAdministrator
TO winforms;
GO

--AddOfficer
DROP PROCEDURE IF EXISTS AddOfficer;
GO
CREATE PROCEDURE AddOfficer
	@user_name varchar(45), 
	@password varchar(200), 
	@first_name varchar(45), 
	@last_name varchar(45), 
	@gender char(1), 
	@hire_date date, 
	@birthdate date, 
	@assignment varchar(45)
AS
SET NOCOUNT ON;
	DECLARE @ID table (ID int)
    DECLARE @personnel_id INT;

    INSERT INTO Personnel
	OUTPUT INSERTED.personnel_id into @ID
	VALUES (
		@first_name,
		@last_name,
		@gender,
		@hire_date,
		@birthdate,
		@assignment
	)
	SELECT @personnel_id = ID FROM @ID
	INSERT INTO Officers
	VALUES (
		@personnel_id
	)
GO
GRANT EXECUTE ON
AddOfficer
TO winforms;
GO

--GetCitizen
DROP PROCEDURE IF EXISTS GetCitizen;
GO
CREATE PROCEDURE GetCitizen 
	@citizen_id int		
AS
SET NOCOUNT ON;

SELECT citizen_id, first_name, last_name, address1, address2, city, state, zipcode, phone, email
FROM Citizens
WHERE citizen_id = @citizen_id

GRANT EXECUTE ON GetCitizen 
    TO winforms;  
GO 
