Feature: LogIn
	As a user, i want to login the todo application

@mytag
Scenario: User login successfully
	Given I navigated to the todo application page
	And I enter username "sharonm@test.com"
	And I enter password "test123"
	When I click on the login button
	Then I should be logged in successfully