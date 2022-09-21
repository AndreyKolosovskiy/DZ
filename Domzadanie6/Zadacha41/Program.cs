// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int n = Prompt("Число элементов массива");
int[] array = new int[n];
fullArray(array);
printArray(array);

int Prompt(string message)
{
    System.Console.WriteLine(message);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
void fullArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Prompt("Ввод числа");
    }
}
void printArray(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
            count++;
        System.Console.Write($"{  array [i]} ");

    }
     System.Console.WriteLine("Больше нуля"+ count );
}