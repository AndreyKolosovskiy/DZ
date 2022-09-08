// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Number(int arg)
{
    if (arg < 10000 || arg > 99999)
    {
        throw new Exception("Это не пятизначное число");
    }
    else
    {
        return arg;
    }
}
System.Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
num = Number(num);
if (num / 10000 == num % 10)
{
    if ((num - num / 10000 * 10000) / 1000 == (num / 10 % 10))
    {
        System.Console.WriteLine("Это палиндром");
    }
    else
    {
        System.Console.WriteLine("Это не палиндром");
    }
}
else
{
    System.Console.WriteLine("Это не палиндром");
}
