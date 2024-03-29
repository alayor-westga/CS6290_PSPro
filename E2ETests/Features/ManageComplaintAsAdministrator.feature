﻿Feature: Manage Complaint As Administrator
	Manage a complaint as administrator

Background:
    Given personnel exists on the DB with this info
	|type|username|password|first_name|last_name|gender|hiredate|birthdate|assignment|
	|supervisor|s-001|4567|Super|Visor|M|2000-01-01|1970-01-01|assigment1|
	|administrator|a-001|4567|Adminis|Traitor|F|2000-01-01|1970-01-01|assigment1|
	|investigator|i-001|4567|Investi|Gator|F|2000-01-01|1970-01-01|assigment1|
	|officer|||Offi|Cer|F|2010-01-01|1990-01-01|assigment2|
	|officer|||Another|OffiCer|M|2009-10-01|1970-01-12|assigment3|
    And supervisor "s-001" logs in with password "4567"
	And a complaint with this info is created
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|officer|allegation|summary|
	|Citi|Zen|123 Main St.||San Jose|California|89900|555-555-5555|citizen@example.com|Offi Cer|Ethics Violation|Complaint summary example|
	And the user logs out
	
Scenario: See active complaint
    And administrator "a-001" logs in with password "4567"
	Then administrator should see a complaint with this info
	|officer|citizen|allegation|
	|Offi Cer|Citi Zen|Officer Safety Violation|
	When administrator clicks on Manage Complaint
	Then the complaint status should be "Open"
	And the user logs out

Scenario: See active complaints by officer
    Given supervisor "s-001" logs in with password "4567"
	And a complaint with this info is created
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|officer|allegation|summary|
	|Another|CitiZen|123 Linconln Blvd.||Grapevine|Texas|68821|555-444-5532|citizen2@example.com|Another OffiCer|Excessive Force|Complaint notes example|
	And the user logs out
	And administrator "a-001" logs in with password "4567"
	Then administrator should see 2 complaints
	When admin selects officer "Offi Cer"
	Then administrator should see one complaint with this info
	|officer|allegation|
	|Offi Cer|Ethics Violation|
	When admin selects officer "Another OffiCer"
	Then administrator should see one complaint with this info
	|officer|allegation|
	|Another OffiCer|Excessive Force|

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
	And the user logs out
	When investigator "i-001" logs in with password "4567"
	Then investigator should see 0 complaints

Scenario: Append comments to complaint
	Given administrator "a-001" logs in with password "4567"
	Given administrator clicks on Manage Complaint
	And administrator clicks the See Notes button
	Then the current notes should contain "Complaint summary example"
	When administrator adds the comment "my comment"
	And administrator saves the comment
	Then the complaint notes should contain "my comment" in the DB
	And the user logs out

Scenario: Complaints for officers having greater than three complaints in past year
	And supervisor "s-001" logs in with password "4567"
	And a complaint with this info is created
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|officer|allegation|summary|
	|Citi|Zen|123 Main St.||San Jose|California|89900|555-555-5575|citizen@example.com|Offi Cer|Ethics Violation|Complaint summary example|
	And a complaint with this info is created
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|officer|allegation|summary|
	|Citi|Zen|123 Main St.||San Jose|California|89900|555-555-5535|citizen@example.com|Offi Cer|Ethics Violation|Complaint summary example|
	And a complaint with this info is created
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|officer|allegation|summary|
	|Citi|Zen|123 Main St.||San Jose|California|89900|555-555-5955|citizen@example.com|Offi Cer|Ethics Violation|Complaint summary example|
	And a complaint with this info is created
    |first_name|last_name|address1|address2|city|state|zip_code|phone_number|email_address|officer|allegation|summary|
	|Another|CitiZen|123 Linconln Blvd.||Grapevine|Texas|68821|555-444-5532|citizen2@example.com|Another OffiCer|Excessive Force|Complaint notes example|
	And the user logs out
	And administrator "a-001" logs in with password "4567"
	Then administrator should see 5 complaints
	When administrator selects view complaints for officers with more than three complaints
	Then administrator should see 4 complaints