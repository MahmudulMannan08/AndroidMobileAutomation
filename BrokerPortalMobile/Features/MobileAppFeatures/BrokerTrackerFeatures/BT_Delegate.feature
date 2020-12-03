Feature: BT_Delegate
	Login as Broker, Broker Admin, Delegated Broker, Non-Delegated Broker
	Verify Delegate Filter

Scenario: BT Delegate Broker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn for broker delegate
	Then I search and view MMS deal for broker delegate
	Then I assign MMS deal to broker delegate
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	Then I verify broker filter unavailable on Broker Tracker
	Then I go to My Profile on Broker Tracker
	And I select Delegated Authority menu on Broker Tracker
	Then I add a broker delegate on Broker Tracker
	Then I enable broker delegate on Broker Tracker
	Then I navigate back on android
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App with delegated broker on Android Emulator
	Then I verify broker filter available on Broker Tracker
	And I verify broker filter on Broker Tracker
	Then I select All Brokers on broker filter on Broker Tracker App
	And I select Solicitor closed deals tab on Broker Tracker
	And I verify the deal list view for All Brokers on Broker Tracker
	And I cancel search on Broker Tracker
	Then I select Non-Delegate broker on broker filter on Broker Tracker App
	And I select Solicitor closed deals tab on Broker Tracker
	And I verify the deal list view for Non-Delegate broker on Broker Tracker
	And I cancel search on Broker Tracker
	Then I select Delegate broker on broker filter on Broker Tracker App
	And I select Solicitor closed deals tab on Broker Tracker
	And I verify the deal list view for Delegate broker on Broker Tracker
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App on Android Emulator
	Then I verify broker filter unavailable on Broker Tracker
	Then I go to My Profile on Broker Tracker
	And I select Delegated Authority menu on Broker Tracker
	Then I delete broker delegate on Broker Tracker
	Then I navigate back on android
	And I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Delegate - Verify Broker Admin
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App with broker admin on Android Emulator
	Then I verify broker filter unavailable on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser