/*необязательная задача Написать программу сортировки массива от большего к меньшему. 
Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.
*/
// Реализация пирамидальной сортировки на C#

    void sort(int[] nums)
    {
        int n = nums.Length;

            // сортировка
        int temp;
        for (int i = 0; i < n  - 1; i++)
        {
            for (int j = i + 1; j < n ; j++)
            {
                if (nums[i] < nums[j])
                {
                    temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }
        }
    }

    /* Вспомогательная функция для вывода на экран массива размера n */
    void printArray(int[] arr)
    {
        int n = arr.Length;
        for (int i=0; i<n; ++i)
            Console.Write(arr[i]+" ");
        Console.Read();
    }
     
    /* Вспомогательная функция для заполнения массива размера n случайными числами */
    int [] rand_Array(int n)
    {
        //Создание объекта для генерации чисел
        Random rnd = new Random();
        int [] rndA = new int [n];
        for (int i=0; i<n; ++i){
            
            //Получить случайное число (в диапазоне от 0 до n)
            rndA[i]  = rnd.Next(0, n);
        }
        return rndA;
    }

    //Управляющая программа

             
        Console.WriteLine("Введите число n, программа вернет сортированный массив чисел. ");
try {
    int n = Convert.ToInt32(Console.ReadLine());
       int[] arr = new int [n];
        arr = rand_Array(n);
      
        sort(arr);

        Console.WriteLine("Сортированный массив:");
        printArray(arr);

}
catch
{
    Console.WriteLine("Ошибка - вы ввели не число");
}

 
  
