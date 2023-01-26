using OpenQA.Selenium;

namespace SpecFlowWorkshop.PageObjects
{
    public class LoginPage
    {
        private readonly WebDriver driver;

        private readonly By textfieldUsername = By.Name("username");
        private readonly By textfieldPassword = By.Name("password");
        private readonly By buttonDoLogin = By.XPath("//input[@value='Log In']");

        public LoginPage(WebDriver driver)
        {
            this.driver = driver;
            this.driver.Navigate().GoToUrl("http://localhost:8080/parabank");
        }

        public void LoginAs(string username, string password)
        {
            driver.FindElement(textfieldUsername).SendKeys(username);
            driver.FindElement(textfieldPassword).SendKeys(password);
            driver.FindElement(buttonDoLogin).Click();
        }
    }
}
