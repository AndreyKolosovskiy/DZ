﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int num(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int Ackerman (int m, int n)
{
    if (m == 0)
    {
        return n+1;
    }
    if (n == 0)
    {
        return Ackerman(m-1, 1);
    }
    return Ackerman(m-1, Ackerman(m, n-1));
}
int m = num("Введите значение m");
int n = num("Введите значение n");
System.Console.WriteLine($"A({m},{n}) = {Ackerman(m,n)}");