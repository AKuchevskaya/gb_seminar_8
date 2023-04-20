// // Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// // Например, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // В итоге получается вот такой массив:
// // 7 4 2 1
// // 9 5 3 2
// // 8 4 4 2

// Console.Write("Введите количество строк в массиве: m = ");
// int row = int.Parse(Console.ReadLine()!);

// Console.Write("Введите количество столбцов в массиве: n = ");
// int column = int.Parse(Console.ReadLine()!);

// int[,] array = GetArray(row, column, 0, 10);
// PrintArray(array);

// Console.WriteLine();
// PrintArray(GetSortedArray(array));

// //--------Заполнение двумерного массива-------------
// int[,] GetArray(int m, int n, int minValue, int maxValue)
// {
//     int[,] result = new int[m, n];
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             result[i, j] = new Random().Next(minValue, maxValue);
//         }
//     }
//     return result;
// }


// //----------------Получение нового массива-----------
// int[,] GetSortedArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         int temp = array[i, 0];
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             for (int next = j + 1; next < array.GetLength(1); next++)
//             {
//                 if (array[i, next] > array[i, j])
//                 {
//                     temp = array[i, j];
//                     array[i, j] = array[i, next];
//                     array[i, next] = temp;
//                 }
//             }
//         }
//     }
//     return array;
// }

// // --------------------Вывод массива--------------
// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write($"{array[i, j]} ");
//         }
//         Console.WriteLine(" ");
//     }
// }

// Задача 57: Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том, сколько раз встречается элемент входных данных.

// 1, 2, 3
// 4, 6, 1
// 2, 1, 6

// 1 встречается 3 раза
// 2 встречается 2 раз
// 3 встречается 1 раз
// 4 встречается 1 раз
// 6 встречается 2 раза

Console.Write("Введите количество строк в массиве: m = ");
int row = int.Parse(Console.ReadLine()!);

Console.Write("Введите количество столбцов в массиве: n = ");
int column = int.Parse(Console.ReadLine()!);

int[,] array = GetArray(row, column, 0, 10);
PrintArray(array);

Console.WriteLine($"[{(String.Join(", ", GetFrequencyDictionary(array)))}]");
int[] numbers = GetFrequencyDictionary(array);
int[] sortedNumbers = SortingArray(numbers);
Console.WriteLine($"[{(String.Join(", ", sortedNumbers))}]");

PrintСount(sortedNumbers);

//--------Заполнение двумерного массива-------------
int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue);
        }
    }
    return result;
}

//----------------Метод поиска элементов в массиве-----------
int[] GetFrequencyDictionary(int[,] array)
{
    int coint = 0;
    int[] numbers = new int[array.GetLength(0) * array.GetLength(1)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            numbers[coint] = array[i, j];
            coint++;
        }
    }
    return numbers;
}

//----------------Метод сортировки массива-----------
int[] SortingArray(int[] frequency)
{
    int number = frequency[0];
    for (int i = 0; i < frequency.Length; i++)
    {
        for (int j = i + 1; j < frequency.Length; j++)
        {
            if (frequency[i] > frequency[j])
            {
                int temp = frequency[j];
                frequency[j] = frequency[i];
                frequency[i] = temp;
            }
        }
    }
    return frequency;
}
//------------Метод вывода счетчика--------------
void PrintСount(int[] sortedNumbers)
{
    int count = 0;
    int number = sortedNumbers[0];
    for (int i = 0; i < sortedNumbers.Length; i++)
    {
        if (sortedNumbers[i] != number)
        {
            Console.WriteLine($"{number} встречается в массиве {count} раз");
            number = sortedNumbers[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    Console.WriteLine($"{number} встречается в массиве {count} раз");
}
// --------------------Вывод массива--------------
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine(" ");
    }
}

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

// -------------------Задачи повышенной сложности---------------------
// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
