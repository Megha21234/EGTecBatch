using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    internal class SetUpTeardown
    {//run for every test method.
        [SetUp]
        public void launchbrowser()
        {
            Console.WriteLine("launching the browser");
        }
        [TearDown]
        public void closebrowser()
        {
            Console.WriteLine("closing the browser");
        }

        [Test, Order(1)]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test, Order(2)]
        public void login()
        {
            Console.WriteLine("User login completed");
        }
        [Test, Order(3)]
        public void products()
        {
            Console.WriteLine("User purchase completed");
        }
    }

}
