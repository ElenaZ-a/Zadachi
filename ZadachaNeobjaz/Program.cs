/*
задача необязательная.
"В институте биоинформатики по офису передвигается робот. Недавно студенты из группы программистов написали для него программу, по которой робот, 
когда заходит в комнату, считает количество программистов в ней и произносит его вслух: "n программистов".

Для того, чтобы это звучало правильно, для каждого n нужно использовать верное окончание слова.

Напишите программу, считывающую с пользовательского ввода целое число n (неотрицательное),
 выводящее это число в консоль вместе с правильным образом изменённым словом "программист", для того, чтобы робот мог нормально общаться с людьми, например:
  1 программист, 2 программиста, 5 программистов.

В комнате может быть очень много программистов. Проверьте, что ваша программа правильно обработает все случаи, как минимум до 1000 человек."
*/

String sklProgram(int n){
   string res ="";
    if (n==1) {
        res ="";
    } 
    else if (n%100>=5 && n%100<=20 || n%10==0){
        res="ов";
    }
    else if (n%10==1){//двадцать один программист
        res="";
    }
    else if (n%10>=2 && n%10<=4){//двадцать два 
        res="а";
    }
    return res;
    
}



for (int i=0; i<=5; i++ ){
    Console.WriteLine(i + " программист"+ sklProgram(i));
    Console.WriteLine(i+10 + " программист"+ sklProgram(i+10));
    Console.WriteLine((i+100) + " программист"+ sklProgram(i+100));
    Console.WriteLine((i+1000) + " программист"+ sklProgram(i+1000));

    
}
