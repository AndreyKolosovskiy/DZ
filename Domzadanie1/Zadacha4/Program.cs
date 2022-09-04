//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

//5 -> 2, 4
//8 -> 2, 4, 6, 8

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
int ChetNum = 2;
if (num<2)
{
    Console.WriteLine(" от 1 до вашего числа нет четных");
}
else
{
Console.WriteLine("Четные числа от 1 до вашего числа:");
while (ChetNum<=num)
{
    Console.WriteLine(ChetNum);
    ChetNum = ChetNum + 2;
}
}
