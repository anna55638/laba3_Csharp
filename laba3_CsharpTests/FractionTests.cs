using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionTests
{
    [TestClass]
    public class FractionTests
    {
        // Тест для сложения дробей
        [TestMethod]
        public void TestAdd()
        {
            Fraction f1 = new Fraction(1, 2); // 1/2
            Fraction f2 = new Fraction(1, 3); // 1/3
            Fraction result = f1.Add(f2); // Ожидаемый результат: 5/6
            Assert.AreEqual("5/6", result.ToString());
        }

        // Тест для вычитания дробей
        [TestMethod]
        public void TestSubtract()
        {
            Fraction f1 = new Fraction(3, 4); // 3/4
            Fraction f2 = new Fraction(1, 4); // 1/4
            Fraction result = f1.Subtract(f2); // Ожидаемый результат: 1/2
            Assert.AreEqual("1/2", result.ToString());
        }

        // Тест для умножения дробей
        [TestMethod]
        public void TestMultiply()
        {
            Fraction f1 = new Fraction(2, 3); // 2/3
            Fraction f2 = new Fraction(3, 4); // 3/4
            Fraction result = f1.Multiply(f2); // Ожидаемый результат: 1/2
            Assert.AreEqual("1/2", result.ToString());
        }

        // Тест для деления дробей
        [TestMethod]
        public void TestDivide()
        {
            Fraction f1 = new Fraction(1, 2); // 1/2
            Fraction f2 = new Fraction(3, 4); // 3/4
            Fraction result = f1.Divide(f2); // Ожидаемый результат: 2/3
            Assert.AreEqual("2/3", result.ToString());
        }

        // Тест для деления на ноль
        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestDivideByZero()
        {
            Fraction f1 = new Fraction(1, 2); // 1/2
            Fraction f2 = new Fraction(0, 1); // 0/1 (деление на ноль)
            Fraction result = f1.Divide(f2); // Ожидается исключение
        }

        // Тест для сравнения дробей (дробь 1 меньше дроби 2)
        [TestMethod]
        public void TestCompareTo_Less()
        {
            Fraction f1 = new Fraction(1, 2); // 1/2
            Fraction f2 = new Fraction(2, 3); // 2/3
            int result = f1.CompareTo(f2); // Ожидаемый результат: -1
            Assert.AreEqual(-1, result);
        }

        // Тест для сравнения дробей (дробь 1 больше дроби 2)
        [TestMethod]
        public void TestCompareTo_Greater()
        {
            Fraction f1 = new Fraction(3, 4); // 3/4
            Fraction f2 = new Fraction(1, 2); // 1/2
            int result = f1.CompareTo(f2); // Ожидаемый результат: 1
            Assert.AreEqual(1, result);
        }

        // Тест для сравнения дробей (дроби равны)
        [TestMethod]
        public void TestCompareTo_Equal()
        {
            Fraction f1 = new Fraction(2, 3); // 2/3
            Fraction f2 = new Fraction(4, 6); // 4/6 (эквивалентно 2/3)
            int result = f1.CompareTo(f2); // Ожидаемый результат: 0
            Assert.AreEqual(0, result);
        }

        // Тест для сокращения дроби
        [TestMethod]
        public void TestSimplify()
        {
            Fraction f = new Fraction(4, 8); // 4/8
            Assert.AreEqual("1/2", f.ToString()); // Ожидаемый результат: 1/2
        }

        // Тест для создания дроби с нулевым знаменателем
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestZeroDenominator()
        {
            Fraction f = new Fraction(1, 0); // Ожидается исключение
        }
    }
}