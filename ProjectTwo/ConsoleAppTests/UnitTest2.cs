using NUnit.Framework;
using ProjectTwo.Core.Components;

namespace ConsoleAppTests
{
    [TestFixture]
    public class MainerTests
    {
        [Test]
        public void GenerateMaybeHashString_CorrectLength()
        {
            var mainer = new Mainer();
            string hash = mainer.generateMaybeHashString(0, 5, "0123456789abcdef");
            Assert.Equals(5, hash.Length);
        }

        [Test]
        public void GenerateMaybeHashString_CorrectValues()
        {
            var mainer = new Mainer();
            string hash = mainer.generateMaybeHashString(16, 2, "0123456789abcdef");
            Assert.Equals("10", hash); // Проверка на конкретное значение
            hash = mainer.generateMaybeHashString(271, 3, "0123456789abcdef");
            Assert.Equals("ab1", hash); //Проверка на другое конкретное значение

        }


        [Test]
        public void HashChecking_CorrectComparison()
        {
            var mainer = new Mainer();
            Assert.Equals(true, mainer.hashChecking("abcdef", "abcdef"));
            Assert.Equals(false, mainer.hashChecking("abcdef", "123456"));
        }
    }
}

