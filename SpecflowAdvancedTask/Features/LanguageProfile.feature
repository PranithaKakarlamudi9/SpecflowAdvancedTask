Feature: LanguageProfile
	In order to have language details in  profile
	As a user selling skills
  user wants to be perform add upadate and delete on Lnguage tab in profile page

@Automation @Add
Scenario: Add language to profile page
	Given user clicks AddNew in Lnguage tab
	When adds language details
	Then language should get added on the profile page

@Automation @Update
Scenario:Update language on profile page
	Given user clicks edit icon in Lnguage tab
	When updates language details
	Then language should get updated on the profile page

@Automation @Delete
Scenario:Delete language on profile page
	Given user clicks  delete icon in Lnguage tab	
	Then language should get deleted on the profile page