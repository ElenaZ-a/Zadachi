//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1

int second(String tri_znak_chislo)
{
    int res = Int32.Parse(tri_znak_chislo.Substring(1,1));
    return res;
}
Console.WriteLine("Введите трехзначное число, например 782");
String vvod=Console.ReadLine();

try {
    Console.WriteLine(second(vvod));
}
catch {
    Console.WriteLine("Ошибка ввода числа, Второй символ не число, а "+"\""+  vvod.Substring(1,1) +"\"");
}