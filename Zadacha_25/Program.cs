/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/
int pow(int a, int b){
    int pow = 1;
    for (int i=0; i<b; i++){
        pow = pow * a;
    }
    return pow;
}

Console.WriteLine("Введите числа A и B - программа выдаст A в степени B. ");
try {
    
    Console.WriteLine("Введите число A: ");
    int a = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите число B: ");
    int b = Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(pow(a,b));
}
catch
{
    Console.WriteLine("Ошибка - вы ввели не число");
}

