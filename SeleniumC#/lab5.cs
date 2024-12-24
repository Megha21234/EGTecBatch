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
    internal class lab5
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
            driver.Navigate().GoToUrl("https://rahulshettyacademy.com/AutomationPractice/");
            driver.Manage().Window.Maximize();
            //locators
            //ID
            Thread.Sleep(5000);
            IWebElement infoalert = driver.FindElement(By.XPath("(//input[@id='alertbtn'])[1]"));
            infoalert.Click();
            Thread.Sleep(5000);
            //handling information alert
            IAlert alt = driver.SwitchTo().Alert();
            //clicking on ok button
            alt.Accept();
            Thread.Sleep(5000);
            //Handling confirmational alerts
            IWebElement confalert = driver.FindElement(By.XPath("//input[@id='confirmbtn']"));
            confalert.Click();
            //clicking on cancel button
            Thread.Sleep(2000);
            alt.Dismiss();
            




        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
