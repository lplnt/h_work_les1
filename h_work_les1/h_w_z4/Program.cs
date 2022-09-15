// Домашняя работа Задача 4
Console.Clear(); //очистка консоли

Console.WriteLine("Введите первое число: "); //вывод сообщение 
int num1 = Convert.ToInt32(Console.ReadLine()); //ввод числа 1

Console.WriteLine("Введите второе число: "); //вывод сообщение 
int num2 = Convert.ToInt32(Console.ReadLine()); //ввод числа 2

Console.WriteLine("Введите третье число: "); //вывод сообщение 
int num3 = Convert.ToInt32(Console.ReadLine()); //ввод числа 3

int max = num1; 
if(max < num2){
    max = num2;
}

if(num2 < num3){
     max = num3;
}
Console.WriteLine("Максимальное число = " + max);