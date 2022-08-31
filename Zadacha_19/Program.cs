//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
/*14212 -> нет
12821 -> да
23432 -> да*/

string isPalindrom(int chislo){
    string str="";
    str = chislo.ToString();
    int length = str.Length;
    string res="";
    if (length!=5){
        res="должно быть пятизначное число!";
    } 
    else
    {
        bool isPal=true;
        for (int i=0; i<length/2; i++){
            isPal=isPal&&(str.Substring(i,1)==str.Substring(length-1-i,1));
        }
        res=isPal?"да":"нет";
    }
    return res;
}
try{
    Console.WriteLine("Введите пятизначное число, если это палиндром мы выведем - да");
    int chislo5=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(isPalindrom(chislo5));
}
catch
{
    Console.WriteLine("Это не число");
}    