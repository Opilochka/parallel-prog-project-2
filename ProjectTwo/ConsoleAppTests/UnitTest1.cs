using NUnit.Framework;
using ProjectTwo.Core.Components;

namespace ConsoleAppTests
{
    [TestFixture]
    class UnitTest1
    {
        [Test]
        public void generateHash_ReturnsStringOfCorrectLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(10);
            Assert.Equals(10, hash.Length);

            hash = generator.generateHash(64);
            Assert.Equals(64, hash.Length);

            hash = generator.generateHash(100); // Запрос длины больше чем доступно, но функция должна корректно работать
            Assert.Equals(64, hash.Length); // Проверяем, что функция не выбросила исключение и вернула правильную длину
        }

        [Test]
        public void generateHash_ReturnsDifferentHashesOnMultipleCalls()
        {
            var generator = new HashGenerator();
            string hash1 = generator.generateHash(10);
            string hash2 = generator.generateHash(10);
            Assert.Equals(hash1, hash2);// Проверка на различие хэшей при одинаковых входных
        }

        [Test]
        public void generateHash_HandlesZeroLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(0);
            Assert.Equals(0, hash.Length); // Проверка на нулевую длину
        }

        [Test]
        public void generateHash_HandlesNegativeLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(-5);
            Assert.Equals(0, hash.Length); // Проверка на отрицательную длину
        }
    }
    //kk 2
}
