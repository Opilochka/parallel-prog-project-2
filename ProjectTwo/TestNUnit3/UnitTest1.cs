using NUnit.Framework;
using ProjectTwo.Core.Components;

namespace TestNUnit3
{
    [TestFixture]
    public class HashGeneratorTests
    {
        [Test]
        public void generateHash_ReturnsStringOfCorrectLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(10);
            Assert.Equals(10, hash.Length);

            hash = generator.generateHash(64);
            Assert.Equals(64, hash.Length);

            hash = generator.generateHash(100); // ������ ����� ������ ��� ��������, �� ������� ������ ��������� ��������
            Assert.Equals(64, hash.Length); // ���������, ��� ������� �� ��������� ���������� � ������� ���������� �����
        }

        [Test]
        public void generateHash_ReturnsDifferentHashesOnMultipleCalls()
        {
            var generator = new HashGenerator();
            string hash1 = generator.generateHash(10);
            string hash2 = generator.generateHash(10);
            Assert.Equals(hash1, hash2);// �������� �� �������� ����� ��� ���������� �������
        }

        [Test]
        public void generateHash_HandlesZeroLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(0);
            Assert.Equals(0, hash.Length); // �������� �� ������� �����
        }

        [Test]
        public void generateHash_HandlesNegativeLength()
        {
            var generator = new HashGenerator();
            string hash = generator.generateHash(-5);
            Assert.Equals(0, hash.Length); // �������� �� ������������� �����
        }

    }
}