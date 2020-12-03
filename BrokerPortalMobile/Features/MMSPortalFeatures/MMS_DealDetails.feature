Feature: MMS_DealDetails
	Login to MMS Portal
	Create MMS Deal
	Assign Broker to Deal
	Verify Deal Details, Deal Status, Notes & Action Required Sections

Scenario: BP Veriy Notes Section
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal on broker portal
	Then I go to MMS deal details page on broker portal
	And I verify blank note grid on broker portal
	And I verify Action Required section for broker alert available
	Then I acknowledge YES to broker alert
	And I verify acknowledged MMS note grid on broker portal
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I add second MMS predefined note with broker alert
	Then I close MMS FCT portal
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I search MMS deal on broker portal
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for second broker alert available
	Then I submit reply to second MMS broker alert
	And I verify replied MMS note grid on broker portal
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Verify Action Required Section
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal without broker alert on broker portal
	Then I verify Action Required section for broker alert unavailable
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I search MMS deal on broker portal
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for broker alert available
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Verify Deal Details Section
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I update person mortgagor information on MMS Portal
	Then I add property address on MMS Portal
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal without broker alert on broker portal
	And I verify MMS deal details on broker portal
	And I verify MMS person mortgagor information on broker portal
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I update business mortgagor information on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	Then I search MMS deal without broker alert on broker portal
	And I verify MMS deal details on broker portal
	And I verify MMS business mortgagor information on broker portal
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I add person mortgagor information on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	Then I search MMS deal without broker alert on broker portal
	And I verify MMS deal details on broker portal
	And I verify multiple MMS mortgagor information on broker portal
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Verify Deal Status
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add property address on MMS Portal
	Then I verify RFI received date is populated on MMS Portal
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal without broker alert on broker portal
	And I verify deal milestones for MMS on broker portal
	And I verify Deal received milestone status completed for MMS on broker portal
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I upload solicitor instruction package on MMS Portal
	Then I verify Solicitors instruction sent date is populated on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	Then I search MMS deal without broker alert on broker portal
	And I verify Solicitor instructed milestone status completed for MMS on broker portal
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I check Broker Conditions Satisfied milestone on MMS Portal
	And I verify Broker Conditions Satisfied completed date is populated on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	Then I search MMS deal without broker alert on broker portal
	And I verify Broker conditions met milestone status completed for MMS on broker portal
	And I logout from Broker Portal on Android Emulator Browser