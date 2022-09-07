// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int number(int arg)
{
    return arg * -1;
}
System.Console.WriteLine("Введите трехзначное число");
int num = Convert.ToInt32(System.Console.ReadLine());
if (num < 0)
    num = number(num);
if (num < 100 || num > 999)
{
    System.Console.WriteLine("Введено некорректное число");
}
else
{
    System.Console.WriteLine(num / 10 - num / 100 * 10);
}