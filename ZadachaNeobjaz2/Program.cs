﻿/*
задача необязательная

Напишите программу, которая считывает с консоли числа (по одному в строке) до тех пор, 
пока сумма введённых чисел не будет равна 0 и сразу после этого выводит сумму квадратов всех считанных чисел.

Гарантируется, что в какой-то момент сумма введённых чисел окажется равной 0, после этого считывание продолжать не нужно.

В примере мы считываем числа 1, -3, 5, -6, -10, 13; в этот момент замечаем, что сумма этих чисел равна нулю и выводим сумму их квадратов,
 не обращая внимания на то, что остались ещё не прочитанные значения.﻿

На входе:
1
-3
5
-6
-10
13
4
-8

На выходе:

340
*/

int getChislo(){
    int res=0;
    try {
        res=Convert.ToInt32(Console.ReadLine());
    }
    catch
    {
        Console.WriteLine("Вы ввели не число");

    };
    return res;
}
int summ=0;
int summ2=0;
int chislo; 
Console.WriteLine("Вводите целые числа по одному");
do {
    chislo = getChislo();
    summ = summ + chislo;
    summ2 =summ2 + chislo*chislo;


} while(summ!=0);

Console.WriteLine(summ2);