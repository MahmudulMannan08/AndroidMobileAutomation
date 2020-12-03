Feature: Motion_DealListView
	Login to Motion Portal
	Create Motion Deal
	Assign Broker to Deal
	Verify Deal List for Action Required, In Process & Funded Buckets

Scenario: BP Hold Deal - Verify Action Required Bucket
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	And I hold motion deal on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal on broker portal
	Then I select Action Required bucket on broker portal
	And I verify alert icon on deal list page
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Cancel Deal - Verify Action Required Bucket
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	And I cancel motion deal on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search cancelled Motion deal on broker portal
	Then I select Action Required bucket on broker portal
	And I verify alert icon on deal list page unavailable
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Multiple Alerts - Verify Action Required Bucket Count
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	Then I add second Motion note with broker alert
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal on broker portal
	Then I select Action Required bucket on broker portal
	Then I verify Action Required bucket count for multiple alerts
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Approved Deal - Verify In Process Bucket
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
	Then I select In Process bucket on broker portal
	And I verify alert icon on deal list page
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Hold Deal - Verify In Process Bucket
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	And I hold motion deal on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal on broker portal
	Then I select In Process bucket on broker portal
	And I verify alert icon on deal list page
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Cancel Deal - Verify In Process Bucket
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	And I cancel motion deal on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search cancelled Motion deal on broker portal
	Then I select In Process bucket on broker portal
	And I verify alert icon on deal list page unavailable
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Approved Deal - Verify Funded Bucket
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	#Then I set payout ordered date on Motion Portal
	#Then I set payout received date on Motion Portal
	#Then I set appointment date on Motion Portal
	Then I set funding completion date on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal on broker portal
	Then I select Funded bucket on broker portal
	And I verify alert icon on deal list page
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Hold Deal - Verify Funded Bucket
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	#Then I set payout ordered date on Motion Portal
	#Then I set payout received date on Motion Portal
	#Then I set appointment date on Motion Portal
	Then I set funding completion date on Motion Portal
	And I hold motion deal on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search Motion deal on broker portal
	Then I select Funded bucket on broker portal
	And I verify alert icon on deal list page
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Cancel Deal - Verify Funded Bucket
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	And I cancel motion deal on Motion Portal
	And I close Motion Portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select FCT closed deals tab
	Then I search cancelled Motion deal on broker portal
	Then I select Funded bucket on broker portal
	And I verify alert icon on deal list page unavailable
	And I logout from Broker Portal on Android Emulator Browser