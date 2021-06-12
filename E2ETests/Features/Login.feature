Feature: LoginFeature
	Login into the app

Background:
    Given personnel exists on the DB with this info
	|type|username|password|first_name|last_name|gender|hiredate|birthdate|assignment|
	|"supervisor"|"s-001"|"4567"|"Super"|"Visor"|"M"|"2000-01-01"|"1970-01-01"|"assigment1"|
	|"investigator"|"i-001"|"4567"|"Investi"|"Gator"|"F"|"2001-01-01"|"1988-01-01"|"assigment1"|
	|"administrator"|"a-001"|"4567"|"Admin"|"Istrator"|"M"|"2016-01-01"|"1992-01-01"|"assigment1"|

Scenario: Login with no username and password
	Given username is empty
	And password is empty
	When click on Login
	Then the message "Invalid credentials" is shown

Scenario: Login as supervisor
	Given username is "s-001"
	And password is "1234"
	When click on Login
	Then the user full name "Kristin Hero (s-001)" is shown

Scenario: Login as investigator
	Given username is "i-001"
	And password is "1234"
	When click on Login
	Then the user full name "Derek Frost (i-001)" is shown