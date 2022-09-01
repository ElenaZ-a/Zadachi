/*Если решите без функций, то минус балл!

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/

    /* Вспомогательная функция для вывода на экран массива размера n */
    void printArray(int[] arr)
    {
        int n = arr.Length;
        Console.Write("[");
        for (int i=0; i<n; ++i){
            Console.Write(arr[i]);
            if (i<n-1){
               Console.Write(","); 
            }
            else
            {
                Console.Write("]");
            }
        }
        
    }
     
    /* Вспомогательная функция для заполнения массива размера n случайными числами */
    int [] rand_Array(int n)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        int [] rndA = new int [n];
        for (int i=0; i<n; ++i){
            
            //Получить случайное число (в диапазоне от 100 до 999)
            rndA[i]  = rnd.Next(100, 999);
        }
        return rndA;
    }

    /*Количество четных чисел*/
    int num_even_Numbers(int [] rndArray)
    {
        //Создание объекта для генерации чисел
        int n = rndArray.Length;
        int count_even=0;
        for (int i=0; i<n; ++i){
            if (rndArray[i]%2==0){
                count_even++;
            }
        }
        return count_even;
    }

    //Главная программа
    int [] rnd_Arr = rand_Array(4);
    printArray(rnd_Arr);
    Console.WriteLine("->" + num_even_Numbers(rnd_Arr));
