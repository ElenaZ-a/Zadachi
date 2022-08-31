
/*Задача 23

Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
int [] tableOfCubes(int n){
    int [] table3 = new  int [n]; 
    for (int i = 0; i<n; i++){
        table3[i]=(i + 1)*(i + 1)*(i + 1);
    }
    return table3;
}

void printTableOfCubes(int [] table3){
    for (int i = 0; i<table3.Length; i++){
        Console.Write(table3[i] + " ");
    }
}

Console.WriteLine("Введите число N - программа выдаст таблицу кубов чисел от 1 до N. ");
try {
    int n = Convert.ToInt32(Console.ReadLine());
   

   printTableOfCubes(tableOfCubes(n));
}
catch
{
      Console.WriteLine("Ошибка - вы ввели не число");
}