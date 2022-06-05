Feature: NonChromeBrowser
Testing Non Chrome browsers

@ToDoApp
Scenario Outline: Add items to the ToDoApp
	Given I navigate to LamdaTest App on following <Browser> with <Title>
	And I select the first item
	And I select the second item
	And I enter the <NewItem> in textbox
	When I click the Add button
	Then I verify whether <NewItem> is added to the list
	Examples:
	| Browser | Title                 | NewItem |
	| Chrome  | LambdaTest Sample App | N Item  |
	