// // // Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// // // m = 3, n = 4.
// // // 1 4 8 19


// // System.Console.WriteLine("Введите количество строк: ");
// // int rows = Convert.ToInt32(Console.ReadLine());

// // Console.Write("Введите количество столбцов: ");
// // int colums = Convert.ToInt32(Console.ReadLine());

// // //заполняем массив
// // // m строчки n столбцы
// // int[,] GetMatrix(int m, int n) //запятая отделяет количество мерности массивов, сначала столбцы потом строки создаем матрицу
// // {
// //     int[,] matrix = new int[m, n];
// //     for (int i = 0; i < matrix.GetLength(0); i++)
// //     {
// //         for (int j = 0; j < n; j++) //столбцам matrix.GetLength(1) = n
// //         // лучше указывать переменную
// //         {
// //             matrix[i, j] = new Random().Next(11);
// //         }
// //     }
// //     return matrix;
// // }
// // // печать массива
// // //входной параметр матрица - таблица, состоящая из М строк и Н столбцов
// // //матрица = таблица
// // void PrintMatrix(int[,] inputmatrix)
// // {
// //     for (int i = 0; i < inputmatrix.GetLength(0); i++) //строки
// //     {
// //         for (int m = 0; m < inputmatrix.GetLength(1); m++) //столбцы
// //         {
// //             Console.Write(inputmatrix[i, m] + "\t"); // "\t" - табуляция между элементами
// //         }
// //         Console.WriteLine();
// //     }
// // }

// // int[,] resultMATRIX = GetMatrix(rows, colums); //заполнение матрицы
// // // на rows строк и colums столбцов

// // PrintMatrix(resultMATRIX);


// // Задача 48: Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aₘₙ = m+n. Выведите полученный массив на экран.
// // m = 3, n = 4.
// // 0 1 2 3
// // 1 2 3 4
// // 2 3 4 5
 
 
// int m = 3;
// int n = 4;
 
// int[,] array = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = i + j;
//         System.Console.Write(array[i, j] + "\t");
//     }
//     System.Console.WriteLine();
// }
// System.Console.WriteLine();
 
 
 
 
 
 
 
 
 
 
// //49.Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
 
// int[,] array2 = new int[m, n];
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array2[i, j] = new Random().Next(10);
//         if (i % 2 == 0 && j % 2 == 0)  //проверка на четность индекса
//         {
//             array2[i, j] = (int)Math.Pow(array2[i, j], 2);
//         }
//         System.Console.Write(array2[i, j] + "\t");
//     }
//     System.Console.WriteLine();
// }

// ...........

//int[,] ChangeArray(int[,] inputArray)
// {
//     for (int i = 0; i < inputArray.GetLength(0); i++)
//     {
//         for (int j = 0; j < inputArray.GetLength(1); j++)
//         {
//             // Индекс i и индекс j должны быть четными
//             if (i % 2 == 0 && j % 2 == 0)
//             {
//                 inputArray[i,j] *= inputArray[i,j];
//                 // inputArray[i,j] = inputArray[i,j] * inputArray[i,j]
//             }
//         }
//     }
//     return inputArray;
// }
// PrintMatrix(ChangeArray(resultMatrix));

 
// System.Console.WriteLine();
// // Найти сумму элементов главной диагоналиюНапример, задан массив:
// // 1 4 7 2
// // 5 9 2 3
// // 8 4 2 4
// // Сумма элементов главной диагонали: 1+9+2 = 12
 
// int sum = 0;    // сумма элементов диагонали
// for (int i = 0; i < m && i < n; i++)
// {
//     sum = sum + array2[i,i];
// }
// System.Console.WriteLine(sum);




