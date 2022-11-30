//Задача 23
//Напишите программу, которая принимает на вход 2 числа (N,M) и выдаёт 
//таблицу кубов чисел от N до M.
//2,3 -> 8, 27
//1,5 -> 1, 8, 27, 64, 125

Console.Clear();

Console.Write("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число M : ");
int m = Convert.ToInt32(Console.ReadLine());
if (n < m)
{
    int count = n;

    while (count < m)
    {
        Console.Write($"{count * count * count}, ");
        count++;
    }
    Console.Write($"{m * m * m}");
}

else
{
    int count = n;

    while (count > m)
    {
        Console.Write($"{count * count * count}, ");
        count--;
    }
    Console.Write($"{m * m * m}");
}
