// Домашняя работа Задача 2 

Console.Clear();
Console.Write("Введите первое число: "); //ввод сообщение 
int num1 = Convert.ToInt32(Console.ReadLine()); //ввод числа 1

Console.Write("Введите второе число: "); //ввод сообщение 
int num2 = Convert.ToInt32(Console.ReadLine()); //ввод числа 2

if(num1 > num2) //сравниваем числа
{
    Console.WriteLine("Максимальное число = " + num1 + ". Минимальное число = " + num2); //если правильно выведем это
}
else
{
    Console.WriteLine("Максимальное число = " + num2 + ". Минимальное число = " + num1); //если неправильно то это
}