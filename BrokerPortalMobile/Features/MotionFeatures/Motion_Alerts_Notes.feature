Feature: Motion_Alerts_Notes
	Login to Motion Portal
	Create Motion Deal
	Assign Broker to Deal
	Create notes with/without Broker Alert
	Verify Alerts on Broker Portal
	Send New Note from Broker Portal

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
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I get Action Required bucket count
	Then I search Motion deal on broker portal
	And I verify alert icon on deal list page
	Then I go to Motion deal details page on broker portal
	And I verify Action Required section for Motion broker alert available
	Then I acknowledge NO to broker alert
	Then I navigate back on android
	And I select FCT closed deals tab
	Then I verify Action Required bucket count
	Then I search Motion deal on broker portal
	Then I go to Motion deal details page on broker portal
	And I verify Action Required section for Motion broker alert available
	Then I acknowledge YES to Motion broker alert
	Then I navigate back on android
	And I select FCT closed deals tab
	Then I verify Action Required bucket count decreased
	And I logout from Broker Portal on Android Emulator Browser

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
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I get Action Required bucket count
	Then I search Motion deal on broker portal
	And I verify alert icon on deal list page
	Then I go to Motion deal details page on broker portal
	And I verify Action Required section for Motion broker alert available
	Then I acknowledge NO to broker alert
	Then I navigate back on android
	And I select FCT closed deals tab
	Then I verify Action Required bucket count
	Then I search Motion deal on broker portal
	Then I go to Motion deal details page on broker portal
	And I verify Action Required section for Motion broker alert available
	Then I acknowledge YES to Motion broker alert
	Then I navigate back on android
	And I select FCT closed deals tab
	Then I verify Action Required bucket count decreased
	And I logout from Broker Portal on Android Emulator Browser

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
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal without broker alert on broker portal
	Then I verify Action Required section for Motion broker alert unavailable
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Reply Alert To Motion Note
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
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I get Action Required bucket count
	Then I search Motion deal on broker portal
	And I verify alert icon on deal list page
	Then I go to Motion deal details page on broker portal
	And I verify Action Required section for Motion broker alert available
	Then I cancel reply to broker alert
	Then I navigate back on android
	And I select FCT closed deals tab
	Then I verify Action Required bucket count
	Then I search Motion deal on broker portal
	Then I go to Motion deal details page on broker portal
	And I verify Action Required section for Motion broker alert available
	Then I submit reply to Motion broker alert
	Then I navigate back on android
	And I select FCT closed deals tab
	Then I verify Action Required bucket count decreased
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to Motion portal
	Then I search deal on Motion Portal
	And I verify note reply by broker on Motion Portal

Scenario: BP New Note To Motion With Alert
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
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal on broker portal
	Then I go to Motion deal details page on broker portal
	Then I cancel new note on broker portal
	Then I send new note to Lender on broker portal
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to Motion portal
	Then I search deal on Motion Portal
	And I verify new note by broker on Motion Portal

Scenario: BP New Note To Motion Without Alert
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal without broker alert on broker portal
	Then I cancel new note on broker portal
	Then I send new note to Lender on broker portal
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to Motion portal
	Then I search deal on Motion Portal
	And I verify new note by broker on Motion Portal