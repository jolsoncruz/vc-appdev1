using NUnit.Framework;

namespace UnitTesting
{
    class Class1
    {
        [Test]
        public void TestAdd()
        {
            //Arrange
            Program program = new Program();

            // Act
            double result = program.add(2, 9.2);

            // Assert
            Assert.That(result, Is.EqualTo(11.2));
        }

        [Test]
        public void TestMinus()
        {
            //Arrange
            Program program = new Program();

            // Act
            double result = program.minus(9.2, 2);

            // Assert
            Assert.That(result, Is.EqualTo(7.2));
        }

    }
}
