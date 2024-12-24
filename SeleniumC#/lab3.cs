using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class lab3
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
            Thread.Sleep(10000);

            IWebElement UserName = driver.FindElement(By.XPath("//input[@placeholder='Username']"));
            UserName.SendKeys("Admin");
            Thread.Sleep(5000);

            IWebElement Password = driver.FindElement(By.XPath("//input[@placeholder='Password']"));
            Password.SendKeys("admin123");
            Thread.Sleep(5000);

            IWebElement Login = driver.FindElement(By.XPath("//button[normalize-space()='Login']"));
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
