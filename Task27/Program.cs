// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// 452 -> 11
// 82 -> 10
// 9012 -> 12
int Sum(int num)
{
    int sum;
    for (sum = 0; num > 0;)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;
}

Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"{Sum(num)}");
