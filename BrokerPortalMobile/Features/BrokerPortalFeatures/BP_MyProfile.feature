Feature: BP_MyProfile
	Login as Broker, Broker Admin, Delegated Broker
	Verify My Profile, Contact Us, Delegated Authority, Notificatin Preferences Features

Scenario: BP My Profile - Delegate Authority
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	Then I go to My Profile on broker portal
	And I select Delegated Authority menu on broker portal
	Then I add a broker delegate on broker portal
	And I sign out from My Profile page on broker portal
	Then I login to Broker Portal with delegated broker on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal for disabled delegate on broker portal
	And I logout from Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	Then I go to My Profile on broker portal
	And I select Delegated Authority menu on broker portal
	Then I enable broker delegate on broker portal
	And I sign out from My Profile page on broker portal
	Then I login to Broker Portal with delegated broker on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal for delegated broker on broker portal
	And I verify alert icon on deal list page
	Then I verify broker filter available on broker portal
	And I logout from Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	Then I go to My Profile on broker portal
	And I select Delegated Authority menu on broker portal
	Then I delete broker delegate on broker portal
	And I sign out from My Profile page on broker portal
	Then I login to Broker Portal with delegated broker on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal for disabled delegate on broker portal
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP My Profile - Menu
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I verify My Profile menu on broker portal
	Then I go to My Profile on broker portal
	And I verify left navigation menu on My Profile for broker on broker portal
	And I sign out from My Profile page on broker portal
	Then I login to Broker Portal with broker admin on Android Emulator Browser
	And I verify My Profile menu on broker portal
	Then I go to My Profile on broker portal
	And I verify left navigation menu on My Profile for broker admin on broker portal
	And I sign out from My Profile page on broker portal

Scenario: BP My Profile - Contact Information
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	Then I go to My Profile on broker portal
	And I select Contact Information menu on broker portal
	Then I update Contact Information on My Profile on broker portal
	And I select Delegated Authority menu on broker portal
	And I select Contact Information menu on broker portal
	Then I verify Contact Information updated on My Profile on broker portal
	And I sign out from My Profile page on broker portal