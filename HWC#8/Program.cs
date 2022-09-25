// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

// Console.WriteLine("Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
// Console.WriteLine();
// Console.WriteLine("Задайте количество строк двумерного массива:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Задайте количество столбцов двумерного массива:");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] twoDimArray = new int[m, n];

// Random rnd = new Random();
// void PrintArray(int[,] matr) //Вывод на печать массива
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             Console.Write($"{matr[i, j]} " + "\t");
//         }
//         Console.WriteLine();
//     }
// }

// void FillArray(int[,] matr) //Заполнение  массива
// {
//     for (int i = 0; i < m; i++)
//     {
//         for (int j = 0; j < n; j++)
//         {
//             matr[i, j] = Convert.ToInt32(rnd.Next(0, 100));
//         }
//     }
// }

// void NewArray(int[,] twoDimArray)  // Метод сортировки массива
// {
//     for (int i = 0; i < twoDimArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < twoDimArray.GetLength(1); j++)
//         {
//             for (int k = 0; k < twoDimArray.GetLength(1) - 1; k++)
//             {
//                 if (twoDimArray[i, k] < twoDimArray[i, k + 1])
//                 {
//                     int t = twoDimArray[i, k + 1];
//                     twoDimArray[i, k + 1] = twoDimArray[i, k];
//                     twoDimArray[i, k] = t;
//                 }
//             }
//         }
//     }
// }

// FillArray(twoDimArray);
// Console.WriteLine();
// PrintArray(twoDimArray);
// Console.WriteLine();

// Console.WriteLine($"\n" + "Отсортированный массив: ");
// NewArray(twoDimArray);
// PrintArray(twoDimArray);


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.WriteLine("Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
Console.WriteLine();
Console.WriteLine("Задайте количество строк двумерного массива:");
int strok = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Задайте количество столбцов двумерного массива:");
int stolb = Convert.ToInt32(Console.ReadLine());
int[,] massiv = new int[strok, stolb];
Random mas = new Random();

void PrintMassiv(int[,] massiv)
{
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            Console.Write($"{massiv[i, j]} " + "\t");
        }
        Console.WriteLine();
    }
}

void FillMassiv(int[,] massiv)
{
    for (int i = 0; i < strok; i++)
    {
        for (int j = 0; j < stolb; j++)
        {
            massiv[i, j] = Convert.ToInt32(mas.Next(0, 100));
        }
    }
}
void SumStr(int[,] massiv)
{
    int sum = 0;
    int index = 0;
    for (int i = 0; i < massiv.GetLength(1); i++)
        {
            int temp = 0;
            for (int j = 0; j < massiv.GetLength(0); j++)
                {
                    temp += massiv[j, i];
                }
                    if (temp > sum)
                        {
                            sum = temp;
                            index = i;
                        }
        }
Console.WriteLine("Столбец: " );
for (int i = 0; i < massiv.GetLength(0); i++)
   {
        Console.WriteLine(massiv[i, index]);
    }
}

FillMassiv(massiv);
Console.WriteLine();
PrintMassiv(massiv);
Console.WriteLine();

// PrintMassiv(massiv);
SumStr(massiv);

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18



// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



// * Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
//  1  2  3  4
// 12 13 14  5
// 11 16 15  6
// 10  9  8  7
