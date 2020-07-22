Feature: SearchSkill
	In order to search a skill
	As a user selling skill
	user wants to search skill by category,by sub-category and filter

@Automation 
Scenario: Search skill by category 
	Given User enters category in search textbox to search
	Then Search result should get displayed

@Automation
Scenario:Search skill by SubCategory 
      Given User enters sub category in search textbox to search
	Then Search result should get displayed

@Automation
Scenario:Search skill by filter
      Given User enters filter in search textbox to search
	Then Search result should get displayed

@Automation
Scenario:Search Skill by category in search result page
      Given User is in search result page
	  When user search skill by selecting category
	  Then Search result should get displayed

@Automation
Scenario:Search Skill by sub-category in search result page
      Given User is in search result page
	  When user search skill by selecting sub-category
	  Then Search result should get displayed