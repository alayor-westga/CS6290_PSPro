﻿Feature: Manage Complaint As Administrator
	Manage a complaint as administrator

Background:
    Given personnel exists on the DB with this info
	|type|username|password|first_name|last_name|gender|hiredate|birthdate|assignment|
	|supervisor|s-001|4567|Super|Visor|M|2000-01-01|1970-01-01|assigment1|
	|administrator|a-001|4567|Adminis|Traitor|F|2000-01-01|1970-01-01|assigment1|
	|investigator|i-001|4567|Investi|Gator|F|2000-01-01|1970-01-01|assigment1|
	|officer|||Offi|Cer|F|2010-01-01|1990-01-01|assigment2|
    And supervisor "s-001" logs in with password "4567"
	And a complaint with this info is created
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|officer|allegation|summary|
	|Citi|Zen|123 Main St.||San Jose|California|89900|555-555-5555|citizen@example.com|Offi Cer|Officer Safety Violation|Complaint summary|
	And the user logs out
	


Scenario: See active complaint
    And administrator "a-001" logs in with password "4567"
	Then administrator should see a complaint with this info
	|officer|citizen|allegation|
	|Offi Cer|Citi Zen|Officer Safety Violation|
	# When administrator clicks on Manage Complaint
	# Then the complaint status should be "Open"
	And the user logs out



Scenario: Set complaint discipline
	And investigator "i-001" logs in with password "4567"
    Given investigator clicks on Manage Complaint
	And investigator selects the disposition "Unfounded"
	When investigator saves the complaint changes
	Then the complaint disposition should be updated to "Unfounded" in the DB
	And the user logs out
	Given administrator "a-001" logs in with password "4567"
	Given administrator clicks on Manage Complaint
	And administrator selects the discipline "None"
	When administrator saves the complaint changes
	Then the complaint discipline should be updated to "None" in the DB

