// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int A, int B)
{
    int C = 1;
    for (int i = 0; i < B; i++) 
    {
        C = C * A;
    }
    return C;
}

Console.WriteLine("Введите число");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите степень");
int B = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Число {A} в степени {B} равно {Power(A,B)}");