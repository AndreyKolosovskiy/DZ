// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// рандомный массив

int size = 8;
int[] array = new int[size];
FillArray(array);
System.Console.WriteLine("[{0}]", string.Join(",", array));

void FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}

