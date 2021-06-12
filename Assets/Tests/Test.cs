using NUnit.Framework;

namespace Tests
{
    public class Test 
    {
        [Test]
        public void MyTest()
        {
            Manager m = new Manager(2);

            Assert.AreEqual(m.A, 2);
            Assert.AreEqual(m.Add(2), 4);

        }
    }
}