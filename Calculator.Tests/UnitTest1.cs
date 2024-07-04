using _16_6_1;
namespace CalculatorTests
{
    [TestFixture]
    public class CalculatorTests
    {
        Calculator calculatorTests = new Calculator();
        [Test]
        public void AdditionalCalculatorTests()
        {
            Assert.That(calculatorTests.Additional(10, 10), Is.EqualTo(20));
        }
        [Test]
        public void SubtractionCalculatorTests()
        {
            Assert.That(calculatorTests.Subtraction(20, 10), Is.EqualTo(10));
        }
        [Test]
        public void MiltiplicationCalculatorTests()
        {
            Assert.That(calculatorTests.Miltiplication(10, 10), Is.EqualTo(100));
        }
        [Test]
        public void DivisionCalculatorTests()
        {
            Assert.That(calculatorTests.Division(10, 10), Is.EqualTo(1));
        }
        // Здесь дополнительно проверим на отработку исключения деления на ноль.
        public void GetThrowNullReferanceException()
        {
            Assert.Throws<NullReferenceException>(() => calculatorTests.Division(5, 0));
        }
    }
}