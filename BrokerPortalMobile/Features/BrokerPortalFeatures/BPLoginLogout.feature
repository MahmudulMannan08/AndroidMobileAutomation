Feature: BPLoginLogout
	Launch Broker Portal on Android/Ios Emulator
	Login to Broker Portal
	Logout from Broker Portal

Scenario: Broker Portal Login & Logout
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I logout from Broker Portal on Android Emulator Browser
