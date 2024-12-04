using NUnit.Framework;
using ProjectTwo.Core.Components;

namespace ProjectTwo.Tests
{
    public class Tests
    {
        [Test]
        public void generateHash_ReturnsStringOfCorrectLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(10);
            Assert.That(hash.Length, Is.EqualTo(10));

            hash = generator.generateHash(64);
            Assert.That(hash.Length, Is.EqualTo(64));

            hash = generator.generateHash(100);
            Assert.That(hash.Length, Is.EqualTo(100));
        }

        [Test]
        public void generateHash_ReturnsDifferentHashesOnMultipleCalls()
        {
            var generator = new HashGenerator();
            string hash1 = generator.generateHash(10);
            string hash2 = generator.generateHash(10);
            Assert.That(hash1, Is.Not.EqualTo(hash2));
        }

        [Test]
        public void generateHash_HandlesZeroLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(0);
            Assert.That(hash.Length, Is.EqualTo(0));
        }

        /*
        [Test]
        public void generateHash_HandlesNegativeLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(-5);
            Assert.That(hash.Length, Is.EqualTo(0)); 
        }
        */
        //kk 5
    }
}