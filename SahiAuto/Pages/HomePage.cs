
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;

namespace SahiAuto.Pages
{
    public class HomePage
    {

        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {

            PageFactory.InitElements(driver, this);
        }

        [FindsBy(How = How.CssSelector, Using = "#available > h2")]
        public IWebElement HomePageValidationText { get; set; }

        [FindsBy(How = How.CssSelector, Using = ":nth-child(2) > :nth-child(4) > input")]
        public IWebElement JavaField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ":nth-child(3) > :nth-child(4) > input")]
        public IWebElement RubyField { get; set; }

        [FindsBy(How = How.CssSelector, Using = ":nth-child(4) > :nth-child(4) > input")]
        public IWebElement PythonField { get; set; }

        [FindsBy(How = How.Id, Using = "total")]
        public IWebElement TotalField { get; set; }

        [FindsBy(How = How.CssSelector, Using = "input[value=Add]")]
        public IWebElement AddButton { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@value='Clear']")]
        public IWebElement ClearButton { get; set; }

        public void clearFields()
        {
            JavaField.Clear();
            RubyField.Clear();
            PythonField.Clear();
        }

        public void AddItemsToCart()
        {

            JavaField.SendKeys("1" + Keys.Enter);
            RubyField.SendKeys("2");
            PythonField.SendKeys("1");
            AddButton.Click();
        }

    }
}

