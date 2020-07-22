Feature: CertificationsProfile
	In order to have Certification details in  profile
	As a user selling skills
  User wants to be perform add,upadate and delete on Certification tab in profile page


@Automation @Add
Scenario: Add Certification to profile page
	Given User clicks on Certification tab
	When Adds Certification details
	Then Certification should get added on the profile page

@Automation @Update
Scenario:Update Certification on profile page
	Given User clicks on Certification tab
	When Updates Certification details
	Then Certification should get updated on the profile page

@Automation @Delete
Scenario:Delete Certification on profile page
	Given  User clicks on Certification tab
	When  Clicks on Ceritification delete icon
	Then Certification should get deleted on the profile page
