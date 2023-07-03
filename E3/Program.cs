// Задача 38: Задайте массив целых двухзначных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [22, 42, 15, 77, 65] => 77 - 15 = 62**

Console.Write("Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);

int[] array = GetArray(size);
Console.WriteLine($"Исходный массив: [{String.Join(", ", array)}]");

int max = array[ 0 ];
int min = array[ 0 ];

foreach (int chislo in array)
{
    max = chislo > max ? chislo : max;
    min = chislo < min ? chislo : min;
}

Console.WriteLine($"max = { max }");
Console.WriteLine($"min = { min }");

int r = max - min ; 

Console.WriteLine($"Разница между максимальным и минимальным элементами массива = { r }");

// Функция заполнения массива
int[] GetArray(int size)
{
    int[] result = new int[size];
    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next( 10, 100 );
    }
    return result;
}