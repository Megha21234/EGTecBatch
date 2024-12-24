using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Edge;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class lab2
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()

        {

            //launch chrome browser

            new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig());

            //initialize the web driver

            driver = new EdgeDriver();

        }

        [Test]
        public void testcase1()

        {

           //launch application URL

             driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");

            //locators

            //ID
            driver.Manage().Window.Maximize();


            Thread.Sleep(5000);

            IWebElement UserName = driver.FindElement(By.XPath("//input[@name='username']"));

            UserName.SendKeys("Admin");

            Thread.Sleep(5000);

            IWebElement Password = driver.FindElement(By.XPath("//input[@name='password']"));

            Password.SendKeys("admin123");

            Thread.Sleep(5000);

            IWebElement Login = driver.FindElement(By.XPath("//button[contains(normalize-space(),'Login')]"));

            Login.Click();

            Thread.Sleep(5000);

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
