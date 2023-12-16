using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAwesomeDictionary.UnitTests
{
    public class KeyUnitTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Key_GetHashCode()
        {
            // Arange
            var key = new Key("asdfasdf");

            // Act
            // Assert
            Assert.That(8, Is.EqualTo(key.GetHashCode()));
        }
    }
}
