Feature: Order
	As an admin I want to be able to view orders

Scenario: Admin_F02_TC01_Navigation
	Given I have gone to the http://localhost:81/admin.php url
	When I login with username user@example.com and password 1234
	Then Orders menu item is displayed in the left menu
	When I click Orders menu item
	Then Orders list, Statistics, Payment transactions items are displayed under Orders menu item
	When I click Orders list item
	Then Orders page is displayed
	When I click Statistics item
	Then Statistics page is displayed
	When I click Payment transactions item
	Then Payment transactions page is displayed

Scenario: Admin_F02_TC02_OrdersPage_UI

Scenario: Admin_F02_TC03_OrdersPage_NewOrderAddedToOrdersTable

Scenario: Admin_F02_TC04_OrdersPage_DeleteOrder

Scenario: Admin_F02_TC05_OrdersPage_SearchOrders