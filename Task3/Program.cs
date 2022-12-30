/*Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine("Создадим матрицы.");
int sizeMatrix = ReadInt("Введите размер матрицы: ");
int[,] matrixA = new int[sizeMatrix, sizeMatrix];
int[,] matrixB = new int[sizeMatrix, sizeMatrix];
Create2DArray(matrixA);
Create2DArray(matrixB);
int[,] matrixC = new int[sizeMatrix, sizeMatrix];


Console.WriteLine($"Даны {sizeMatrix} матрицы: ");
Print2DArray(matrixA); 
Print2DArray(matrixB);

for (int i = 0; i < sizeMatrix; i++)
{
    for (int j = 0; j < sizeMatrix; j++)
    {
        for (int k = 0; k < sizeMatrix; k++)
        {
            matrixC[i, j] = matrixC[i, j] + (matrixA[i, k] * matrixB[k, j]);
        }
    }
}

Console.WriteLine($"Произведение {sizeMatrix}x матриц: ");
Print2DArray(matrixC);

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
