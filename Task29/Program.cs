// Задача 29: Напишите программу, которая задаёт массив из 8 элементов с клавиатуры и выводит массив на экран.


int[] array = new int[8];
int i = 0;
while (i < 8)
{
    Console.WriteLine("Введите элемент массива");
    array[i] = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    i++;
}
for (i = 0; i < 8; i = i + 1)

Console.Write($"{array[i]} ");
