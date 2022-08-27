
/*Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6
*/

int trinity(String tri_chislo)
{
    int lenght = tri_chislo.Length;
    int res = -1;
    if (lenght>2){
         res = Int32.Parse(tri_chislo.Substring(2,1));
    }else
    {
        Console.WriteLine("Ошибка ввода числа, длина строки менне 3 символов");
    
    }
    
    return res;
}
Console.WriteLine("Введите число");
String vvod=Console.ReadLine();

try {
    
    Console.WriteLine(trinity(vvod)>0?trinity(vvod):"");
}
catch {
    Console.WriteLine("Ошибка ввода числа, третьей цифры нет или символ не число, а "+"\""+  vvod.Substring(2,1) +"\"");
}
