using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class Alerts
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
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/javascript_alerts");
            driver.Manage().Window.Maximize();
            //locators
            //ID
            Thread.Sleep(5000);
            IWebElement infoalert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Alert']"));
            infoalert.Click();
            //handling information alert
            IAlert alt = driver.SwitchTo().Alert();
            //clicking on ok button
            alt.Accept();
            Thread.Sleep(2000);
            //Handling confirmational alerts
            IWebElement confalert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Confirm']"));
            confalert.Click();
            //clicking on cancel button
            alt.Dismiss();
            Thread.Sleep(2000);
            IWebElement propalert = driver.FindElement(By.XPath("//button[normalize-space()='Click for JS Prompt']"));
            propalert.Click();
            string alttext=alt.Text;
            Console.WriteLine(alttext);
            Thread.Sleep(2000);
            alt.SendKeys("Hello");
            Thread.Sleep(5000);
            alt.Accept();
            Thread.Sleep(2000);


        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
