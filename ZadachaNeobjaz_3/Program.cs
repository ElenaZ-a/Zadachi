/*необязательная задача Написать программу сортировки массива от большего к меньшему. 
Массив задается размерностью N с клавиатуры, далее заполняется случайными целыми числами.
*/
// Реализация пирамидальной сортировки на C#

    void sort(int[] arr)
    {
        int n = arr.Length;

        // Построение кучи (перегруппируем массив)
        for (int i = n / 2 - 1; i >= 0; i--)
            heapify(arr, n, i);

       // Один за другим извлекаем элементы из кучи
        for (int i=n-1; i>=0; i--)
        {
            // Перемещаем текущий корень в конец
            int temp = arr[0];
            arr[0] = arr[i];
            arr[i] = temp;

            // вызываем процедуру heapify на уменьшенной куче
            heapify(arr, i, 0);
        }
    }

    // Процедура для преобразования в двоичную кучу поддерева с корневым узлом i, что является
// индексом в arr[]. n - размер кучи

    void heapify(int[] arr, int n, int i)
    {
        int largest = i;
// Инициализируем наибольший элемент как корень
        int l = 2*i + 1; // left = 2*i + 1
        int r = 2*i + 2; // right = 2*i + 2

        // Если левый дочерний элемент больше корня
        if (l < n && arr[l] > arr[largest])
            largest = l;

        // Если правый дочерний элемент больше, чем самый большой элемент на данный момент
        if (r < n && arr[r] > arr[largest])
            largest = r;

        // Если самый большой элемент не корень
        if (largest != i)
        {
            int swap = arr[i];
            arr[i] = arr[largest];
            arr[largest] = swap;

            // Рекурсивно преобразуем в двоичную кучу затронутое поддерево
            heapify(arr, n, largest);
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

 
  
