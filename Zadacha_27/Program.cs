/*
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/
int summCifr(int chislo){
    string str="";
    str = chislo.ToString();
    int length = str.Length;
    int summ=0;
    for (int i=0; i<length; i++){
            summ = summ + Convert.ToInt32(str.Substring(i,1));
    }

    
    return summ;
}

try{
    Console.WriteLine("Введите число, вернем сумму цифр в числе: ");
    int chislo=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(summCifr(chislo));
}
catch
{
    Console.WriteLine("Это не число");
}    