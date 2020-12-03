Feature: BT_Motion_Alerts_Notes
	Login to Motion Portal
	Create Motion Deal
	Assign Broker to Deal
	Create notes with/without Broker Alert
	Verify Alerts on Broker Tracker
	Send New Note from Broker Tracker

Scenario: Motion Note with checked Broker Alert
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
	Then Motion - I get Action Required bucket count on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Action Required section for Motion broker alert available on Broker Tracker
	Then Motion - I acknowledge NO to broker alert on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And I refresh android app
	Then Motion - I verify Action Required bucket count on Broker Tracker
	Then I search Motion deal on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	Then I acknowledge YES to Motion broker alert on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And I refresh android app
	Then Motion - I verify Action Required bucket count decreased on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: Motion Note with un-checked Broker Alert
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note without broker alert
	And I check broker alert checkbox on Motion note grid
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get Action Required bucket count on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Action Required section for Motion broker alert available on Broker Tracker
	Then Motion - I acknowledge NO to broker alert on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And I refresh android app
	Then Motion - I verify Action Required bucket count on Broker Tracker
	Then I search Motion deal on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	Then I acknowledge YES to Motion broker alert on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And I refresh android app
	Then Motion - I verify Action Required bucket count decreased on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: Motion No Broker Alert
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note without broker alert
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Action Required section for Motion broker alert unavailable on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Reply Alert To Motion Note
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
	Then Motion - I get Action Required bucket count on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Action Required section for Motion broker alert available on Broker Tracker
	Then Motion - I cancel reply to broker alert on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And I refresh android app
	Then Motion - I verify Action Required bucket count on Broker Tracker
	Then I search Motion deal on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Action Required section for Motion broker alert available on Broker Tracker
	Then I submit reply to Motion broker alert on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And I refresh android app
	Then Motion - I verify Action Required bucket count decreased on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I search deal on Motion Portal
	And I verify note reply by broker on Motion Portal

Scenario: BT New Note To Motion With Alert
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
	Then Motion - I cancel new note on Broker Tracker
	Then Motion - I send new note to Lender on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I search deal on Motion Portal
	And I verify new note by broker on Motion Portal