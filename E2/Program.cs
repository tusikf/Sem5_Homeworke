// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных ИНДЕКСАХ.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int summ = 0;

int[] array = GetArray(size);
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");

for ( int i = 1 ; i < size ; i=i+2)
{
    summ = summ + array[i];
    Console.WriteLine( summ );
}

Console.WriteLine($"Сумма элементов стоящих на нечётных индексах = { summ }");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next( 0, 11 );
    }
    return result;
}