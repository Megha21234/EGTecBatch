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
    internal class ActionEg
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
            //driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/drag_and_drop");
            //driver.Manage().Window.Maximize();
            //IWebElement source = driver.FindElement(By.Id("column-a"));
            //Thread.Sleep(2000);
            //IWebElement dest = driver.FindElement(By.Id("column-b"));
            //new Actions(driver)
            //    .DragAndDrop(source, dest).Perform();
            //Thread.Sleep(2000);
            //launch application URL
            driver.Navigate().GoToUrl("https://www.amazon.in/");
            driver.Manage().Window.Maximize();
            //locators
            //ID
            Thread.Sleep(2000);
            IWebElement primes = driver.FindElement(By.XPath("//a[@id='nav-link-amazonprime']"));
            Thread.Sleep(2000);
            //IWebElement latestmovies = driver.FindElement(By.XPath("(//img[@id='multiasins-img-link'])[1]"));
            new Actions(driver)
                .MoveToElement(primes)
                .ClickAndHold()
                .Pause(TimeSpan.FromSeconds(1))
               // .MoveToElement(latestmovies)
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
