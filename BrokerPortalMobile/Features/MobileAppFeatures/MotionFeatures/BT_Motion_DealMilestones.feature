Feature: BT_Motion_DealMilestones
	Login to Motion Portal
	Create Motion Deal
	Assign Broker to Deal
	Verify Motion Deal milestones Deal received, Statements ordered, Statements received, Signing appointment booked, Funded

Scenario: Motion deal milestones on Broker Tracker
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
	And I verify deal milestones for Motion on Broker Tracker
	And I verify Deal received milestone status completed for Motion on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I set payout ordered date on Motion Portal
	And I close Motion Portal
	#Then Motion - I navigate back on android
	#And Motion - I cancel search on Broker Tracker
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Statements ordered milestone status completed for Motion on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I set payout received date on Motion Portal
	And I close Motion Portal
	#Then Motion - I navigate back on android
	#And Motion - I cancel search on Broker Tracker
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Statements received milestone status completed for Motion on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I set appointment date on Motion Portal
	And I close Motion Portal
	#Then Motion - I navigate back on android
	#And Motion - I cancel search on Broker Tracker
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Signing appointment booked milestone status completed for Motion on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I set funding completion date on Motion Portal
	And I close Motion Portal
	#Then Motion - I navigate back on android
	#And Motion - I cancel search on Broker Tracker
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Funded milestone status completed for Motion on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: Verify set unset Statements Ordered Milestone on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I set payout ordered date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Statements ordered milestone status completed for Motion on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I unset payout ordered date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Statements ordered milestone status turns incomplete for Motion on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: Verify set unset Statements Received Milestone on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Statements received milestone status completed for Motion on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I unset payout received date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Statements received milestone status turns incomplete for Motion on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: Verify set unset Signing Appointment Booked Milestone on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	Then I set appointment date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Signing appointment booked milestone status completed for Motion on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I unset appointment date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Signing appointment booked milestone status turns incomplete for Motion on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser

Scenario: Verify set unset Funded Milestone on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	Then I select program and lender for new order on Motion Portal
	And I submit new order on Motion Portal
	Then I locate Motion deal and get FCTURN on Motion Portal
	Then I approve Motion deal on Motion Portal
	And I search deal on Motion Portal
	Then I assign Motion deal to broker
	Then I set payout ordered date on Motion Portal
	Then I set payout received date on Motion Portal
	Then I set appointment date on Motion Portal
	Then I set funding completion date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Funded milestone status completed for Motion on Broker Tracker
	Given I go to Motion portal
	Then I select Title Officer on Motion Portal
	And I search deal on Motion Portal
	Then I unset funding completion date on Motion Portal
	And I close Motion Portal
	Given I launch Broker Tracker App on Android Emulator
	Then Motion - I login to Broker Tracker App on Android Emulator
	And Motion - I select FCT closed deals tab on Broker Tracker
	Then I search Motion deal without broker alert on Broker Tracker
	Then I go to Motion deal details page on Broker Tracker
	And I verify Funded milestone status turns incomplete for Motion on Broker Tracker
	Then Motion - I navigate back on android
	And Motion - I cancel search on Broker Tracker
	And Motion - I logout from Broker Tracker on Android Emulator Browser