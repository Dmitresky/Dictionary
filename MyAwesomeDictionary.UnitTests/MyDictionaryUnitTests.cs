namespace MyAwesomeDictionary.UnitTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GetValueByIndex()
        {
            // Arange
            var dictionary = new MyDictionary();
            var key = new Key("str");
            var expectedValue = "dafsdf";

            dictionary[key] = expectedValue;

            // Act
            // Assert
            Assert.That(expectedValue, Is.EqualTo(dictionary[key]));
        }

        [Test]
        public void SetValueByIndex()
        {
            // Arange
            var dictionary = new MyDictionary();
            var key = new Key("str");
            var value = "dafsdf";

            // Act
            // Assert
            Assert.DoesNotThrow(() => dictionary[key] = value);
            Assert.That(dictionary.Count, Is.EqualTo(1));
        }

        [Test]
        public void Test_Count()
        {
            // Arange
            var dictionary = new MyDictionary();
            var key = new Key("str");
            var value = "dafsdf";

            // Act
            dictionary[key] = value;

            // Assert
            Assert.That(dictionary.Count, Is.EqualTo(1));
        }

    }
}