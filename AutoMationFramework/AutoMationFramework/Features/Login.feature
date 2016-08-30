Feature: Login

@Login
Scenario: Login Verification
Given I Launch The Browser
When I navigate to "https://mozart-uat.iso.com"
Then The Login Should Display
When User Log in With "AMcustomeradmin" and "Verisk@123"
Then Login should be successfull
	
