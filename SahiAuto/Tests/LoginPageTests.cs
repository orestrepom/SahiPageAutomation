
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SahiAuto.Pages;

namespace SahiAuto.Test 

{
   
    public class LoginPageTests
    {
        public IWebDriver Driver;


        [SetUp]
       
        public void BeforeEach()
        {
            Driver = new ChromeDriver();
            Driver.Url = "http://sahitest.com/demo/training/login.htm";
           
        }

        //[TearDown]
        //public void AfterEach()
        //{
        //    Driver.Quit();
        //}

        [Test]
        public void LoginSuccess()
        {
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.loggin("test", "secret");
            HomePage homePage = loginPage.textValidation(Driver);
            var HomePageValidationText = homePage.HomePageValidationText.Text;
            Assert.AreEqual("All available books", HomePageValidationText);
        }

    }
}