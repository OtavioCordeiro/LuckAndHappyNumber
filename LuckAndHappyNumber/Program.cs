using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckAndHappyNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Numbers numbers = new Numbers();

            for (int i = 1; i <= 100; i++)
            {

                //Console.Write("Digite o numero: ");
                //int number = Convert.ToInt32(Console.ReadLine());
                int number = i;

                bool isHappy = numbers.IsHappy(number);

                bool isLucky = numbers.IsLucky(100);

                string happy = isHappy ? "Feliz" : "Não-Feliz";

                string lucky = isLucky ? "Sortudo" : "Não-Sortudo";

                Console.WriteLine("{0} - Número {1} e {2} \n", number, lucky, happy);
            }

            Console.ReadKey();
        }
    }
}
