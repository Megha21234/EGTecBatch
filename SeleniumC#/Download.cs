using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using AngleSharp.Io;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class Download
    {

        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            //launch chrome browser
            new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
            //initialize the web driver
            driver = new FirefoxDriver();
        }
        [Test]
        public void testcase1()
        {
            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/download");
            driver.Manage().Window.Maximize();
            Thread.Sleep(2000);
            IWebElement download = driver.FindElement(By.XPath("//a[normalize-space()='1734472065.txt']"));
            download.Click();
            string filepath = "C:\\Users\\mjana\\Downloads\\1734472065.txt";
            if (File.Exists(filepath))
            {
                Console.WriteLine("file is present");
            }
            else
            {
                Console.WriteLine("file is not present");
            }




        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
