using NUnit.Framework;

namespace Tests
{
    public class Test 
    {
        [Test]
        public void MyTest()
        {
            Assert.AreEqual(2 + 2, 4);
            Assert.AreEqual(2 + 3, 5);
        }
    }
}