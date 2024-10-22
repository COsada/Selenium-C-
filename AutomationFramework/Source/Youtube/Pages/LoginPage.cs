using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using AutomationFramework.Utilities;

namespace AutomationFramework.Source.Youtube.Pages
{
    public class LoginPage
    {
        private IWebDriver _driver = Webdrivers.GetDriver(AppSettings.GetBrowserType());

        private IWebElement _emailBox => _driver.FindElement(By.Id("identifierId"));
        private IWebElement _emailNextButton => _driver.FindElement(By.XPath("//*[@id='identifierNext']/div/button"));
        private IWebElement _passwordBox => _driver.FindElement(By.XPath("//*[@id='password']//input"));
        private IWebElement _passwordNextButton => _driver.FindElement(By.XPath("//*[@id='passwordNext']//button"));

        public void GetPastEmailScreen(string email, string password)
        {
            HomePage hp = new HomePage();
            hp.ClickSignInLink();
            _emailBox.SendKeys(email);
            _emailNextButton.Click();
            _passwordBox.SendKeys(email);
            _passwordNextButton.Click();
        }
        public void GetPasswordScreen(string email, string password)
        {
            _emailBox.SendKeys(email);
            _emailNextButton.Click();
            _passwordBox.SendKeys(email);
            _passwordNextButton.Click();
        }
    }
}
