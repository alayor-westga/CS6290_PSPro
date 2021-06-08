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



DROP PROCEDURE IF EXISTS AddIncident;
GO
CREATE PROCEDURE AddIncident 
	@citizen_id int, 
	@first_name varchar, 
	@last_name varchar, 
	@address1 varchar, 
	@address2 varchar, 
	@city varchar, 
	@state char(2), 
	@zipcode varchar, 
	@phone varchar, 
	@email varchar
AS
SET NOCOUNT ON;

INSERT Citizens (citizen_id, first_name, last_name, address1, address2, city, state, zipcode, phone, email)
VALUES (@citizen_id, @first_name, @last_name, @address1, @address2, @city, @state, @zipcode, @phone, @email)
GO
GRANT EXECUTE ON AddIncident 
    TO winforms;  
GO 
