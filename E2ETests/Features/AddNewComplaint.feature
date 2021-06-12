Feature: Add New Complaint
	Add a new complaint as a supervisor

Background:
    Given personnel exists on the DB with this info
	|type|username|password|first_name|last_name|gender|hiredate|birthdate|assignment|
	|supervisor|s-001|4567|Super|Visor|M|2000-01-01|1970-01-01|assigment1|
    And supervisor "s-001" logs in with password "4567"

Scenario: Add new complaint with empty information 
	When click on Save
    Then the first name field is labeled as required
    And the officer field is labeled as required
    And the allegation field is labeled as required
    And the complaint summary field is labeled as required