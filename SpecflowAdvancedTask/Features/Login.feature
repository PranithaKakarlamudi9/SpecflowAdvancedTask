Feature: Login
	In order to Login into website
	As a user selling skills
	user enters valid data and logs in successfully

@Automation
Scenario:successful login 
	Given user is in homepage
	And user enters valid username and password
	When user clicks on login
	Then user logs in successfully
