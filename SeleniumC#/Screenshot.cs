using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;

using OpenQA.Selenium.Firefox;

using OpenQA.Selenium;

using WebDriverManager.DriverConfigs.Impl;

using OpenQA.Selenium.Support.Extensions;

namespace TestProjectNunitTraining.SeleniumnewC_

{

    internal class Screenshot1

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

            //launch application URL

            driver.Navigate().GoToUrl("https://the-internet.herokuapp.com/upload");

            driver.Manage().Window.Maximize();

            Thread.Sleep(2000);
            //saving inside folder.
            Screenshot ss = driver.TakeScreenshot();

            string folderPath = @"C:\Users\mjana\Documents\new";
            string fileName = "Screenshot_" + DateTime.Now.ToString("yyyy-MM-dd_HHmmss") + ".png"; 
            string fullPath = Path.Combine(folderPath, fileName);

           
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

          
             ss.SaveAsFile(fullPath);

        }

        [TearDown]

        public void closeBrowser()

        {

            driver.Close();

        }

    }

}






//Screenshot screenshot = ((ITakesScreenshot)driver).GetScreenshot(); // Correct casting to ITakesScreenshot


