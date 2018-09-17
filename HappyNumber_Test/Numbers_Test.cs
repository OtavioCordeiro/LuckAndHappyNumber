using LuckAndHappyNumber;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HappyNumber_Test
{
    [TestClass]
    public class Numbers_Test
    {
        [TestMethod]
        public void Number7()
        {
            Numbers numbers = new Numbers();

            int number = 7;

            Assert.IsTrue(numbers.IsLucky(number));
            Assert.IsTrue(numbers.IsHappy(number));
        }

        [TestMethod]
        public void Number21()
        {
            Numbers numbers = new Numbers();

            int number = 21;

            Assert.IsTrue(numbers.IsLucky(number));
            Assert.IsFalse(numbers.IsHappy(number));
        }

        [TestMethod]
        public void Number28()
        {
            Numbers numbers = new Numbers();

            int number = 28;

            Assert.IsFalse(numbers.IsLucky(number));
            Assert.IsTrue(numbers.IsHappy(number));
        }

        [TestMethod]
        public void Number142()
        {
            Numbers numbers = new Numbers();

            int number = 142;

            Assert.IsFalse(numbers.IsLucky(number));
            Assert.IsFalse(numbers.IsHappy(number));
        }

        [TestMethod]
        public void Number37()
        {
            Numbers numbers = new Numbers();

            int number = 37;

            Assert.IsTrue(numbers.IsLucky(number));
            Assert.IsFalse(numbers.IsHappy(number));
        }

        [TestMethod]
        public void Number100()
        {
            Numbers numbers = new Numbers();

            int number = 100;

            Assert.IsFalse(numbers.IsLucky(number));
            Assert.IsTrue(numbers.IsHappy(number));
        }

        [TestMethod]
        public void SurvivalNumbers()
        {
            //Questão: 1, 3, 7, 9, 13, 15, 21, 25, 31, 33, 37, 43, 49, 51, 63, 67, 69, 73, 75, 79, 87, 93, 99

            //Prova real: 1, 3, 7, 9, 13, 15, 21, 25, 27, 31, 33, 37, 43, 45, 49, 51, 57, 63, 67, 69, 73, 75, 79, 85, 87, 91, 93, 97, 99
            int[] testNumbers = new int[] { 1, 3, 7, 9, 13, 15, 21, 25, 27, 31, 33, 37, 43, 45, 49, 51, 57, 63, 67, 69, 73, 75, 79, 85, 87, 91, 93, 97, 99 };

            Numbers numbers = new Numbers();

            // obtem a lista de numeros da sortudo no range de 1 a 100
            List<int> result = numbers.GetLuckyNumbers(100);

            foreach (int number in testNumbers)
            {
                Assert.IsTrue(result.Contains(number));
            }
        }
    }
}
