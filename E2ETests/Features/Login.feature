Feature: LoginFeature
	Login into the app

Background:
    Given supervisor with username "s-001" and password "4567" exists on the DB
    And investigator with username "i-001" and password "4567" exists on the DB
    And administrator with username "a-001" and password "4567" exists on the DB

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