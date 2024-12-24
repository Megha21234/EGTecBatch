using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Interactions;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class Keyboadevents
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
            driver.Navigate().GoToUrl("https://www.facebook.com/");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement email = driver.FindElement(By.Id("email"));
            IWebElement password = driver.FindElement(By.Id("pass"));
            new Actions(driver)
           
                .KeyDown(Keys.Shift)
                .SendKeys("mjana")
                .MoveToElement(password)
                .Click()
                .Perform();
            Thread.Sleep(2000);
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
