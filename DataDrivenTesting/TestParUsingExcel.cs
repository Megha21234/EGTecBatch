using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AspectInjector.Broker;
using NUnit.Framework.Interfaces;
using NUnit.Framework;
using NUnitSeleniumC_Training.Utilities;

namespace TestProjectNunitTraining.DataDrivenTesting
{
    internal class TestParUsingExcel : NUnitSeleniumC_Training.Utilities.ExcelRead
    {
        [Test, TestCaseSource("GetTestdata")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);
        }
        public static IEnumerable<TestCaseData> GetTestdata()
        {
            var columns = new List<string> { "username", "password" };
            return ExcelRead.GetTestDataFromExcel("C:\\Users\\mjana\\source\\repos\\TestProjectDecBatchEGIndia\\TestProjectDecBatchEGIndia\\testdata.xlsx", "LoginTests", columns);
        }
    }
}