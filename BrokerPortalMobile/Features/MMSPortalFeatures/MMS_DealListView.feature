Feature: MMS_DealListView
	Login to MMS Portal
	Create MMS Deal
	Assign Broker to Deal
	Verify Deal List for Action Required, In Process & Funded Buckets

Scenario: BP - Verify Action Required Bucket
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
	Then I select Action Required bucket on broker portal
	And I verify alert icon on deal list page
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I hold MMS deal on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I search MMS deal on broker portal
	Then I select Action Required bucket on broker portal
	And I verify alert icon on deal list page
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I unhold MMS deal on MMS Portal
	And I issue COI for MMS deal on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I search MMS deal on broker portal
	Then I select Action Required bucket on broker portal
	And I verify alert icon on deal list page
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I cancel MMS deal on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I search cancelled MMS deal on broker portal
	Then I select Action Required bucket on broker portal
	And I verify alert icon on deal list page unavailable
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP Multiple Alerts - Verify Action Required Bucket Count
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I add MMS predefined note with broker alert
	Then I add second MMS predefined note with broker alert
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I search MMS deal on broker portal
	Then I select Action Required bucket on broker portal
	Then I verify Action Required bucket count for multiple alerts
	And I logout from Broker Portal on Android Emulator Browser

Scenario: BP - Verify In Process Bucket
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
	Then I select In Process bucket on broker portal
	And I verify alert icon on deal list page
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I hold MMS deal on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I search MMS deal on broker portal
	Then I select In Process bucket on broker portal
	And I verify alert icon on deal list page
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I unhold MMS deal on MMS Portal
	And I issue COI for MMS deal on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I search MMS deal on broker portal
	Then I select In Process bucket on broker portal
	And I verify alert icon on deal list page
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	And I cancel MMS deal on MMS Portal
	Then I close MMS FCT portal
	Then I navigate back on android
	And I select Solicitor closed deals tab
	Then I search cancelled MMS deal on broker portal
	Then I select In Process bucket on broker portal
	And I verify alert icon on deal list page unavailable
	And I logout from Broker Portal on Android Emulator Browser