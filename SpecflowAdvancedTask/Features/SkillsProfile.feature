Feature: SkillsProfile
	In order to have Skills details in  profile
	As a user selling skills
  User wants to be perform add,upadate and delete on Skills tab in profile page


@Automation @Add
Scenario: Add Skills to profile page
	Given User clicks on Skills tab
	When Adds skill details
	Then Language should get added on the profile page

@Automation @Update
Scenario:Update Skills on profile page
	Given User clicks on Skills tab
	When Updates skill details
	Then Skill should get updated on the profile page

@Automation @Delete
Scenario:Delete Skills on profile page
	Given User clicks on Skills tab
	When Clicks on skill delete icon
	Then Skill should get deleted on the profile page