Feature: Parameters in Feature file

@param
Scenario: Parameter Scenario 1
	Given I am on the web page "http://www.softpost.org"
	Then I verify that title of the page contains "free tutorial"

@param
Scenario: Parameter Scenario 2
	Given I am on the web page "http://www.yahoo.com"
	Then I verify that title of the page contains "yahoo"