using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationFramework.Source.Pages;

namespace AutomationFramework.Source.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver;

        [FindsBy(How = How.Id, Using = "identifierId")]
        private IWebElement _emailBox;
        [FindsBy(How = How.XPath, Using = "//*[@id='identifierNext']/div/button")]
        private IWebElement _emailNextButton;

        [FindsBy(How = How.XPath, Using = "//*[@id='password']//input")]
        private IWebElement _passwordBox;
        [FindsBy(How = How.XPath, Using = "//*[@id='passwordNext']//button")]
        private IWebElement _passwordNextButton;

        public LoginPage(IWebDriver driver)
        {
            _driver = driver;
            PageFactory.InitElements(driver, this);
        }

        public void SignIn(string email, string password)
        {
            HomePage hp = new HomePage();
            hp.ClickSignInLink();
            _emailBox.SendKeys(email);
            _emailNextButton.Click();
            _passwordBox.SendKeys(email);
            _passwordNextButton.Click();
        }
    }
}
