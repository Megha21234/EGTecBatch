using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.DataDrivenTesting
{
    internal class TestParUsingTestCasesource
    {
        [Test,TestCaseSource("GetTestdata")]
        public void LoginTest(string username, string password)
        {
            Console.WriteLine(username + ":" + password);
        }
        public static IEnumerable<TestCaseData> GetTestdata()
        {
            yield return new TestCaseData("abc.com", "ggyu");
            yield return new TestCaseData("abd.com", "lihh");
            yield return new TestCaseData("acc.com", "jihh");
            yield return new TestCaseData("amc.com", "grgh");
        }

    }
}
