Feature: Open Pages

@mytag
Scenario: F01_TC01_Open XCart Admin page
	When I go to the http://localhost:81/admin.php url
	Then The X-Cart online store builder - *Your company names* page should be displayed

Scenario: F01_TC02_Login with valid account
	Given I have gone to the http://localhost:81/admin.php url
	When I login with username user@example.com and password 1234