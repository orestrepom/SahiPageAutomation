
using System;
using NUnit.Framework;
using OpenQA.Selenium;
using SahiAuto.Pages;

namespace SahiAuto.Test 

{

    public class HomePageTests : LoginPageTests
    {

        [Test]
        public void AddValidItemstoCart()
        {
           
            LoginPage loginPage = new LoginPage(Driver);
            loginPage.loggin("test", "secret");
            HomePage homePage = new HomePage(Driver);
            homePage.clearFields();
            homePage.AddItemsToCart();
            Assert.AreEqual("1050", homePage.TotalField.GetAttribute("value"));

        }

    }
}