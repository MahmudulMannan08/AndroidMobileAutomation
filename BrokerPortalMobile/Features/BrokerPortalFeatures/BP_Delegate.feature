Feature: BP_Delegate
	Login as Broker, Broker Admin, Delegated Broker, Non-Delegated Broker
	Verify Delegate Filter

Scenario: BP Delegate Broker
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
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	Then I verify broker filter unavailable on broker portal
	Then I go to My Profile on broker portal
	And I select Delegated Authority menu on broker portal
	Then I add a broker delegate on broker portal
	And I sign out from My Profile page on broker portal
	Then I login to Broker Portal on Android Emulator Browser
	Then I go to My Profile on broker portal
	And I select Delegated Authority menu on broker portal
	Then I enable broker delegate on broker portal
	And I sign out from My Profile page on broker portal
	Then I login to Broker Portal with delegated broker on Android Emulator Browser
	Then I verify broker filter available on broker portal
	And I verify broker filter on broker portal
	And I select Solicitor closed deals tab
	Then I select All Brokers on broker filter
	And I verify the deal list view for All Brokers on broker portal
	Then I select Non-Delegate broker on broker filter
	And I verify the deal list view for Non-Delegate broker on broker portal
	Then I select Delegate broker on broker filter
	And I verify the deal list view for Delegate broker on broker portal
	And I logout from Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	Then I go to My Profile on broker portal
	And I select Delegated Authority menu on broker portal
	Then I delete broker delegate on broker portal
	And I sign out from My Profile page on broker portal

Scenario: BP Delegate - Verify Broker Admin
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal with broker admin on Android Emulator Browser
	Then I verify broker filter unavailable on broker portal
	And I logout from Broker Portal on Android Emulator Browser