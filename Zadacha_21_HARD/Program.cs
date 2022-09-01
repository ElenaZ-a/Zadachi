/*Задача 21 HARD - необязательная

Напишите программу, которая принимает на вход целое положительное число N 
и координаты двух точек и находит расстояние между ними в N-мерном пространстве.
*/

double distance(int n, double [] coordA, double [] coordB ){
    double summ2 =0;
    for (int i=0; i<n; i++){
        summ2 = summ2 + (coordB[i]-coordA[i])*(coordB[i]-coordA[i]);
    }
    return Math.Sqrt(summ2);
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
                Console.WriteLine("]");
            }
        }
        
    }
    //Главная программа
    try{
        Console.WriteLine("Введите Размерность пространства N :");
        int n=Convert.ToInt32(Console.ReadLine());
      
        double [] rndA = rand_Array(n);
     
        double [] rndB = rand_Array(n);
        Console.Write("Точка А:");
        printArray(rndA);
        Console.Write("Точка B:");
        printArray(rndB);

     
        
        Console.WriteLine("->" + " расстояние между точками: "+ distance(n, rndA, rndB) );
    }
    catch
    {
        Console.WriteLine("Это не число");
    }    
        