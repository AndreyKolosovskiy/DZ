// Задача 3. Сформируйте двухмерный массив из неповторяющихся случайных двузначных чисел (размер массива не более 50 элементов). Напишите программу, которая будет построчно выводить массив.
// Вариант создания функции:
// Проверить число на присутствие в массиве (bool Contains(int[,] arr, int value){...} )
// Пример:
// Массив размером 3 x 3
// 10 11 55
// 33 41 23
// 17 28 34

bool CheckNumberArray(int[,] array, int number)
{
    int check = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] == number)
            {
                check = 1;
                break;
            }
        }
    }
    return (check == 1);
}

int[,] FillArrayNoRepeat(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    Random rnd = new Random();
    int temporary = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            do
                temporary = rnd.Next(9, 99);
            while (CheckNumberArray(array, temporary) == true);
            array[i, j] = temporary;
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}

int[,] array = FillArrayNoRepeat(3, 3);
PrintArray(array);
