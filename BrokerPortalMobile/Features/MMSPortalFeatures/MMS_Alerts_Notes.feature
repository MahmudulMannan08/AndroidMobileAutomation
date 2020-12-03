Feature: MMS_Alerts_Notes
	Login to MMS Portal
	Create MMS Deal
	Assign Broker to Deal
	Create Custom/Premade notes with/without Broker Alert
	Verify Alerts on Broker Portal
	Send New Note from Broker Portal

Scenario: MMS Predefined Note with checked Broker Alert
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
	Then I get Action Required bucket count
	Then I search MMS deal on broker portal
	And I verify alert icon on deal list page
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for broker alert available
	Then I acknowledge NO to broker alert
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I verify Action Required bucket count
	Then I search MMS deal on broker portal
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for broker alert available
	Then I acknowledge YES to broker alert
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I verify Action Required bucket count decreased
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I verify note acknowledgement by broker on MMS Portal
	Then I close MMS FCT portal

Scenario: MMS Predefined Note with un-checked Broker Alert
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note without broker alert
	And I check broker alert checkbox on MMS note grid
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I get Action Required bucket count
	Then I search MMS deal on broker portal
	And I verify alert icon on deal list page
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for broker alert available
	Then I acknowledge NO to broker alert
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I verify Action Required bucket count
	Then I search MMS deal on broker portal
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for broker alert available
	Then I acknowledge YES to broker alert
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I verify Action Required bucket count decreased
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I verify note acknowledgement by broker on MMS Portal
	Then I close MMS FCT portal

Scenario: MMS No Broker Alert
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note without broker alert
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal without broker alert on broker portal
	Then I verify Action Required section for broker alert unavailable
	And I logout from Broker Portal on Android Emulator Browser

Scenario: MMS Custom Note with checked Broker Alert
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS custom note with broker alert
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I get Action Required bucket count
	Then I search MMS deal on broker portal
	And I verify alert icon on deal list page
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for custom note broker alert available
	Then I acknowledge NO to broker alert
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I verify Action Required bucket count
	Then I search MMS deal on broker portal
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for custom note broker alert available
	Then I acknowledge YES to custom note broker alert
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I verify Action Required bucket count decreased
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I verify custom note acknowledgement by broker on MMS Portal
	Then I close MMS FCT portal

Scenario: BP Reply Alert To MMS Predefined Note
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
	Then I get Action Required bucket count
	Then I search MMS deal on broker portal
	And I verify alert icon on deal list page
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for broker alert available
	Then I cancel reply to broker alert
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I verify Action Required bucket count
	Then I search MMS deal on broker portal
	Then I go to MMS deal details page on broker portal
	And I verify Action Required section for broker alert available
	Then I submit reply to broker alert
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I verify Action Required bucket count decreased
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I verify note reply by broker on MMS Portal
	And I acknowledge broker reply on MMS Portal
	Then I close MMS FCT portal

Scenario: BP New Note To MMS Without Alert
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
	Then I cancel new note on broker portal
	Then I send new note to Lender on broker portal
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I verify new note by broker on MMS Portal
	Then I close MMS FCT portal

Scenario: BP New Note To MMS With Alert
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
	Then I cancel new note on broker portal
	Then I send new note to Lender on broker portal
	And I logout from Broker Portal on Android Emulator Browser
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I verify new note by broker on MMS Portal
	Then I close MMS FCT portal