using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Firefox;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class BrowserCommands
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
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/web/index.php/auth/login");
            //get the title of the web page.
            String title = driver.Title;
            Console.WriteLine(title);
            //get the current url.
            string currenturl=driver.Url;
            Console.WriteLine(currenturl);  
            //get the page source or the html code
            string pagesource=driver.PageSource;
            Console.WriteLine(pagesource);

        }
        [TearDown]
        public void closebrowser()
        {
            driver.Close();//it will close the opened browser section
            //driver.Quite()//will close all the browser section
        }
    }
}

