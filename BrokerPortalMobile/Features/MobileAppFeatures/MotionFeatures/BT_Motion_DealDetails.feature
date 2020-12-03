Feature: BT_Motion_DealDetails
	Login to Motion Portal
	Create Motion Deal
	Assign Broker to Deal
	Verify Deal Details, Deal Status, Notes & Action Required Sections

Scenario: BT Veriy Notes Section
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And Motion - I verify blank note grid on Broker Tracker
	And I verify blank note grid on Broker Tracker
	And I verify Action Required section for Motion broker alert available on Broker Tracker
	Then I acknowledge YES to Motion broker alert on Broker Tracker
	And I verify acknowledged Motion note grid on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I add second Motion note with broker alert
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Action Required section for second Motion broker alert available on Broker Tracker
	Then I submit reply to second Motion broker alert on Broker Tracker
	And I verify replied Motion note grid on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Verify Action Required Section
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Action Required section for Motion broker alert unavailable on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I add Motion note with broker alert
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Action Required section for Motion broker alert available on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Verify Deal Details Section
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Motion deal details on Broker Tracker
	And I verify Motion person mortgagor information on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I update business mortgagor information on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Motion business mortgagor information on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I add person mortgagor information on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Motion deal details on Broker Tracker
	And I verify multiple Motion mortgagor information on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser