Feature: Getting Motor quotes
	In order to validate quoting process I want to be able to enter
	the required data and navigating through the screens and to get list of
	eligible Motor quotes

@GetMotorQuotes
Scenario Outline: Get at least 1 Motor quote displayed on the results page
	Given I navigate to the Compare the Market website and start a Motor quote
	When I enter the details of the quote inculding <CoverType>, <FactoryOptions>, <HowCarUsed>, <HasYoungerDriver> and navigate through the screens
	Then I can verify that the results page is displayed
	And I can verify that at least 1 quote result is displayed
	And the cover type selected is printed to the output

	Examples:
	| Testcase | CoverType      | FactoryOptions | HowCarUsed | HasYoungerDriver |
	| 1        | Comprehensive  | yes            | business   | yes              |
	| 2        | Comprehensive  | no             | private    | no              |

