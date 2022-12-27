// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

int[,,] FillArray(int l, int m, int n) //Заполнение массива
{
    int[] range = new int[1000];
    for (int i = 0; i < 90; i++) range[i] = i + 10; //массив двузначных чисел 0т 10 до 99 - словарь чисел
    int temp;
    int[,,] array = new int[l, m, n];

    for (int i = 0; i < l; i++)
    {
        for (int j = 0; j < m; j++)
        {
            for (int k = 0; k < n; k++)
            {
                temp = new Random().Next(0, 90); // Генерирую индекс элемента словаря и после использования элемента ставим туда "-1". Это упрощает проверку на то, что мы использовали мы это число уже или нет.
                if (range[temp] > 0)
                {
                    array[i, j, k] = range[temp];
                    range[temp] = -1;
                }
                else k--;
            }
        }
    }
    return array;
}

void ExitArray(int[,,] array) // Вывод трехмерного массива
{
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]} ({i}, {j}, {k})    ");
            }
            Console.WriteLine();
        }
    }
}

ExitArray(FillArray(2, 2, 2));