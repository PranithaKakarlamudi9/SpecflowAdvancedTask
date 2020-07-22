Feature: ChangePassword
	In order to change password
	As a user selling skills
	I want to make changes accordingly

@Automation
Scenario:Change Password
	Given user clicks on change password 
	When user enters valid information
	Then password gets changed successfully
