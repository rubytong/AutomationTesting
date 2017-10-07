﻿Feature: Order
	As an admin I want to be able to view orders

Scenario: Admin_F02_TC01_Navigation
	Given I have gone to the http://google.com url


@ignore
Scenario: Admin_F02_TC02_OrdersPage_UI
	When I login with username user@example.com and password 1234
	Then Orders menu item should be displayed in the left menu
	When I open Orders menu item
	Then Orders list, Statistics, Payment transactions items are displayed under Orders menu item
	When I select Orders list under Orders menu item
	Then The title page label should display Orders
	When I select Statistics under Orders menu item
	Then The title page label should display Statistics
	When I select Payment transactions under Orders menu item
	Then The title page label should display Payment transactions

@ignore
Scenario: Admin_F02_TC03_OrdersPage_NewOrderAddedToOrdersTable

@ignore
Scenario: Admin_F02_TC04_OrdersPage_DeleteOrder

@ignore
Scenario: Admin_F02_TC05_OrdersPage_SearchOrders