// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

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

int SumInRows(int[,] array)
{
    int minSum = 0;
    int minSumRow = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (i == 0) minSum = sum;
        if (minSum >= sum)
        {
            minSum = sum;
            minSumRow = i + 1;
        }
        sum = 0;
    }
    return minSumRow;
}

int EnterData(string text) //Ввод размера массива
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}


int m = EnterData("Введите количество строк массива: ");
int n = EnterData("Введите количество столбцов массива: ");

int[,] array = FillArray(m, n);
int result = SumInRows(array);
Console.WriteLine("Минимальная сумма значений в строке № " + result);