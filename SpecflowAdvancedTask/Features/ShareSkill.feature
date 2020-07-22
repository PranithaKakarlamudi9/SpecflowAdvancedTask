Feature: ShareSkill
	In order to Share skills
	As a user selling skills
	I want to add ShareSkill

@Automation @Add
Scenario: Add ShareSkill
	Given User navigates to ShareSkill page
	When User adds ShareSkill details on the ShareSkill page
	Then ShareSkill should get added 
