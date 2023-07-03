// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int schet = 0;

int[] array = GetArray(size);
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");

foreach(int chislo in array)
{
    schet += chislo % 2 == 0 ? 1 : 0;
}

Console.WriteLine($"Количество чётных элементов в массиве = { schet}");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(100, 1000);
    }
    return result;
}