
using System;

namespace Задача6
{
    class Zadacha6
    {

/*       Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
        4 -> да
        -3 -> нет
        7 -> нет
*/
        static void Main(string[] args)
        {
            int a;
            Console.Write("введите число: ");
            a = Int32.Parse(Console.ReadLine()) ;//Преобразуем введенное число из строки в число
            Console.Clear();
            Console.WriteLine(a + " -> " + ((a%2==0)?"да":"нет")); //Проверка на четность и вывод да или нет
        }
    }
}

