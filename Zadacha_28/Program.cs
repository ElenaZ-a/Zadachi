/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

int [] vvod_Array(){
    const int N = 8;
    int [] resArray = new int[N];
    Console.WriteLine("Введите массив из 8 чисел: ");
        int i = 0;
        do {
            Console.WriteLine("Введите число №" + (i+1));
            string stringNumber = Console.ReadLine();
            try {
            int numericValue = Convert.ToInt32(stringNumber);
            
                resArray[i]=numericValue;
                i++;
            }
            catch {
                Console.WriteLine("Вы ввели не число: ");
            }
        } while(i<N);   
    
    return resArray;
}

void print_Array(int [] array){
        Console.Write("["); 
    for (int i=0; i<array.Length; i++){
        Console.Write(array[i]);
        if (i<array.Length-1) {
            Console.Write(", ");
        }
        else
        {
            Console.WriteLine("]");
        }       
    }
}

    try 
    {
        int [] a = vvod_Array();
        print_Array(a);
    }
    catch 
    {
        Console.WriteLine("Ошибка");
    }
    