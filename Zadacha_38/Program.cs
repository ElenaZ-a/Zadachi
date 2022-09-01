/* Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
    /* Вспомогательная функция для вывода на экран массива размера n */
    void printArray(double[] arr)
    {
        int n = arr.Length;
        Console.Write("[");
        for (int i=0; i<n; ++i){
            Console.Write(arr[i]);
            if (i<n-1){
               Console.Write(";"); 
            }
            else
            {
                Console.Write("]");
            }
        }
        
    }
     
    /* Вспомогательная функция для заполнения массива размера n случайными числами */
    double [] rand_Array(int n)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        double [] rndA = new double [n];
        for (int i=0; i<n; ++i){
            
            //Получить случайное число (в диапазоне от 0 до 1)
            rndA[i]  = rnd.Next(0, int.MaxValue)/(double)(int.MaxValue);
        }
        return rndA;
    }

    /*поиск минимального и максимального числа*/
    double find_min_max(double [] rndArray, out double min, out double max)
    {
        int n = rndArray.Length;
        min = rndArray[0];
        max = min;
        for (int i=1; i<n; ++i){
            if (rndArray[i]>max){
                max = rndArray[i];
            };
            if (rndArray[i]<min){
                min = rndArray[i];
            };
        }
        return min;
    }

    //Главная программа
    double [] rnd_Arr = rand_Array(4);
    printArray(rnd_Arr);
    double min=0, max=0;
    
    Console.WriteLine("->" + "min: "+ find_min_max(rnd_Arr, out min, out max)  + "; max: " + max);
