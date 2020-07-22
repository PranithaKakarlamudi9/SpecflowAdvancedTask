Feature: Registration
	In order to join into website
	As a new user selling skills
	User registers with valid information

@Automation
Scenario: User registration
	Given User is in  the homepage 
	When  User enter valid information
	Then  User successfully registers 
