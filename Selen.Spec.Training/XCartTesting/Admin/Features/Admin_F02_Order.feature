Feature: Order
	As an admin I want to be able to view orders
@ignore
Scenario: Admin_F02_TC01_Navigation
	Given I have gone to the http://localhost:81/admin.php url
	When I login with username user@example.com and password 1234
	Then Orders menu item should be displayed in the left menu
	When I open Orders menu item
	Then Orders list, Statistics, Payment transactions items are displayed under Orders menu item
	When I select Orders list under Orders menu item
	Then Orders page should be displayed
	When I select Statistics under Orders menu item
	Then Statistics page should be displayed
	When I select Payment transactions under Orders menu item
	Then Payment transactions page should be displayed

@ignore
Scenario: Admin_F02_TC02_OrdersPage_UI

@ignore
Scenario: Admin_F02_TC03_OrdersPage_NewOrderAddedToOrdersTable

@ignore
Scenario: Admin_F02_TC04_OrdersPage_DeleteOrder

@ignore
Scenario: Admin_F02_TC05_OrdersPage_SearchOrders