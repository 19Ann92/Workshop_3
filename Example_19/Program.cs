//Задача 19
//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

Console.Clear();

Console.Write("Введите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

int NumberSearch(int num, int fraction)
{
    int res = 0;

    while (num > fraction)
    {
        num = num / 10;
        res = num % 10;
    }
    return res;
}

int firstnum = NumberSearch(num, fraction: 10);
int secondnum = NumberSearch(num, fraction: 100);
int fourthnum = num / 10 % 10;
int fifthnum = num % 10;

if (firstnum == fifthnum)
{
    if(secondnum == fourthnum)
    {
        Console.Write($"Число является палиндромом");
    }
    else
    {
    Console.Write($"Число не является палиндромом");
    }
}
else
{
    Console.Write($"Число не является палиндромом");
}