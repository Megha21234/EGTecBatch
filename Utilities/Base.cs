using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using Microsoft.Extensions.Configuration;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using TestProjectDecBatchEGIndia.SeleniumC_;


namespace TestProjectDecBatchEGIndia.Utilities
{
    public class Base
    {
        public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            string browserName = ConfigurationManager.AppSettings["browser"];
            InitBrowser(browserName);
            //new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig());
           
            //    driver = new FirefoxDriver();

        }
        public void InitBrowser(string browserName)
        {
            switch (browserName)
            {
                case "Firefox":
                    new WebDriverManager.DriverManager().SetUpDriver(new FirefoxConfig()); /*EdgeConfig*/ //FirefoxConfig
                                                                                                      //initialize the web driver
                    driver = new FirefoxDriver();
                    break;
                case "Chrome":
                    new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig()); /*EdgeConfig*/ //FirefoxConfig
                                                                                                         //initialize the web driver
                    driver = new ChromeDriver();
                    break;
                case "Edge":
                    new WebDriverManager.DriverManager().SetUpDriver(new EdgeConfig()); /*EdgeConfig*/ //FirefoxConfig
                                                                                                       //initialize the web driver
                    driver = new EdgeDriver();
                    break;
            }
        }
        [TearDown]
        public void TearDownBrowser()
        {
            if (driver != null)
            {
                driver.Quit();
                driver.Dispose();
                driver = null;
            }
        }
    }
}