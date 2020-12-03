Feature: BT_MMS_DealListView
	Login to MMS Portal
	Create MMS Deal
	Assign Broker to Deal
	Verify Deal List for Action Required, In Process & Funded Buckets

Scenario: BT - Verify Action Required Bucket
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I select Action Required bucket on Broker Tracker
	Then I get Action Required bucket count on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	And I refresh android app
	Then I verify Action Required bucket count increased on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I hold MMS deal on MMS Portal
	Then I close MMS FCT portal
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I unhold MMS deal on MMS Portal
	And I issue COI for MMS deal on MMS Portal
	Then I close MMS FCT portal
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I cancel MMS deal on MMS Portal
	Then I close MMS FCT portal
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify Action Required bucket count decreased on Broker Tracker
	Then I search cancelled MMS deal on Broker Tracker
	And I verify alert icon on deal list page unavailable on Broker Tracker
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser

Scenario: BT Multiple Alerts - Verify Action Required Bucket Count
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I select Action Required bucket on Broker Tracker
	Then I get Action Required bucket count on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I add second MMS predefined note with broker alert
	Then I close MMS FCT portal
	And I refresh android app
	Then I verify Action Required bucket count for multiple alerts on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser

Scenario: BT - Verify In Process Bucket
	Given I launch Broker Tracker App on Android Emulator
	Then I login to Broker Tracker App on Android Emulator
	And I select Solicitor closed deals tab on Broker Tracker
	Then I select In Process bucket on Broker Tracker
	Then I get In Process bucket count on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	And I refresh android app
	Then I verify In Process bucket count increased on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I hold MMS deal on MMS Portal
	Then I close MMS FCT portal
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify In Process bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I unhold MMS deal on MMS Portal
	And I issue COI for MMS deal on MMS Portal
	Then I close MMS FCT portal
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify In Process bucket count on Broker Tracker
	Then I search MMS deal on Broker Tracker
	And I verify alert icon on deal list page on Broker Tracker
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I cancel MMS deal on MMS Portal
	Then I close MMS FCT portal
	And I cancel search on Broker Tracker
	And I refresh android app
	Then I verify In Process bucket count decreased on Broker Tracker
	Then I search cancelled MMS deal on Broker Tracker
	And I verify alert icon on deal list page unavailable on Broker Tracker
	And I cancel search on Broker Tracker
	And I logout from Broker Tracker on Android Emulator Browser