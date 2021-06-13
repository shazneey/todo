Feature: ViewTodo
	As a user, i want to view the todo i created

@mytag
Scenario: View Todo
	Given I navigated to the todo application page
	And I enter username "sharonm@test.com"
	And I enter password "test123"
	And I click on the login button
	And I click on items
	When I click on todo item with title "Todo Updated"
	Then I should see the todo item details