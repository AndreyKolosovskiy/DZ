//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

System.Console.WriteLine("Введите координаты точки A:");
System.Console.WriteLine("Введите значение x");
 int x1 = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Введите значение y");
 int y1 = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Введите значение z");
 int z1 = Convert.ToInt32(Console.ReadLine());

 System.Console.WriteLine("Введите координаты точки B:");
 System.Console.WriteLine("Введите значение x");
 int x2 = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Введите значение y");
 int y2 = Convert.ToInt32(Console.ReadLine());
 System.Console.WriteLine("Введите значение z");
 int z2 = Convert.ToInt32(Console.ReadLine());

 double distance = Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2)+Math.Pow(z2-z1,2));
 System.Console.WriteLine(distance);