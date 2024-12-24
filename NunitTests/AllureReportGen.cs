using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    [Allure.NUnit.AllureNUnit]
    internal class AllureReportGen
    {
        [Test]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test]
        public void login()
        {
            Console.WriteLine("User login completed");
        }
        [Test]
        public void products()
        {
            Console.WriteLine("User purchase completed");
        }
    }
}
