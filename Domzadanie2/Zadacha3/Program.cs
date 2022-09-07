// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и 
// проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

bool freeday(int arg)
{
    if (arg < 6)
    {
        return false;
    }
    else
    {
        return true;
    }
}


System.Console.WriteLine("номер дня недели");
int numberday = Convert.ToInt32(System.Console.ReadLine());
if (numberday > 7)
{
    System.Console.WriteLine("Некорректный номер");
}
else
{
    System.Console.WriteLine(freeday(numberday));
}

