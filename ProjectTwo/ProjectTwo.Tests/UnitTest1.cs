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
            Assert.AreEqual(10, hash.Length);

            hash = generator.generateHash(64);
            Assert.AreEqual(64, hash.Length);

            hash = generator.generateHash(100); // ������ ����� ������ ��� ��������, �� ������� ������ ��������� ��������
            Assert.AreEqual(100, hash.Length); // ���������, ��� ������� �� ��������� ���������� � ������� ���������� �����
        }

        [Test]
        public void generateHash_ReturnsDifferentHashesOnMultipleCalls()
        {
            var generator = new HashGenerator();
            string hash1 = generator.generateHash(10);
            string hash2 = generator.generateHash(10);
            Assert.AreNotEqual(hash1, hash2);// �������� �� �������� ����� ��� ���������� �������
        }

        [Test]
        public void generateHash_HandlesZeroLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(0);
            Assert.AreEqual(0, hash.Length); // �������� �� ������� �����
        }

        /*
        [Test]
        public void generateHash_HandlesNegativeLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(-5);
            Assert.AreEqual(0, hash.Length); // �������� �� ������������� �����
        }
        */
        //kk 5
    }
}