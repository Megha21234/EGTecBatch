using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    internal class Categories
    {
        [Test, Order(1),Category("Regression")]
        public void userreg()
        {
            Console.WriteLine("User registration completed");
        }
        [Test, Order(2), Category("Sanity")]
        public void login()
        {
            Console.WriteLine("User login completed");
        }
        [Test, Order(3),Category("Regression")]
        public void products()
        {
            Console.WriteLine("User purchase completed");
        }
    }
}
