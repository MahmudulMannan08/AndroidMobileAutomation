Feature: BT_Motion_DealListView
	Login to Motion Portal
	Create Motion Deal
	Assign Broker to Deal
	Verify Deal List for Action Required, In Process & Funded Buckets

Scenario: BT Hold Deal - Verify Action Required Bucket
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get Action Required bucket count on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
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
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify Action Required bucket count increased on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Cancel Deal - Verify Action Required Bucket
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
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I search deal on Motion Portal
	And I cancel motion deal on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify Action Required bucket count decreased on Broker Tracker
	Then I search cancelled Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page unavailable on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Multiple Alerts - Verify Action Required Bucket Count
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get Action Required bucket count on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
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
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify Action Required bucket count for multiple alerts on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Approved Deal - Verify In Process Bucket
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get In Process bucket count on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	Then I set appointment date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify In Process bucket count increased on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Hold Deal - Verify In Process Bucket
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get In Process bucket count on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	Then I set appointment date on Motion Portal
	And I hold motion deal on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify In Process bucket count increased on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Cancel Deal - Verify In Process Bucket
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	Then I set appointment date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get In Process bucket count on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I search deal on Motion Portal
	And I cancel motion deal on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify In Process bucket count decreased on Broker Tracker
	Then I search cancelled Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page unavailable on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Approved Deal - Verify Funded Bucket
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get Funded bucket count on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	Then I set appointment date on Motion Portal
	Then I set funding completion date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify Funded bucket count increased on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Hold Deal - Verify Funded Bucket
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get Funded bucket count on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I add Motion note with broker alert
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	Then I set appointment date on Motion Portal
	Then I set funding completion date on Motion Portal
	And I hold motion deal on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify Funded bucket count increased on Broker Tracker
	Then I search Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

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
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	Then I set appointment date on Motion Portal
	Then I set funding completion date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I get Funded bucket count on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser
	Given I go to Motion portal
	Then I search deal on Motion Portal
	And I cancel motion deal on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then Motion - I verify Funded bucket count decreased on Broker Tracker
	Then I search cancelled Motion deal on Broker Tracker
	And Motion - I verify alert icon on deal list page unavailable on Broker Tracker
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser