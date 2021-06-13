Feature: CreateTodo
	As a user, i want to create a todo

@mytag
Scenario: Create a new Todo
	Given I navigated to the todo application page
	And I enter username "sharonm@test.com"
	And I enter password "test123"
	And I click on the login button
	And I click on the Add todo icon
	And I enter title "My Todo"
	And I enter description "This is my test Todo"
	When I click on the save button
	Then The todo should be created successfully

	When I click on the todo item "My Todo"
	Then I should see all the todo item details