Feature: Login Functionality for locked_out_user

  Scenario: Locked out user cannot log in
    Given the user is on the login page
    When the user enters "locked_out_user" as username and "secret_sauce" as password
    And the user clicks the login button
    Then the user should see an error message "Epic sadface: Sorry, this user has been locked out."
