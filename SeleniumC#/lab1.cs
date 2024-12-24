using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class lab1
    {
        IWebDriver driver;
        [SetUp]
        public void startbrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); /*EdgeConfig*/ //FirefoxConfig
            //initialize the web driver
            driver = new FirefoxDriver(); /*EdgeDriver()*/  //FirefoxDriver
        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/v1/");
            Thread.Sleep(1000);
            //xpath
            IWebElement UserName = driver.FindElement(By.XPath("//input[@id='user-name']"));
            UserName.SendKeys("standard_user");
            Thread.Sleep(1000);
            //password
            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));
            Password.SendKeys("secret_sauce");
            Thread.Sleep(1000);
            //Link text
            IWebElement Login = driver.FindElement(By.XPath("//input[@id='login-button']"));
            Login.Click();
            Thread.Sleep(1000);
            IWebElement Products = driver.FindElement(By.XPath("//div[@class='product_label']"));
            Products.Click();
            Thread.Sleep(1000);
            //displayed validation
            if (Products.Displayed)
            {
                Console.WriteLine("User is on the home page");
            }
            else
            {
                Console.WriteLine("User is not on the home page");
            }
            //assertion class
            //string actualtext = Products.Text;
            //string expectedvalue = "Products";
            //Assert.AreEqual(actualtext, expectedvalue);

        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();//it will close the opened browser section
            //driver.Quite()//will close all the browser section
        }
    }
}
