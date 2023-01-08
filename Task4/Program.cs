/*Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, 
добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/



int size1 = ReadInt("Введите размер 1: ");
int size2 = ReadInt("Введите размер 2: ");
int size3 = ReadInt("Введите размер 3: ");
Console.WriteLine();
Console.WriteLine($"Дан массив размером {size1} x {size2} x {size3}");

int [,,] array3D = new int[size1, size2, size3];
Create3DArray(array3D);
Print3DArray(array3D);

void Print3DArray (int[,,] array3D)
{
  for (int i = 0; i < array3D.GetLength(0); i++)
  {
    for (int j = 0; j < array3D.GetLength(1); j++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        Console.Write($"{array3D[i, j, k]}({i},{j},{k})");
      }
      Console.WriteLine();
    }
  }
}

void Create3DArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }

  int countNums = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int k = 0; k < array3D.GetLength(2); k++)
      {
        array3D[x, y, k] = temp[countNums];
        countNums++;
      }
    }
  }
}

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}