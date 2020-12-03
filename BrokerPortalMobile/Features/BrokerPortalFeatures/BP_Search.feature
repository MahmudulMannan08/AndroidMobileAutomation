Feature: BP_Search
	Verify Search By Filter
	Search By Person/Business Morgagor Last Name, City & FCTUrn
	Verify Invalid Search

Scenario: BP - Search Deals
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	And I create new deal on MMS Portal
	And I get MMS FCT Urn
	Then I search and view MMS deal
	Then I assign MMS deal to broker
	Then I update person mortgagor information on MMS Portal
	Then I add property address on MMS Portal
	Then I add MMS predefined note with broker alert
	Then I close MMS FCT portal
	Given I go to Broker Portal on Android Emulator Browser
	Then I login to Broker Portal on Android Emulator Browser
	And I select Solicitor closed deals tab
	Then I verify Search By dropdown on broker portal
	And I verify invalid search on broker portal
	And I verify mismatch search on broker portal
	Then I search deal by person mortgagor last name on broker portal
	Given I go to MMS FCT Portal
	Then I login to MMS Portal
	Then I search and view MMS deal
	Then I update business mortgagor information on MMS Portal
	Then I close MMS FCT portal
	Then I search deal by business mortgagor name on broker portal
	Then I search deal by city on broker portal
	And I verify contains search on broker portal
	And I logout from Broker Portal on Android Emulator Browser