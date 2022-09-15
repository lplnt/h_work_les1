// Домашняя работа Задача 6
Console.Clear(); //очистка консоли

Console.WriteLine("Введите число чтобы узнать четное оно или нет: "); //вывод сообщение 
int num = Convert.ToInt32(Console.ReadLine()); //ввод числа 
int result = num % 2;
if (result == 0)
{
    Console.WriteLine($"Поздравляю! {num} Это четное число. =)");
}
else
{
    Console.WriteLine($"К сожалению {num} это нечетное число. :(");
}