Feature: EducationProfile
	In order to have Education details in  profile
	As a user selling skills
  User wants to be perform add,upadate and delete on Education tab in profile page


@Automation @Add
Scenario: Add Education to profile page
	Given User clicks on Education tab
	When Adds Education details
	Then Education should get added on the profile page

@Automation @Update
Scenario:Update Education on profile page
	Given User clicks on Education tab
	When Updates Education details
	Then Education should get updated on the profile page

@Automation @Delete
Scenario:Delete Education on profile page
	Given  User clicks on Education tab
	When  Clicks on delete icon
	Then Education should get deleted on the profile page