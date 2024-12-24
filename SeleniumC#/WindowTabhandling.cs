using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using WebDriverManager.DriverConfigs.Impl;
using OpenQA.Selenium.Support.UI;

namespace TestProjectDecBatchEGIndia.SeleniumC_
{
    internal class WindowTabhandling
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


            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/windows");

            driver.Manage().Window.Maximize();
              //wait until elements are load //global
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
            //fecth the parent window handle
            string parenthandle = driver.CurrentWindowHandle;
            Console.WriteLine(parenthandle);
            Thread.Sleep(1000);
            IWebElement clickhere = driver.FindElement(By.XPath("//a[normalize-space()='Click Here']"));
            //explicit applicable for single element..
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(2));
            wait.Until(d => clickhere.Displayed);

            clickhere.Click();
            Thread.Sleep(2000);
            //fecth the window handle to all window-two window are opened;
            IList<string>windowhandles = new List<string>(driver.WindowHandles);//method
            //move the control to child window
            driver.SwitchTo().Window(windowhandles[1]);
            
            string title = driver.Title;
            Console.WriteLine(title);
            driver.Close();
            Thread.Sleep(1000);
            driver.SwitchTo().Window(windowhandles[0]);
            //driver.SwitchTo().DefaultContent();
            string parenttitle = driver.Title;
            Console.WriteLine(parenttitle);
            Assert.AreEqual("The Internet", parenttitle);
          
        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();
            //driver.Quit();

        }
    }
}
