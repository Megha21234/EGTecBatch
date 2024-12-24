using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    internal class Test1
    {
        [Test,Description("Firsttest case")]//test description
        public void test1()//method
        {
            Console.WriteLine("First test case is executed");
        }
    }
}
