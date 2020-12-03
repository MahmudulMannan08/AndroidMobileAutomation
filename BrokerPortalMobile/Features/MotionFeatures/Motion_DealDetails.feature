Feature: Motion_DealDetails
	Login to Motion Portal
	Create Motion Deal
	Assign Broker to Deal
	Verify Deal Details, Deal Status, Notes & Action Required Sections

Scenario: BP Veriy Notes Section
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
	And I verify blank note grid on broker portal
	And I verify Action Required section for Motion broker alert available
	Then I acknowledge YES to Motion broker alert
	And I verify acknowledged Motion note grid on broker portal
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I add second Motion note with broker alert
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal on broker portal
	Then I go to Motion deal details page on broker portal
	And I verify Action Required section for second Motion broker alert available
	Then I submit reply to second Motion broker alert
	And I verify replied Motion note grid on broker portal
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Verify Action Required Section
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
	Then I verify Action Required section for Motion broker alert unavailable
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I add Motion note with broker alert
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal on broker portal
	Then I go to Motion deal details page on broker portal
	And I verify Action Required section for Motion broker alert available
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Verify Deal Details Section
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
	And I verify Motion deal details on broker portal
	And I verify Motion person mortgagor information on broker portal
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I update business mortgagor information on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal without broker alert on broker portal
	And I verify Motion business mortgagor information on broker portal
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I add person mortgagor information on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal without broker alert on broker portal
	And I verify Motion deal details on broker portal
	And I verify multiple Motion mortgagor information on broker portal
	And I logout from Broker Portal on Android Emulator Browser