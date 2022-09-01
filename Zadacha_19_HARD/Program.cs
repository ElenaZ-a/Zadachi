/*
Задача 19 HARD - необязательная
Напишите программу, которая принимает на вход любое число и проверяет, является ли оно палиндромом.
*/

string isPalindrom(int chislo){
    string str="";
    str = chislo.ToString();
    int length = str.Length;
    string res="";
    
        bool isPal=true;
        for (int i=0; i<length/2; i++){
            isPal=isPal&&(str.Substring(i,1)==str.Substring(length-1-i,1));
        }
        res=isPal?"да":"нет";
    
    return res;
}
try{
    Console.WriteLine("Введите число, если это палиндром мы выведем - да");
    int chislo=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(isPalindrom(chislo));
}
catch
{
    Console.WriteLine("Это не число");
}    
