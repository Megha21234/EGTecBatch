using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProjectDecBatchEGIndia.NunitTests
{
    internal class Assertion
    {
        [Test]
        public void AssertionEg() {
            String actual = "google";
            String expecteds = "yahoo";
            if (actual==expecteds)
            {
                Console.WriteLine("the result is matching");

            }
            else
            {
                Console.WriteLine("THE result is not matching");
            }
           // Assert.AreEqual(actual, expecteds);//fail
            Assert.AreNotEqual(actual, expecteds);//pass
           // Assert.AreSame(actual, expecteds);//fail
            Assert.AreNotSame(actual, expecteds); //pass  
            //assert.that
           // Assert.That(actual, Is.EqualTo(expecteds));
            Assert.That(actual,Is.Not.EqualTo(expecteds));
            //qassert for starting with ignore case
          //  Assert.That(actual, Is.EqualTo(expecteds).IgnoreCase);
            //substring
            Assert.That(actual, Does.Contain("goo").IgnoreCase);
            //empty asssertion
           // Assert.IsTrue(actual.Equals(expecteds));
           // Assert.IsEmpty(actual);
          //  Assert.IsNull(actual);
            Assert.IsNotNull(actual);
            //Assert.AreEqual(expecteds,actual);
            int[] array= new int[] {1,9,2,3,4,5,6};
            Assert.NotNull(array);
            Assert.That(array,Is.All.GreaterThan(0));
          //  Assert.IsEmpty(array);
           // Assert.That(array, Is.Ordered.Ascending);
            int age = 17;
            if(age<18)
            {
          //      throw new AssertionException("user is not eligible for voting");
            }


        }
    }
}
