Feature: BT_Login
	Login as Broker, Broker Admin, Delegated Broker, Non-Broker User, Inactive Broker, Declined Broker, Locked Broker
	Verify Login Authentication

Scenario: BT - Login Authentication
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I verify successful login to Broker Tracker
	Then I go to My Profile on Broker Tracker
	And I select Delegated Authority menu on Broker Tracker
	Then I add a broker delegate on Broker Tracker
	Then I enable broker delegate on Broker Tracker
	Then I navigate back on android
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App with delegated broker on Android Emulator
	Then I verify broker filter available on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker App on Android Emulator
	Then I verify broker filter unavailable on Broker Tracker
	Then I go to My Profile on Broker Tracker
	And I select Delegated Authority menu on Broker Tracker
	Then I delete broker delegate on Broker Tracker
	Then I navigate back on android
	And I logout from Broker Tracker on Android Emulator Browser
	Then I login to Broker Tracker with non-broker user on Android Emulator
	And I verify user unauthorized to log in on Broker Tracker
	Then I login to Broker Tracker with inactive broker user on Android Emulator
	And I verify user unauthorized to log in on Broker Tracker
	Then I login to Broker Tracker with declined broker user on Android Emulator
	And I verify user unauthorized to log in on Broker Tracker
	Then I login to Broker Tracker with locked broker user on Android Emulator
	And I verify locked user log in on Broker Tracker