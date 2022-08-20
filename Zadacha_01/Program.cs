
using System;

namespace Задача2
{
    class Zadacha2
    {
/*Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
        static void Main(string[] args)
        {
            int a;
            int b; 
            Console.Write("а = ");
            a = Int32.Parse(Console.ReadLine()) ;//Преобразуем введенное число из строки в число
            Console.Write("b = ");
            b = Int32.Parse(Console.ReadLine()) ;//Преобразуем введенное число из строки в число
            Console.Clear();
            Console.Write("а = " + a );
            Console.Write(" b = " + b );
            Console.Write("->");
            Console.Write(" max = ");
            Console.WriteLine(a>b?a:b);
        }
    }
}
