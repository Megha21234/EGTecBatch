using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    internal class TestOrder
    {
        [Test,Order(1)]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test,Order(2)]
        public void login()
        {
            Console.WriteLine("User login completed");
        }
        [Test,Order(3)]
        public void products()
        {
            Console.WriteLine("User purchase completed");
        }
        [Test,Order(4)]
        public void addtocart()
        {
            Console.WriteLine("User addtocart completed");
        }
        [Test,Order(5)]
        public void payment()
        {
            Console.WriteLine("User payment completed");
        }
    }
}
