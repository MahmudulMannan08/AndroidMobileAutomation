Feature: BT_MMS_Alerts_Notes
	Login to MMS Portal
	Create MMS Deal
	Assign Broker to Deal
	Create Custom/Premade notes with/without Broker Alert
	Verify Alerts on Broker Tracker
	Send New Note from Broker Tracker

Scenario: MMS Predefined Note with checked Broker Alert
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
	Then I get Action Required bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Action Required section for broker alert available on Broker Tracker
	Then I acknowledge NO to broker alert on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	Then I acknowledge YES to broker alert on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count decreased on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
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
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I get Action Required bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Action Required section for broker alert available on Broker Tracker
	Then I acknowledge NO to broker alert on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	Then I acknowledge YES to broker alert on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count decreased on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
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
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I search MMS deal without broker alert on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Action Required section for broker alert unavailable on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Reply Alert To MMS Predefined Note
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
	Then I get Action Required bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Action Required section for broker alert available on Broker Tracker
	Then I cancel reply to broker alert on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	Then I go to MMS deal details page on Broker Tracker
	And I verify Action Required section for broker alert available on Broker Tracker
	Then I submit reply to broker alert on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count decreased on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I verify note reply by broker on MMS Portal
	And I acknowledge broker reply on MMS Portal
	Then I close MMS FCT portal

Scenario: BT New Note To MMS With Alert
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
	Then I cancel new note on Broker Tracker
	Then I send new note to Lender on Broker Tracker
	Then I navigate back on android
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I verify new note by broker on MMS Portal
	Then I close MMS FCT portal