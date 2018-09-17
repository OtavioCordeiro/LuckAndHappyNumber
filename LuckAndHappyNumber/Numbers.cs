using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckAndHappyNumber
{
    public class Numbers
    {
        public bool IsHappy(int number)
        {
            bool isHappy = false;

            List<int> digits = new List<int>();

            digits = SeparateDigits(number);

            for (int i = 0; i < 100 && isHappy == false; i++)
            {
                int sumActual = CalculateSquare(digits);
                if (sumActual == 1)
                {
                    isHappy = true;
                }
                else
                {
                    digits = SeparateDigits(sumActual);
                }
            }

            return isHappy;
        }

        private List<int> SeparateDigits(int number)
        {
            List<int> digits = new List<int>();

            while (number != 0)
            {
                digits.Add(number % 10);
                number /= 10;
            }

            return digits;
        }

        private int CalculateSquare(List<int> digits)
        {
            int result = 0;
            foreach (int digit in digits)
            {
                result += digit * digit;
            }

            return result;
        }

        public bool IsLucky(int number)
        {
            List<int> finalList = GetLuckyNumbers(number);

            return finalList.Contains(number);
        }

        public List<int> GetLuckyNumbers(int number)
        {
            List<int> initialList = new List<int>();
            List<int> multiplesOfTwo = new List<int>();
            List<int> multiplesOfTree = new List<int>();
            List<int> multiplesOfSeven = new List<int>();
            List<int> finalList = new List<int>();

            for (int i = 1; i <= number; i++)
            {
                initialList.Add(i);
            }

            for (int i = 1; i <= initialList.Count; i++)
            {
                if (i % 2 != 0)
                {
                    multiplesOfTwo.Add(initialList[i - 1]);
                }
            }
            finalList = multiplesOfTwo;

            for (int i = 1; i <= finalList.Count; i++)
            {
                if (i % 3 != 0)
                {
                    multiplesOfTree.Add(finalList[i - 1]);
                }
            }
            finalList = multiplesOfTree;

            for (int i = 1; i <= finalList.Count; i++)
            {
                if (i % 7 != 0)
                {
                    multiplesOfSeven.Add(finalList[i - 1]);
                }
            }
            finalList = multiplesOfSeven;

            return finalList;
        }
    }
}
