// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         matrix[i, j] = new Random().Next(-10, 11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns ; j++)
//     {
//         int max_position = j;
//         for (int k = j + 1; k < columns; k++)
//         {
//             if (matrix[i, k] > matrix[i, max_position]) max_position = k;

//         }
//         int current = matrix[i, j];
//         matrix[i, j] = matrix[i, max_position];
//         matrix[i, max_position] = current;
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }










// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с
// наименьшей суммой элементов: 1 строка

// Console.Write("Введите количество строк: ");
// int rows = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите количество столбцов: ");
// int columns = Convert.ToInt32(Console.ReadLine());

// int[,] matrix = new int[rows, columns];

// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         matrix[i, j] = new Random().Next(-10, 11);
//         Console.Write(matrix[i, j] + "\t");
//     }
//     Console.WriteLine();
// }

// Console.WriteLine();

// int[] sumRows = new int[rows];
// for (int i = 0; i < rows; i++)
// {
//     for (int j = 0; j < columns; j++)
//     {
//         sumRows[i] += matrix[i, j];
//     }
//     Console.Write(sumRows[i] + "\t");
// }
// Console.WriteLine();

// int minRow = sumRows[0];
// int minRowIndex = 0;
// for (int i = 0; i < rows; i++)
// {
//     if (sumRows[i] < minRow)
//     {
//         minRow = sumRows[i];
//         minRowIndex = i;
//     }
// }
// Console.WriteLine($"Номер строки с наименьшей суммой элементов: {minRowIndex + 1}");










// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить
// произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// int[,] FillArray(int numstr, int numcol)
// {
//     int[,] matr = new int[numstr, numcol];
//     for (int i = 0; i < numstr; i++)
//     {
//         for (int j = 0; j < numcol; j++)   matr[i,j] = new Random().Next(1,10); 
//     }
//     return matr;
// }
// void PrintArray(int[,] matr)
// {
//     for (int i = 0; i < matr.GetLength(0); i++)
//     { 
//         for (int j = 0; j < matr.GetLength(1); j++)  Console.Write($"{matr[i, j]} ");
//         Console.WriteLine();
//     }
// }
// void MultiplMatrix(int[,] matr1, int[,] matr2)
// {
//     int[,] matrixAB = new int[matr1.GetLength(0), matr2.GetLength(1)];
//     for (int i = 0; i < matr1.GetLength(0); i++)
//     {
//         for (int j = 0; j < matr2.GetLength(1); j++)
//         {
//             for (int k = 0; k < matr1.GetLength(1); k++)   matrixAB[i, j] += matr1[i, k] * matr2[k, j];
//             Console.Write($"{matrixAB[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// } 
// Console.Write("Введите размер первой матрицы: укажите количество строк m1 = ");
// int m1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("укажите количество столбцов n1 = ");
// int n1 = Convert.ToInt32(Console.ReadLine());
// Console.Write("Укажите количество строк m2 = ");
// int m2 = Convert.ToInt32(Console.ReadLine());
// Console.Write("укажите количество столбцов n2 = ");
// int n2 = Convert.ToInt32(Console.ReadLine());
// if (m2 != n1) 
// {
//     Console.WriteLine("Матрицы НЕЛЬЗЯ умножить!");
//     Console.WriteLine($"Число столбцов {(n1)} первой матрицы не равно числу строк {(m2)} второй матрицы!");
//     Console.WriteLine($"Мы возьмем его правильно: m2 = n1 = {n1}");
//     m2 = n1;
// }
// int[,] matrixA = FillArray(m1, n1);
// int[,] matrixB = FillArray(m2, n2);
// PrintArray(matrixA);
// Console.WriteLine();
// PrintArray(matrixB);
// Console.WriteLine();
// MultiplMatrix(matrixA, matrixB);










// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы
// каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++) Console.Write($"{matr[i, j, k]}({i}{j}{k})\t");
            Console.WriteLine();
        }
    }
}
int Sravn(int[,,] arr, int i, int j, int k)
{
    arr [i, j, k] = new Random().Next(10, 100);
    int result = 0;
    for (int x = 0; x <= i; x++)
    {
        for (int y = 0; y <= j; y++)
        {
            for (int z = 0; z <= k; z++)
            {
                if ((x == i) && (y == j) && (z == k))  break;
                else if (arr[x, y, z] == arr[i, j, k])
                {
                    result = 1;
                    break;
                }
            }
        }
    }
    if (result == 1) arr[i, j, k] = new Random().Next(10, 100);
    return arr[i, j, k];
}
int[,,] FillArrayCondition(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int k = 0; k < matr.GetLength(2); k++) matr[i, j, k] = Sravn(matr, i, j, k);
        }
    }
    return matr;
}
int[,,] matrix = new int[3, 2, 3];
int [,,] resultArray = FillArrayCondition(matrix);
PrintArray(resultArray);