using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowWorkshop.PageObjects;

namespace SpecFlowWorkshop.StepDefinitions
{
    [Binding]
    public class LoanApplicationStepDefinitions
    {
        private WebDriver driver;

        [BeforeScenario]
        public void StartBrowser()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Given(@"John is an active ParaBank customer")]
        public void GivenJohnIsAnActiveParaBankCustomer()
        {
            new LoginPage(driver)
                .LoginAs("john", "demo");
        }

        [When(@"they apply for a (.*) dollar loan")]
        public void WhenTheyApplyForADollarLoan(int loanAmount)
        {
        }

        [Then(@"the loan application is approved")]
        public void ThenTheLoanApplicationIsApproved()
        {
        }

        [Then(@"the loan application is denied")]
        public void ThenTheLoanApplicationIsDenied()
        {
        }

        [When(@"their monthly income is (.*)")]
        public void WhenTheirMonthlyIncomeIs(int p0)
        {
            throw new PendingStepException();
        }

        [AfterScenario]
        public void StopBrowser()
        {
            driver.Quit();
        }
    }
}
