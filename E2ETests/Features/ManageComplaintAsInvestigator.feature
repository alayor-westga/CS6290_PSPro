﻿Feature: Manage Complaint As Investigator
	Manage a complaint as investigator

Background:
    Given personnel exists on the DB with this info
	|type|username|password|first_name|last_name|gender|hiredate|birthdate|assignment|
	|supervisor|s-001|4567|Super|Visor|M|2000-01-01|1970-01-01|assigment1|
	|investigator|i-001|4567|Investi|Gator|M|2000-01-01|1970-01-01|assigment1|
	|officer|||Offi|Cer|F|2010-01-01|1990-01-01|assigment2|
    And supervisor "s-001" logs in with password "4567"
	And a complaint with this info is created
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|officer|allegation|summary|
	|Citi|Zen|123 Main St.||San Jose|California|89900|555-555-5555|citizen@example.com|Offi Cer|Ethics Violation|Complaint summary example|
	And the user logs out
	And investigator "i-001" logs in with password "4567"


Scenario: See active complaint
	Then investigator should see a complaint with this info
	|officer|citizen|allegation|
	|Offi Cer|Citi Zen|Ethics Violation|
	When investigator clicks on Manage Complaint
	Then the complaint status should be "Open"

Scenario: Set complaint disposition
	Given investigator clicks on Manage Complaint
	And investigator selects the disposition "Unfounded"
	When investigator saves the complaint changes
	Then the complaint disposition should be updated to "Unfounded" in the DB