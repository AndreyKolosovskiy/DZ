// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

int a = Promt("Введите А");
int b = Promt("Введите Б");
System.Console.WriteLine(Math.Pow(a, b));
int Promt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    return Convert.ToInt32(value);
}