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

int CalcNumber(int[,] matrixA, int[,] matrixB, int strA, int stlB) // считает конкретный элемент нового массива с индексами i и j
//strA - номер строки по которой двигаемся в первом массиве. По сути это номер строки результирующего массива
//stlB - номер столбца по которому двигаемся во втором массиве. По сути это номер вызова метода
//Внутри метода эти переменные не меняются. двигаемся за счет изменения индекса j который начинается всегда с 0.
// в первом массиве он меняет номер столбца. Во втором массиве - номер строки.

{
    int mul;
    int sum = 0;
    for (int j = 0; j < matrixB.GetLength(1); j++)
    {
        mul = matrixA[strA, j] * matrixB[j, stlB];
        sum = sum + mul;
    }
    return sum;
}

//int[,] MatrixMultiply(int[,] matrixA, int matrixB[,])


int[,] matrixA = FillArray(3, 3);
Console.WriteLine();
int[,] matrixB = FillArray(3, 3);
int m = matrixB.GetLength(1);
int n = matrixA.GetLength(0);
int[,] matrixC = new int[m,n];
if (m != n) Console.WriteLine("Произведение данных матриц невозможно");
else
{
    
for (int i=0; i<n; i++)
{
    
    for (int j = 0; j < n; j++)
    {
        matrixC[i,j] = CalcNumber(matrixA, matrixB, i, j );
        
    }
    
}

ExitArray(matrixC);

}