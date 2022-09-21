// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

(double b, double k) line1 = (Prompt("Введите b1"), Prompt("Введите k1"));
(double b, double k) line2 = (Prompt("Введите b2"), Prompt("Введите k2"));
PointInter(line1, line2);

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int num = Int32.Parse(Console.ReadLine());
    return num;
}
void PointInter((double b, double k) line1, (double b, double k) line2)
{
    double x, y;
    if ((line1.k == line2.k) && (line1.b == line2.b))
        System.Console.WriteLine("Прямые совпадают");


    else if (line1.k == line2.k)
    {
        System.Console.WriteLine("Прямые параллельны");
    }
    else
    {
        x = (line2.b - line1.b) / (line1.k - line2.k);
        y = (line1.k * (line2.b - line1.b)) / (line1.k - line2.k) + line1.b;
        System.Console.WriteLine("x=" + x + "y=" + y);
    }

}


// double Input(string message)
// {
//     System.Console.Write(message);
//     return Convert.ToDouble(Console.ReadLine());
// }

// (double, double) FindIntersection(double b1, double k1, double b2, double k2)
// {
//     double x = (b2 - b1) / (k1 - k2);
//     double y = k2 * x + b2;
//     return (Math.Round(x, 1), Math.Round(y, 1));
// }

// double b1 = Input("Введите b1: ");
// double k1 = Input("Введите k1: ");
// double b2 = Input("Введите b2: ");
// double k2 = Input("Введите k2: ");
// System.Console.Write($"Точка пересечения двух прямых: {FindIntersection(b1, k1, b2, k2)}");