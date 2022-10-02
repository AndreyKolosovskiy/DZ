/// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30

int num(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void SumN(int M, int N, int sum)
{
    if (M>N)
    {
    System.Console.WriteLine(sum);
    }
    else
    {
    sum = sum + N;
    SumN(M,N-1,sum);
    }
}

int M = num("Введите значение M");
int N = num("Введите значение N");
if (N==M)
{
    System.Console.WriteLine("введены одинаковые числа");
}
if (N<M)
{
    int temp = N;
    N = M;
    M = temp;
}
System.Console.Write($"Сумма чисел от {M} до {N} = ");
SumN(M, N, 0);