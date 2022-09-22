// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

System.Console.WriteLine("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

//заполняем массив
// m строчки n столбцы
double[,] NewMatrix(int m, int n) //запятая отделяет количество мерности массивов, сначала столбцы потом строки создаем матрицу
{
    double[,] matrix = new double[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < n; j++) //столбцам matrix.GetLength(1) = n
        // лучше указывать переменную
        {
            matrix[i, j] = new Random().NextDouble()*1000;
        }
    }
    return matrix;
}
void PrdoubleMatrix(double[,] inputmatrix)
{
    for (int i = 0; i < inputmatrix.GetLength(0); i++) //строки
    {
        for (int m = 0; m < inputmatrix.GetLength(1); m++) //столбцы
        {
            Console.Write(inputmatrix[i, m] + "\t"); // "\t" - табуляция между элементами
        }
        Console.WriteLine();
    }
}
double[,] resultMATRIX = NewMatrix(m, n); //заполнение матрицы
// // // на rows строк и colums столбцов

PrdoubleMatrix(resultMATRIX);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.