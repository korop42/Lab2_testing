using OpenQA.Selenium;

public class LoginPage
{
    private IWebDriver driver;

    public LoginPage(IWebDriver driver)
    {
        this.driver = driver;
    }

    private IWebElement UsernameField => driver.FindElement(By.Id("user-name"));
    private IWebElement PasswordField => driver.FindElement(By.Id("password"));
    private IWebElement LoginButton => driver.FindElement(By.Id("login-button"));
    private IWebElement ErrorMessage => driver.FindElement(By.CssSelector("h3[data-test='error']"));

    public void EnterUsername(string username)
    {
        UsernameField.SendKeys(username);
    }

    public void EnterPassword(string password)
    {
        PasswordField.SendKeys(password);
    }

    public void ClickLogin()
    {
        LoginButton.Click();
    }

    public string GetErrorMessage()
    {
        return ErrorMessage.Text;
    }
}
