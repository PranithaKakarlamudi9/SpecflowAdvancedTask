Feature: ManageListings
	In order to Mnage Listings
	As a user selling skills
	I want to perform update and delete on Manage Listings

@Automation @Update
Scenario:Update Manage Listings
	Given user navigates to Manage Listings page
	When  user clicks on edit icon in Manage listings table
	Then manage listing should get updated

@Automation @Delete
Scenario:Delete Manage Listings
	Given user navigates to Manage Listings page
	When  user clicks on delete icon in Manage listings table
	Then manage listing should get deleted
