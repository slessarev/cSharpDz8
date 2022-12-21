// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int[,] FillArray(int m, int n) //Заполнение массива
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] MatrixMultiply(int[,] matrixA, int[,] matrixB)
{
    int[,] ResultMatrix = new int[(matrixA.GetLength(0)), (matrixB.GetLength(1))]; //определили количество строк и столбцов результирующего массива

    for (int k = 0; k < matrixA.GetLength(0) * matrixB.GetLength(1); k++)
    {
        for (int i = 0; i < matrixA.GetLength(0); i++)
        {
            int mul;
            int sum = 0;
            int count = 0;
            for (int j = 0; j < matrixB.GetLength(1); j++)
            {
                mul = matrixA[i, j] * matrixB[j, i];
                sum = sum + mul;
                count++;
            }
            ResultMatrix[i, count] = sum;
        }
    }
    return ResultMatrix;
}


void ExitArray(int[,] array) // Вывод двумерного массива
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]}    ");
        }
        Console.WriteLine();
    }
}

int[,] matrixA = FillArray(2, 2);
Console.WriteLine();
int[,] matrixB = FillArray(2, 2);

int[,] matrixC = MatrixMultiply(matrixA, matrixB);
ExitArray(matrixC);