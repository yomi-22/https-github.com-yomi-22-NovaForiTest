Feature: TechnicalTest
As user I should able to 
naviagte across the website successfully

@Exercise1
Scenario: User should see error message when coordinate is blank
	Given the user is on home page
	And the coordinates are displayed
	When the user leaves coordinate blank
	Then the user get an error message "This field is required"

Scenario: More than one coordinates should be separated by comma
	Given the user is on home page
	When there are more than one coordinates displayed
	Then the coordinates should be separated by comma

Scenario: Error message should be displayed if four coordinates do not make a square
	Given the user is on home page
	And there are 4 coordinates join together
	When the four coordinates do not make a square
	Then the user should see an error message

Scenario: Next page should be identical with the mock page
	Given the user is on home page
	And the user filled coordinates without leaving any blank
	When the user click on checkbox
	Then the user is on new the page
	And the user should see 4 coordinates with check and clear button

@Exercise2
Scenario: User should able to click on the sticky naviagtion link and see the total numbers of links
	Given the user is on homepage
	And the user click on the resources link
	And the user click on the FAQ's link on the dropdown link
	And the user is on the faqs page
	When the user click on each "Pricing, Integrations, Marketplace features,Hosting, Industry and verticals" sub navigation link on the left side
	Then the total number of the  sub navigation link on the left side should be 5