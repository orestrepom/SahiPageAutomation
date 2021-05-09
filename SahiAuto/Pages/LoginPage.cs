using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SahiAuto.Pages
{
    public class LoginPage

    {
        private IWebDriver driver;


        public LoginPage(IWebDriver driver)
        {
        
           PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.Name, Using = "user")]
        public IWebElement username { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
         public IWebElement password { get; set; } 

        [FindsBy(How = How.CssSelector, Using = ".button")]
        public IWebElement loginButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#available > h2")]
        public IWebElement HomePageValidationText { get; set; }


        public void loggin( string user, string psw)
        {
            username.SendKeys(user);
            password.SendKeys(psw);
            loginButton.Click();
        }

        public HomePage textValidation (IWebDriver driver)
        {

            return new HomePage(driver);

        }

    }
}
