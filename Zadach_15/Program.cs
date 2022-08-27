//Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

String isSandayOrSaturDay(int dayOfWeek){
    String res = "";
    if (dayOfWeek>=1 && dayOfWeek<=5)
    {
        res = "нет";
    }
    else if (dayOfWeek>=6 && dayOfWeek<=7) 
    {    
        res = "да";
    }
    else {
       res = "число вне диапазона: 1-7";
    }
 
    return res;
}


Console.WriteLine("Введите число 1-7 день недели 1-пн, 2-вт, 3-ср, 4-чт, 5-пт, 6-сб, 7-вс, если день выходной, программа ответит да:");


try {
    int dayOfWeek=Convert.ToInt32(Console.ReadLine());
    
    Console.WriteLine(isSandayOrSaturDay(dayOfWeek));
}
catch {
    Console.WriteLine("Ошибка ввода, символ не число");
}
