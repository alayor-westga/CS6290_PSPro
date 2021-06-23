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
	FROM Personnel p
		INNER JOIN Officers o ON (o.personnel_id = p.personnel_id)
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


--UpdateCitizen
DROP PROCEDURE IF EXISTS UpdateCitizen;
GO
CREATE PROCEDURE UpdateCitizen 
	@RowCnt int OUTPUT,
	@UpdatedFirstName varchar(45), 
	@UpdatedLastName varchar(45), 
	@UpdatedAddress1 varchar(45), 
	@UpdatedAddress2 varchar(45), 
	@UpdatedCity varchar(45), 
	@UpdatedState char(2), 
	@UpdatedZipcode varchar(10), 
	@UpdatedPhone varchar(12), 
	@UpdatedEmail varchar(45),

	@CitizenID int,
	@FirstName varchar(45), 
	@LastName varchar(45), 
	@Address1 varchar(45), 
	@Address2 varchar(45), 
	@City varchar(45), 
	@State char(2), 
	@Zipcode varchar(10), 
	@Phone varchar(12), 
	@Email varchar(45)
AS
SET NOCOUNT ON;

UPDATE Citizens SET  
                    first_name = @UpdatedFirstName,  
                    last_name = @UpdatedLastName,  
                    address1 = @UpdatedAddress1,  
                    address2 = @Updatedaddress2,
                    city = @UpdatedCity,
                    state = @UpdatedState,
                    zipcode = @UpdatedZipcode,
                    phone = @UpdatedPhone, 
                    email = @UpdatedEmail                 
                WHERE citizen_id = @CitizenID 
                    AND first_name = @FirstName  
                    AND last_name = @LastName  
                    AND address1 = @Address1  
                    AND (address2 = @Address2 OR address2 IS NULL AND @Address2 IS NULL)
                    AND city = @City
                    AND state = @State
                    AND zipcode = @Zipcode
                    AND phone = @Phone 
                    AND (email = @Email OR email IS NULL AND @Email IS NULL)
				SELECT @RowCnt = @@ROWCOUNT
GO
GRANT EXECUTE ON UpdateCitizen 
    TO winforms;  
GO 
 
--GetAllActiveComplaints
DROP PROCEDURE IF EXISTS GetAllActiveComplaints;
GO
CREATE PROCEDURE GetAllActiveComplaints
AS
SET NOCOUNT ON;

    SELECT 
		co.complaint_id,
		co.date_created,
		CONCAT(o.first_name, ' ', o.last_name) AS officer_full_name,
		CONCAT(ci.first_name, ' ', ci.last_name) AS citizen_full_name,
		CONCAT(ci.address1, ' ', ci.address2, ' ', ci.city, ' ', ci.state, ' ', ci.zipcode) AS citizen_full_address,
		ci.phone AS citizen_phone,
		co.disposition,
		co.discipline,
		co.allegation_type,
		co.complaint_notes
	FROM Complaints co
		INNER JOIN Personnel o ON (o.personnel_id = co.officers_personnel_id)
		INNER JOIN Citizens ci ON (ci.citizen_id = co.citizen_id)
	WHERE co.discipline IS NULL
GO
GRANT EXECUTE ON
GetAllActiveComplaints
TO winforms;
GO

--GetActiveComplaintsByOfficer
DROP PROCEDURE IF EXISTS GetActiveComplaintsByOfficer;
GO
CREATE PROCEDURE GetActiveComplaintsByOfficer
	@officers_personnel_id int
AS
SET NOCOUNT ON;

    SELECT 
		co.complaint_id,
		co.date_created,
		CONCAT(o.first_name, ' ', o.last_name) AS officer_full_name,
		CONCAT(ci.first_name, ' ', ci.last_name) AS citizen_full_name,
		CONCAT(ci.address1, ' ', ci.address2, ' ', ci.city, ' ', ci.state, ' ', ci.zipcode) AS citizen_full_address,
		ci.phone AS citizen_phone,
		co.disposition,
		co.discipline,
		co.allegation_type,
		co.complaint_notes
	FROM Complaints co
		INNER JOIN Personnel o ON (o.personnel_id = co.officers_personnel_id)
		INNER JOIN Citizens ci ON (ci.citizen_id = co.citizen_id)
	WHERE co.discipline IS NULL
	AND o.personnel_id = @officers_personnel_id
GO
GRANT EXECUTE ON
GetActiveComplaintsByOfficer
TO winforms;
GO


--GetCitizensByEmail
DROP PROCEDURE IF EXISTS GetCitizensByEmail;
GO
CREATE PROCEDURE GetCitizensByEmail
	@email varchar(45)
AS
SET NOCOUNT ON;

    SELECT 
		citizen_id, first_name, last_name, address1, address2, city, state, zipcode, phone, email
	FROM Citizens		
	WHERE email = @email
	ORDER BY email 
GO
GRANT EXECUTE ON
GetCitizensByEmail
TO winforms;
GO


--GetCitizensByPhone
DROP PROCEDURE IF EXISTS GetCitizensByPhoneNumber;
GO
CREATE PROCEDURE GetCitizensByPhoneNumber
	@phone varchar(12)
AS
SET NOCOUNT ON;

    SELECT 
		citizen_id, first_name, last_name, address1, address2, city, state, zipcode, phone, email
	FROM Citizens		
	WHERE phone = @phone

GO
GRANT EXECUTE ON
GetCitizensByPhoneNumber
TO winforms;
GO


--GetCitizensByName
DROP PROCEDURE IF EXISTS GetCitizensByName;
GO
CREATE PROCEDURE GetCitizensByName
	@first_name varchar(45),
	@last_name varchar(45)
AS
SET NOCOUNT ON;

    SELECT 
		citizen_id, first_name, last_name, address1, address2, city, state, zipcode, phone, email
	FROM Citizens		
	WHERE first_name = @first_name OR last_name = @last_name
	AND last_name <> ''

GO
GRANT EXECUTE ON
GetCitizensByName
TO winforms;
GO


--GetComplaintById
DROP PROCEDURE IF EXISTS GetComplaintById;
GO
CREATE PROCEDURE GetComplaintById
	@complaint_id int
AS
SET NOCOUNT ON;

    SELECT 
		co.complaint_id,
		co.date_created,
		CONCAT(o.first_name, ' ', o.last_name) AS officer_full_name,
		CONCAT(ci.first_name, ' ', ci.last_name) AS citizen_full_name,
		CONCAT(ci.address1, ' ', ci.address2, ' ', ci.city, ' ', ci.state, ' ', ci.zipcode) AS citizen_full_address,
		ci.phone AS citizen_phone,
		co.disposition,
		co.discipline,
		co.allegation_type,
		co.complaint_notes
	FROM Complaints	co
		INNER JOIN Personnel o ON (o.personnel_id = co.officers_personnel_id)
		INNER JOIN Citizens ci ON (ci.citizen_id = co.citizen_id)
	WHERE complaint_id = @complaint_id

GO
GRANT EXECUTE ON
GetComplaintById
TO winforms;
GO



--INSERT Complaints(citizen_id, officers_personnel_id, supervisors_personnel_id, date_created, allegation_type, complaint_notes)
--VALUES (@citizen_id,@officers_personnel_id, @supervisors_personnel_id, CURRENT_TIMESTAMP,@allegation_type, @complaint_notes)