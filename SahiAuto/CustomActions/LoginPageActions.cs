
using System;
using OpenQA.Selenium;

namespace SahiAuto.CustomActions
{
    public class LoginPageActions
    {
        public static void enterValue(IWebElement webElement, string value)
        {
            webElement.SendKeys(value);
        }

        public static void clickButton(IWebElement webElement)
        {
            webElement.Click();
        }

        internal static void enterValue(string v)
        {
            throw new NotImplementedException();
        }
    }
}
