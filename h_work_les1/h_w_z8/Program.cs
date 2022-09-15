// Домашняя работа Задача 8
Console.Clear(); //очистка консоли

Console.Write("Введите число чтобы узнать все четные числа которые в него входят: "); //вывод сообщение 
int num = Convert.ToInt32(Console.ReadLine()); //ввод числа 

int i = 0;

while (i < num)
{
    Console.WriteLine(i+=2);
}