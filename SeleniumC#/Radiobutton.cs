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
    internal class Radiobutton
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

            //locators

            //ID
            driver.Manage().Window.Maximize();


            Thread.Sleep(5000);
            //single click

            IWebElement radio = driver.FindElement(By.XPath("(//input[@name='radioButton'])[3]"));

            if (radio.Enabled)
            {
                Console.WriteLine("Radio button is enabled hence clicking on it");
                radio.Click();
            }
            Thread.Sleep(5000);
            //single or multi select
            // IWebElement chechbox= driver.FindElement(By.XPath("//input[@id='checkBoxOption1']"));

            //if(chechbox.Displayed)
            // {
            //     Console.WriteLine("Check box is displayed hence clicking on it");
            //     chechbox.Click();
            // }
            // Thread.Sleep(2000);
            IReadOnlyList<IWebElement> chechbox = driver.FindElements(By.XPath("//input[@type='checkbox']"));

            foreach (IWebElement element in chechbox)
            {
               // Console.WriteLine(element.Text);
                element.Click();
                Thread.Sleep(2000);

            }
        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }
    }
}
   