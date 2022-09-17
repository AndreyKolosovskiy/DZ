// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

/// Я поняла это как "Найдите сумму элементов с нечетным индексом"
void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(-100, 100);
}

System.Console.WriteLine("длина массива");
int lenght = Convert.ToInt32(Console.ReadLine());
int[] array = new int[lenght];
FillArray(array);
System.Console.WriteLine("[{0}]", string.Join(", ", array));
int Summ = 0;
for (int i = 1; i < array.Length; i = i + 2)
    Summ += array[i];
System.Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях {Summ}");