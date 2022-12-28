/*Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

Console.WriteLine("Зададим двумерный прямоугольный массив.");
int m = ReadInt("Введите m: ");
int n = ReadInt("Введите n: ");
int[,] numbers = new int[m, n];
int minSumRow = Int32.MaxValue;
int minRow = 0;

Console.WriteLine("Наш двумерный прямоугольный массив: ");

Create2DArray(numbers);
Print2DArray(numbers);

for (int i = 0; i < numbers.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];        
    }
    if (sum < minSumRow)
    {
        minSumRow = sum;
        minRow++;
    }
}

Console.WriteLine($"Строка под номером - {minRow}, носит в себе наименьшую сумму элементов = {minSumRow}");

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void Create2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}
