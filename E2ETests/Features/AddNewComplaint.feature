Feature: Add New Complaint
	Add a new complaint as a supervisor

Background:
    Given personnel exists on the DB with this info
	|type|username|password|first_name|last_name|gender|hiredate|birthdate|assignment|
	|supervisor|s-001|4567|Super|Visor|M|2000-01-01|1970-01-01|assigment1|
	|officer|||Offi|Cer|F|2010-01-01|1990-01-01|assigment2|
    And supervisor "s-001" logs in with password "4567"

Scenario: Add new complaint with empty information 
	When click on save
    Then the first name field is labeled as required
    And the officer field is labeled as required
    And the allegation field is labeled as required
    And the complaint summary field is labeled as required

Scenario: Add new complaint successfully
    Given this citizen info is entered
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|
	|Citi|Zen|123 Main St.||San Jose|California|89900|555-555-5555|citizen@example.com|
    And the officer "Offi Cer" is selected
    And the allegation "Ethics Violation" is selected
    And the complaint summary is "Complaint summary example"
    When click on save
    Then the complaint should be saved with this content
    |supervisor_name|citizen_name|officer_name|allegation_type|complaint_notes|
    |Super Visor|Citi Zen|Offi Cer|Ethics Violation|Complaint summary example|
    And the citizen should be saved with this content
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|
    |Citi|Zen|123 Main St.||San Jose|CA|89900|555-555-5555|citizen@example.com|