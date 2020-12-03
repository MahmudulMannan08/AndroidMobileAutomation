Feature: BT_MyProfile
	Login as Broker, Broker Admin, Delegated Broker
	Verify My Profile, Contact Us, Delegated Authority, Notificatin Preferences Features

Scenario: BT My Profile - Delegate Authority
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	Then I verify broker filter unavailable on Broker Tracker
	Then I go to My Profile on Broker Tracker
	And I select Delegated Authority menu on Broker Tracker
	Then I add a broker delegate on Broker Tracker
	Then I navigate back on android
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App with delegated broker on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I search MMS deal for disabled delegate on Broker Tracker
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App on Android Emulator
	Then I verify broker filter unavailable on Broker Tracker
	Then I go to My Profile on Broker Tracker
	And I select Delegated Authority menu on Broker Tracker
	Then I enable broker delegate on Broker Tracker
	Then I navigate back on android
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App with delegated broker on Android Emulator
	Then I verify broker filter available on Broker Tracker
	And I select Solicitor closed deals tab on Broker Tracker
	Then I search MMS deal for delegated broker on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App on Android Emulator
	Then I verify broker filter unavailable on Broker Tracker
	Then I go to My Profile on Broker Tracker
	And I select Delegated Authority menu on Broker Tracker
	Then I delete broker delegate on Broker Tracker
	Then I navigate back on android
	And I logout from Broker Tracker on Android Emulator Browser

Scenario: BT My Profile - Menu
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I verify My Profile menu on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App with broker admin on Android Emulator
	And I verify My Profile menu on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser

