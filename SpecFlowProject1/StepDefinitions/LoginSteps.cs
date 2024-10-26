using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;

[Binding]
public class LoginSteps
{
    private IWebDriver driver;
    private LoginPage loginPage;

    [Given(@"the user is on the login page")]
    public void GivenTheUserIsOnTheLoginPage()
    {
        driver = new ChromeDriver();
        driver.Navigate().GoToUrl("https://www.saucedemo.com/");
        loginPage = new LoginPage(driver);
    }

    [When(@"the user enters ""(.*)"" as username and ""(.*)"" as password")]
    public void WhenTheUserEntersAsUsernameAndAsPassword(string username, string password)
    {
        loginPage.EnterUsername(username);
        loginPage.EnterPassword(password);
    }

    [When(@"the user clicks the login button")]
    public void WhenTheUserClicksTheLoginButton()
    {
        loginPage.ClickLogin();
    }

    [Then(@"the user should see an error message ""(.*)""")]
    public void ThenTheUserShouldSeeAnErrorMessage(string expectedMessage)
    {
        string actualMessage = loginPage.GetErrorMessage();
        Assert.AreEqual(expectedMessage, actualMessage);
        driver.Quit();
    }
}
