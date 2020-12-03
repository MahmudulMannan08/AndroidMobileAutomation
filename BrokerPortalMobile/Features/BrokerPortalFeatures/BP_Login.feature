Feature: BP_Login
	Login as Broker, Broker Admin, Delegated Broker, Non-Broker User, Inactive Broker, Declined Broker, Locked Broker
	Verify Login Authentication

Scenario: BP - Login Authentication
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I verify successful login to broker portal
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
	And I logout from Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	Then I go to My Profile on broker portal
	And I select Delegated Authority menu on broker portal
	Then I delete broker delegate on broker portal
	And I sign out from My Profile page on broker portal
	Then I login to Broker Portal with non-broker user on Android Emulator Browser
	And I verify user unauthorized to log in on broker portal
	Then I login to Broker Portal with inactive broker user on Android Emulator Browser
	And I verify user unauthorized to log in on broker portal
	Then I login to Broker Portal with declined broker user on Android Emulator Browser
	And I verify user unauthorized to log in on broker portal
	Then I login to Broker Portal with locked broker user on Android Emulator Browser
	And I verify locked user log in on broker portal