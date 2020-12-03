Feature: BT_MMS_DealDetails
	Login to MMS Portal
	Create MMS Deal
	Assign Broker to Deal
	Verify Deal Details, Deal Status, Notes & Action Required Sections

Scenario: BT Veriy Notes Section
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I search MMS deal on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify blank note grid on Broker Tracker
	And I verify Action Required section for broker alert available on Broker Tracker
	Then I acknowledge YES to broker alert on Broker Tracker
	And I verify acknowledged MMS note grid on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I add second MMS predefined note with broker alert
	Then I close MMS FCT portal
	Then I navigate back on android
	And I cancel search on Broker Tracker
	Then I search MMS deal on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Action Required section for second broker alert available on Broker Tracker
	Then I submit reply to second MMS broker alert on Broker Tracker
	And I verify replied MMS note grid on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Verify Action Required Section
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I close MMS FCT portal
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I search MMS deal without broker alert on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Action Required section for broker alert unavailable on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Then I navigate back on android
	And I cancel search on Broker Tracker
	Then I search MMS deal on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Action Required section for broker alert available on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Verify Deal Details Section
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I update person mortgagor information on MMS Portal
	Then I add property address on MMS Portal
	Then I close MMS FCT portal
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I search MMS deal without broker alert on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify MMS deal details on Broker Tracker
	And I verify MMS person mortgagor information on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I update business mortgagor information on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I cancel search on Broker Tracker
	Then I search MMS deal without broker alert on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify MMS deal details on Broker Tracker
	And I verify MMS business mortgagor information on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I add person mortgagor information on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I cancel search on Broker Tracker
	Then I search MMS deal without broker alert on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify MMS deal details on Broker Tracker
	And I verify multiple MMS mortgagor information on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Verify Deal Status
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add property address on MMS Portal
	Then I verify RFI received date is populated on MMS Portal
	Then I close MMS FCT portal
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I search MMS deal without broker alert on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify deal milestones for MMS on Broker Tracker
	And I verify Deal received milestone status completed for MMS on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I upload solicitor instruction package on MMS Portal
	Then I verify Solicitors instruction sent date is populated on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I cancel search on Broker Tracker
	Then I search MMS deal without broker alert on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Solicitor instructed milestone status completed for MMS on Broker Tracker	
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I check Broker Conditions Satisfied milestone on MMS Portal
	And I verify Broker Conditions Satisfied completed date is populated on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I cancel search on Broker Tracker
	Then I search MMS deal without broker alert on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Broker conditions met milestone status completed for MMS on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser