using System;
using System.Collections.Specialized;

namespace Lab1
{
    class Program
    {
        static void Number1()
        {

            double a, result;
            int n, i;

            result = 0;

            Console.Write("Введите число a: ");
            a = Convert.ToDouble(Console.ReadLine());

            Console.Write("Введите степень n: ");
            n = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i < n; ++i)
            {
                result = a * a;

            }

            Console.Write($"Результат равен: {result}\n");


        }

        static void Number2()
        {
            Console.WriteLine("Введите трёхзначное число или больше");

            string number = Console.ReadLine();
            string newNumber = "";
            int numberIndex;

            for (numberIndex = 0; numberIndex < number.Length; ++numberIndex)
            {

                if (numberIndex == 1)
                {
                    numberIndex = numberIndex + 1;
                }

                newNumber = newNumber + number[numberIndex];
            }

            newNumber = newNumber + number[1];

            Console.WriteLine($"Новое число: {newNumber}");
        }

        static void Main(string[] args) {
            while (true) {
                Console.WriteLine("Номер 1 \nНомер 2");
                Console.WriteLine("Что бы выбрать первый номер нажмите 1, что бы выбрать второй номер нажмите 2");

                string choise = Console.ReadLine();

                switch (choise) {
                    case "1":
                        Number1();
                        break;
                    case "2":
                        Number2();
                        break;
                }
            }
        }
    }
}
 

