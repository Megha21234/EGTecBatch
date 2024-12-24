using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    [Parallelizable(ParallelScope.All)]
    internal class ParallelExecution
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
        [Test]
        public void addtocart()
        {
            Console.WriteLine("User addtocart completed");
        }
        [Test]
        public void payment()
        {
            Console.WriteLine("User payment completed");
        }
    }
}
