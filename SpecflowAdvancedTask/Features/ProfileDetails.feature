Feature: Profile
	In order to add availability,hours,earn target and description to profile
	As a user selling skills
	user enters valid information 

@Automation @Add
Scenario:  Add Availabilty
	Given user clicks on availability
	When user selects availabity from dropdown
	Then availability is successfully saved
@Automation @Update
Scenario: Update Availabilty
	Given user clicks on availability
	When user updates availability
	Then availability is successfully updated

@Automation @Add
Scenario: Add Hours
	Given user clicks on Hours
	When user selects hours from dropdown
	Then hours is successfully saved
@Automation @Update
Scenario: Update Hours
	Given user clicks on Hours
	When user updates Hours
	Then hours is successfully updated

@Automation @Add
Scenario: Add Earn Target
	Given user clicks on Earn Target
	When user selects Earn Target from dropdown
	Then Earn Target is successfully saved
@Automation @Update
Scenario: Update Earn Target
	Given user clicks on Earn Target
	When user updates Earn Target
	Then Earn Target is successfully updated

@Automation @Add
Scenario: Add Description
	Given user clicks on Description
	When user adds Description
	Then user saves Description

@Automation @Update
Scenario: Update Description
	Given user clicks on Description
	When user updates Description
	Then user updates Description successsfully





