using NUnit.Framework;
using ScientificCalculator;

namespace ScientificCalculator.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test, Order(1)]
        public void Addition_Test()
        {
            
            double result = calculator.Addition(5, 3);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test, Order(2)]
        public void Subtraction_Test()
        {
            double result = calculator.Subtraction(5, 3);
            Assert.That(result, Is.EqualTo(2));
        }

        [Test, Order(3)]
        public void Multiplication_Test()
        {
            double result = calculator.Multiplication(5, 3);
            Assert.That(result, Is.EqualTo(15));
        }

        [Test, Order(4)]
        public void Division_Test()
        {
            double result = calculator.Division(10, 2);
            Assert.That(result, Is.EqualTo(5));
        }

        [Test, Order(5)]
        public void Division_By_Zero_Test()
        {
            double result = calculator.Division(10, 0);
            Assert.That(result, Is.EqualTo(double.NaN));
        }

        [Test, Order(6)]
        public void SquareRoot_Test()
        {
            double result = calculator.SquareRoot(16);
            Assert.That(result, Is.EqualTo(4));
        }

        [Test, Order(7)]
        public void Exponentiation_Test()
        {
            double result = calculator.Exponentiation(2, 3);
            Assert.That(result, Is.EqualTo(8));
        }

        [Test, Order(8)]
        public void Sine_Test()
        {
            double result = calculator.Sine(90);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test, Order(9)]
        public void Cosine_Test()
        {
            double result = calculator.Cosine(0);
            Assert.That(result, Is.EqualTo(1));
        }

        [Test, Order(10)]
        public void Tangent_Test()
        {
            double result = calculator.Tangent(0);
            Assert.That(result, Is.EqualTo(0));
        }
    }
}
