using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using SimpleCalc.MathOperations;

namespace SimpleCalc.UnitTests
{
    [TestFixture]
    public class MathTests
    {
        private Calculator _calc;

        //prosty test nie podajesz parametrów sprawdzasz po prostu na sztywno czy 2+3 =5
        [Test]
        public void SimpleAdditionTest()
        {
            _calc = new Calculator();
            _calc.MathOperation = new AdditionOperation();
            _calc.Arg1 = 2;
            _calc.Arg2 = 3;

            double result = _calc.CalculateResult();

            //Asert AreEqual sprawdza czy wynik spodziewany (pierwsza liczba) jest równy wynikowi (druga liczba, wewnątrz zmiennej result)
            Assert.AreEqual(5, result, $"Addition result incorrect. Should be 5, but it`s {result}");
        }

        //Test z wartościami podawanymi jako parametr TestCase
        //w nawiasach podajesz co jest arg1, co arg2 dla metody testowej.
        //możesz wartość expected policzyć jak poniżej arg1+arg2, ale można też podać jako kolejny parametr test case np.  [TestCase(1.25, 2.5, 3.75)] wtedy metoda wyglądała by tak:
        //public void AdditionTest(double arg1, double arg2, double expected)
        [TestCase(1.25, 2.5)]
        [TestCase(1.8, 2.5)]
        [TestCase(100.25, 2.5)]
        public void AdditionTest(double arg1, double arg2)
        {
            _calc = new Calculator();
            _calc.MathOperation = new AdditionOperation();
            _calc.Arg1 = arg1;
            _calc.Arg2 = arg2;

            double result = _calc.CalculateResult();

            Assert.AreEqual(arg1+arg2, result, $"Addition result incorrect. Should be {arg1+arg2}, but it`s {result}");

        }

        //Można dać kilka Assertów, choć czasem można spotkać się ze zdaniem że 1 test = 1 Assert. Nie mnniej jednak czasem tak jest po prostu wygodniej:
        [TestCase(1.25, 2.5)]
        [TestCase(1.8, 2.5)]
        [TestCase(100.25, 2.5)]
        public void MathTest(double arg1, double arg2)
        {
            _calc = new Calculator();
            _calc.Arg1 = arg1;
            _calc.Arg2 = arg2;

            //Wybieramy operacje dodawania
            _calc.MathOperation = new AdditionOperation();

            //obliczamy wynik
            var additionResult = _calc.CalculateResult();

            //sprawdzamy czy się zgadza:
            Assert.AreEqual(arg1 + arg2, additionResult, $"Addition result incorrect. Should be {arg1 + arg2}, but it`s {additionResult}");


            //wybieramy operacje odejmowania
            _calc.MathOperation = new SubtractionOperation();
            var subtractionResult = _calc.CalculateResult();
            //sprawdzamy czy się zgadza:
            Assert.AreEqual(arg1 - arg2, subtractionResult, $"Subtraction result incorrect. Should be {arg1 - arg2}, but it`s {subtractionResult}");
        }


    }
}
