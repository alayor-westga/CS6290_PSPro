Feature: LoginFeature
	Login into the app

@mytag
Scenario: Login with no username and password
	Given username is empty
	And password is empty
	When click on Login
	Then the message "Invalid Credentials" is shown