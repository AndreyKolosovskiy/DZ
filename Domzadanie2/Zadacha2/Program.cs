// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int numbers(int arg)
{
    return arg * -1;
}

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(System.Console.ReadLine());
if (num < 0)
    num = numbers(num);
if (num < 100)
{
    System.Console.WriteLine("Третьей цифры нет");
}
else
{
    System.Console.WriteLine(num.ToString()[2]);
}