using System;

namespace lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1)

            int x;

            Console.WriteLine("Введите число: ");
            x = Convert.ToInt32(Console.ReadLine());

            int y = 7 * x ^ 2 - 3 * x + 4;

            Console.WriteLine("y = " + y);

            Console.WriteLine(" ");


            // 2)

            int r = 12;
            double p = 3.14;

            Console.WriteLine("Окружность: " + r * p);
            Console.WriteLine("Площадь круга: " + Convert.ToInt32(p * r * r));

            Console.WriteLine(" ");

            // 3)

            Console.WriteLine("Введите число в см: ");
            int num;

            num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("В метрах: " + num / 100);

            Console.WriteLine(" ");

            //4

            int moment = 234;
            Console.WriteLine("В неделях: " + 234 / 7);

            Console.WriteLine(" ");


            //5
            int num2, firstNum, lastNum, totalNum, multiNum;

            Console.WriteLine("Введите двузначное число: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            firstNum = num2 / 10;
            lastNum = num2 % 10;
            totalNum = firstNum + lastNum;
            multiNum = firstNum * lastNum;

            Console.WriteLine("Десятки: " + firstNum);
            Console.WriteLine("Единицы: " + lastNum);
            Console.WriteLine("Сумма: " + totalNum);
            Console.WriteLine("Произведение: " + multiNum);

            Console.WriteLine(" ");

            //6
            int someNum, numOne, numTwo, numThree, numFour;

            Console.WriteLine("Введите четырехзначное число: ");
            someNum = Convert.ToInt32(Console.ReadLine());

            numOne = someNum / 1000;
            numTwo = someNum / 100 % 10;
            numThree = someNum % 100 / 10;
            numFour = someNum % 10;

            Console.WriteLine("Сумма цифр: " + (numOne + numTwo + numThree + numFour));
            Console.WriteLine("Произведение: " + numOne * numTwo * numThree * numFour);

            Console.WriteLine(" ");


            // 7

            int number = 456, a, b, c;

            a = number / 100;
            b = number / 10 % 10;
            c = number % 10;

            Console.WriteLine(100 * a + 10 * c + b);

            Console.WriteLine(" ");

            //8

















































        }
    }
}
