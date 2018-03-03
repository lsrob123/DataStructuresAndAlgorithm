using System;
using NUnit.Framework;

namespace UnitTestProject1
{
    public class TypesContainer
    {
        public Type Type1 { get; set; }
        public Type Type2 { get; set; }
    }

    public class Class1
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }

    public class Class2
    {
        public int Key { get; set; }
        public string Name { get; set; }
    }

    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public void TestMethod1()
        {
            var a=new TypesContainer
            {
                Type1= typeof(Class1),
                Type2 = typeof(Class2),
            };

            var b = new TypesContainer
            {
                Type1 = typeof(Class1),
                Type2 = typeof(Class2),
            };

            Assert.IsTrue(a.Equals(b));
        }

    }
}